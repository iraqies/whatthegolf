using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001E")]
	public class DecodeAuthorizationMessageResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x28")]
		private string _decodedMessage;

		[Token(Token = "0x1700003C")]
		public string DecodedMessage
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x12DDAA4", Offset = "0x12DDAA4", VA = "0x12DDAA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x12DDAAC", Offset = "0x12DDAAC", VA = "0x12DDAAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x12DDAB4", Offset = "0x12DDAB4", VA = "0x12DDAB4")]
		internal bool IsSetDecodedMessage()
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12DDAC4", Offset = "0x12DDAC4", VA = "0x12DDAC4")]
		public DecodeAuthorizationMessageResponse()
		{
		}
	}
}
