// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoveResourceDependency
    {
        internal static MoveResourceDependency DeserializeMoveResourceDependency(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> resolutionStatus = default;
            Optional<ResolutionType> resolutionType = default;
            Optional<DependencyType> dependencyType = default;
            Optional<ManualResolutionProperties> manualResolution = default;
            Optional<AutomaticResolutionProperties> automaticResolution = default;
            Optional<string> isOptional = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionStatus"))
                {
                    resolutionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolutionType = new ResolutionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependencyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dependencyType = new DependencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manualResolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    manualResolution = ManualResolutionProperties.DeserializeManualResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("automaticResolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    automaticResolution = AutomaticResolutionProperties.DeserializeAutomaticResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isOptional"))
                {
                    isOptional = property.Value.GetString();
                    continue;
                }
            }
            return new MoveResourceDependency(id.Value, resolutionStatus.Value, Optional.ToNullable(resolutionType), Optional.ToNullable(dependencyType), manualResolution.Value, automaticResolution.Value, isOptional.Value);
        }
    }
}
