using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x2000010")]
	internal class AdfsAuthenticationResponseParser : IAuthenticationResponseParser
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12D0018", Offset = "0x12D0018", VA = "0x12D0018", Slot = "4")]
		public SAMLAssertion Parse(string authenticationResponse)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12D0414", Offset = "0x12D0414", VA = "0x12D0414")]
		public AdfsAuthenticationResponseParser()
		{
		}
	}
}
