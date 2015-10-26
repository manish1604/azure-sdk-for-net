// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    public partial class LocalNetworkGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        public LocalNetworkGateway() { }

        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        public LocalNetworkGateway(string etag = default(string), AddressSpace localNetworkAddressSpace = default(AddressSpace), string gatewayIpAddress = default(string), string provisioningState = default(string))
        {
            Etag = etag;
            LocalNetworkAddressSpace = localNetworkAddressSpace;
            GatewayIpAddress = gatewayIpAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Local network site Address space
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkAddressSpace")]
        public AddressSpace LocalNetworkAddressSpace { get; set; }

        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIpAddress")]
        public string GatewayIpAddress { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the LocalNetworkGateway
        /// resource Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
