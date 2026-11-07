using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000061")]
	public class AdminUserGlobalSignOutRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x30")]
		private string _username;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000088")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C460", Offset = "0x1C460")]
		public string Username
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x10C59D0", Offset = "0x10C59D0", VA = "0x10C59D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x10C59D8", Offset = "0x10C59D8", VA = "0x10C59D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C4B0", Offset = "0x1C4B0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x10C59F0", Offset = "0x10C59F0", VA = "0x10C59F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x10C59F8", Offset = "0x10C59F8", VA = "0x10C59F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x10C59E0", Offset = "0x10C59E0", VA = "0x10C59E0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x10C5A00", Offset = "0x10C5A00", VA = "0x10C5A00")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x10C5A10", Offset = "0x10C5A10", VA = "0x10C5A10")]
		public AdminUserGlobalSignOutRequest()
		{
		}
	}
}
