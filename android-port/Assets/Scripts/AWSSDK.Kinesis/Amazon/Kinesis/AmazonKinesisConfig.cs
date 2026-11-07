using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000002")]
	public class AmazonKinesisConfig : ClientConfig
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
			[Address(RVA = "0x12A18E0", Offset = "0x12A18E0", VA = "0x12A18E0", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public override string ServiceVersion
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x12A1924", Offset = "0x12A1924", VA = "0x12A1924", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public override string UserAgent
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x12A1968", Offset = "0x12A1968", VA = "0x12A1968", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x129B774", Offset = "0x129B774", VA = "0x129B774")]
		public AmazonKinesisConfig()
		{
		}
	}
}
