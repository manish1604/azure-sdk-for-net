// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Virtual machine image resource information.
    /// </summary>
    public partial class VirtualMachineImageResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageResource
        /// class.
        /// </summary>
        public VirtualMachineImageResource() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageResource
        /// class.
        /// </summary>
        public VirtualMachineImageResource(string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Name = name;
            Location = location;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
