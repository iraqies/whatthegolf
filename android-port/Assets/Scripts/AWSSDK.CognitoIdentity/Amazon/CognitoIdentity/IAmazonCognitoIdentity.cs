using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public interface IAmazonCognitoIdentity : IAmazonService, IDisposable
	{
		Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdResponse> GetIdAsync(GetIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}
}
