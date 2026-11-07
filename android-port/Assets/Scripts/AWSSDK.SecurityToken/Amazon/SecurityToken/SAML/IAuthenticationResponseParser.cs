using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x2000013")]
	public interface IAuthenticationResponseParser
	{
		[Token(Token = "0x6000070")]
		SAMLAssertion Parse(string authenticationResponse);
	}
}
