using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x25814", Offset = "0x25814")]
	public static class ProfileManager
	{
		[Serializable]
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2584C", Offset = "0x2584C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SettingsCollection.ObjectSettings, string> _003C_003E9__9_0;

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1291600", Offset = "0x1291600", VA = "0x1291600")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1291608", Offset = "0x1291608", VA = "0x1291608")]
			internal string _003CListProfileNames_003Eb__9_0(SettingsCollection.ObjectSettings os)
			{
				return null;
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2585C", Offset = "0x2585C")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x10")]
			public string profileName;

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1291790", Offset = "0x1291790", VA = "0x1291790")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1291798", Offset = "0x1291798", VA = "0x1291798")]
			internal bool _003CReadProfileSettings_003Eb__0(SettingsCollection.ObjectSettings x)
			{
				return default;
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2586C", Offset = "0x2586C")]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x10")]
			public string settingsKey;

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1291930", Offset = "0x1291930", VA = "0x1291930")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1291938", Offset = "0x1291938", VA = "0x1291938")]
			internal bool _003CReadSettings_003Eb__0(SettingsCollection.ObjectSettings x)
			{
				return default;
			}
		}

		[Token(Token = "0x400023B")]
		public const string AWSCredentialsProfileType = "AWS";

		[Token(Token = "0x400023C")]
		public const string SAMLRoleProfileType = "SAML";

		[Token(Token = "0x170000F4")]
		public static bool IsAvailable
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1251548", Offset = "0x1251548", VA = "0x1251548")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1251550", Offset = "0x1251550", VA = "0x1251550")]
		public static void RegisterProfile(string profileName, string accessKeyId, string secretKey)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1251558", Offset = "0x1251558", VA = "0x1251558")]
		public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1251568", Offset = "0x1251568", VA = "0x1251568")]
		public static void RegisterSAMLRoleProfile(string profileName, string endpointName, string roleArn, string userIdentity, string stsRegion)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1251578", Offset = "0x1251578", VA = "0x1251578")]
		public static string RegisterSAMLEndpoint(string endpointName, Uri endpoint, string authenticationType)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x125161C", Offset = "0x125161C", VA = "0x125161C")]
		public static void UnregisterProfile(string profileName)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1251970", Offset = "0x1251970", VA = "0x1251970")]
		public static IEnumerable<string> ListProfileNames()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1251BD8", Offset = "0x1251BD8", VA = "0x1251BD8")]
		public static IEnumerable<ProfileSettingsBase> ListProfiles()
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12521CC", Offset = "0x12521CC", VA = "0x12521CC")]
		public static bool IsProfileKnown(string profileName)
		{
			return default;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1252334", Offset = "0x1252334", VA = "0x1252334")]
		public static string CopyProfileSettings(string sourceProfileName, string destinationProfileName)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1252400", Offset = "0x1252400", VA = "0x1252400")]
		public static string CopyProfileSettings(SettingsCollection.ObjectSettings source, string destinationProfileName)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x12529F0", Offset = "0x12529F0", VA = "0x12529F0")]
		public static bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
		{
			return default;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1252C0C", Offset = "0x1252C0C", VA = "0x1252C0C")]
		public static AWSCredentials GetAWSCredentials(string profileName)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1252D28", Offset = "0x1252D28", VA = "0x1252D28")]
		public static ProfileSettingsBase GetProfile(string profileName)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		public static T GetProfile<T>(string profileName) where T : ProfileSettingsBase
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		public static bool TryGetProfile<T>(string profileName, out T profile) where T : ProfileSettingsBase
		{
			return default;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1252E9C", Offset = "0x1252E9C", VA = "0x1252E9C")]
		public static bool TryGetSAMLEndpoint(string endpointName, out SAMLEndpointSettings endpointSettings)
		{
			return default;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x12530A8", Offset = "0x12530A8", VA = "0x12530A8")]
		public static SAMLEndpointSettings GetSAMLEndpoint(string endpointName)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x12521E8", Offset = "0x12521E8", VA = "0x12521E8")]
		internal static SettingsCollection.ObjectSettings ReadProfileSettings(string profileName)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1251880", Offset = "0x1251880", VA = "0x1251880")]
		internal static SettingsCollection.ObjectSettings ReadProfileSettings(SettingsCollection settings, string profileName)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1253180", Offset = "0x1253180", VA = "0x1253180")]
		internal static SettingsCollection.ObjectSettings ReadSettings(SettingsCollection settings, string settingsKey)
		{
			return null;
		}
	}
}
