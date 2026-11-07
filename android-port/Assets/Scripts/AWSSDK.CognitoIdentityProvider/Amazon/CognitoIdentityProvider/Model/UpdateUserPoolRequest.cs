using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200013A")]
	public class UpdateUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x30")]
		private AccountRecoverySettingType _accountRecoverySetting;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x38")]
		private AdminCreateUserConfigType _adminCreateUserConfig;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _autoVerifiedAttributes;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x48")]
		private DeviceConfigurationType _deviceConfiguration;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x50")]
		private EmailConfigurationType _emailConfiguration;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x58")]
		private string _emailVerificationMessage;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x60")]
		private string _emailVerificationSubject;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x68")]
		private LambdaConfigType _lambdaConfig;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x70")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x78")]
		private UserPoolPolicyType _policies;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x80")]
		private string _smsAuthenticationMessage;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x88")]
		private SmsConfigurationType _smsConfiguration;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x90")]
		private string _smsVerificationMessage;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x98")]
		private UserPoolAddOnsType _userPoolAddOns;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0xA0")]
		private string _userPoolId;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, string> _userPoolTags;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xB0")]
		private VerificationMessageTemplateType _verificationMessageTemplate;

		[Token(Token = "0x17000284")]
		public AccountRecoverySettingType AccountRecoverySetting
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x116F2B4", Offset = "0x116F2B4", VA = "0x116F2B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x116F2BC", Offset = "0x116F2BC", VA = "0x116F2BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000285")]
		public AdminCreateUserConfigType AdminCreateUserConfig
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x116F2D4", Offset = "0x116F2D4", VA = "0x116F2D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x116F2DC", Offset = "0x116F2DC", VA = "0x116F2DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000286")]
		public List<string> AutoVerifiedAttributes
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x116F2F4", Offset = "0x116F2F4", VA = "0x116F2F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x116F2FC", Offset = "0x116F2FC", VA = "0x116F2FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000287")]
		public DeviceConfigurationType DeviceConfiguration
		{
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x116F35C", Offset = "0x116F35C", VA = "0x116F35C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x116F364", Offset = "0x116F364", VA = "0x116F364")]
			set
			{
			}
		}

		[Token(Token = "0x17000288")]
		public EmailConfigurationType EmailConfiguration
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x116F37C", Offset = "0x116F37C", VA = "0x116F37C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x116F384", Offset = "0x116F384", VA = "0x116F384")]
			set
			{
			}
		}

		[Token(Token = "0x17000289")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2136C", Offset = "0x2136C")]
		public string EmailVerificationMessage
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x116F39C", Offset = "0x116F39C", VA = "0x116F39C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x116F3A4", Offset = "0x116F3A4", VA = "0x116F3A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700028A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x213B4", Offset = "0x213B4")]
		public string EmailVerificationSubject
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x116F3BC", Offset = "0x116F3BC", VA = "0x116F3BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x116F3C4", Offset = "0x116F3C4", VA = "0x116F3C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700028B")]
		public LambdaConfigType LambdaConfig
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x116F3DC", Offset = "0x116F3DC", VA = "0x116F3DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x116F3E4", Offset = "0x116F3E4", VA = "0x116F3E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700028C")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x116F3FC", Offset = "0x116F3FC", VA = "0x116F3FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x116F404", Offset = "0x116F404", VA = "0x116F404")]
			set
			{
			}
		}

		[Token(Token = "0x1700028D")]
		public UserPoolPolicyType Policies
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x116F488", Offset = "0x116F488", VA = "0x116F488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x116F490", Offset = "0x116F490", VA = "0x116F490")]
			set
			{
			}
		}

		[Token(Token = "0x1700028E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x213FC", Offset = "0x213FC")]
		public string SmsAuthenticationMessage
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x116F4A8", Offset = "0x116F4A8", VA = "0x116F4A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x116F4B0", Offset = "0x116F4B0", VA = "0x116F4B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700028F")]
		public SmsConfigurationType SmsConfiguration
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x116F4C8", Offset = "0x116F4C8", VA = "0x116F4C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x116F4D0", Offset = "0x116F4D0", VA = "0x116F4D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000290")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21444", Offset = "0x21444")]
		public string SmsVerificationMessage
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x116F4E8", Offset = "0x116F4E8", VA = "0x116F4E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x116F4F0", Offset = "0x116F4F0", VA = "0x116F4F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000291")]
		public UserPoolAddOnsType UserPoolAddOns
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x116F508", Offset = "0x116F508", VA = "0x116F508")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x116F510", Offset = "0x116F510", VA = "0x116F510")]
			set
			{
			}
		}

		[Token(Token = "0x17000292")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2148C", Offset = "0x2148C")]
		public string UserPoolId
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x116F528", Offset = "0x116F528", VA = "0x116F528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x116F530", Offset = "0x116F530", VA = "0x116F530")]
			set
			{
			}
		}

		[Token(Token = "0x17000293")]
		public Dictionary<string, string> UserPoolTags
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x116F548", Offset = "0x116F548", VA = "0x116F548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x116F550", Offset = "0x116F550", VA = "0x116F550")]
			set
			{
			}
		}

		[Token(Token = "0x17000294")]
		public VerificationMessageTemplateType VerificationMessageTemplate
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x116F5B4", Offset = "0x116F5B4", VA = "0x116F5B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x116F5BC", Offset = "0x116F5BC", VA = "0x116F5BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x116F2C4", Offset = "0x116F2C4", VA = "0x116F2C4")]
		internal bool IsSetAccountRecoverySetting()
		{
			return default;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x116F2E4", Offset = "0x116F2E4", VA = "0x116F2E4")]
		internal bool IsSetAdminCreateUserConfig()
		{
			return default;
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x116F304", Offset = "0x116F304", VA = "0x116F304")]
		internal bool IsSetAutoVerifiedAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x116F36C", Offset = "0x116F36C", VA = "0x116F36C")]
		internal bool IsSetDeviceConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x116F38C", Offset = "0x116F38C", VA = "0x116F38C")]
		internal bool IsSetEmailConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x116F3AC", Offset = "0x116F3AC", VA = "0x116F3AC")]
		internal bool IsSetEmailVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x116F3CC", Offset = "0x116F3CC", VA = "0x116F3CC")]
		internal bool IsSetEmailVerificationSubject()
		{
			return default;
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x116F3EC", Offset = "0x116F3EC", VA = "0x116F3EC")]
		internal bool IsSetLambdaConfig()
		{
			return default;
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x116F40C", Offset = "0x116F40C", VA = "0x116F40C")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x116F498", Offset = "0x116F498", VA = "0x116F498")]
		internal bool IsSetPolicies()
		{
			return default;
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x116F4B8", Offset = "0x116F4B8", VA = "0x116F4B8")]
		internal bool IsSetSmsAuthenticationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x116F4D8", Offset = "0x116F4D8", VA = "0x116F4D8")]
		internal bool IsSetSmsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x116F4F8", Offset = "0x116F4F8", VA = "0x116F4F8")]
		internal bool IsSetSmsVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x116F518", Offset = "0x116F518", VA = "0x116F518")]
		internal bool IsSetUserPoolAddOns()
		{
			return default;
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x116F538", Offset = "0x116F538", VA = "0x116F538")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x116F558", Offset = "0x116F558", VA = "0x116F558")]
		internal bool IsSetUserPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x116F5C4", Offset = "0x116F5C4", VA = "0x116F5C4")]
		internal bool IsSetVerificationMessageTemplate()
		{
			return default;
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x116F5D4", Offset = "0x116F5D4", VA = "0x116F5D4")]
		public UpdateUserPoolRequest()
		{
		}
	}
}
