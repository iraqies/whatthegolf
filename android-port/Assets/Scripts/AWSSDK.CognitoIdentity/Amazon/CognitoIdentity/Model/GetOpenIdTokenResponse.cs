using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000032")]
	public class GetOpenIdTokenResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x28")]
		private string _identityId;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		private string _token;

		[Token(Token = "0x17000059")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22FAC", Offset = "0x22FAC")]
		public string IdentityId
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x108B9E4", Offset = "0x108B9E4", VA = "0x108B9E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x108B9EC", Offset = "0x108B9EC", VA = "0x108B9EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public string Token
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x108BA04", Offset = "0x108BA04", VA = "0x108BA04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x108BA0C", Offset = "0x108BA0C", VA = "0x108BA0C")]
			set
			{
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x108B9F4", Offset = "0x108B9F4", VA = "0x108B9F4")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x108BA14", Offset = "0x108BA14", VA = "0x108BA14")]
		internal bool IsSetToken()
		{
			return default;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x108BA24", Offset = "0x108BA24", VA = "0x108BA24")]
		public GetOpenIdTokenResponse()
		{
		}
	}
}
