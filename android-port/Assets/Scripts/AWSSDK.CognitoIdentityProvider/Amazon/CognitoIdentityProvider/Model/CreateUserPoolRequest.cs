using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		private AccountRecoverySettingType _accountRecoverySetting;

		private AdminCreateUserConfigType _adminCreateUserConfig;

		private List<string> _aliasAttributes;

		private List<string> _autoVerifiedAttributes;

		private DeviceConfigurationType _deviceConfiguration;

		private EmailConfigurationType _emailConfiguration;

		private string _emailVerificationMessage;

		private string _emailVerificationSubject;

		private LambdaConfigType _lambdaConfig;

		private UserPoolMfaType _mfaConfiguration;

		private UserPoolPolicyType _policies;

		private string _poolName;

		private List<SchemaAttributeType> _schema;

		private string _smsAuthenticationMessage;

		private SmsConfigurationType _smsConfiguration;

		private string _smsVerificationMessage;

		private List<string> _usernameAttributes;

		private UsernameConfigurationType _usernameConfiguration;

		private UserPoolAddOnsType _userPoolAddOns;

		private Dictionary<string, string> _userPoolTags;

		private VerificationMessageTemplateType _verificationMessageTemplate;

		public AccountRecoverySettingType AccountRecoverySetting
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdminCreateUserConfigType AdminCreateUserConfig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> AliasAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> AutoVerifiedAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeviceConfigurationType DeviceConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EmailConfigurationType EmailConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string EmailVerificationMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string EmailVerificationSubject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LambdaConfigType LambdaConfig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserPoolMfaType MfaConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserPoolPolicyType Policies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string PoolName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public List<SchemaAttributeType> Schema
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SmsAuthenticationMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SmsConfigurationType SmsConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SmsVerificationMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> UsernameAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UsernameConfigurationType UsernameConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserPoolAddOnsType UserPoolAddOns
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, string> UserPoolTags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VerificationMessageTemplateType VerificationMessageTemplate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccountRecoverySetting()
		{
			return false;
		}

		internal bool IsSetAdminCreateUserConfig()
		{
			return false;
		}

		internal bool IsSetAliasAttributes()
		{
			return false;
		}

		internal bool IsSetAutoVerifiedAttributes()
		{
			return false;
		}

		internal bool IsSetDeviceConfiguration()
		{
			return false;
		}

		internal bool IsSetEmailConfiguration()
		{
			return false;
		}

		internal bool IsSetEmailVerificationMessage()
		{
			return false;
		}

		internal bool IsSetEmailVerificationSubject()
		{
			return false;
		}

		internal bool IsSetLambdaConfig()
		{
			return false;
		}

		internal bool IsSetMfaConfiguration()
		{
			return false;
		}

		internal bool IsSetPolicies()
		{
			return false;
		}

		internal bool IsSetPoolName()
		{
			return false;
		}

		internal bool IsSetSchema()
		{
			return false;
		}

		internal bool IsSetSmsAuthenticationMessage()
		{
			return false;
		}

		internal bool IsSetSmsConfiguration()
		{
			return false;
		}

		internal bool IsSetSmsVerificationMessage()
		{
			return false;
		}

		internal bool IsSetUsernameAttributes()
		{
			return false;
		}

		internal bool IsSetUsernameConfiguration()
		{
			return false;
		}

		internal bool IsSetUserPoolAddOns()
		{
			return false;
		}

		internal bool IsSetUserPoolTags()
		{
			return false;
		}

		internal bool IsSetVerificationMessageTemplate()
		{
			return false;
		}
	}
}
