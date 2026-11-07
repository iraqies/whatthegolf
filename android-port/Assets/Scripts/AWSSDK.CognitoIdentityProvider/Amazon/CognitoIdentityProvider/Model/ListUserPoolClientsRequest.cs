using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E8")]
	public class ListUserPoolClientsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170001B5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F490", Offset = "0x1F490")]
		public int MaxResults
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x11363A4", Offset = "0x11363A4", VA = "0x11363A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x11363E4", Offset = "0x11363E4", VA = "0x11363E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F4D8", Offset = "0x1F4D8")]
		public string NextToken
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1136498", Offset = "0x1136498", VA = "0x1136498")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x11364A0", Offset = "0x11364A0", VA = "0x11364A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F510", Offset = "0x1F510")]
		public string UserPoolId
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x11364B8", Offset = "0x11364B8", VA = "0x11364B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x11364C0", Offset = "0x11364C0", VA = "0x11364C0")]
			set
			{
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1136458", Offset = "0x1136458", VA = "0x1136458")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x11364A8", Offset = "0x11364A8", VA = "0x11364A8")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x11364C8", Offset = "0x11364C8", VA = "0x11364C8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x11364D8", Offset = "0x11364D8", VA = "0x11364D8")]
		public ListUserPoolClientsRequest()
		{
		}
	}
}
