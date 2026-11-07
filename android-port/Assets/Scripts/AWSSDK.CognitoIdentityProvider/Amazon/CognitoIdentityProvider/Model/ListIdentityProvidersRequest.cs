using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E0")]
	public class ListIdentityProvidersRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170001A4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F054", Offset = "0x1F054")]
		public int MaxResults
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x113027C", Offset = "0x113027C", VA = "0x113027C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x11302BC", Offset = "0x11302BC", VA = "0x11302BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F09C", Offset = "0x1F09C")]
		public string NextToken
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1130370", Offset = "0x1130370", VA = "0x1130370")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1130378", Offset = "0x1130378", VA = "0x1130378")]
			set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F0D4", Offset = "0x1F0D4")]
		public string UserPoolId
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1130390", Offset = "0x1130390", VA = "0x1130390")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1130398", Offset = "0x1130398", VA = "0x1130398")]
			set
			{
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1130330", Offset = "0x1130330", VA = "0x1130330")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1130380", Offset = "0x1130380", VA = "0x1130380")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x11303A0", Offset = "0x11303A0", VA = "0x11303A0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x11303B0", Offset = "0x11303B0", VA = "0x11303B0")]
		public ListIdentityProvidersRequest()
		{
		}
	}
}
