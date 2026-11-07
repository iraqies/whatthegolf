using System;
using Amazon.Runtime;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
	[Obsolete]
	public class STSAssumeRoleAWSCredentials : RefreshingAWSCredentials, IDisposable
	{
		private IAmazonSecurityTokenService _stsClient;

		private AssumeRoleRequest _assumeRequest;

		private AssumeRoleWithSAMLRequest _assumeSamlRequest;

		private bool _isDisposed;

		private static TimeSpan _defaultPreemptExpiryTime;

		public STSAssumeRoleAWSCredentials(IAmazonSecurityTokenService sts, AssumeRoleRequest assumeRoleRequest)
		{
		}

		public STSAssumeRoleAWSCredentials(AssumeRoleWithSAMLRequest assumeRoleWithSamlRequest)
		{
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		protected new virtual void Dispose(bool disposing)
		{
		}

		public new void Dispose()
		{
		}

		private Credentials GetServiceCredentials()
		{
			return null;
		}
	}
}
