using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SetUserPoolMfaConfigRequest : AmazonCognitoIdentityProviderRequest
	{
		private UserPoolMfaType _mfaConfiguration;

		private SmsMfaConfigType _smsMfaConfiguration;

		private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;

		private string _userPoolId;

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

		public SmsMfaConfigType SmsMfaConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
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

		internal bool IsSetMfaConfiguration()
		{
			return false;
		}

		internal bool IsSetSmsMfaConfiguration()
		{
			return false;
		}

		internal bool IsSetSoftwareTokenMfaConfiguration()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
