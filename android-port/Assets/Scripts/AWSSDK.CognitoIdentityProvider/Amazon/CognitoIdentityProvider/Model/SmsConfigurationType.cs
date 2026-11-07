using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SmsConfigurationType
	{
		private string _externalId;

		private string _snsCallerArn;

		public string ExternalId
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
		public string SnsCallerArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetExternalId()
		{
			return false;
		}

		internal bool IsSetSnsCallerArn()
		{
			return false;
		}
	}
}
