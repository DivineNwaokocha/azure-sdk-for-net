// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Details of role definition. </summary>
    public partial class ExpandedPropertiesRoleDefinition
    {
        /// <summary> Initializes a new instance of ExpandedPropertiesRoleDefinition. </summary>
        internal ExpandedPropertiesRoleDefinition()
        {
        }

        /// <summary> Initializes a new instance of ExpandedPropertiesRoleDefinition. </summary>
        /// <param name="id"> Id of the role definition. </param>
        /// <param name="displayName"> Display name of the role definition. </param>
        /// <param name="expandedPropertiesRoleDefinitionType"> Type of the role definition. </param>
        internal ExpandedPropertiesRoleDefinition(ResourceIdentifier id, string displayName, string expandedPropertiesRoleDefinitionType)
        {
            Id = id;
            DisplayName = displayName;
            ExpandedPropertiesRoleDefinitionType = expandedPropertiesRoleDefinitionType;
        }

        /// <summary> Id of the role definition. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Display name of the role definition. </summary>
        public string DisplayName { get; }
        /// <summary> Type of the role definition. </summary>
        public string ExpandedPropertiesRoleDefinitionType { get; }
    }
}
