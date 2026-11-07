using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000043")]
	public class AdminGetUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		private string _username;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000034")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B570", Offset = "0x1B570")]
		public string Username
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x10AAAB0", Offset = "0x10AAAB0", VA = "0x10AAAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x10AAAB8", Offset = "0x10AAAB8", VA = "0x10AAAB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B5C0", Offset = "0x1B5C0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x10AAAD0", Offset = "0x10AAAD0", VA = "0x10AAAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x10AAAD8", Offset = "0x10AAAD8", VA = "0x10AAAD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x10AAAC0", Offset = "0x10AAAC0", VA = "0x10AAAC0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x10AAAE0", Offset = "0x10AAAE0", VA = "0x10AAAE0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x10AAAF0", Offset = "0x10AAAF0", VA = "0x10AAAF0")]
		public AdminGetUserRequest()
		{
		}
	}
}
