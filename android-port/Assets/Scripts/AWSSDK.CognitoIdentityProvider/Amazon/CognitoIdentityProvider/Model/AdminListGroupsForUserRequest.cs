using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004B")]
	public class AdminListGroupsForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x2C")]
		private int? _limit;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000053")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B970", Offset = "0x1B970")]
		public int Limit
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x10B2B4C", Offset = "0x10B2B4C", VA = "0x10B2B4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x10B2B8C", Offset = "0x10B2B8C", VA = "0x10B2B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B9B8", Offset = "0x1B9B8")]
		public string NextToken
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x10B2C40", Offset = "0x10B2C40", VA = "0x10B2C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x10B2C48", Offset = "0x10B2C48", VA = "0x10B2C48")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B9F0", Offset = "0x1B9F0")]
		public string Username
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x10B2C60", Offset = "0x10B2C60", VA = "0x10B2C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x10B2C68", Offset = "0x10B2C68", VA = "0x10B2C68")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BA40", Offset = "0x1BA40")]
		public string UserPoolId
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x10B2C80", Offset = "0x10B2C80", VA = "0x10B2C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x10B2C88", Offset = "0x10B2C88", VA = "0x10B2C88")]
			set
			{
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x10B2C00", Offset = "0x10B2C00", VA = "0x10B2C00")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x10B2C50", Offset = "0x10B2C50", VA = "0x10B2C50")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x10B2C70", Offset = "0x10B2C70", VA = "0x10B2C70")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x10B2C90", Offset = "0x10B2C90", VA = "0x10B2C90")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x10B2CA0", Offset = "0x10B2CA0", VA = "0x10B2CA0")]
		public AdminListGroupsForUserRequest()
		{
		}
	}
}
