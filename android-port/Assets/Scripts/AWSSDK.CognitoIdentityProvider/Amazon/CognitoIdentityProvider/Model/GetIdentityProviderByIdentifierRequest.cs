using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BD")]
	public class GetIdentityProviderByIdentifierRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x30")]
		private string _idpIdentifier;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700015E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E4F4", Offset = "0x1E4F4")]
		public string IdpIdentifier
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x111C480", Offset = "0x111C480", VA = "0x111C480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x111C488", Offset = "0x111C488", VA = "0x111C488")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E544", Offset = "0x1E544")]
		public string UserPoolId
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x111C4A0", Offset = "0x111C4A0", VA = "0x111C4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x111C4A8", Offset = "0x111C4A8", VA = "0x111C4A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x111C490", Offset = "0x111C490", VA = "0x111C490")]
		internal bool IsSetIdpIdentifier()
		{
			return default;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x111C4B0", Offset = "0x111C4B0", VA = "0x111C4B0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x111C4C0", Offset = "0x111C4C0", VA = "0x111C4C0")]
		public GetIdentityProviderByIdentifierRequest()
		{
		}
	}
}
