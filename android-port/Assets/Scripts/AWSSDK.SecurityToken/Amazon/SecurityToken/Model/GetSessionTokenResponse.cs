using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000028")]
	public class GetSessionTokenResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		private Credentials _credentials;

		[Token(Token = "0x1700004F")]
		public Credentials Credentials
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x12E313C", Offset = "0x12E313C", VA = "0x12E313C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x12E3144", Offset = "0x12E3144", VA = "0x12E3144")]
			set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12E314C", Offset = "0x12E314C", VA = "0x12E314C")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x12E315C", Offset = "0x12E315C", VA = "0x12E315C")]
		public GetSessionTokenResponse()
		{
		}
	}
}
