using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003B")]
	public class ListIdentityPoolsRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x17000068")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23224", Offset = "0x23224")]
		public int MaxResults
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x108F488", Offset = "0x108F488", VA = "0x108F488")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x108F4C8", Offset = "0x108F4C8", VA = "0x108F4C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23274", Offset = "0x23274")]
		public string NextToken
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x108F57C", Offset = "0x108F57C", VA = "0x108F57C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x108F584", Offset = "0x108F584", VA = "0x108F584")]
			set
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x108F53C", Offset = "0x108F53C", VA = "0x108F53C")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x108F58C", Offset = "0x108F58C", VA = "0x108F58C")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x108F59C", Offset = "0x108F59C", VA = "0x108F59C")]
		public ListIdentityPoolsRequest()
		{
		}
	}
}
