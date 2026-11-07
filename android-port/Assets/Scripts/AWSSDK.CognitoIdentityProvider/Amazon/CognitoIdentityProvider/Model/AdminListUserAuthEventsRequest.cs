using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004D")]
	public class AdminListUserAuthEventsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000059")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BAC8", Offset = "0x1BAC8")]
		public int MaxResults
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x10B45A8", Offset = "0x10B45A8", VA = "0x10B45A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x10B45E8", Offset = "0x10B45E8", VA = "0x10B45E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BB10", Offset = "0x1BB10")]
		public string NextToken
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x10B469C", Offset = "0x10B469C", VA = "0x10B469C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x10B46A4", Offset = "0x10B46A4", VA = "0x10B46A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BB48", Offset = "0x1BB48")]
		public string Username
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x10B46BC", Offset = "0x10B46BC", VA = "0x10B46BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x10B46C4", Offset = "0x10B46C4", VA = "0x10B46C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BB98", Offset = "0x1BB98")]
		public string UserPoolId
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x10B46DC", Offset = "0x10B46DC", VA = "0x10B46DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x10B46E4", Offset = "0x10B46E4", VA = "0x10B46E4")]
			set
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x10B465C", Offset = "0x10B465C", VA = "0x10B465C")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x10B46AC", Offset = "0x10B46AC", VA = "0x10B46AC")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x10B46CC", Offset = "0x10B46CC", VA = "0x10B46CC")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x10B46EC", Offset = "0x10B46EC", VA = "0x10B46EC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x10B46FC", Offset = "0x10B46FC", VA = "0x10B46FC")]
		public AdminListUserAuthEventsRequest()
		{
		}
	}
}
