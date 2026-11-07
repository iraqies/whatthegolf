using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class EmailConfigurationType
	{
		private string _configurationSet;

		private EmailSendingAccountType _emailSendingAccount;

		private string _from;

		private string _replyToEmailAddress;

		private string _sourceArn;

		[AWSProperty]
		public string ConfigurationSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EmailSendingAccountType EmailSendingAccount
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string From
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ReplyToEmailAddress
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
		public string SourceArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConfigurationSet()
		{
			return false;
		}

		internal bool IsSetEmailSendingAccount()
		{
			return false;
		}

		internal bool IsSetFrom()
		{
			return false;
		}

		internal bool IsSetReplyToEmailAddress()
		{
			return false;
		}

		internal bool IsSetSourceArn()
		{
			return false;
		}
	}
}
