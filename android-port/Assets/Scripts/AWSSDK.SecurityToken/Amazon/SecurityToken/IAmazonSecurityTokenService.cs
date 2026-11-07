using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000007")]
	public interface IAmazonSecurityTokenService : IDisposable, ICoreAmazonSTS, ICoreAmazonSTS_SAML, IAmazonService
	{
		[Token(Token = "0x6000043")]
		Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000044")]
		Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000045")]
		Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000046")]
		Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000047")]
		Task<GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000048")]
		Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000049")]
		Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600004A")]
		Task<GetSessionTokenResponse> GetSessionTokenAsync([Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600004B")]
		Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, [Optional] CancellationToken cancellationToken);
	}
}
