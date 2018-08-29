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

    public partial class MicrosoftDynamicsCRMquarterlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMquarterlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMquarterlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMquarterlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMquarterlyfiscalcalendar(int? fiscalperiodtype = default(int?), object quarter4 = default(object), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), object quarter1 = default(object), object createdon = default(object), string _modifiedbyValue = default(string), string _transactioncurrencyidValue = default(string), object quarter3 = default(object), string _salespersonidValue = default(string), string _createdonbehalfbyValue = default(string), string userfiscalcalendarid = default(string), string _modifiedonbehalfbyValue = default(string), object quarter2 = default(object), object exchangerate = default(object), object quarter4Base = default(object), string _businessunitidValue = default(string), object quarter2Base = default(object), object quarter1Base = default(object), object effectiveon = default(object), int? utcconversiontimezonecode = default(int?), object modifiedon = default(object), object quarter3Base = default(object), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMasyncoperation> quarterlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> quarterlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser))
        {
            Fiscalperiodtype = fiscalperiodtype;
            Quarter4 = quarter4;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Quarter1 = quarter1;
            Createdon = createdon;
            this._modifiedbyValue = _modifiedbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Quarter3 = quarter3;
            this._salespersonidValue = _salespersonidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Userfiscalcalendarid = userfiscalcalendarid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Quarter2 = quarter2;
            Exchangerate = exchangerate;
            Quarter4Base = quarter4Base;
            this._businessunitidValue = _businessunitidValue;
            Quarter2Base = quarter2Base;
            Quarter1Base = quarter1Base;
            Effectiveon = effectiveon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            Quarter3Base = quarter3Base;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            QuarterlyFiscalCalendarAsyncOperations = quarterlyFiscalCalendarAsyncOperations;
            QuarterlyFiscalCalendarBulkDeleteFailures = quarterlyFiscalCalendarBulkDeleteFailures;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Salespersonid = salespersonid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter4")]
        public object Quarter4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter1")]
        public object Quarter1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter3")]
        public object Quarter3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter2")]
        public object Quarter2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter4_base")]
        public object Quarter4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter2_base")]
        public object Quarter2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter1_base")]
        public object Quarter1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public object Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quarter3_base")]
        public object Quarter3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuarterlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QuarterlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QuarterlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

    }
}
