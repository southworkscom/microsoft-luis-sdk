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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ClosedListModelCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the ClosedListModelCreateObject
        /// class.
        /// </summary>
        public ClosedListModelCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClosedListModelCreateObject
        /// class.
        /// </summary>
        public ClosedListModelCreateObject(IList<WordListCreateObject> subLists = default(IList<WordListCreateObject>), string name = default(string))
        {
            SubLists = subLists;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubLists")]
        public IList<WordListCreateObject> SubLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
