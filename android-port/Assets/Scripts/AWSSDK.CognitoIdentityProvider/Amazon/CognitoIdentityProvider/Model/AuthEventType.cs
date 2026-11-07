using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200006A")]
	public class AuthEventType
	{
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x10")]
		private List<ChallengeResponseType> _challengeResponses;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _creationDate;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		private EventContextDataType _eventContextData;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x30")]
		private EventFeedbackType _eventFeedback;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x38")]
		private string _eventId;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x40")]
		private EventResponseType _eventResponse;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x48")]
		private EventRiskType _eventRisk;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x50")]
		private EventType _eventType;

		[Token(Token = "0x1700009B")]
		public List<ChallengeResponseType> ChallengeResponses
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x10DEA3C", Offset = "0x10DEA3C", VA = "0x10DEA3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x10DEA44", Offset = "0x10DEA44", VA = "0x10DEA44")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public DateTime CreationDate
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x10DEAA4", Offset = "0x10DEAA4", VA = "0x10DEAA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x10DEAE4", Offset = "0x10DEAE4", VA = "0x10DEAE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public EventContextDataType EventContextData
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x10DEB98", Offset = "0x10DEB98", VA = "0x10DEB98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x10DEBA0", Offset = "0x10DEBA0", VA = "0x10DEBA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public EventFeedbackType EventFeedback
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x10DEBB8", Offset = "0x10DEBB8", VA = "0x10DEBB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x10DEBC0", Offset = "0x10DEBC0", VA = "0x10DEBC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public string EventId
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x10DEBD8", Offset = "0x10DEBD8", VA = "0x10DEBD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x10DEBE0", Offset = "0x10DEBE0", VA = "0x10DEBE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public EventResponseType EventResponse
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x10DEBF8", Offset = "0x10DEBF8", VA = "0x10DEBF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x10DEC00", Offset = "0x10DEC00", VA = "0x10DEC00")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public EventRiskType EventRisk
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x10DEC84", Offset = "0x10DEC84", VA = "0x10DEC84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x10DEC8C", Offset = "0x10DEC8C", VA = "0x10DEC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public EventType EventType
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x10DECA4", Offset = "0x10DECA4", VA = "0x10DECA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x10DECAC", Offset = "0x10DECAC", VA = "0x10DECAC")]
			set
			{
			}
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10DEA4C", Offset = "0x10DEA4C", VA = "0x10DEA4C")]
		internal bool IsSetChallengeResponses()
		{
			return default;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x10DEB58", Offset = "0x10DEB58", VA = "0x10DEB58")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x10DEBA8", Offset = "0x10DEBA8", VA = "0x10DEBA8")]
		internal bool IsSetEventContextData()
		{
			return default;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x10DEBC8", Offset = "0x10DEBC8", VA = "0x10DEBC8")]
		internal bool IsSetEventFeedback()
		{
			return default;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x10DEBE8", Offset = "0x10DEBE8", VA = "0x10DEBE8")]
		internal bool IsSetEventId()
		{
			return default;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x10DEC08", Offset = "0x10DEC08", VA = "0x10DEC08")]
		internal bool IsSetEventResponse()
		{
			return default;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x10DEC94", Offset = "0x10DEC94", VA = "0x10DEC94")]
		internal bool IsSetEventRisk()
		{
			return default;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x10DECB4", Offset = "0x10DECB4", VA = "0x10DECB4")]
		internal bool IsSetEventType()
		{
			return default;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x10DED30", Offset = "0x10DED30", VA = "0x10DED30")]
		public AuthEventType()
		{
		}
	}
}
