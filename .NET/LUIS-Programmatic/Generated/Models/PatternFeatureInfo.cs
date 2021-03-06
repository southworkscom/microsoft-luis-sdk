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

    public partial class PatternFeatureInfo : FeatureInfoObject
    {
        /// <summary>
        /// Initializes a new instance of the PatternFeatureInfo class.
        /// </summary>
        public PatternFeatureInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatternFeatureInfo class.
        /// </summary>
        /// <param name="id">A six-digit ID used for Features.</param>
        /// <param name="name">The name of the Feature.</param>
        public PatternFeatureInfo(double? id = default(double?), string name = default(string), bool? isActive = default(bool?), string pattern = default(string))
            : base(id, name, isActive)
        {
            Pattern = pattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

    }
}
