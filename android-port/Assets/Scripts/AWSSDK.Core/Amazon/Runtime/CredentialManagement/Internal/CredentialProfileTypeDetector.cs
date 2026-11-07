using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	[Token(Token = "0x2000142")]
	public static class CredentialProfileTypeDetector
	{
		[Token(Token = "0x40004EA")]
		private const string BasicCredentials = "Basic";

		[Token(Token = "0x40004EB")]
		private const string SessionCredentials = "Session";

		[Token(Token = "0x40004EC")]
		private const string AssumeRoleCredentials = "Assume Role";

		[Token(Token = "0x40004ED")]
		private const string AssumeRoleWithWebIdentityCredentials = "Assume Role with OIDC Web Identity";

		[Token(Token = "0x40004EE")]
		private const string SAMLCredentials = "SAML";

		[Token(Token = "0x40004EF")]
		private const string AccessKey = "AccessKey";

		[Token(Token = "0x40004F0")]
		private const string CredentialSource = "CredentialSource";

		[Token(Token = "0x40004F1")]
		private const string EndpointName = "EndpointName";

		[Token(Token = "0x40004F2")]
		private const string ExternalID = "ExternalID";

		[Token(Token = "0x40004F3")]
		private const string MfaSerial = "MfaSerial";

		[Token(Token = "0x40004F4")]
		private const string RoleArn = "RoleArn";

		[Token(Token = "0x40004F5")]
		private const string RoleSessionName = "RoleSessionName";

		[Token(Token = "0x40004F6")]
		private const string SecretKey = "SecretKey";

		[Token(Token = "0x40004F7")]
		private const string SourceProfile = "SourceProfile";

		[Token(Token = "0x40004F8")]
		private const string Token = "Token";

		[Token(Token = "0x40004F9")]
		private const string WebIdentityTokenFile = "WebIdentityTokenFile";

		[Token(Token = "0x40004FA")]
		private const string UserIdentity = "UserIdentity";

		[Token(Token = "0x40004FB")]
		private const string CredentialProcess = "CredentialProcess";

		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<CredentialProfileType, HashSet<string>> TypePropertyDictionary;

		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<CredentialProfileType, string> CredentialTypeDictionary;

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x11E6AA4", Offset = "0x11E6AA4", VA = "0x11E6AA4")]
		public static string GetUserFriendlyCredentialType(CredentialProfileType? profileType)
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x11E6B80", Offset = "0x11E6B80", VA = "0x11E6B80")]
		public static CredentialProfileType? DetectProfileType(CredentialProfileOptions profileOptions)
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x11EB174", Offset = "0x11EB174", VA = "0x11EB174")]
		public static HashSet<string> GetPropertiesForProfileType(CredentialProfileType profileType)
		{
			return null;
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x11EAF9C", Offset = "0x11EAF9C", VA = "0x11EAF9C")]
		private static HashSet<string> GetPropertyNames(CredentialProfileOptions profileOptions)
		{
			return null;
		}
	}
}
