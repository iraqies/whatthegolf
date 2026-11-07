using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000137")]
	public class NetSDKCredentialsFile : ICredentialProfileStore, ICredentialProfileSource
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C14", Offset = "0x25C14")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40004A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40004AA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<CredentialProfile, string> _003C_003E9__14_0;

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x128FCD4", Offset = "0x128FCD4", VA = "0x128FCD4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x128FCDC", Offset = "0x128FCDC", VA = "0x128FCDC")]
			internal string _003CListProfileNames_003Eb__14_0(CredentialProfile p)
			{
				return null;
			}
		}

		[Token(Token = "0x400049C")]
		public const string DefaultProfileName = "Default";

		[Token(Token = "0x400049D")]
		private const string AWSCredentialsProfileType = "AWS";

		[Token(Token = "0x400049E")]
		private const string SAMLRoleProfileType = "SAML";

		[Token(Token = "0x400049F")]
		private const string RegionField = "Region";

		[Token(Token = "0x40004A0")]
		private const string EndpointDiscoveryEnabledField = "EndpointDiscoveryEnabled";

		[Token(Token = "0x40004A1")]
		private const string S3UseArnRegionField = "S3UseArnRegion";

		[Token(Token = "0x40004A2")]
		private const string StsRegionalEndpointsField = "StsRegionalEndpoints";

		[Token(Token = "0x40004A3")]
		private const string S3RegionalEndpointField = "S3RegionalEndpoint";

		[Token(Token = "0x40004A4")]
		private const string RetryModeField = "RetryMode";

		[Token(Token = "0x40004A5")]
		private const string MaxAttemptsField = "MaxAttempts";

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> ReservedPropertyNames;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly CredentialProfilePropertyMapping PropertyMapping;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x10")]
		private readonly NamedSettingsManager _settingsManager;

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1240BFC", Offset = "0x1240BFC", VA = "0x1240BFC")]
		public NetSDKCredentialsFile()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1240CD4", Offset = "0x1240CD4", VA = "0x1240CD4", Slot = "10")]
		public List<string> ListProfileNames()
		{
			return null;
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1240E40", Offset = "0x1240E40", VA = "0x1240E40", Slot = "11")]
		public List<CredentialProfile> ListProfiles()
		{
			return null;
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1241078", Offset = "0x1241078", VA = "0x1241078", Slot = "12")]
		public bool TryGetProfile(string profileName, out CredentialProfile profile)
		{
			return default;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x12419F0", Offset = "0x12419F0", VA = "0x12419F0", Slot = "8")]
		public void RegisterProfile(CredentialProfile profile)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1242214", Offset = "0x1242214", VA = "0x1242214", Slot = "9")]
		public void UnregisterProfile(string profileName)
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x124222C", Offset = "0x124222C", VA = "0x124222C", Slot = "4")]
		public void RenameProfile(string oldProfileName, string newProfileName)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1242248", Offset = "0x1242248", VA = "0x1242248", Slot = "5")]
		public void RenameProfile(string oldProfileName, string newProfileName, bool force)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1242260", Offset = "0x1242260", VA = "0x1242260", Slot = "6")]
		public void CopyProfile(string fromProfileName, string toProfileName)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x124227C", Offset = "0x124227C", VA = "0x124227C", Slot = "7")]
		public void CopyProfile(string fromProfileName, string toProfileName, bool force)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1241FAC", Offset = "0x1241FAC", VA = "0x1241FAC")]
		private static void SetProfileTypeField(IDictionary<string, string> properties, CredentialProfileType profileType)
		{
		}
	}
}
