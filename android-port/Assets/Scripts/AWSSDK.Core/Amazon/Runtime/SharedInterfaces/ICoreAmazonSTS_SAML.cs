using System;
using System.Net;

namespace Amazon.Runtime.SharedInterfaces
{
	public interface ICoreAmazonSTS_SAML
	{
		SAMLImmutableCredentials CredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, TimeSpan credentialDuration, ICredentials userCredential);
	}
}
