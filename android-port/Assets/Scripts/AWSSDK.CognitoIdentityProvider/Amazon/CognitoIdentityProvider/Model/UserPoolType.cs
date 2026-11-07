using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserPoolType
	{
		private AccountRecoverySettingType _accountRecoverySetting;

		private AdminCreateUserConfigType _adminCreateUserConfig;

		private List<string> _aliasAttributes;

		private string _arn;

		private List<string> _autoVerifiedAttributes;

		private DateTime? _creationDate;

		private string _customDomain;

		private DeviceConfigurationType _deviceConfiguration;

		private string _domain;

		private EmailConfigurationType _emailConfiguration;

		private string _emailConfigurationFailure;

		private string _emailVerificationMessage;

		private string _emailVerificationSubject;

		private int? _estimatedNumberOfUsers;

		private string _id;

		private LambdaConfigType _lambdaConfig;

		private DateTime? _lastModifiedDate;

		private UserPoolMfaType _mfaConfiguration;

		private string _name;

		private UserPoolPolicyType _policies;

		private List<SchemaAttributeType> _schemaAttributes;

		private string _smsAuthenticationMessage;

		private SmsConfigurationType _smsConfiguration;

		private string _smsConfigurationFailure;

		private string _smsVerificationMessage;

		private StatusType _status;

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

		[AWSProperty]
		public string Arn
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

		public DateTime CreationDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string CustomDomain
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

		[AWSProperty]
		public string Domain
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

		public string EmailConfigurationFailure
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

		public int EstimatedNumberOfUsers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Id
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

		public DateTime LastModifiedDate
		{
			get
			{
				return default;
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

		[AWSProperty]
		public string Name
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
		public List<SchemaAttributeType> SchemaAttributes
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

		public string SmsConfigurationFailure
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

		public StatusType Status
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

		internal bool IsSetArn()
		{
			return false;
		}

		internal bool IsSetAutoVerifiedAttributes()
		{
			return false;
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetCustomDomain()
		{
			return false;
		}

		internal bool IsSetDeviceConfiguration()
		{
			return false;
		}

		internal bool IsSetDomain()
		{
			return false;
		}

		internal bool IsSetEmailConfiguration()
		{
			return false;
		}

		internal bool IsSetEmailConfigurationFailure()
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

		internal bool IsSetEstimatedNumberOfUsers()
		{
			return false;
		}

		internal bool IsSetId()
		{
			return false;
		}

		internal bool IsSetLambdaConfig()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetMfaConfiguration()
		{
			return false;
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetPolicies()
		{
			return false;
		}

		internal bool IsSetSchemaAttributes()
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

		internal bool IsSetSmsConfigurationFailure()
		{
			return false;
		}

		internal bool IsSetSmsVerificationMessage()
		{
			return false;
		}

		internal bool IsSetStatus()
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
