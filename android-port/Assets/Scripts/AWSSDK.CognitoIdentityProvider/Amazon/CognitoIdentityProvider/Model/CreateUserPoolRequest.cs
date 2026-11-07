using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000087")]
	public class CreateUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x30")]
		private AccountRecoverySettingType _accountRecoverySetting;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x38")]
		private AdminCreateUserConfigType _adminCreateUserConfig;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _aliasAttributes;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x48")]
		private List<string> _autoVerifiedAttributes;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x50")]
		private DeviceConfigurationType _deviceConfiguration;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x58")]
		private EmailConfigurationType _emailConfiguration;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x60")]
		private string _emailVerificationMessage;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x68")]
		private string _emailVerificationSubject;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x70")]
		private LambdaConfigType _lambdaConfig;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x78")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x80")]
		private UserPoolPolicyType _policies;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x88")]
		private string _poolName;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x90")]
		private List<SchemaAttributeType> _schema;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x98")]
		private string _smsAuthenticationMessage;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0xA0")]
		private SmsConfigurationType _smsConfiguration;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xA8")]
		private string _smsVerificationMessage;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> _usernameAttributes;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xB8")]
		private UsernameConfigurationType _usernameConfiguration;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0xC0")]
		private UserPoolAddOnsType _userPoolAddOns;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<string, string> _userPoolTags;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0xD0")]
		private VerificationMessageTemplateType _verificationMessageTemplate;

		[Token(Token = "0x170000F3")]
		public AccountRecoverySettingType AccountRecoverySetting
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x10F6860", Offset = "0x10F6860", VA = "0x10F6860")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x10F6868", Offset = "0x10F6868", VA = "0x10F6868")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public AdminCreateUserConfigType AdminCreateUserConfig
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x10F6880", Offset = "0x10F6880", VA = "0x10F6880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x10F6888", Offset = "0x10F6888", VA = "0x10F6888")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public List<string> AliasAttributes
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x10F68A0", Offset = "0x10F68A0", VA = "0x10F68A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x10F68A8", Offset = "0x10F68A8", VA = "0x10F68A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public List<string> AutoVerifiedAttributes
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x10F6908", Offset = "0x10F6908", VA = "0x10F6908")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x10F6910", Offset = "0x10F6910", VA = "0x10F6910")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public DeviceConfigurationType DeviceConfiguration
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x10F6970", Offset = "0x10F6970", VA = "0x10F6970")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x10F6978", Offset = "0x10F6978", VA = "0x10F6978")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public EmailConfigurationType EmailConfiguration
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x10F6990", Offset = "0x10F6990", VA = "0x10F6990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x10F6998", Offset = "0x10F6998", VA = "0x10F6998")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D538", Offset = "0x1D538")]
		public string EmailVerificationMessage
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x10F69B0", Offset = "0x10F69B0", VA = "0x10F69B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x10F69B8", Offset = "0x10F69B8", VA = "0x10F69B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D580", Offset = "0x1D580")]
		public string EmailVerificationSubject
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x10F69D0", Offset = "0x10F69D0", VA = "0x10F69D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x10F69D8", Offset = "0x10F69D8", VA = "0x10F69D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public LambdaConfigType LambdaConfig
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x10F69F0", Offset = "0x10F69F0", VA = "0x10F69F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x10F69F8", Offset = "0x10F69F8", VA = "0x10F69F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x10F6A10", Offset = "0x10F6A10", VA = "0x10F6A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x10F6A18", Offset = "0x10F6A18", VA = "0x10F6A18")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public UserPoolPolicyType Policies
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x10F6A9C", Offset = "0x10F6A9C", VA = "0x10F6A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x10F6AA4", Offset = "0x10F6AA4", VA = "0x10F6AA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D5C8", Offset = "0x1D5C8")]
		public string PoolName
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x10F6ABC", Offset = "0x10F6ABC", VA = "0x10F6ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x10F6AC4", Offset = "0x10F6AC4", VA = "0x10F6AC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D618", Offset = "0x1D618")]
		public List<SchemaAttributeType> Schema
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x10F6ADC", Offset = "0x10F6ADC", VA = "0x10F6ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x10F6AE4", Offset = "0x10F6AE4", VA = "0x10F6AE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D660", Offset = "0x1D660")]
		public string SmsAuthenticationMessage
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x10F6B44", Offset = "0x10F6B44", VA = "0x10F6B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x10F6B4C", Offset = "0x10F6B4C", VA = "0x10F6B4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public SmsConfigurationType SmsConfiguration
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x10F6B64", Offset = "0x10F6B64", VA = "0x10F6B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x10F6B6C", Offset = "0x10F6B6C", VA = "0x10F6B6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D6A8", Offset = "0x1D6A8")]
		public string SmsVerificationMessage
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x10F6B84", Offset = "0x10F6B84", VA = "0x10F6B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x10F6B8C", Offset = "0x10F6B8C", VA = "0x10F6B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public List<string> UsernameAttributes
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x10F6BA4", Offset = "0x10F6BA4", VA = "0x10F6BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x10F6BAC", Offset = "0x10F6BAC", VA = "0x10F6BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public UsernameConfigurationType UsernameConfiguration
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x10F6C0C", Offset = "0x10F6C0C", VA = "0x10F6C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x10F6C14", Offset = "0x10F6C14", VA = "0x10F6C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public UserPoolAddOnsType UserPoolAddOns
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x10F6C2C", Offset = "0x10F6C2C", VA = "0x10F6C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x10F6C34", Offset = "0x10F6C34", VA = "0x10F6C34")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public Dictionary<string, string> UserPoolTags
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x10F6C4C", Offset = "0x10F6C4C", VA = "0x10F6C4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x10F6C54", Offset = "0x10F6C54", VA = "0x10F6C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public VerificationMessageTemplateType VerificationMessageTemplate
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x10F6CB8", Offset = "0x10F6CB8", VA = "0x10F6CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x10F6CC0", Offset = "0x10F6CC0", VA = "0x10F6CC0")]
			set
			{
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x10F6870", Offset = "0x10F6870", VA = "0x10F6870")]
		internal bool IsSetAccountRecoverySetting()
		{
			return default;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x10F6890", Offset = "0x10F6890", VA = "0x10F6890")]
		internal bool IsSetAdminCreateUserConfig()
		{
			return default;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x10F68B0", Offset = "0x10F68B0", VA = "0x10F68B0")]
		internal bool IsSetAliasAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x10F6918", Offset = "0x10F6918", VA = "0x10F6918")]
		internal bool IsSetAutoVerifiedAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x10F6980", Offset = "0x10F6980", VA = "0x10F6980")]
		internal bool IsSetDeviceConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x10F69A0", Offset = "0x10F69A0", VA = "0x10F69A0")]
		internal bool IsSetEmailConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x10F69C0", Offset = "0x10F69C0", VA = "0x10F69C0")]
		internal bool IsSetEmailVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x10F69E0", Offset = "0x10F69E0", VA = "0x10F69E0")]
		internal bool IsSetEmailVerificationSubject()
		{
			return default;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x10F6A00", Offset = "0x10F6A00", VA = "0x10F6A00")]
		internal bool IsSetLambdaConfig()
		{
			return default;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x10F6A20", Offset = "0x10F6A20", VA = "0x10F6A20")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x10F6AAC", Offset = "0x10F6AAC", VA = "0x10F6AAC")]
		internal bool IsSetPolicies()
		{
			return default;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x10F6ACC", Offset = "0x10F6ACC", VA = "0x10F6ACC")]
		internal bool IsSetPoolName()
		{
			return default;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x10F6AEC", Offset = "0x10F6AEC", VA = "0x10F6AEC")]
		internal bool IsSetSchema()
		{
			return default;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x10F6B54", Offset = "0x10F6B54", VA = "0x10F6B54")]
		internal bool IsSetSmsAuthenticationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x10F6B74", Offset = "0x10F6B74", VA = "0x10F6B74")]
		internal bool IsSetSmsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x10F6B94", Offset = "0x10F6B94", VA = "0x10F6B94")]
		internal bool IsSetSmsVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x10F6BB4", Offset = "0x10F6BB4", VA = "0x10F6BB4")]
		internal bool IsSetUsernameAttributes()
		{
			return default;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x10F6C1C", Offset = "0x10F6C1C", VA = "0x10F6C1C")]
		internal bool IsSetUsernameConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x10F6C3C", Offset = "0x10F6C3C", VA = "0x10F6C3C")]
		internal bool IsSetUserPoolAddOns()
		{
			return default;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x10F6C5C", Offset = "0x10F6C5C", VA = "0x10F6C5C")]
		internal bool IsSetUserPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x10F6CC8", Offset = "0x10F6CC8", VA = "0x10F6CC8")]
		internal bool IsSetVerificationMessageTemplate()
		{
			return default;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x10F6CD8", Offset = "0x10F6CD8", VA = "0x10F6CD8")]
		public CreateUserPoolRequest()
		{
		}
	}
}
