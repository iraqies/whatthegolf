using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class VerificationMessageTemplateType
	{
		private DefaultEmailOptionType _defaultEmailOption;

		private string _emailMessage;

		private string _emailMessageByLink;

		private string _emailSubject;

		private string _emailSubjectByLink;

		private string _smsMessage;

		public DefaultEmailOptionType DefaultEmailOption
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
		public string EmailMessageByLink
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
		public string EmailSubjectByLink
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
		public string SmsMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDefaultEmailOption()
		{
			return false;
		}

		internal bool IsSetEmailMessage()
		{
			return false;
		}

		internal bool IsSetEmailMessageByLink()
		{
			return false;
		}

		internal bool IsSetEmailSubject()
		{
			return false;
		}

		internal bool IsSetEmailSubjectByLink()
		{
			return false;
		}

		internal bool IsSetSmsMessage()
		{
			return false;
		}
	}
}
