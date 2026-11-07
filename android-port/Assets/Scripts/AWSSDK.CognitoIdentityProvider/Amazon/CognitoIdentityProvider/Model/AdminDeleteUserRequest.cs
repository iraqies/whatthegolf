using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000037")]
	public class AdminDeleteUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		private string _username;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000025")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B114", Offset = "0x1B114")]
		public string Username
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x10A2B24", Offset = "0x10A2B24", VA = "0x10A2B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x10A2B2C", Offset = "0x10A2B2C", VA = "0x10A2B2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B164", Offset = "0x1B164")]
		public string UserPoolId
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x10A2B44", Offset = "0x10A2B44", VA = "0x10A2B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x10A2B4C", Offset = "0x10A2B4C", VA = "0x10A2B4C")]
			set
			{
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x10A2B34", Offset = "0x10A2B34", VA = "0x10A2B34")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x10A2B54", Offset = "0x10A2B54", VA = "0x10A2B54")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10A2B64", Offset = "0x10A2B64", VA = "0x10A2B64")]
		public AdminDeleteUserRequest()
		{
		}
	}
}
