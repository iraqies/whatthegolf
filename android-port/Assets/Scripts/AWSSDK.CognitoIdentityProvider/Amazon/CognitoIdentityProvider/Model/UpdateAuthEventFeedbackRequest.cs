using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateAuthEventFeedbackRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _eventId;

		private string _feedbackToken;

		private FeedbackValueType _feedbackValue;

		private string _username;

		private string _userPoolId;

		[AWSProperty]
		public string EventId
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
		public string FeedbackToken
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
		public FeedbackValueType FeedbackValue
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
		public string Username
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

		internal bool IsSetEventId()
		{
			return false;
		}

		internal bool IsSetFeedbackToken()
		{
			return false;
		}

		internal bool IsSetFeedbackValue()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
