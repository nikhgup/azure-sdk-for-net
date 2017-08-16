// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccessRights.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessRights
    {
        [EnumMember(Value = "Manage")]
        Manage,
        [EnumMember(Value = "Send")]
        Send,
        [EnumMember(Value = "Listen")]
        Listen
    }
    internal static class AccessRightsEnumExtension
    {
        internal static string ToSerializedValue(this AccessRights? value)  =>
            value == null ? null : ((AccessRights)value).ToSerializedValue();

        internal static string ToSerializedValue(this AccessRights value)
        {
            switch( value )
            {
                case AccessRights.Manage:
                    return "Manage";
                case AccessRights.Send:
                    return "Send";
                case AccessRights.Listen:
                    return "Listen";
            }
            return null;
        }

        internal static AccessRights? ParseAccessRights(this string value)
        {
            switch( value )
            {
                case "Manage":
                    return AccessRights.Manage;
                case "Send":
                    return AccessRights.Send;
                case "Listen":
                    return AccessRights.Listen;
            }
            return null;
        }
    }
}
