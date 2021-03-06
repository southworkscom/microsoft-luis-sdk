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

    public partial class PhraselistCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        public PhraselistCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        public PhraselistCreateObject(string phrases = default(string), string name = default(string), bool? isExchangeable = default(bool?))
        {
            Phrases = phrases;
            Name = name;
            IsExchangeable = isExchangeable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phrases")]
        public string Phrases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsExchangeable")]
        public bool? IsExchangeable { get; set; }

    }
}
