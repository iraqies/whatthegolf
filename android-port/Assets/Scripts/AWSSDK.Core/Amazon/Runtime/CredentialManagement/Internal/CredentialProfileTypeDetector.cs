using System.Collections.Generic;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	public static class CredentialProfileTypeDetector
	{
		private const string BasicCredentials = "Basic";

		private const string SessionCredentials = "Session";

		private const string AssumeRoleCredentials = "Assume Role";

		private const string AssumeRoleWithWebIdentityCredentials = "Assume Role with OIDC Web Identity";

		private const string SAMLCredentials = "SAML";

		private const string AccessKey = "AccessKey";

		private const string CredentialSource = "CredentialSource";

		private const string EndpointName = "EndpointName";

		private const string ExternalID = "ExternalID";

		private const string MfaSerial = "MfaSerial";

		private const string RoleArn = "RoleArn";

		private const string RoleSessionName = "RoleSessionName";

		private const string SecretKey = "SecretKey";

		private const string SourceProfile = "SourceProfile";

		private const string Token = "Token";

		private const string WebIdentityTokenFile = "WebIdentityTokenFile";

		private const string UserIdentity = "UserIdentity";

		private const string CredentialProcess = "CredentialProcess";

		private static Dictionary<CredentialProfileType, HashSet<string>> TypePropertyDictionary;

		private static Dictionary<CredentialProfileType, string> CredentialTypeDictionary;

		public static string GetUserFriendlyCredentialType(CredentialProfileType? profileType)
		{
			return null;
		}

		public static CredentialProfileType? DetectProfileType(CredentialProfileOptions profileOptions)
		{
			return null;
		}

		public static HashSet<string> GetPropertiesForProfileType(CredentialProfileType profileType)
		{
			return null;
		}

		private static HashSet<string> GetPropertyNames(CredentialProfileOptions profileOptions)
		{
			return null;
		}
	}
}
