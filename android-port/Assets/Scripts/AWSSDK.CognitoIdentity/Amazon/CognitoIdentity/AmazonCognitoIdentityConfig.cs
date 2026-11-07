using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000010")]
	public class AmazonCognitoIdentityConfig : ClientConfig
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string UserAgentString;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xE8")]
		private string _userAgent;

		[Token(Token = "0x17000011")]
		public override string RegionEndpointServiceName
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1075C50", Offset = "0x1075C50", VA = "0x1075C50", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public override string ServiceVersion
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1075C94", Offset = "0x1075C94", VA = "0x1075C94", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public override string UserAgent
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1075CD8", Offset = "0x1075CD8", VA = "0x1075CD8", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1070B08", Offset = "0x1070B08", VA = "0x1070B08")]
		public AmazonCognitoIdentityConfig()
		{
		}
	}
}
