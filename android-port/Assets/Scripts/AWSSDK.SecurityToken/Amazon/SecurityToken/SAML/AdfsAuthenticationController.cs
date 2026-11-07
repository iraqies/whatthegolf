using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x200000E")]
	internal class AdfsAuthenticationController : IAuthenticationController
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12CF540", Offset = "0x12CF540", VA = "0x12CF540", Slot = "4")]
		public string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType, IWebProxy proxySettings)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12CF634", Offset = "0x12CF634", VA = "0x12CF634")]
		private static string QueryProvider(Uri identityProvider, IWebProxy proxySettings, ICredentials credentials, string authenticationType)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12CFEF4", Offset = "0x12CFEF4", VA = "0x12CFEF4")]
		public AdfsAuthenticationController()
		{
		}
	}
}
