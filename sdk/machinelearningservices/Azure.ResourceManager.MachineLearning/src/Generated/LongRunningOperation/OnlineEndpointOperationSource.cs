// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MachineLearning
{
    internal class OnlineEndpointOperationSource : IOperationSource<OnlineEndpointResource>
    {
        private readonly ArmClient _client;

        internal OnlineEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        OnlineEndpointResource IOperationSource<OnlineEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = OnlineEndpointData.DeserializeOnlineEndpointData(document.RootElement);
            return new OnlineEndpointResource(_client, data);
        }

        async ValueTask<OnlineEndpointResource> IOperationSource<OnlineEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = OnlineEndpointData.DeserializeOnlineEndpointData(document.RootElement);
            return new OnlineEndpointResource(_client, data);
        }
    }
}
