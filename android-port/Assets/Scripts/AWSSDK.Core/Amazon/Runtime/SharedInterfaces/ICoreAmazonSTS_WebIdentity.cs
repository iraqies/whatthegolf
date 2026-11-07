using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010F")]
	public interface ICoreAmazonSTS_WebIdentity : IDisposable
	{
		[Token(Token = "0x60008F4")]
		AssumeRoleImmutableCredentials CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options);

		[Token(Token = "0x60008F5")]
		Task<AssumeRoleImmutableCredentials> CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options);
	}
}
