using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000002")]
	public class AmazonCognitoSyncConfig : ClientConfig
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string UserAgentString;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0xE8")]
		private string _userAgent;

		[Token(Token = "0x17000001")]
		public override string RegionEndpointServiceName
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x11905A8", Offset = "0x11905A8", VA = "0x11905A8", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public override string ServiceVersion
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x11905EC", Offset = "0x11905EC", VA = "0x11905EC", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public override string UserAgent
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x1190630", Offset = "0x1190630", VA = "0x1190630", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x118C638", Offset = "0x118C638", VA = "0x118C638")]
		public AmazonCognitoSyncConfig()
		{
		}
	}
}
