using System;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B0")]
	public class EventFeedbackType
	{
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _feedbackDate;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x20")]
		private FeedbackValueType _feedbackValue;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x28")]
		private string _provider;

		[Token(Token = "0x17000146")]
		public DateTime FeedbackDate
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x11116D0", Offset = "0x11116D0", VA = "0x11116D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x1111710", Offset = "0x1111710", VA = "0x1111710")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1E198", Offset = "0x1E198")]
		public FeedbackValueType FeedbackValue
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x11117C4", Offset = "0x11117C4", VA = "0x11117C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x11117CC", Offset = "0x11117CC", VA = "0x11117CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1E1CC", Offset = "0x1E1CC")]
		public string Provider
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1111850", Offset = "0x1111850", VA = "0x1111850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1111858", Offset = "0x1111858", VA = "0x1111858")]
			set
			{
			}
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1111784", Offset = "0x1111784", VA = "0x1111784")]
		internal bool IsSetFeedbackDate()
		{
			return default;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x11117D4", Offset = "0x11117D4", VA = "0x11117D4")]
		internal bool IsSetFeedbackValue()
		{
			return default;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1111860", Offset = "0x1111860", VA = "0x1111860")]
		internal bool IsSetProvider()
		{
			return default;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1111870", Offset = "0x1111870", VA = "0x1111870")]
		public EventFeedbackType()
		{
		}
	}
}
