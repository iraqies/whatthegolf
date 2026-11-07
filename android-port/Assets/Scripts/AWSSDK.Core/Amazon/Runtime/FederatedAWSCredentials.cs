using System;
using System.Net;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.CredentialManagement.Internal;

namespace Amazon.Runtime
{
	public class FederatedAWSCredentials : RefreshingAWSCredentials
	{
		private const int MaxAuthenticationRetries = 3;

		private static readonly RegionEndpoint DefaultSTSClientRegion;

		private static readonly TimeSpan MaximumCredentialTimespan;

		private static readonly TimeSpan DefaultPreemptExpiryTime;

		private readonly SAMLRoleSessionManager sessionManager;

		public SAMLEndpoint SAMLEndpoint { get; private set; }

		public string RoleArn { get; private set; }

		public FederatedAWSCredentialsOptions Options { get; private set; }

		public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn)
		{
		}

		public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn, FederatedAWSCredentialsOptions options)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		private CredentialsRefreshState Authenticate(ICredentials userCredential)
		{
			return null;
		}

		private string GetRoleSessionName()
		{
			return null;
		}

		private bool TryGetRoleSession(out SAMLImmutableCredentials sessionCredentials)
		{
			sessionCredentials = null;
			return false;
		}

		private void RegisterRoleSession(SAMLImmutableCredentials sessionCredentials)
		{
		}

		public override void ClearCredentials()
		{
		}
	}
}
