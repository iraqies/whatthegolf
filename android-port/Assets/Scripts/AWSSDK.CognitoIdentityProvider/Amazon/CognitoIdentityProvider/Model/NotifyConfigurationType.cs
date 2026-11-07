using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class NotifyConfigurationType
	{
		private NotifyEmailType _blockEmail;

		private string _from;

		private NotifyEmailType _mfaEmail;

		private NotifyEmailType _noActionEmail;

		private string _replyTo;

		private string _sourceArn;

		public NotifyEmailType BlockEmail
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

		public NotifyEmailType MfaEmail
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NotifyEmailType NoActionEmail
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ReplyTo
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

		internal bool IsSetBlockEmail()
		{
			return false;
		}

		internal bool IsSetFrom()
		{
			return false;
		}

		internal bool IsSetMfaEmail()
		{
			return false;
		}

		internal bool IsSetNoActionEmail()
		{
			return false;
		}

		internal bool IsSetReplyTo()
		{
			return false;
		}

		internal bool IsSetSourceArn()
		{
			return false;
		}
	}
}
