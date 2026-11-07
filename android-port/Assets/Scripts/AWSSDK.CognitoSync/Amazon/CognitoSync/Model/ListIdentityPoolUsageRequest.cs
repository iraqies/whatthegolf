using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002A")]
	public class ListIdentityPoolUsageRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x1700003A")]
		public int MaxResults
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x119FB6C", Offset = "0x119FB6C", VA = "0x119FB6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x119FBAC", Offset = "0x119FBAC", VA = "0x119FBAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public string NextToken
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x119FC60", Offset = "0x119FC60", VA = "0x119FC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x119FC68", Offset = "0x119FC68", VA = "0x119FC68")]
			set
			{
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x119FC20", Offset = "0x119FC20", VA = "0x119FC20")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x119FC70", Offset = "0x119FC70", VA = "0x119FC70")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x119FC80", Offset = "0x119FC80", VA = "0x119FC80")]
		public ListIdentityPoolUsageRequest()
		{
		}
	}
}
