using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SetUserPoolMfaConfigResponse : AmazonWebServiceResponse
	{
		private UserPoolMfaType _mfaConfiguration;

		private SmsMfaConfigType _smsMfaConfiguration;

		private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;

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
	}
}
