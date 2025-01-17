// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The type of identity used for the Batch Pool. </summary>
    public enum PoolIdentityType
    {
        /// <summary> Batch pool has no identity associated with it. Setting `None` in update pool will remove existing identities. </summary>
        None,
        /// <summary> Batch pool has user assigned identities with it. </summary>
        UserAssigned
    }
}
