// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Identity provider details. </summary>
    public partial class IdentityProviderDetails
    {
        /// <summary> Initializes a new instance of IdentityProviderDetails. </summary>
        internal IdentityProviderDetails()
        {
        }

        /// <summary> Initializes a new instance of IdentityProviderDetails. </summary>
        /// <param name="tenantId"> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="applicationId"> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="objectId"> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="audience"> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </param>
        /// <param name="aadAuthority"> The base authority for Azure Active Directory authentication. </param>
        internal IdentityProviderDetails(Guid? tenantId, string applicationId, string objectId, string audience, string aadAuthority)
        {
            TenantId = tenantId;
            ApplicationId = applicationId;
            ObjectId = objectId;
            Audience = audience;
            AadAuthority = aadAuthority;
        }

        /// <summary> The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public Guid? TenantId { get; }
        /// <summary> The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ApplicationId { get; }
        /// <summary> The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string ObjectId { get; }
        /// <summary> The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services. </summary>
        public string Audience { get; }
        /// <summary> The base authority for Azure Active Directory authentication. </summary>
        public string AadAuthority { get; }
    }
}
