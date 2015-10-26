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
    /// Describes a hardware profile.
    /// </summary>
    public partial class HardwareProfile
    {
        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>
        public HardwareProfile() { }

        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>
        public HardwareProfile(string vmSize = default(string))
        {
            VmSize = vmSize;
        }

        /// <summary>
        /// The virtual machine size name. Possible values for this property
        /// include: 'Basic_A0', 'Basic_A1', 'Basic_A2', 'Basic_A3',
        /// 'Basic_A4', 'Standard_A0', 'Standard_A1', 'Standard_A2',
        /// 'Standard_A3', 'Standard_A4', 'Standard_A5', 'Standard_A6',
        /// 'Standard_A7', 'Standard_A8', 'Standard_A9', 'Standard_G1',
        /// 'Standard_G2', 'Standard_G3', 'Standard_G4', 'Standard_G5'.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

    }
}
