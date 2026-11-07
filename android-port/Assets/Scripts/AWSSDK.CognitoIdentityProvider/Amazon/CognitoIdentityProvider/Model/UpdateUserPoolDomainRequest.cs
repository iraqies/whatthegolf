using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000138")]
	public class UpdateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x30")]
		private CustomDomainConfigType _customDomainConfig;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x38")]
		private string _domain;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000280")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21250", Offset = "0x21250")]
		public CustomDomainConfigType CustomDomainConfig
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x116DCB0", Offset = "0x116DCB0", VA = "0x116DCB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x116DCB8", Offset = "0x116DCB8", VA = "0x116DCB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000281")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21284", Offset = "0x21284")]
		public string Domain
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x116DCD0", Offset = "0x116DCD0", VA = "0x116DCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x116DCD8", Offset = "0x116DCD8", VA = "0x116DCD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000282")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x212D4", Offset = "0x212D4")]
		public string UserPoolId
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x116DCF0", Offset = "0x116DCF0", VA = "0x116DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x116DCF8", Offset = "0x116DCF8", VA = "0x116DCF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x116DCC0", Offset = "0x116DCC0", VA = "0x116DCC0")]
		internal bool IsSetCustomDomainConfig()
		{
			return default;
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x116DCE0", Offset = "0x116DCE0", VA = "0x116DCE0")]
		internal bool IsSetDomain()
		{
			return default;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x116DD00", Offset = "0x116DD00", VA = "0x116DD00")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x116DD10", Offset = "0x116DD10", VA = "0x116DD10")]
		public UpdateUserPoolDomainRequest()
		{
		}
	}
}
