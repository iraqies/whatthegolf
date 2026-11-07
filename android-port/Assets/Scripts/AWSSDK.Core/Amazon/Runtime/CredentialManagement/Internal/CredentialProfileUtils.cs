using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	[Token(Token = "0x2000143")]
	public static class CredentialProfileUtils
	{
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x11EBC88", Offset = "0x11EBC88", VA = "0x11EBC88")]
		public static Dictionary<string, string> GetProperties(CredentialProfile profile)
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x11EBD0C", Offset = "0x11EBD0C", VA = "0x11EBD0C")]
		public static void SetProperty(CredentialProfile profile, string key, string value)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x11EBDE4", Offset = "0x11EBDE4", VA = "0x11EBDE4")]
		public static string GetProperty(CredentialProfile profile, string key)
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x11EBECC", Offset = "0x11EBECC", VA = "0x11EBECC")]
		public static Guid EnsureUniqueKeyAssigned(CredentialProfile profile, ICredentialProfileStore profileStore)
		{
			return default;
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x11EC074", Offset = "0x11EC074", VA = "0x11EC074")]
		public static string GetUniqueKey(CredentialProfile profile)
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x11EC140", Offset = "0x11EC140", VA = "0x11EC140")]
		public static void SetUniqueKey(CredentialProfile profile, Guid? uniqueKey)
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x11EC164", Offset = "0x11EC164", VA = "0x11EC164")]
		public static CredentialProfileType? GetProfileType(CredentialProfile profile)
		{
			return null;
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x11EC1E0", Offset = "0x11EC1E0", VA = "0x11EC1E0")]
		public static bool IsCallbackRequired(CredentialProfile profile)
		{
			return default;
		}
	}
}
