namespace Amazon.SecurityToken.SAML
{
	public interface IAuthenticationResponseParser
	{
		SAMLAssertion Parse(string authenticationResponse);
	}
}
