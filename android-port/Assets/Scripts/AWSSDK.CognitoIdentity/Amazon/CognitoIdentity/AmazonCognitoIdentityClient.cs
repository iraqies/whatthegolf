using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentity
{
	public class AmazonCognitoIdentityClient : AmazonServiceClient, IAmazonCognitoIdentity, IAmazonService, IDisposable
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata => null;

		IClientConfig IAmazonService.Config => null;

		public AmazonCognitoIdentityClient()
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(AmazonCognitoIdentityConfig config)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(AWSCredentials credentials)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(AWSCredentials credentials, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(AWSCredentials credentials, AmazonCognitoIdentityConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityConfig clientConfig)
			: base(null, null)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal virtual CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
		{
			return null;
		}

		public virtual Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteIdentitiesResponse DeleteIdentities(DeleteIdentitiesRequest request)
		{
			return null;
		}

		public virtual Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
		{
			return null;
		}

		public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request)
		{
			return null;
		}

		public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
		{
			return null;
		}

		public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request)
		{
			return null;
		}

		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetIdResponse GetId(GetIdRequest request)
		{
			return null;
		}

		public virtual Task<GetIdResponse> GetIdAsync(GetIdRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request)
		{
			return null;
		}

		public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
		{
			return null;
		}

		public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request)
		{
			return null;
		}

		public virtual Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
		{
			return null;
		}

		public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
		{
			return null;
		}

		public virtual Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
		{
			return null;
		}

		public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request)
		{
			return null;
		}

		public virtual Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request)
		{
			return null;
		}

		public virtual Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request)
		{
			return null;
		}

		public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual TagResourceResponse TagResource(TagResourceRequest request)
		{
			return null;
		}

		public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request)
		{
			return null;
		}

		public virtual Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
		{
			return null;
		}

		public virtual Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
		{
			return null;
		}

		public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
		{
			return null;
		}

		public virtual Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
