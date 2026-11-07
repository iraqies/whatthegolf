using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014B")]
	public class UserPoolType
	{
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x10")]
		private AccountRecoverySettingType _accountRecoverySetting;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x18")]
		private AdminCreateUserConfigType _adminCreateUserConfig;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x20")]
		private List<string> _aliasAttributes;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x28")]
		private string _arn;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _autoVerifiedAttributes;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x38")]
		private DateTime? _creationDate;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x48")]
		private string _customDomain;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x50")]
		private DeviceConfigurationType _deviceConfiguration;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x58")]
		private string _domain;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x60")]
		private EmailConfigurationType _emailConfiguration;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x68")]
		private string _emailConfigurationFailure;

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x70")]
		private string _emailVerificationMessage;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x78")]
		private string _emailVerificationSubject;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x80")]
		private int? _estimatedNumberOfUsers;

		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x88")]
		private string _id;

		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x90")]
		private LambdaConfigType _lambdaConfig;

		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x98")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0xA8")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0xB0")]
		private string _name;

		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0xB8")]
		private UserPoolPolicyType _policies;

		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0xC0")]
		private List<SchemaAttributeType> _schemaAttributes;

		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0xC8")]
		private string _smsAuthenticationMessage;

		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0xD0")]
		private SmsConfigurationType _smsConfiguration;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0xD8")]
		private string _smsConfigurationFailure;

		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0xE0")]
		private string _smsVerificationMessage;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0xE8")]
		private StatusType _status;

		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0xF0")]
		private List<string> _usernameAttributes;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0xF8")]
		private UsernameConfigurationType _usernameConfiguration;

		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x100")]
		private UserPoolAddOnsType _userPoolAddOns;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<string, string> _userPoolTags;

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x110")]
		private VerificationMessageTemplateType _verificationMessageTemplate;

		[Token(Token = "0x170002C2")]
		public AccountRecoverySettingType AccountRecoverySetting
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x1175B5C", Offset = "0x1175B5C", VA = "0x1175B5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x1175B64", Offset = "0x1175B64", VA = "0x1175B64")]
			set
			{
			}
		}

		[Token(Token = "0x170002C3")]
		public AdminCreateUserConfigType AdminCreateUserConfig
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x1175B7C", Offset = "0x1175B7C", VA = "0x1175B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x1175B84", Offset = "0x1175B84", VA = "0x1175B84")]
			set
			{
			}
		}

		[Token(Token = "0x170002C4")]
		public List<string> AliasAttributes
		{
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x1175B9C", Offset = "0x1175B9C", VA = "0x1175B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x1175BA4", Offset = "0x1175BA4", VA = "0x1175BA4")]
			set
			{
			}
		}

		[Token(Token = "0x170002C5")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21B1C", Offset = "0x21B1C")]
		public string Arn
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x1175C04", Offset = "0x1175C04", VA = "0x1175C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x1175C0C", Offset = "0x1175C0C", VA = "0x1175C0C")]
			set
			{
			}
		}

		[Token(Token = "0x170002C6")]
		public List<string> AutoVerifiedAttributes
		{
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x1175C24", Offset = "0x1175C24", VA = "0x1175C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x1175C2C", Offset = "0x1175C2C", VA = "0x1175C2C")]
			set
			{
			}
		}

		[Token(Token = "0x170002C7")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x1175C8C", Offset = "0x1175C8C", VA = "0x1175C8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x1175CCC", Offset = "0x1175CCC", VA = "0x1175CCC")]
			set
			{
			}
		}

		[Token(Token = "0x170002C8")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21B64", Offset = "0x21B64")]
		public string CustomDomain
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x1175D80", Offset = "0x1175D80", VA = "0x1175D80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x1175D88", Offset = "0x1175D88", VA = "0x1175D88")]
			set
			{
			}
		}

		[Token(Token = "0x170002C9")]
		public DeviceConfigurationType DeviceConfiguration
		{
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x1175DA0", Offset = "0x1175DA0", VA = "0x1175DA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x1175DA8", Offset = "0x1175DA8", VA = "0x1175DA8")]
			set
			{
			}
		}

		[Token(Token = "0x170002CA")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21BAC", Offset = "0x21BAC")]
		public string Domain
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x1175DC0", Offset = "0x1175DC0", VA = "0x1175DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x1175DC8", Offset = "0x1175DC8", VA = "0x1175DC8")]
			set
			{
			}
		}

		[Token(Token = "0x170002CB")]
		public EmailConfigurationType EmailConfiguration
		{
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x1175DE0", Offset = "0x1175DE0", VA = "0x1175DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x1175DE8", Offset = "0x1175DE8", VA = "0x1175DE8")]
			set
			{
			}
		}

		[Token(Token = "0x170002CC")]
		public string EmailConfigurationFailure
		{
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x1175E00", Offset = "0x1175E00", VA = "0x1175E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x1175E08", Offset = "0x1175E08", VA = "0x1175E08")]
			set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21BF4", Offset = "0x21BF4")]
		public string EmailVerificationMessage
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x1175E20", Offset = "0x1175E20", VA = "0x1175E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x1175E28", Offset = "0x1175E28", VA = "0x1175E28")]
			set
			{
			}
		}

		[Token(Token = "0x170002CE")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21C3C", Offset = "0x21C3C")]
		public string EmailVerificationSubject
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x1175E40", Offset = "0x1175E40", VA = "0x1175E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x1175E48", Offset = "0x1175E48", VA = "0x1175E48")]
			set
			{
			}
		}

		[Token(Token = "0x170002CF")]
		public int EstimatedNumberOfUsers
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x1175E60", Offset = "0x1175E60", VA = "0x1175E60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1175EA0", Offset = "0x1175EA0", VA = "0x1175EA0")]
			set
			{
			}
		}

		[Token(Token = "0x170002D0")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21C84", Offset = "0x21C84")]
		public string Id
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x1175F54", Offset = "0x1175F54", VA = "0x1175F54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x1175F5C", Offset = "0x1175F5C", VA = "0x1175F5C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D1")]
		public LambdaConfigType LambdaConfig
		{
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x1175F74", Offset = "0x1175F74", VA = "0x1175F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x1175F7C", Offset = "0x1175F7C", VA = "0x1175F7C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D2")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x1175F94", Offset = "0x1175F94", VA = "0x1175F94")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x1175FD4", Offset = "0x1175FD4", VA = "0x1175FD4")]
			set
			{
			}
		}

		[Token(Token = "0x170002D3")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x1176088", Offset = "0x1176088", VA = "0x1176088")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x1176090", Offset = "0x1176090", VA = "0x1176090")]
			set
			{
			}
		}

		[Token(Token = "0x170002D4")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21CCC", Offset = "0x21CCC")]
		public string Name
		{
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x1176114", Offset = "0x1176114", VA = "0x1176114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x117611C", Offset = "0x117611C", VA = "0x117611C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D5")]
		public UserPoolPolicyType Policies
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x1176134", Offset = "0x1176134", VA = "0x1176134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x117613C", Offset = "0x117613C", VA = "0x117613C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D6")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21D14", Offset = "0x21D14")]
		public List<SchemaAttributeType> SchemaAttributes
		{
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x1176154", Offset = "0x1176154", VA = "0x1176154")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x117615C", Offset = "0x117615C", VA = "0x117615C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D7")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21D5C", Offset = "0x21D5C")]
		public string SmsAuthenticationMessage
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x11761BC", Offset = "0x11761BC", VA = "0x11761BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x11761C4", Offset = "0x11761C4", VA = "0x11761C4")]
			set
			{
			}
		}

		[Token(Token = "0x170002D8")]
		public SmsConfigurationType SmsConfiguration
		{
			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x11761DC", Offset = "0x11761DC", VA = "0x11761DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x11761E4", Offset = "0x11761E4", VA = "0x11761E4")]
			set
			{
			}
		}

		[Token(Token = "0x170002D9")]
		public string SmsConfigurationFailure
		{
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x11761FC", Offset = "0x11761FC", VA = "0x11761FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x1176204", Offset = "0x1176204", VA = "0x1176204")]
			set
			{
			}
		}

		[Token(Token = "0x170002DA")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21DA4", Offset = "0x21DA4")]
		public string SmsVerificationMessage
		{
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x117621C", Offset = "0x117621C", VA = "0x117621C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x1176224", Offset = "0x1176224", VA = "0x1176224")]
			set
			{
			}
		}

		[Token(Token = "0x170002DB")]
		public StatusType Status
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x117623C", Offset = "0x117623C", VA = "0x117623C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x1176244", Offset = "0x1176244", VA = "0x1176244")]
			set
			{
			}
		}

		[Token(Token = "0x170002DC")]
		public List<string> UsernameAttributes
		{
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x11762C8", Offset = "0x11762C8", VA = "0x11762C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x11762D0", Offset = "0x11762D0", VA = "0x11762D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002DD")]
		public UsernameConfigurationType UsernameConfiguration
		{
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1176330", Offset = "0x1176330", VA = "0x1176330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x1176338", Offset = "0x1176338", VA = "0x1176338")]
			set
			{
			}
		}

		[Token(Token = "0x170002DE")]
		public UserPoolAddOnsType UserPoolAddOns
		{
			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x1176350", Offset = "0x1176350", VA = "0x1176350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x1176358", Offset = "0x1176358", VA = "0x1176358")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public Dictionary<string, string> UserPoolTags
		{
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x1176370", Offset = "0x1176370", VA = "0x1176370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x1176378", Offset = "0x1176378", VA = "0x1176378")]
			set
			{
			}
		}

		[Token(Token = "0x170002E0")]
		public VerificationMessageTemplateType VerificationMessageTemplate
		{
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x11763DC", Offset = "0x11763DC", VA = "0x11763DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x11763E4", Offset = "0x11763E4", VA = "0x11763E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x1175B6C", Offset = "0x1175B6C", VA = "0x1175B6C")]
		internal bool IsSetAccountRecoverySetting()
		{
			return default;
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x1175B8C", Offset = "0x1175B8C", VA = "0x1175B8C")]
		internal bool IsSetAdminCreateUserConfig()
		{
			return default;
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x1175BAC", Offset = "0x1175BAC", VA = "0x1175BAC")]
		internal bool IsSetAliasAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x1175C14", Offset = "0x1175C14", VA = "0x1175C14")]
		internal bool IsSetArn()
		{
			return default;
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1175C34", Offset = "0x1175C34", VA = "0x1175C34")]
		internal bool IsSetAutoVerifiedAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x1175D40", Offset = "0x1175D40", VA = "0x1175D40")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x1175D90", Offset = "0x1175D90", VA = "0x1175D90")]
		internal bool IsSetCustomDomain()
		{
			return default;
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x1175DB0", Offset = "0x1175DB0", VA = "0x1175DB0")]
		internal bool IsSetDeviceConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x1175DD0", Offset = "0x1175DD0", VA = "0x1175DD0")]
		internal bool IsSetDomain()
		{
			return default;
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1175DF0", Offset = "0x1175DF0", VA = "0x1175DF0")]
		internal bool IsSetEmailConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x1175E10", Offset = "0x1175E10", VA = "0x1175E10")]
		internal bool IsSetEmailConfigurationFailure()
		{
			return default;
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x1175E30", Offset = "0x1175E30", VA = "0x1175E30")]
		internal bool IsSetEmailVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x1175E50", Offset = "0x1175E50", VA = "0x1175E50")]
		internal bool IsSetEmailVerificationSubject()
		{
			return default;
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x1175F14", Offset = "0x1175F14", VA = "0x1175F14")]
		internal bool IsSetEstimatedNumberOfUsers()
		{
			return default;
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x1175F64", Offset = "0x1175F64", VA = "0x1175F64")]
		internal bool IsSetId()
		{
			return default;
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x1175F84", Offset = "0x1175F84", VA = "0x1175F84")]
		internal bool IsSetLambdaConfig()
		{
			return default;
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x1176048", Offset = "0x1176048", VA = "0x1176048")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x1176098", Offset = "0x1176098", VA = "0x1176098")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x1176124", Offset = "0x1176124", VA = "0x1176124")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x1176144", Offset = "0x1176144", VA = "0x1176144")]
		internal bool IsSetPolicies()
		{
			return default;
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x1176164", Offset = "0x1176164", VA = "0x1176164")]
		internal bool IsSetSchemaAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x11761CC", Offset = "0x11761CC", VA = "0x11761CC")]
		internal bool IsSetSmsAuthenticationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x11761EC", Offset = "0x11761EC", VA = "0x11761EC")]
		internal bool IsSetSmsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x117620C", Offset = "0x117620C", VA = "0x117620C")]
		internal bool IsSetSmsConfigurationFailure()
		{
			return default;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x117622C", Offset = "0x117622C", VA = "0x117622C")]
		internal bool IsSetSmsVerificationMessage()
		{
			return default;
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x117624C", Offset = "0x117624C", VA = "0x117624C")]
		internal bool IsSetStatus()
		{
			return default;
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x11762D8", Offset = "0x11762D8", VA = "0x11762D8")]
		internal bool IsSetUsernameAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x1176340", Offset = "0x1176340", VA = "0x1176340")]
		internal bool IsSetUsernameConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x1176360", Offset = "0x1176360", VA = "0x1176360")]
		internal bool IsSetUserPoolAddOns()
		{
			return default;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x1176380", Offset = "0x1176380", VA = "0x1176380")]
		internal bool IsSetUserPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x11763EC", Offset = "0x11763EC", VA = "0x11763EC")]
		internal bool IsSetVerificationMessageTemplate()
		{
			return default;
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x11763FC", Offset = "0x11763FC", VA = "0x11763FC")]
		public UserPoolType()
		{
		}
	}
}
