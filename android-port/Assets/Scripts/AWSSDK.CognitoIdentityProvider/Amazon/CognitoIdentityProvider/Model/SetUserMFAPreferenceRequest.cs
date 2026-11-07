using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private SMSMfaSettingsType _smsMfaSettings;

		private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

		[AWSProperty]
		public string AccessToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetSMSMfaSettings()
		{
			return false;
		}

		internal bool IsSetSoftwareTokenMfaSettings()
		{
			return false;
		}
	}
}
