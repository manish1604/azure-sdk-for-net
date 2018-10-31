// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the update certificate operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CertificateUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters
        /// class.
        /// </summary>
        public CertificateUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the
        /// certificate.</param>
        /// <param name="description">Gets or sets the description of the
        /// certificate.</param>
        public CertificateUpdateParameters(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}