using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000109")]
	public class SetRiskConfigurationRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x30")]
		private AccountTakeoverRiskConfigurationType _accountTakeoverRiskConfiguration;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x40")]
		private CompromisedCredentialsRiskConfigurationType _compromisedCredentialsRiskConfiguration;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x48")]
		private RiskExceptionConfigurationType _riskExceptionConfiguration;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x17000213")]
		public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x114B748", Offset = "0x114B748", VA = "0x114B748")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x114B750", Offset = "0x114B750", VA = "0x114B750")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20220", Offset = "0x20220")]
		public string ClientId
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x114B768", Offset = "0x114B768", VA = "0x114B768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x114B770", Offset = "0x114B770", VA = "0x114B770")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x114B788", Offset = "0x114B788", VA = "0x114B788")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x114B790", Offset = "0x114B790", VA = "0x114B790")]
			set
			{
			}
		}

		[Token(Token = "0x17000216")]
		public RiskExceptionConfigurationType RiskExceptionConfiguration
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x114B7A8", Offset = "0x114B7A8", VA = "0x114B7A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x114B7B0", Offset = "0x114B7B0", VA = "0x114B7B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000217")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20268", Offset = "0x20268")]
		public string UserPoolId
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x114B7C8", Offset = "0x114B7C8", VA = "0x114B7C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x114B7D0", Offset = "0x114B7D0", VA = "0x114B7D0")]
			set
			{
			}
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x114B758", Offset = "0x114B758", VA = "0x114B758")]
		internal bool IsSetAccountTakeoverRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x114B778", Offset = "0x114B778", VA = "0x114B778")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x114B798", Offset = "0x114B798", VA = "0x114B798")]
		internal bool IsSetCompromisedCredentialsRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x114B7B8", Offset = "0x114B7B8", VA = "0x114B7B8")]
		internal bool IsSetRiskExceptionConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x114B7D8", Offset = "0x114B7D8", VA = "0x114B7D8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x114B7E8", Offset = "0x114B7E8", VA = "0x114B7E8")]
		public SetRiskConfigurationRequest()
		{
		}
	}
}
