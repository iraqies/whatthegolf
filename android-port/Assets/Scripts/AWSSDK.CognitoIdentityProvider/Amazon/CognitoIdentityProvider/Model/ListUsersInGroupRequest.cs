using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000EC")]
	public class ListUsersInGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x30")]
		private string _groupName;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x38")]
		private int? _limit;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x40")]
		private string _nextToken;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x170001BE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F658", Offset = "0x1F658")]
		public string GroupName
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1139610", Offset = "0x1139610", VA = "0x1139610")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1139618", Offset = "0x1139618", VA = "0x1139618")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F6A8", Offset = "0x1F6A8")]
		public int Limit
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1139630", Offset = "0x1139630", VA = "0x1139630")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1139670", Offset = "0x1139670", VA = "0x1139670")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F6F0", Offset = "0x1F6F0")]
		public string NextToken
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1139724", Offset = "0x1139724", VA = "0x1139724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x113972C", Offset = "0x113972C", VA = "0x113972C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F728", Offset = "0x1F728")]
		public string UserPoolId
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x1139744", Offset = "0x1139744", VA = "0x1139744")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x113974C", Offset = "0x113974C", VA = "0x113974C")]
			set
			{
			}
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1139620", Offset = "0x1139620", VA = "0x1139620")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x11396E4", Offset = "0x11396E4", VA = "0x11396E4")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1139734", Offset = "0x1139734", VA = "0x1139734")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1139754", Offset = "0x1139754", VA = "0x1139754")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1139764", Offset = "0x1139764", VA = "0x1139764")]
		public ListUsersInGroupRequest()
		{
		}
	}
}
