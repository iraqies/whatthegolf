using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000039")]
	public class ListIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x29")]
		private bool? _hideDisabled;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x38")]
		private int? _maxResults;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x40")]
		private string _nextToken;

		[Token(Token = "0x17000061")]
		public bool HideDisabled
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x108D91C", Offset = "0x108D91C", VA = "0x108D91C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x108D95C", Offset = "0x108D95C", VA = "0x108D95C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x230CC", Offset = "0x230CC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x108DA10", Offset = "0x108DA10", VA = "0x108DA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x108DA18", Offset = "0x108DA18", VA = "0x108DA18")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2311C", Offset = "0x2311C")]
		public int MaxResults
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x108DA30", Offset = "0x108DA30", VA = "0x108DA30")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x108DA70", Offset = "0x108DA70", VA = "0x108DA70")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2316C", Offset = "0x2316C")]
		public string NextToken
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x108DB24", Offset = "0x108DB24", VA = "0x108DB24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x108DB2C", Offset = "0x108DB2C", VA = "0x108DB2C")]
			set
			{
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x108D9D0", Offset = "0x108D9D0", VA = "0x108D9D0")]
		internal bool IsSetHideDisabled()
		{
			return default;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x108DA20", Offset = "0x108DA20", VA = "0x108DA20")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x108DAE4", Offset = "0x108DAE4", VA = "0x108DAE4")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x108DB34", Offset = "0x108DB34", VA = "0x108DB34")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x108DB44", Offset = "0x108DB44", VA = "0x108DB44")]
		public ListIdentitiesRequest()
		{
		}
	}
}
