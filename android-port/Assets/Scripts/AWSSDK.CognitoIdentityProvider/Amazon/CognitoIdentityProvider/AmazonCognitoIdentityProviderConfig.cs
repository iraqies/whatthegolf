using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000002")]
	public class AmazonCognitoIdentityProviderConfig : ClientConfig
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
			[Address(RVA = "0x10DC0B0", Offset = "0x10DC0B0", VA = "0x10DC0B0", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public override string ServiceVersion
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x10DC0F4", Offset = "0x10DC0F4", VA = "0x10DC0F4", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public override string UserAgent
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x10DC138", Offset = "0x10DC138", VA = "0x10DC138", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x10C780C", Offset = "0x10C780C", VA = "0x10C780C")]
		public AmazonCognitoIdentityProviderConfig()
		{
		}
	}
}
