/* 
 * OpenBots Server API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OpenBots.Server.SDK.Client.SwaggerDateConverter;

namespace OpenBots.Server.SDK.Model
{
    /// <summary>
    /// Stores the usage type for the IPFencing
    /// </summary>
    /// <value>Stores the usage type for the IPFencing</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UsageType
    {
        /// <summary>
        /// Enum Allow for value: Allow
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow = 1,
        /// <summary>
        /// Enum Deny for value: Deny
        /// </summary>
        [EnumMember(Value = "Deny")]
        Deny = 2    }
}
