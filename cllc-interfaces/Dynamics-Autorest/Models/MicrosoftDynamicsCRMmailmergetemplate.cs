// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// mailmergetemplate
    /// </summary>
    public partial class MicrosoftDynamicsCRMmailmergetemplate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmailmergetemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmailmergetemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmailmergetemplate class.
        /// </summary>
        public MicrosoftDynamicsCRMmailmergetemplate(int? timezoneruleversionnumber = default(int?), int? componentstate = default(int?), int? languagecode = default(int?), string _modifiedonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), string _transactioncurrencyidValue = default(string), bool? ismanaged = default(bool?), int? filesize = default(int?), string mailmergetemplateidunique = default(string), string _owningteamValue = default(string), int? statuscode = default(int?), long? versionnumber = default(long?), string mimetype = default(string), int? mailmergetype = default(int?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string _owninguserValue = default(string), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), string body = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string filename = default(string), int? documentformat = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? statecode = default(int?), string solutionid = default(string), object exchangerate = default(object), string introducedversion = default(string), bool? ispersonal = default(bool?), string description = default(string), string mailmergetemplateid = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string defaultfilter = default(string), string name = default(string), string _owneridValue = default(string), string _createdbyValue = default(string), string templatetypecode = default(string), string parameterxml = default(string), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMasyncoperation> mailMergeTemplateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> mailMergeTemplateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Componentstate = componentstate;
            Languagecode = languagecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Ismanaged = ismanaged;
            Filesize = filesize;
            Mailmergetemplateidunique = mailmergetemplateidunique;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            Mimetype = mimetype;
            Mailmergetype = mailmergetype;
            Iscustomizable = iscustomizable;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Body = body;
            Modifiedon = modifiedon;
            Filename = filename;
            Documentformat = documentformat;
            Overwritetime = overwritetime;
            Statecode = statecode;
            Solutionid = solutionid;
            Exchangerate = exchangerate;
            Introducedversion = introducedversion;
            Ispersonal = ispersonal;
            Description = description;
            Mailmergetemplateid = mailmergetemplateid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            Defaultfilter = defaultfilter;
            Name = name;
            this._owneridValue = _owneridValue;
            this._createdbyValue = _createdbyValue;
            Templatetypecode = templatetypecode;
            Parameterxml = parameterxml;
            Transactioncurrencyid = transactioncurrencyid;
            Ownerid = ownerid;
            MailMergeTemplateAsyncOperations = mailMergeTemplateAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            Owningbusinessunit = owningbusinessunit;
            Modifiedonbehalfby = modifiedonbehalfby;
            MailMergeTemplateSyncErrors = mailMergeTemplateSyncErrors;
            Modifiedby = modifiedby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailmergetemplateidunique")]
        public string Mailmergetemplateidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailmergetype")]
        public int? Mailmergetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentformat")]
        public int? Documentformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispersonal")]
        public bool? Ispersonal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailmergetemplateid")]
        public string Mailmergetemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultfilter")]
        public string Defaultfilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templatetypecode")]
        public string Templatetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameterxml")]
        public string Parameterxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MailMergeTemplate_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MailMergeTemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MailMergeTemplate_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MailMergeTemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
