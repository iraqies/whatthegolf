using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000022")]
	public class GetAccessKeyInfoResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x28")]
		private string _account;

		[Token(Token = "0x17000040")]
		public string Account
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x12DF048", Offset = "0x12DF048", VA = "0x12DF048")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x12DF050", Offset = "0x12DF050", VA = "0x12DF050")]
			set
			{
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x12DF058", Offset = "0x12DF058", VA = "0x12DF058")]
		internal bool IsSetAccount()
		{
			return default;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x12DF068", Offset = "0x12DF068", VA = "0x12DF068")]
		public GetAccessKeyInfoResponse()
		{
		}
	}
}
