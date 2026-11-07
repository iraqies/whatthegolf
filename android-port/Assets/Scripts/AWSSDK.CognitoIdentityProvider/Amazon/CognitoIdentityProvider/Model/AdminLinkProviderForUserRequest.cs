using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000047")]
	public class AdminLinkProviderForUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x30")]
		private ProviderUserIdentifierType _destinationUser;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x38")]
		private ProviderUserIdentifierType _sourceUser;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x1700004A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B77C", Offset = "0x1B77C")]
		public ProviderUserIdentifierType DestinationUser
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x10AF97C", Offset = "0x10AF97C", VA = "0x10AF97C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x10AF984", Offset = "0x10AF984", VA = "0x10AF984")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B7B0", Offset = "0x1B7B0")]
		public ProviderUserIdentifierType SourceUser
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x10AF99C", Offset = "0x10AF99C", VA = "0x10AF99C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x10AF9A4", Offset = "0x10AF9A4", VA = "0x10AF9A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B7E4", Offset = "0x1B7E4")]
		public string UserPoolId
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x10AF9BC", Offset = "0x10AF9BC", VA = "0x10AF9BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x10AF9C4", Offset = "0x10AF9C4", VA = "0x10AF9C4")]
			set
			{
			}
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x10AF98C", Offset = "0x10AF98C", VA = "0x10AF98C")]
		internal bool IsSetDestinationUser()
		{
			return default;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x10AF9AC", Offset = "0x10AF9AC", VA = "0x10AF9AC")]
		internal bool IsSetSourceUser()
		{
			return default;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x10AF9CC", Offset = "0x10AF9CC", VA = "0x10AF9CC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x10AF9DC", Offset = "0x10AF9DC", VA = "0x10AF9DC")]
		public AdminLinkProviderForUserRequest()
		{
		}
	}
}
