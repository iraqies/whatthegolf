using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000028")]
	public class ListDatasetsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x40")]
		private int? _maxResults;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x48")]
		private string _nextToken;

		[Token(Token = "0x17000033")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24984", Offset = "0x24984")]
		public string IdentityId
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x119E21C", Offset = "0x119E21C", VA = "0x119E21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x119E224", Offset = "0x119E224", VA = "0x119E224")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x249D4", Offset = "0x249D4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x119E23C", Offset = "0x119E23C", VA = "0x119E23C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x119E244", Offset = "0x119E244", VA = "0x119E244")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int MaxResults
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x119E25C", Offset = "0x119E25C", VA = "0x119E25C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x119E29C", Offset = "0x119E29C", VA = "0x119E29C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public string NextToken
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x119E350", Offset = "0x119E350", VA = "0x119E350")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x119E358", Offset = "0x119E358", VA = "0x119E358")]
			set
			{
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x119E22C", Offset = "0x119E22C", VA = "0x119E22C")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x119E24C", Offset = "0x119E24C", VA = "0x119E24C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x119E310", Offset = "0x119E310", VA = "0x119E310")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x119E360", Offset = "0x119E360", VA = "0x119E360")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x119E370", Offset = "0x119E370", VA = "0x119E370")]
		public ListDatasetsRequest()
		{
		}
	}
}
