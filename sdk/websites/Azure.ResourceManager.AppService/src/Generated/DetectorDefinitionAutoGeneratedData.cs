// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the DetectorDefinitionAutoGenerated data model. </summary>
    public partial class DetectorDefinitionAutoGeneratedData : ResourceData
    {
        /// <summary> Initializes a new instance of DetectorDefinitionAutoGeneratedData. </summary>
        public DetectorDefinitionAutoGeneratedData()
        {
        }

        /// <summary> Initializes a new instance of DetectorDefinitionAutoGeneratedData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the detector. </param>
        /// <param name="description"> Description of the detector. </param>
        /// <param name="rank"> Detector Rank. </param>
        /// <param name="isEnabled"> Flag representing whether detector is enabled or not. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal DetectorDefinitionAutoGeneratedData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, double? rank, bool? isEnabled, string kind) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            Rank = rank;
            IsEnabled = isEnabled;
            Kind = kind;
        }

        /// <summary> Display name of the detector. </summary>
        public string DisplayName { get; }
        /// <summary> Description of the detector. </summary>
        public string Description { get; }
        /// <summary> Detector Rank. </summary>
        public double? Rank { get; }
        /// <summary> Flag representing whether detector is enabled or not. </summary>
        public bool? IsEnabled { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
