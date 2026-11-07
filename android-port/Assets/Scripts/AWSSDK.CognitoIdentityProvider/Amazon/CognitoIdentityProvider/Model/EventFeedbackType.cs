using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class EventFeedbackType
	{
		private DateTime? _feedbackDate;

		private FeedbackValueType _feedbackValue;

		private string _provider;

		public DateTime FeedbackDate
		{
			get
			{
				return default;
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
		public string Provider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetFeedbackDate()
		{
			return false;
		}

		internal bool IsSetFeedbackValue()
		{
			return false;
		}

		internal bool IsSetProvider()
		{
			return false;
		}
	}
}
