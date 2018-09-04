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
    /// adoxio_investigationstakeholder
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioInvestigationstakeholder
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationstakeholder class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationstakeholder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationstakeholder class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationstakeholder(string adoxioInvestigationstakeholderid = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _modifiedbyValue = default(string), string emailaddress = default(string), string _createdonbehalfbyValue = default(string), int? adoxioType = default(int?), string adoxioPhonenumber = default(string), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), string _adoxioRelatedinvestigationValue = default(string), string adoxioLastname = default(string), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioMiddlename = default(string), string adoxioName = default(string), string adoxioFirstname = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statuscode = default(int?), int? importsequencenumber = default(int?), long? versionnumber = default(long?), string _owninguserValue = default(string), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> adoxioInvestigationstakeholderActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> adoxioInvestigationstakeholderAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioInvestigationstakeholderEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioInvestigationstakeholderFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioInvestigationstakeholderLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioInvestigationstakeholderPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioInvestigationstakeholderServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> adoxioInvestigationstakeholderTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioInvestigationstakeholderRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioInvestigationstakeholderSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> adoxioInvestigationstakeholderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> adoxioInvestigationstakeholderActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationstakeholderDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationstakeholderDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> adoxioInvestigationstakeholderAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioInvestigationstakeholderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioInvestigationstakeholderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioWitnessstatement> adoxioAdoxioInvestigationstakeholderAdoxioWitnessstatementStakeHolder = default(IList<MicrosoftDynamicsCRMadoxioWitnessstatement>), MicrosoftDynamicsCRMadoxioInvestigation adoxioRelatedInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation))
        {
            AdoxioInvestigationstakeholderid = adoxioInvestigationstakeholderid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            this._modifiedbyValue = _modifiedbyValue;
            Emailaddress = emailaddress;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioType = adoxioType;
            AdoxioPhonenumber = adoxioPhonenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            this._adoxioRelatedinvestigationValue = _adoxioRelatedinvestigationValue;
            AdoxioLastname = adoxioLastname;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioName = adoxioName;
            AdoxioFirstname = adoxioFirstname;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            Statecode = statecode;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioInvestigationstakeholderActivityPointers = adoxioInvestigationstakeholderActivityPointers;
            AdoxioInvestigationstakeholderAppointments = adoxioInvestigationstakeholderAppointments;
            AdoxioInvestigationstakeholderEmails = adoxioInvestigationstakeholderEmails;
            AdoxioInvestigationstakeholderFaxes = adoxioInvestigationstakeholderFaxes;
            AdoxioInvestigationstakeholderLetters = adoxioInvestigationstakeholderLetters;
            AdoxioInvestigationstakeholderPhoneCalls = adoxioInvestigationstakeholderPhoneCalls;
            AdoxioInvestigationstakeholderServiceAppointments = adoxioInvestigationstakeholderServiceAppointments;
            AdoxioInvestigationstakeholderTasks = adoxioInvestigationstakeholderTasks;
            AdoxioInvestigationstakeholderRecurringAppointmentMasters = adoxioInvestigationstakeholderRecurringAppointmentMasters;
            AdoxioInvestigationstakeholderSocialActivities = adoxioInvestigationstakeholderSocialActivities;
            AdoxioInvestigationstakeholderSyncErrors = adoxioInvestigationstakeholderSyncErrors;
            AdoxioInvestigationstakeholderActivityParties = adoxioInvestigationstakeholderActivityParties;
            AdoxioInvestigationstakeholderDuplicateMatchingRecord = adoxioInvestigationstakeholderDuplicateMatchingRecord;
            AdoxioInvestigationstakeholderDuplicateBaseRecord = adoxioInvestigationstakeholderDuplicateBaseRecord;
            AdoxioInvestigationstakeholderAnnotations = adoxioInvestigationstakeholderAnnotations;
            AdoxioInvestigationstakeholderAsyncOperations = adoxioInvestigationstakeholderAsyncOperations;
            AdoxioInvestigationstakeholderBulkDeleteFailures = adoxioInvestigationstakeholderBulkDeleteFailures;
            AdoxioAdoxioInvestigationstakeholderAdoxioWitnessstatementStakeHolder = adoxioAdoxioInvestigationstakeholderAdoxioWitnessstatementStakeHolder;
            AdoxioRelatedInvestigation = adoxioRelatedInvestigation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholderid")]
        public string AdoxioInvestigationstakeholderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_type")]
        public int? AdoxioType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedinvestigation_value")]
        public string _adoxioRelatedinvestigationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioInvestigationstakeholderActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioInvestigationstakeholderAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioInvestigationstakeholderEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioInvestigationstakeholderFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioInvestigationstakeholderLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioInvestigationstakeholderPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioInvestigationstakeholderServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioInvestigationstakeholderTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioInvestigationstakeholderRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioInvestigationstakeholderSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioInvestigationstakeholderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> AdoxioInvestigationstakeholderActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationstakeholderDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationstakeholderDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioInvestigationstakeholderAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioInvestigationstakeholderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationstakeholder_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioInvestigationstakeholderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_investigationstakeholder_adoxio_witnessstatement_StakeHolder")]
        public IList<MicrosoftDynamicsCRMadoxioWitnessstatement> AdoxioAdoxioInvestigationstakeholderAdoxioWitnessstatementStakeHolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedInvestigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation AdoxioRelatedInvestigation { get; set; }

    }
}
