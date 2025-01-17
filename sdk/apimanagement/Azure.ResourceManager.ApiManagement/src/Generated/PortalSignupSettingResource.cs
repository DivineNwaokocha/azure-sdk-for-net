// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a PortalSignupSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PortalSignupSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPortalSignupSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetPortalSignupSetting method.
    /// </summary>
    public partial class PortalSignupSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PortalSignupSettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _portalSignupSettingSignUpSettingsClientDiagnostics;
        private readonly SignUpSettingsRestOperations _portalSignupSettingSignUpSettingsRestClient;
        private readonly PortalSignupSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="PortalSignupSettingResource"/> class for mocking. </summary>
        protected PortalSignupSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PortalSignupSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PortalSignupSettingResource(ArmClient client, PortalSignupSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PortalSignupSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PortalSignupSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _portalSignupSettingSignUpSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string portalSignupSettingSignUpSettingsApiVersion);
            _portalSignupSettingSignUpSettingsRestClient = new SignUpSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, portalSignupSettingSignUpSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/portalsettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PortalSignupSettingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Sign Up Settings for the Portal
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PortalSignupSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _portalSignupSettingSignUpSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalSignupSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sign Up Settings for the Portal
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PortalSignupSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.Get");
            scope.Start();
            try
            {
                var response = _portalSignupSettingSignUpSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalSignupSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update Sign-Up settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update Sign-Up settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<Response> UpdateAsync(string ifMatch, PortalSignupSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _portalSignupSettingSignUpSettingsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ifMatch, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update Sign-Up settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update Sign-Up settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="data"/> is null. </exception>
        public virtual Response Update(string ifMatch, PortalSignupSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.Update");
            scope.Start();
            try
            {
                var response = _portalSignupSettingSignUpSettingsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ifMatch, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update Sign-Up settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PortalSignupSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PortalSignupSettingData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _portalSignupSettingSignUpSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<PortalSignupSettingResource>(Response.FromValue(new PortalSignupSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update Sign-Up settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PortalSignupSettingResource> CreateOrUpdate(WaitUntil waitUntil, PortalSignupSettingData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _portalSignupSettingSignUpSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<PortalSignupSettingResource>(Response.FromValue(new PortalSignupSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the SignUpSettings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _portalSignupSettingSignUpSettingsRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the SignUpSettings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signup
        /// Operation Id: SignUpSettings_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _portalSignupSettingSignUpSettingsClientDiagnostics.CreateScope("PortalSignupSettingResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _portalSignupSettingSignUpSettingsRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
