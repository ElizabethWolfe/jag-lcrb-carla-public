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
    /// ConditionExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMConditionExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMConditionExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMConditionExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMConditionExpression class.
        /// </summary>
        /// <param name="operatorProperty">Possible values include: 'Equal',
        /// 'NotEqual', 'GreaterThan', 'LessThan', 'GreaterEqual', 'LessEqual',
        /// 'Like', 'NotLike', 'In', 'NotIn', 'Between', 'NotBetween', 'Null',
        /// 'NotNull', 'Yesterday', 'Today', 'Tomorrow', 'Last7Days',
        /// 'Next7Days', 'LastWeek', 'ThisWeek', 'NextWeek', 'LastMonth',
        /// 'ThisMonth', 'NextMonth', 'On', 'OnOrBefore', 'OnOrAfter',
        /// 'LastYear', 'ThisYear', 'NextYear', 'LastXHours', 'NextXHours',
        /// 'LastXDays', 'NextXDays', 'LastXWeeks', 'NextXWeeks',
        /// 'LastXMonths', 'NextXMonths', 'LastXYears', 'NextXYears',
        /// 'EqualUserId', 'NotEqualUserId', 'EqualBusinessId',
        /// 'NotEqualBusinessId', 'ChildOf', 'Mask', 'NotMask', 'MasksSelect',
        /// 'Contains', 'DoesNotContain', 'EqualUserLanguage', 'NotOn',
        /// 'OlderThanXMonths', 'BeginsWith', 'DoesNotBeginWith', 'EndsWith',
        /// 'DoesNotEndWith', 'ThisFiscalYear', 'ThisFiscalPeriod',
        /// 'NextFiscalYear', 'NextFiscalPeriod', 'LastFiscalYear',
        /// 'LastFiscalPeriod', 'LastXFiscalYears', 'LastXFiscalPeriods',
        /// 'NextXFiscalYears', 'NextXFiscalPeriods', 'InFiscalYear',
        /// 'InFiscalPeriod', 'InFiscalPeriodAndYear',
        /// 'InOrBeforeFiscalPeriodAndYear', 'InOrAfterFiscalPeriodAndYear',
        /// 'EqualUserTeams', 'EqualUserOrUserTeams', 'Under', 'NotUnder',
        /// 'UnderOrEqual', 'Above', 'AboveOrEqual',
        /// 'EqualUserOrUserHierarchy', 'EqualUserOrUserHierarchyAndTeams',
        /// 'OlderThanXYears', 'OlderThanXWeeks', 'OlderThanXDays',
        /// 'OlderThanXHours', 'OlderThanXMinutes'</param>
        public MicrosoftDynamicsCRMConditionExpression(string attributeName = default(string), string entityName = default(string), string operatorProperty = default(string), IList<object> values = default(IList<object>))
        {
            AttributeName = attributeName;
            EntityName = entityName;
            OperatorProperty = operatorProperty;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Equal', 'NotEqual',
        /// 'GreaterThan', 'LessThan', 'GreaterEqual', 'LessEqual', 'Like',
        /// 'NotLike', 'In', 'NotIn', 'Between', 'NotBetween', 'Null',
        /// 'NotNull', 'Yesterday', 'Today', 'Tomorrow', 'Last7Days',
        /// 'Next7Days', 'LastWeek', 'ThisWeek', 'NextWeek', 'LastMonth',
        /// 'ThisMonth', 'NextMonth', 'On', 'OnOrBefore', 'OnOrAfter',
        /// 'LastYear', 'ThisYear', 'NextYear', 'LastXHours', 'NextXHours',
        /// 'LastXDays', 'NextXDays', 'LastXWeeks', 'NextXWeeks',
        /// 'LastXMonths', 'NextXMonths', 'LastXYears', 'NextXYears',
        /// 'EqualUserId', 'NotEqualUserId', 'EqualBusinessId',
        /// 'NotEqualBusinessId', 'ChildOf', 'Mask', 'NotMask', 'MasksSelect',
        /// 'Contains', 'DoesNotContain', 'EqualUserLanguage', 'NotOn',
        /// 'OlderThanXMonths', 'BeginsWith', 'DoesNotBeginWith', 'EndsWith',
        /// 'DoesNotEndWith', 'ThisFiscalYear', 'ThisFiscalPeriod',
        /// 'NextFiscalYear', 'NextFiscalPeriod', 'LastFiscalYear',
        /// 'LastFiscalPeriod', 'LastXFiscalYears', 'LastXFiscalPeriods',
        /// 'NextXFiscalYears', 'NextXFiscalPeriods', 'InFiscalYear',
        /// 'InFiscalPeriod', 'InFiscalPeriodAndYear',
        /// 'InOrBeforeFiscalPeriodAndYear', 'InOrAfterFiscalPeriodAndYear',
        /// 'EqualUserTeams', 'EqualUserOrUserTeams', 'Under', 'NotUnder',
        /// 'UnderOrEqual', 'Above', 'AboveOrEqual',
        /// 'EqualUserOrUserHierarchy', 'EqualUserOrUserHierarchyAndTeams',
        /// 'OlderThanXYears', 'OlderThanXWeeks', 'OlderThanXDays',
        /// 'OlderThanXHours', 'OlderThanXMinutes'
        /// </summary>
        [JsonProperty(PropertyName = "Operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<object> Values { get; set; }

    }
}
