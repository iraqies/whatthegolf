using System;
using System.Net;

namespace Amazon.SecurityToken.SAML
{
	public interface IAuthenticationController
	{
		string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType, IWebProxy proxySettings);
	}
}
