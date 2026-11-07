using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000039")]
	public class AdminDisableProviderForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x30")]
		private ProviderUserIdentifierType _user;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000027")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B1B4", Offset = "0x1B1B4")]
		public ProviderUserIdentifierType User
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x10A3FA8", Offset = "0x10A3FA8", VA = "0x10A3FA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x10A3FB0", Offset = "0x10A3FB0", VA = "0x10A3FB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B1E8", Offset = "0x1B1E8")]
		public string UserPoolId
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x10A3FC8", Offset = "0x10A3FC8", VA = "0x10A3FC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x10A3FD0", Offset = "0x10A3FD0", VA = "0x10A3FD0")]
			set
			{
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10A3FB8", Offset = "0x10A3FB8", VA = "0x10A3FB8")]
		internal bool IsSetUser()
		{
			return default;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x10A3FD8", Offset = "0x10A3FD8", VA = "0x10A3FD8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10A3FE8", Offset = "0x10A3FE8", VA = "0x10A3FE8")]
		public AdminDisableProviderForUserRequest()
		{
		}
	}
}
