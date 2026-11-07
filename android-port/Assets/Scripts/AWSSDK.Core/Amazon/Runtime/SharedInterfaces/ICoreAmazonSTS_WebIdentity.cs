using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
	public interface ICoreAmazonSTS_WebIdentity : IDisposable
	{
		AssumeRoleImmutableCredentials CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options);

		Task<AssumeRoleImmutableCredentials> CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options);
	}
}
