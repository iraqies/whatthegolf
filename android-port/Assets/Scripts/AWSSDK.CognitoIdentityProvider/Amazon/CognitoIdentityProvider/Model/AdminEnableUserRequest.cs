using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200003D")]
	public class AdminEnableUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x30")]
		private string _username;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700002B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B2BC", Offset = "0x1B2BC")]
		public string Username
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x10A69EC", Offset = "0x10A69EC", VA = "0x10A69EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x10A69F4", Offset = "0x10A69F4", VA = "0x10A69F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B30C", Offset = "0x1B30C")]
		public string UserPoolId
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x10A6A0C", Offset = "0x10A6A0C", VA = "0x10A6A0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x10A6A14", Offset = "0x10A6A14", VA = "0x10A6A14")]
			set
			{
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10A69FC", Offset = "0x10A69FC", VA = "0x10A69FC")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10A6A1C", Offset = "0x10A6A1C", VA = "0x10A6A1C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10A6A2C", Offset = "0x10A6A2C", VA = "0x10A6A2C")]
		public AdminEnableUserRequest()
		{
		}
	}
}
