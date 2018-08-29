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
    /// RescheduleResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRescheduleResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRescheduleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRescheduleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRescheduleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRescheduleResponse(MicrosoftDynamicsCRMValidationResult validationResult = default(MicrosoftDynamicsCRMValidationResult), IList<MicrosoftDynamicsCRMBusinessNotification> notifications = default(IList<MicrosoftDynamicsCRMBusinessNotification>))
        {
            ValidationResult = validationResult;
            Notifications = notifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ValidationResult")]
        public MicrosoftDynamicsCRMValidationResult ValidationResult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notifications")]
        public IList<MicrosoftDynamicsCRMBusinessNotification> Notifications { get; set; }

    }
}
