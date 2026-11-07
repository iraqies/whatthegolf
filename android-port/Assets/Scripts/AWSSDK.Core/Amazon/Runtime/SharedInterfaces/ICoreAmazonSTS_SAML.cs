using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010E")]
	public interface ICoreAmazonSTS_SAML
	{
		[Token(Token = "0x60008F3")]
		SAMLImmutableCredentials CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, TimeSpan credentialDuration, ICredentials userCredential);
	}
}
