using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000018")]
	public interface IAmazonCognitoIdentity : IAmazonService, IDisposable
	{
		[Token(Token = "0x60000B2")]
		Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B3")]
		Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B4")]
		Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B5")]
		Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B6")]
		Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B7")]
		Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B8")]
		Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000B9")]
		Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BA")]
		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BB")]
		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BC")]
		Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BD")]
		Task<GetIdResponse> GetIdAsync(GetIdRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BE")]
		Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000BF")]
		Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C0")]
		Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C1")]
		Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C2")]
		Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C3")]
		Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C4")]
		Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C5")]
		Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C6")]
		Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C7")]
		Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C8")]
		Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000C9")]
		Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000CA")]
		Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000CB")]
		Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000CC")]
		Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000CD")]
		Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60000CE")]
		Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, [Optional] CancellationToken cancellationToken);
	}
}
