using System;
using System.Net;

namespace Amazon.SecurityToken.SAML
{
	public class SAMLAuthenticationController
	{
		public IAuthenticationController AuthenticationController { get; private set; }

		public IAuthenticationResponseParser ResponseParser { get; private set; }

		public IWebProxy ProxySettings { get; private set; }

		public SAMLAuthenticationController()
		{
		}

		public SAMLAuthenticationController(IWebProxy proxySettings)
		{
		}

		public SAMLAuthenticationController(IAuthenticationController authenticationController, IAuthenticationResponseParser responseParser, IWebProxy proxySettings)
		{
		}

		public SAMLAssertion GetSAMLAssertion(string identityProviderUrl, ICredentials credentials, string authenticationType)
		{
			return null;
		}

		public SAMLAssertion GetSAMLAssertion(Uri identityProviderUrl, ICredentials credentials, string authenticationType)
		{
			return null;
		}
	}
}
