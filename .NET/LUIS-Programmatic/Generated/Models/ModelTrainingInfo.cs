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

    public partial class ModelTrainingInfo
    {
        /// <summary>
        /// Initializes a new instance of the ModelTrainingInfo class.
        /// </summary>
        public ModelTrainingInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelTrainingInfo class.
        /// </summary>
        /// <param name="modelId">The GUID of the model.</param>
        public ModelTrainingInfo(string modelId = default(string), ModelTrainingDetails details = default(ModelTrainingDetails))
        {
            ModelId = modelId;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the GUID of the model.
        /// </summary>
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public ModelTrainingDetails Details { get; set; }

    }
}