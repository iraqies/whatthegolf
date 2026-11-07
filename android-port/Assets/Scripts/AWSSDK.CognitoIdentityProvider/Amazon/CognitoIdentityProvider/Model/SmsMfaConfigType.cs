using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SmsMfaConfigType
	{
		private string _smsAuthenticationMessage;

		private SmsConfigurationType _smsConfiguration;

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

		internal bool IsSetSmsAuthenticationMessage()
		{
			return false;
		}

		internal bool IsSetSmsConfiguration()
		{
			return false;
		}
	}
}
