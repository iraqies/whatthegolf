using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000005")]
	public class AmazonSecurityTokenServiceConfig : ClientConfig
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0xE8")]
		private StsRegionalEndpointsValue? _stsRegionalEndpoints;

		[Token(Token = "0x400000D")]
		private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";

		[Token(Token = "0x400000E")]
		private const string DefaultProfileName = "default";

		[Token(Token = "0x400000F")]
		private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

		[Token(Token = "0x4000010")]
		private const string StsDefaultHostname = "https://sts.amazonaws.com";

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialProfileStoreChain credentialProfileChain;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0xF0")]
		private readonly ISet<RegionEndpoint> legacyGlobalRegions;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string UserAgentString;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0xF8")]
		private string _userAgent;

		[Token(Token = "0x17000002")]
		public StsRegionalEndpointsValue StsRegionalEndpoints
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x12D47A0", Offset = "0x12D47A0", VA = "0x12D47A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x12D4AAC", Offset = "0x12D4AAC", VA = "0x12D4AAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public override string RegionEndpointServiceName
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x12D4E08", Offset = "0x12D4E08", VA = "0x12D4E08", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public override string ServiceVersion
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x12D4E4C", Offset = "0x12D4E4C", VA = "0x12D4E4C", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public override string UserAgent
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x12D4E90", Offset = "0x12D4E90", VA = "0x12D4E90", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x12D4B20", Offset = "0x12D4B20", VA = "0x12D4B20", Slot = "47")]
		public override string DetermineServiceURL()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x12D4CCC", Offset = "0x12D4CCC", VA = "0x12D4CCC")]
		internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x12D4888", Offset = "0x12D4888", VA = "0x12D4888")]
		private static StsRegionalEndpointsValue? CheckSTSEnvironmentVariable()
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x12D49C4", Offset = "0x12D49C4", VA = "0x12D49C4")]
		private static StsRegionalEndpointsValue? CheckCredentialsFile()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x12D2390", Offset = "0x12D2390", VA = "0x12D2390")]
		public AmazonSecurityTokenServiceConfig()
		{
		}
	}
}
