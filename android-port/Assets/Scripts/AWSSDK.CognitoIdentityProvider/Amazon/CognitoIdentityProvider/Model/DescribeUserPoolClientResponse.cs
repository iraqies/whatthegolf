using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A3")]
	public class DescribeUserPoolClientResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolClientType _userPoolClient;

		[Token(Token = "0x17000126")]
		public UserPoolClientType UserPoolClient
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x110AD74", Offset = "0x110AD74", VA = "0x110AD74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x110AD7C", Offset = "0x110AD7C", VA = "0x110AD7C")]
			set
			{
			}
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x110AD84", Offset = "0x110AD84", VA = "0x110AD84")]
		internal bool IsSetUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x110AD94", Offset = "0x110AD94", VA = "0x110AD94")]
		public DescribeUserPoolClientResponse()
		{
		}
	}
}
