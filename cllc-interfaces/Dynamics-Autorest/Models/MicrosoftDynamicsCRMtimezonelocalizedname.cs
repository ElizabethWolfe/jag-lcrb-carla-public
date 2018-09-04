// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// timezonelocalizedname
    /// </summary>
    public partial class MicrosoftDynamicsCRMtimezonelocalizedname
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimezonelocalizedname class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonelocalizedname()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimezonelocalizedname class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonelocalizedname(string userinterfacename = default(string), string timezonelocalizednameid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string standardname = default(string), string _timezonedefinitionidValue = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), long? versionnumber = default(long?), string _organizationidValue = default(string), string daylightname = default(string), int? cultureid = default(int?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtimezonedefinition timezonedefinitionid = default(MicrosoftDynamicsCRMtimezonedefinition), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Userinterfacename = userinterfacename;
            Timezonelocalizednameid = timezonelocalizednameid;
            Createdon = createdon;
            Standardname = standardname;
            this._timezonedefinitionidValue = _timezonedefinitionidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Daylightname = daylightname;
            Cultureid = cultureid;
            Createdonbehalfby = createdonbehalfby;
            Timezonedefinitionid = timezonedefinitionid;
            Modifiedonbehalfby = modifiedonbehalfby;
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
        [JsonProperty(PropertyName = "userinterfacename")]
        public string Userinterfacename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonelocalizednameid")]
        public string Timezonelocalizednameid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardname")]
        public string Standardname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_timezonedefinitionid_value")]
        public string _timezonedefinitionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightname")]
        public string Daylightname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cultureid")]
        public int? Cultureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonedefinitionid")]
        public MicrosoftDynamicsCRMtimezonedefinition Timezonedefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
