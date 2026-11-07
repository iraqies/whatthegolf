using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x200013C")]
	public class SharedCredentialsFile : ICredentialProfileStore, ICredentialProfileSource
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C24", Offset = "0x25C24")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40004CB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40004CC")]
			[FieldOffset(Offset = "0x8")]
			public static Func<CredentialProfile, string> _003C_003E9__29_0;

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1296B84", Offset = "0x1296B84", VA = "0x1296B84")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1296B8C", Offset = "0x1296B8C", VA = "0x1296B8C")]
			internal string _003CListProfileNames_003Eb__29_0(CredentialProfile p)
			{
				return null;
			}
		}

		[Token(Token = "0x40004B5")]
		public const string DefaultProfileName = "default";

		[Token(Token = "0x40004B6")]
		private const string ToolkitArtifactGuidField = "toolkit_artifact_guid";

		[Token(Token = "0x40004B7")]
		private const string RegionField = "region";

		[Token(Token = "0x40004B8")]
		private const string EndpointDiscoveryEnabledField = "endpoint_discovery_enabled";

		[Token(Token = "0x40004B9")]
		private const string ConfigFileName = "config";

		[Token(Token = "0x40004BA")]
		private const string DefaultDirectoryName = ".aws";

		[Token(Token = "0x40004BB")]
		private const string DefaultFileName = "credentials";

		[Token(Token = "0x40004BC")]
		private const string CredentialProcess = "credential_process";

		[Token(Token = "0x40004BD")]
		private const string StsRegionalEndpointsField = "sts_regional_endpoints";

		[Token(Token = "0x40004BE")]
		private const string S3UseArnRegionField = "s3_use_arn_region";

		[Token(Token = "0x40004BF")]
		private const string S3RegionalEndpointField = "s3_us_east_1_regional_endpoint";

		[Token(Token = "0x40004C0")]
		private const string RetryModeField = "retry_mode";

		[Token(Token = "0x40004C1")]
		private const string MaxAttemptsField = "max_attempts";

		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x10")]
		private readonly Logger _logger;

		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> ReservedPropertyNames;

		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<CredentialProfileType> ProfileTypeWhitelist;

		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly CredentialProfilePropertyMapping PropertyMapping;

		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string DefaultDirectory;

		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string DefaultFilePath;

		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x18")]
		private ProfileIniFile _credentialsFile;

		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x20")]
		private ProfileIniFile _configFile;

		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27078", Offset = "0x27078")]
		private string FilePath__BackingField;

		[Token(Token = "0x170002A6")]
		public string FilePath
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1274044", Offset = "0x1274044", VA = "0x1274044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29EBC", Offset = "0x29EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x127404C", Offset = "0x127404C", VA = "0x127404C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29ECC", Offset = "0x29ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1273814", Offset = "0x1273814", VA = "0x1273814")]
		static SharedCredentialsFile()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1274054", Offset = "0x1274054", VA = "0x1274054")]
		public SharedCredentialsFile()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1274340", Offset = "0x1274340", VA = "0x1274340")]
		public SharedCredentialsFile(string filePath)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1274144", Offset = "0x1274144", VA = "0x1274144")]
		private void SetUpFilePath(string filePath)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x127443C", Offset = "0x127443C", VA = "0x127443C", Slot = "10")]
		public List<string> ListProfileNames()
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x12745AC", Offset = "0x12745AC", VA = "0x12745AC", Slot = "11")]
		public List<CredentialProfile> ListProfiles()
		{
			return null;
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x12754AC", Offset = "0x12754AC", VA = "0x12754AC", Slot = "12")]
		public bool TryGetProfile(string profileName, out CredentialProfile profile)
		{
			return default;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x12754B8", Offset = "0x12754B8", VA = "0x12754B8", Slot = "8")]
		public void RegisterProfile(CredentialProfile profile)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x12757E0", Offset = "0x12757E0", VA = "0x12757E0")]
		private void RegisterProfileInternal(CredentialProfile profile)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1275D54", Offset = "0x1275D54", VA = "0x1275D54", Slot = "9")]
		public void UnregisterProfile(string profileName)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1275D9C", Offset = "0x1275D9C", VA = "0x1275D9C", Slot = "4")]
		public void RenameProfile(string oldProfileName, string newProfileName)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1275DF8", Offset = "0x1275DF8", VA = "0x1275DF8", Slot = "5")]
		public void RenameProfile(string oldProfileName, string newProfileName, bool force)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1275E58", Offset = "0x1275E58", VA = "0x1275E58", Slot = "6")]
		public void CopyProfile(string fromProfileName, string toProfileName)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1275E60", Offset = "0x1275E60", VA = "0x1275E60", Slot = "7")]
		public void CopyProfile(string fromProfileName, string toProfileName, bool force)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1274234", Offset = "0x1274234", VA = "0x1274234")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1274818", Offset = "0x1274818", VA = "0x1274818")]
		private HashSet<string> ListAllProfileNames()
		{
			return null;
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x12748A4", Offset = "0x12748A4", VA = "0x12748A4")]
		private bool TryGetProfile(string profileName, bool doRefresh, out CredentialProfile profile)
		{
			return default;
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1275FC0", Offset = "0x1275FC0", VA = "0x1275FC0")]
		private bool TryGetSection(string sectionName, out Dictionary<string, string> iniProperties)
		{
			return default;
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1275704", Offset = "0x1275704", VA = "0x1275704")]
		private static bool IsSupportedProfileType(CredentialProfileType? profileType)
		{
			return default;
		}
	}
}
