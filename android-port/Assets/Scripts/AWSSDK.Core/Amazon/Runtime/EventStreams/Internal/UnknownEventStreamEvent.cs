using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x200012F")]
	public class UnknownEventStreamEvent : IEventStreamEvent
	{
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E98", Offset = "0x26E98")]
		private IEventStreamMessage ReceivedMessage__BackingField;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26EA8", Offset = "0x26EA8")]
		private string EventType__BackingField;

		[Token(Token = "0x17000281")]
		public IEventStreamMessage ReceivedMessage
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x127ED08", Offset = "0x127ED08", VA = "0x127ED08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29AFC", Offset = "0x29AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x127ED10", Offset = "0x127ED10", VA = "0x127ED10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B0C", Offset = "0x29B0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000282")]
		public string EventType
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x127ED18", Offset = "0x127ED18", VA = "0x127ED18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B1C", Offset = "0x29B1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x127ED20", Offset = "0x127ED20", VA = "0x127ED20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B2C", Offset = "0x29B2C")]
			set
			{
			}
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x127ED28", Offset = "0x127ED28", VA = "0x127ED28")]
		public UnknownEventStreamEvent()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x127ED30", Offset = "0x127ED30", VA = "0x127ED30")]
		public UnknownEventStreamEvent(IEventStreamMessage receivedMessage, string eventType)
		{
		}
	}
}
