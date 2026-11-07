using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		private AccountRecoverySettingType _accountRecoverySetting;

		private AdminCreateUserConfigType _adminCreateUserConfig;

		private List<string> _autoVerifiedAttributes;

		private DeviceConfigurationType _deviceConfiguration;

		private EmailConfigurationType _emailConfiguration;

		private string _emailVerificationMessage;

		private string _emailVerificationSubject;

		private LambdaConfigType _lambdaConfig;

		private UserPoolMfaType _mfaConfiguration;

		private UserPoolPolicyType _policies;

		private string _smsAuthenticationMessage;

		private SmsConfigurationType _smsConfiguration;

		private string _smsVerificationMessage;

		private UserPoolAddOnsType _userPoolAddOns;

		private string _userPoolId;

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

		[AWSProperty]
		public string UserPoolId
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

		internal bool IsSetUserPoolAddOns()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
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
