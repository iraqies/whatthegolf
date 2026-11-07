using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class MessageTemplateType
	{
		private string _emailMessage;

		private string _emailSubject;

		private string _smsMessage;

		[AWSProperty]
		public string EmailMessage
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
		public string EmailSubject
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
		public string SMSMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEmailMessage()
		{
			return false;
		}

		internal bool IsSetEmailSubject()
		{
			return false;
		}

		internal bool IsSetSMSMessage()
		{
			return false;
		}
	}
}
