using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200004E")]
	public class UnlinkDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x30")]
		private string _developerProviderName;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x38")]
		private string _developerUserIdentifier;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x40")]
		private string _identityId;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x48")]
		private string _identityPoolId;

		[Token(Token = "0x17000088")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23990", Offset = "0x23990")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1181B48", Offset = "0x1181B48", VA = "0x1181B48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1181B50", Offset = "0x1181B50", VA = "0x1181B50")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x239E0", Offset = "0x239E0")]
		public string DeveloperUserIdentifier
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1181B68", Offset = "0x1181B68", VA = "0x1181B68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1181B70", Offset = "0x1181B70", VA = "0x1181B70")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23A30", Offset = "0x23A30")]
		public string IdentityId
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1181B88", Offset = "0x1181B88", VA = "0x1181B88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1181B90", Offset = "0x1181B90", VA = "0x1181B90")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23A80", Offset = "0x23A80")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1181BA8", Offset = "0x1181BA8", VA = "0x1181BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1181BB0", Offset = "0x1181BB0", VA = "0x1181BB0")]
			set
			{
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1181B58", Offset = "0x1181B58", VA = "0x1181B58")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1181B78", Offset = "0x1181B78", VA = "0x1181B78")]
		internal bool IsSetDeveloperUserIdentifier()
		{
			return default;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1181B98", Offset = "0x1181B98", VA = "0x1181B98")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1181BB8", Offset = "0x1181BB8", VA = "0x1181BB8")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1181BC8", Offset = "0x1181BC8", VA = "0x1181BC8")]
		public UnlinkDeveloperIdentityRequest()
		{
		}
	}
}
