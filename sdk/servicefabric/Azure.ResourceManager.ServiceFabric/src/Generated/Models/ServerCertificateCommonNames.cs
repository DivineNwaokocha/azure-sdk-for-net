// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes a list of server certificates referenced by common name that are used to secure the cluster. </summary>
    public partial class ServerCertificateCommonNames
    {
        /// <summary> Initializes a new instance of ServerCertificateCommonNames. </summary>
        public ServerCertificateCommonNames()
        {
            CommonNames = new ChangeTrackingList<ServerCertificateCommonName>();
        }

        /// <summary> Initializes a new instance of ServerCertificateCommonNames. </summary>
        /// <param name="commonNames"> The list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="x509StoreName"> The local certificate store location. </param>
        internal ServerCertificateCommonNames(IList<ServerCertificateCommonName> commonNames, StoreName? x509StoreName)
        {
            CommonNames = commonNames;
            X509StoreName = x509StoreName;
        }

        /// <summary> The list of server certificates referenced by common name that are used to secure the cluster. </summary>
        public IList<ServerCertificateCommonName> CommonNames { get; }
        /// <summary> The local certificate store location. </summary>
        public StoreName? X509StoreName { get; set; }
    }
}
