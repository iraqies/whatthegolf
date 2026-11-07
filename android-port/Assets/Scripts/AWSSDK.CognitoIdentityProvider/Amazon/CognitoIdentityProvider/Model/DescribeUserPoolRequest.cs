using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A6")]
	public class DescribeUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x17000129")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DF50", Offset = "0x1DF50")]
		public string UserPoolId
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x110D150", Offset = "0x110D150", VA = "0x110D150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x110D158", Offset = "0x110D158", VA = "0x110D158")]
			set
			{
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x110D160", Offset = "0x110D160", VA = "0x110D160")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x110D170", Offset = "0x110D170", VA = "0x110D170")]
		public DescribeUserPoolRequest()
		{
		}
	}
}
