using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003F")]
	public class LookupDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		private string _developerUserIdentifier;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x48")]
		private int? _maxResults;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x50")]
		private string _nextToken;

		[Token(Token = "0x1700006E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23334", Offset = "0x23334")]
		public string DeveloperUserIdentifier
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x109231C", Offset = "0x109231C", VA = "0x109231C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1092324", Offset = "0x1092324", VA = "0x1092324")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2337C", Offset = "0x2337C")]
		public string IdentityId
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x109233C", Offset = "0x109233C", VA = "0x109233C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1092344", Offset = "0x1092344", VA = "0x1092344")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x233C4", Offset = "0x233C4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x109235C", Offset = "0x109235C", VA = "0x109235C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1092364", Offset = "0x1092364", VA = "0x1092364")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23414", Offset = "0x23414")]
		public int MaxResults
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x109237C", Offset = "0x109237C", VA = "0x109237C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x10923BC", Offset = "0x10923BC", VA = "0x10923BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2345C", Offset = "0x2345C")]
		public string NextToken
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1092470", Offset = "0x1092470", VA = "0x1092470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1092478", Offset = "0x1092478", VA = "0x1092478")]
			set
			{
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x109232C", Offset = "0x109232C", VA = "0x109232C")]
		internal bool IsSetDeveloperUserIdentifier()
		{
			return default;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x109234C", Offset = "0x109234C", VA = "0x109234C")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x109236C", Offset = "0x109236C", VA = "0x109236C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1092430", Offset = "0x1092430", VA = "0x1092430")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1092480", Offset = "0x1092480", VA = "0x1092480")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1092490", Offset = "0x1092490", VA = "0x1092490")]
		public LookupDeveloperIdentityRequest()
		{
		}
	}
}
