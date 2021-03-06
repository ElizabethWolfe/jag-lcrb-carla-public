﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Grpc.Core;
using Gov.Lclb.Cllb.Services.FileManager;
using System.IO;
using Google.Protobuf;
using static Gov.Lclb.Cllb.Services.FileManager.FileManager;
using Gov.Lclb.Cllb.Public.ViewModels;
using System.Xml.Linq;
using System.Xml.XPath;
using Gov.Lclb.Cllb.Public.Mapping;

// from https://raw.githubusercontent.com/bcgov/jag-lcrb-carla-public/446c4f15f159c7f569e03ac138abce3d81aa3f92/cllc-public-app/Controllers/SystemFormController.cs


namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FormsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        private readonly IDynamicsClient _dynamicsClient;

        public FormsController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _dynamicsClient = dynamicsClient;
            _logger = loggerFactory.CreateLogger(typeof(FileController));
            
        }

        [HttpGet("{formid}")]
        public async Task<JsonResult> GetSystemForm(string formid)
        {
            // get the picklists.

            List<MicrosoftDynamicsCRMpicklistAttributeMetadata> picklistMetadata = null;

            try
            {
                picklistMetadata = _dynamicsClient.Entitydefinitions.GetEntityPicklists("adoxio_application").Value;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "ERROR getting accounts picklist metadata");
            }

            // get the application mapping.

            ApplicationMapping applicationMapping = new ApplicationMapping();
            var systemForm = _dynamicsClient.Systemforms.GetByKey(formid);

            /*
            string entityKey = "SystemForm_" + id + "_Entity";
            string nameKey = "SystemForm_" + id + "_Name";
            string xmlKey = "SystemForm_" + id + "_FormXML";
            string formXml = await _distributedCache.GetStringAsync(xmlKey);
            */

            string formXml = systemForm.Formxml;

            ViewModels.Form form = new ViewModels.Form();
            form.id = formid;
            form.tabs = new List<ViewModels.FormTab>();
            form.sections = new List<ViewModels.FormSection>();

            var tabs = XDocument.Parse(formXml).XPathSelectElements("form/tabs/tab");
            if (tabs != null)
            {
                foreach (var tab in tabs)
                {
                    var tabLabel = tab.XPathSelectElement("labels/label");
                    string description = tabLabel.Attribute("description").Value;
                    string tabId = tabLabel.Attribute("id") == null ? "" : tabLabel.Attribute("id").Value;
                    Boolean tabShowLabel = tab.Attribute("showlabel").DynamicsAttributeToBoolean();
                    Boolean tabVisible = tab.Attribute("visible").DynamicsAttributeToBoolean();

                    FormTab formTab = new FormTab();
                    formTab.id = tabId;
                    formTab.name = description;
                    formTab.sections = new List<FormSection>();
                    formTab.showlabel = tabShowLabel;
                    formTab.visible = tabVisible;

                    // get the sections
                    var sections = tab.XPathSelectElements("columns/column/sections/section");
                    foreach (var section in sections)
                    {
                        Boolean sectionShowLabel = section.Attribute("showlabel").DynamicsAttributeToBoolean();
                        Boolean sectionVisible = section.Attribute("visible").DynamicsAttributeToBoolean();
                        if (section.Attribute("visible") == null)
                        {
                            sectionVisible = true; // default visibility to true if it is not specified.
                        }


                        FormSection formSection = new FormSection();
                        formSection.fields = new List<FormField>();
                        formSection.id = section.Attribute("id").Value;
                        formSection.showlabel = sectionShowLabel;
                        formSection.visible = sectionVisible;

                        // get the fields.
                        var sectionLabels = section.XPathSelectElements("labels/label");

                        // the section label is the section name.
                        foreach (var sectionLabel in sectionLabels)
                        {
                            formSection.name = sectionLabel.Attribute("description").Value;
                        }
                        // get the cells.
                        var cells = section.XPathSelectElements("rows/row/cell");

                        foreach (var cell in cells)
                        {
                            FormField formField = new FormField();
                            // get cell visibility and showlabel
                            bool cellShowLabel = cell.Attribute("showlabel").DynamicsAttributeToBoolean();
                            bool cellVisible = cell.Attribute("visible").DynamicsAttributeToBoolean();

                            // set the cell to visible if it is not hidden.
                            if (cell.Attribute("visible") == null)
                            {
                                cellVisible = true;
                            }

                            formField.showlabel = cellShowLabel;
                            formField.visible = cellVisible;

                            // get the cell label. 

                            if (formField.showlabel)
                            {
                                var cellLabels = cell.XPathSelectElements("labels/label");
                                foreach (var cellLabel in cellLabels)
                                {
                                    formField.name = cellLabel.Attribute("description").Value;
                                }
                            }
                            else
                            {
                                // use the section name.
                                formField.name = formSection.name;
                                formSection.name = ""; 
                            }

                            
                            // get the form field name.
                            var control = cell.XPathSelectElement("control");
                            if (!string.IsNullOrEmpty(formField.name) && control != null && control.Attribute("datafieldname") != null)
                            {
                                formField.classid = control.Attribute("classid").Value;
                                formField.controltype = formField.classid.DynamicsControlClassidToName();
                                string datafieldname = control.Attribute("datafieldname").Value;
                                // translate the data field name
                                formField.datafieldname = applicationMapping.GetViewModelKey(datafieldname);

                                formField.required = control.Attribute("isrequired").DynamicsAttributeToBoolean();

                                if (formField.controltype.Equals ("PicklistControl"))
                                {
                                    // get the options.
                                    var metadata = picklistMetadata.FirstOrDefault(x => x.LogicalName == datafieldname);

                                    formField.options = new List<OptionMetadata>();

                                    if (metadata == null)
                                    {
                                        formField.options.Add(new OptionMetadata() { label = "INVALID PICKLIST", value = 0 });
                                    }
                                    else
                                    {
                                        MicrosoftDynamicsCRMoptionSet optionSet = null;
                                        // could be an OptionSet or a globalOptionSet.
                                        if (metadata.OptionSet != null)
                                        {
                                            optionSet = metadata.OptionSet;
                                        }
                                        else
                                        {
                                            optionSet = metadata.GlobalOptionSet;
                                        }
                                        if (optionSet!= null)
                                        {
                                            foreach (var option in optionSet.Options)
                                            {
                                                int? value = option.Value;
                                                string label = option.Label?.UserLocalizedLabel?.Label;
                                                if (value == null || label == null)
                                                {
                                                    formField.options.Add(new OptionMetadata() { label = "INVALID PICKLIST", value = 0 });
                                                }
                                                else
                                                {
                                                    formField.options.Add(new OptionMetadata() { label = label, value = value.Value });
                                                }

                                            }
                                        }
                                        
                                    }
                                }
                                if (formField.datafieldname != null)
                                {
                                    formSection.fields.Add(formField);
                                }                                
                            }

                        }

                        formTab.sections.Add(formSection);
                        form.sections.Add(formSection);
                    }

                    form.tabs.Add(formTab);
                }
            }
            else // single tab form.
            {
                FormTab formTab = new FormTab();
                formTab.name = "";
                form.tabs.Add(formTab);
            }

            return new JsonResult(form);
        }
    }

}

