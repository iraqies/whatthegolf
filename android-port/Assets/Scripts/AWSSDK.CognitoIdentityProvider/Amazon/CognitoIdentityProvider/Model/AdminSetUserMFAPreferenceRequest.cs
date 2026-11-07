using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminSetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
	{
		private SMSMfaSettingsType _smsMfaSettings;

		private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

		private string _username;

		private string _userPoolId;

		public SMSMfaSettingsType SMSMfaSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SoftwareTokenMfaSettingsType SoftwareTokenMfaSettings
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
		public string Username
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

		internal bool IsSetSMSMfaSettings()
		{
			return false;
		}

		internal bool IsSetSoftwareTokenMfaSettings()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
