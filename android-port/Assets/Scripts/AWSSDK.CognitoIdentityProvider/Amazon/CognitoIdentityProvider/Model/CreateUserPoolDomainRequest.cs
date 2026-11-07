using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000085")]
	public class CreateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x30")]
		private CustomDomainConfigType _customDomainConfig;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x38")]
		private string _domain;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170000EF")]
		public CustomDomainConfigType CustomDomainConfig
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x10F51C4", Offset = "0x10F51C4", VA = "0x10F51C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x10F51CC", Offset = "0x10F51CC", VA = "0x10F51CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D450", Offset = "0x1D450")]
		public string Domain
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x10F51E4", Offset = "0x10F51E4", VA = "0x10F51E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x10F51EC", Offset = "0x10F51EC", VA = "0x10F51EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D4A0", Offset = "0x1D4A0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x10F5204", Offset = "0x10F5204", VA = "0x10F5204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x10F520C", Offset = "0x10F520C", VA = "0x10F520C")]
			set
			{
			}
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x10F51D4", Offset = "0x10F51D4", VA = "0x10F51D4")]
		internal bool IsSetCustomDomainConfig()
		{
			return default;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x10F51F4", Offset = "0x10F51F4", VA = "0x10F51F4")]
		internal bool IsSetDomain()
		{
			return default;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x10F5214", Offset = "0x10F5214", VA = "0x10F5214")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x10F5224", Offset = "0x10F5224", VA = "0x10F5224")]
		public CreateUserPoolDomainRequest()
		{
		}
	}
}
