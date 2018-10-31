// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The port exposed on the container group.
    /// </summary>
    public partial class Port
    {
        /// <summary>
        /// Initializes a new instance of the Port class.
        /// </summary>
        public Port()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Port class.
        /// </summary>
        /// <param name="portProperty">The port number.</param>
        /// <param name="protocol">The protocol associated with the port.
        /// Possible values include: 'TCP', 'UDP'</param>
        public Port(int portProperty, string protocol = default(string))
        {
            Protocol = protocol;
            PortProperty = portProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the protocol associated with the port. Possible values
        /// include: 'TCP', 'UDP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the port number.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int PortProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}