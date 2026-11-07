using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
	public interface IAmazonSecurityTokenService : IDisposable, ICoreAmazonSTS, ICoreAmazonSTS_SAML, IAmazonService
	{
		Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetSessionTokenResponse> GetSessionTokenAsync(CancellationToken cancellationToken = default(CancellationToken));

		Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}
}
