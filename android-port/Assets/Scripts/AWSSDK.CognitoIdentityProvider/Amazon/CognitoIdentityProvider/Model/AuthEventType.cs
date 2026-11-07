using System;
using System.Collections.Generic;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AuthEventType
	{
		private List<ChallengeResponseType> _challengeResponses;

		private DateTime? _creationDate;

		private EventContextDataType _eventContextData;

		private EventFeedbackType _eventFeedback;

		private string _eventId;

		private EventResponseType _eventResponse;

		private EventRiskType _eventRisk;

		private EventType _eventType;

		public List<ChallengeResponseType> ChallengeResponses
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime CreationDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public EventContextDataType EventContextData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EventFeedbackType EventFeedback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public EventResponseType EventResponse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EventRiskType EventRisk
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EventType EventType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetChallengeResponses()
		{
			return false;
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetEventContextData()
		{
			return false;
		}

		internal bool IsSetEventFeedback()
		{
			return false;
		}

		internal bool IsSetEventId()
		{
			return false;
		}

		internal bool IsSetEventResponse()
		{
			return false;
		}

		internal bool IsSetEventRisk()
		{
			return false;
		}

		internal bool IsSetEventType()
		{
			return false;
		}
	}
}
