// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The connectivity properties. </summary>
    public partial class ConnectivityEndpoint
    {
        /// <summary> Initializes a new instance of ConnectivityEndpoint. </summary>
        internal ConnectivityEndpoint()
        {
        }

        /// <summary> Initializes a new instance of ConnectivityEndpoint. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="location"> The location of the endpoint. </param>
        /// <param name="port"> The port to connect to. </param>
        /// <param name="privateIPAddress"> The private ip address of the endpoint. </param>
        internal ConnectivityEndpoint(string name, string protocol, AzureLocation? location, int? port, string privateIPAddress)
        {
            Name = name;
            Protocol = protocol;
            Location = location;
            Port = port;
            PrivateIPAddress = privateIPAddress;
        }

        /// <summary> The name of the endpoint. </summary>
        public string Name { get; }
        /// <summary> The protocol of the endpoint. </summary>
        public string Protocol { get; }
        /// <summary> The location of the endpoint. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The port to connect to. </summary>
        public int? Port { get; }
        /// <summary> The private ip address of the endpoint. </summary>
        public string PrivateIPAddress { get; }
    }
}
