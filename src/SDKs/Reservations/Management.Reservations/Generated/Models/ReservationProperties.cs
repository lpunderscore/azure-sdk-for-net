// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Reservations;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReservationProperties
    {
        /// <summary>
        /// Initializes a new instance of the ReservationProperties class.
        /// </summary>
        public ReservationProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationProperties class.
        /// </summary>
        /// <param name="displayName">Friendly name for user to easily identify
        /// the reservation</param>
        /// <param name="appliedScopeType">Possible values include: 'Single',
        /// 'Shared'</param>
        /// <param name="quantity">Quantity of the SKUs that are part of the
        /// Reservation.</param>
        /// <param name="provisioningState">Possible values include:
        /// 'Creating', 'PendingResourceHold', 'ConfirmedResourceHold',
        /// 'PendingBilling', 'ConfirmedBilling', 'Created', 'Succeeded',
        /// 'Cancelled', 'Expired', 'BillingFailed', 'Failed', 'Split',
        /// 'Merged'</param>
        /// <param name="effectiveDateTime">DateTime of the Reservation
        /// starting when this version is effective from.</param>
        /// <param name="lastUpdatedDateTime">DateTime of the last time the
        /// Reservation was updated.</param>
        /// <param name="expiryDate">This is the date when the Reservation will
        /// expire.</param>
        public ReservationProperties(string displayName = default(string), IList<string> appliedScopes = default(IList<string>), string appliedScopeType = default(string), int? quantity = default(int?), string provisioningState = default(string), System.DateTime? effectiveDateTime = default(System.DateTime?), System.DateTime? lastUpdatedDateTime = default(System.DateTime?), System.DateTime? expiryDate = default(System.DateTime?), ExtendedStatusInfo extendedStatusInfo = default(ExtendedStatusInfo), ReservationSplitProperties splitProperties = default(ReservationSplitProperties), ReservationMergeProperties mergeProperties = default(ReservationMergeProperties))
        {
            DisplayName = displayName;
            AppliedScopes = appliedScopes;
            AppliedScopeType = appliedScopeType;
            Quantity = quantity;
            ProvisioningState = provisioningState;
            EffectiveDateTime = effectiveDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            ExpiryDate = expiryDate;
            ExtendedStatusInfo = extendedStatusInfo;
            SplitProperties = splitProperties;
            MergeProperties = mergeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name for user to easily identify the
        /// reservation
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appliedScopes")]
        public IList<string> AppliedScopes { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Single', 'Shared'
        /// </summary>
        [JsonProperty(PropertyName = "appliedScopeType")]
        public string AppliedScopeType { get; set; }

        /// <summary>
        /// Gets or sets quantity of the SKUs that are part of the Reservation.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Creating',
        /// 'PendingResourceHold', 'ConfirmedResourceHold', 'PendingBilling',
        /// 'ConfirmedBilling', 'Created', 'Succeeded', 'Cancelled', 'Expired',
        /// 'BillingFailed', 'Failed', 'Split', 'Merged'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets dateTime of the Reservation starting when this version
        /// is effective from.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveDateTime")]
        public System.DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// Gets dateTime of the last time the Reservation was updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedDateTime")]
        public System.DateTime? LastUpdatedDateTime { get; private set; }

        /// <summary>
        /// Gets or sets this is the date when the Reservation will expire.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedStatusInfo")]
        public ExtendedStatusInfo ExtendedStatusInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "splitProperties")]
        public ReservationSplitProperties SplitProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mergeProperties")]
        public ReservationMergeProperties MergeProperties { get; set; }

    }
}
