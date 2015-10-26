// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Name value pair
    /// </summary>
    public partial class NameValuePair
    {
        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        public NameValuePair() { }

        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        public NameValuePair(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Pair name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Pair value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
