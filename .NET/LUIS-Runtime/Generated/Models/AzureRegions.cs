// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AzureRegions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AzureRegions
    {
        [EnumMember(Value = "westus")]
        Westus,
        [EnumMember(Value = "westeurope")]
        Westeurope
    }
    internal static class AzureRegionsEnumExtension
    {
        internal static string ToSerializedValue(this AzureRegions? value)
        {
            return value == null ? null : ((AzureRegions)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AzureRegions value)
        {
            switch( value )
            {
                case AzureRegions.Westus:
                    return "westus";
                case AzureRegions.Westeurope:
                    return "westeurope";
            }
            return null;
        }

        internal static AzureRegions? ParseAzureRegions(this string value)
        {
            switch( value )
            {
                case "westus":
                    return AzureRegions.Westus;
                case "westeurope":
                    return AzureRegions.Westeurope;
            }
            return null;
        }
    }
}
