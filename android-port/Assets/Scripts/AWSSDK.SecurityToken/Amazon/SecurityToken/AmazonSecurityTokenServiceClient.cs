using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
	public class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService, IDisposable, ICoreAmazonSTS, ICoreAmazonSTS_SAML, IAmazonService, ICoreAmazonSTS_WebIdentity
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata => null;

		IClientConfig IAmazonService.Config => null;

		SAMLImmutableCredentials ICoreAmazonSTS_SAML.CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, TimeSpan credentialDuration, ICredentials userCredential)
		{
			return null;
		}

		private AssumeRoleWithWebIdentityRequest SetupAssumeRoleWithWebIdentityRequest(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		AssumeRoleImmutableCredentials ICoreAmazonSTS_WebIdentity.CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		Task<AssumeRoleImmutableCredentials> ICoreAmazonSTS_WebIdentity.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		AssumeRoleImmutableCredentials ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
			return null;
		}

		protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		public AmazonSecurityTokenServiceClient()
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
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

		internal virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
		{
			return null;
		}

		public virtual Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
		{
			return null;
		}

		public virtual Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
		{
			return null;
		}

		public virtual Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
		{
			return null;
		}

		public virtual Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetAccessKeyInfoResponse GetAccessKeyInfo(GetAccessKeyInfoRequest request)
		{
			return null;
		}

		public virtual Task<GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
		{
			return null;
		}

		public virtual Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
		{
			return null;
		}

		public virtual Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetSessionTokenResponse GetSessionToken()
		{
			return null;
		}

		internal virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
		{
			return null;
		}

		public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
