using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x2000012")]
	public interface IAuthenticationController
	{
		[Token(Token = "0x600006F")]
		string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType, IWebProxy proxySettings);
	}
}
