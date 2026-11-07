using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000EA")]
	public class ListUserPoolsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x170001BA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F598", Offset = "0x1F598")]
		public int MaxResults
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1137E68", Offset = "0x1137E68", VA = "0x1137E68")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1137EA8", Offset = "0x1137EA8", VA = "0x1137EA8")]
			set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F5E8", Offset = "0x1F5E8")]
		public string NextToken
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1137F5C", Offset = "0x1137F5C", VA = "0x1137F5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1137F64", Offset = "0x1137F64", VA = "0x1137F64")]
			set
			{
			}
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1137F1C", Offset = "0x1137F1C", VA = "0x1137F1C")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1137F6C", Offset = "0x1137F6C", VA = "0x1137F6C")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1137F7C", Offset = "0x1137F7C", VA = "0x1137F7C")]
		public ListUserPoolsRequest()
		{
		}
	}
}
