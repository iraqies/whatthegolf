using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000042")]
	public class MergeDeveloperIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x30")]
		private string _destinationUserIdentifier;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x38")]
		private string _developerProviderName;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x48")]
		private string _sourceUserIdentifier;

		[Token(Token = "0x1700007A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23638", Offset = "0x23638")]
		public string DestinationUserIdentifier
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1094AF0", Offset = "0x1094AF0", VA = "0x1094AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1094AF8", Offset = "0x1094AF8", VA = "0x1094AF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23688", Offset = "0x23688")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1094B10", Offset = "0x1094B10", VA = "0x1094B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1094B18", Offset = "0x1094B18", VA = "0x1094B18")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x236D8", Offset = "0x236D8")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1094B30", Offset = "0x1094B30", VA = "0x1094B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x1094B38", Offset = "0x1094B38", VA = "0x1094B38")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23728", Offset = "0x23728")]
		public string SourceUserIdentifier
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1094B50", Offset = "0x1094B50", VA = "0x1094B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x1094B58", Offset = "0x1094B58", VA = "0x1094B58")]
			set
			{
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1094B00", Offset = "0x1094B00", VA = "0x1094B00")]
		internal bool IsSetDestinationUserIdentifier()
		{
			return default;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1094B20", Offset = "0x1094B20", VA = "0x1094B20")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1094B40", Offset = "0x1094B40", VA = "0x1094B40")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1094B60", Offset = "0x1094B60", VA = "0x1094B60")]
		internal bool IsSetSourceUserIdentifier()
		{
			return default;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1094B70", Offset = "0x1094B70", VA = "0x1094B70")]
		public MergeDeveloperIdentitiesRequest()
		{
		}
	}
}
