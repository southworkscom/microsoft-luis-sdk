// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriptionKeyInfo
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionKeyInfo class.
        /// </summary>
        public SubscriptionKeyInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionKeyInfo class.
        /// </summary>
        public SubscriptionKeyInfo(string subscriptionKey = default(string), string subscriptionName = default(string), string subscriptionRegion = default(string))
        {
            SubscriptionKey = subscriptionKey;
            SubscriptionName = subscriptionName;
            SubscriptionRegion = subscriptionRegion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionKey")]
        public string SubscriptionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionName")]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionRegion")]
        public string SubscriptionRegion { get; set; }

    }
}