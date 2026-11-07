using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A7")]
	public class DescribeUserPoolResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolType _userPool;

		[Token(Token = "0x1700012A")]
		public UserPoolType UserPool
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x110DBE0", Offset = "0x110DBE0", VA = "0x110DBE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x110DBE8", Offset = "0x110DBE8", VA = "0x110DBE8")]
			set
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x110DBF0", Offset = "0x110DBF0", VA = "0x110DBF0")]
		internal bool IsSetUserPool()
		{
			return default;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x110DC00", Offset = "0x110DC00", VA = "0x110DC00")]
		public DescribeUserPoolResponse()
		{
		}
	}
}
