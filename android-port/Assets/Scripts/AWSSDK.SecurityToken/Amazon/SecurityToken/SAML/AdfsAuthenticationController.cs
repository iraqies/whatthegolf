using System;
using System.Net;

namespace Amazon.SecurityToken.SAML
{
	internal class AdfsAuthenticationController : IAuthenticationController
	{
		public string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType, IWebProxy proxySettings)
		{
			return null;
		}

		private static string QueryProvider(Uri identityProvider, IWebProxy proxySettings, ICredentials credentials, string authenticationType)
		{
			return null;
		}
	}
}
