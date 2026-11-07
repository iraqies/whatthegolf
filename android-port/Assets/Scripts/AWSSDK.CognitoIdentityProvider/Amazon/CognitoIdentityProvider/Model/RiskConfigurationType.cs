using System;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000105")]
	public class RiskConfigurationType
	{
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x10")]
		private AccountTakeoverRiskConfigurationType _accountTakeoverRiskConfiguration;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x18")]
		private string _clientId;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x20")]
		private CompromisedCredentialsRiskConfigurationType _compromisedCredentialsRiskConfiguration;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		private RiskExceptionConfigurationType _riskExceptionConfiguration;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000204")]
		public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x114886C", Offset = "0x114886C", VA = "0x114886C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1148874", Offset = "0x1148874", VA = "0x1148874")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x200D8", Offset = "0x200D8")]
		public string ClientId
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x114888C", Offset = "0x114888C", VA = "0x114888C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x1148894", Offset = "0x1148894", VA = "0x1148894")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x11488AC", Offset = "0x11488AC", VA = "0x11488AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x11488B4", Offset = "0x11488B4", VA = "0x11488B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x11488CC", Offset = "0x11488CC", VA = "0x11488CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x114890C", Offset = "0x114890C", VA = "0x114890C")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public RiskExceptionConfigurationType RiskExceptionConfiguration
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x11489C0", Offset = "0x11489C0", VA = "0x11489C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x11489C8", Offset = "0x11489C8", VA = "0x11489C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x20120", Offset = "0x20120")]
		public string UserPoolId
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x11489E0", Offset = "0x11489E0", VA = "0x11489E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x11489E8", Offset = "0x11489E8", VA = "0x11489E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x114887C", Offset = "0x114887C", VA = "0x114887C")]
		internal bool IsSetAccountTakeoverRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x114889C", Offset = "0x114889C", VA = "0x114889C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x11488BC", Offset = "0x11488BC", VA = "0x11488BC")]
		internal bool IsSetCompromisedCredentialsRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1148980", Offset = "0x1148980", VA = "0x1148980")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x11489D0", Offset = "0x11489D0", VA = "0x11489D0")]
		internal bool IsSetRiskExceptionConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x11489F0", Offset = "0x11489F0", VA = "0x11489F0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1148A00", Offset = "0x1148A00", VA = "0x1148A00")]
		public RiskConfigurationType()
		{
		}
	}
}
