using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000DE")]
	public class ListGroupsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x2C")]
		private int? _limit;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x1700019F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EF4C", Offset = "0x1EF4C")]
		public int Limit
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x112E980", Offset = "0x112E980", VA = "0x112E980")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x112E9C0", Offset = "0x112E9C0", VA = "0x112E9C0")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EF94", Offset = "0x1EF94")]
		public string NextToken
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x112EA74", Offset = "0x112EA74", VA = "0x112EA74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x112EA7C", Offset = "0x112EA7C", VA = "0x112EA7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EFCC", Offset = "0x1EFCC")]
		public string UserPoolId
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x112EA94", Offset = "0x112EA94", VA = "0x112EA94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x112EA9C", Offset = "0x112EA9C", VA = "0x112EA9C")]
			set
			{
			}
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x112EA34", Offset = "0x112EA34", VA = "0x112EA34")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x112EA84", Offset = "0x112EA84", VA = "0x112EA84")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x112EAA4", Offset = "0x112EAA4", VA = "0x112EAA4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x112EAB4", Offset = "0x112EAB4", VA = "0x112EAB4")]
		public ListGroupsRequest()
		{
		}
	}
}
