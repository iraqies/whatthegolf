using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class NotifyEmailType
	{
		private string _htmlBody;

		private string _subject;

		private string _textBody;

		[AWSProperty]
		public string HtmlBody
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
		public string Subject
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
		public string TextBody
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetHtmlBody()
		{
			return false;
		}

		internal bool IsSetSubject()
		{
			return false;
		}

		internal bool IsSetTextBody()
		{
			return false;
		}
	}
}
