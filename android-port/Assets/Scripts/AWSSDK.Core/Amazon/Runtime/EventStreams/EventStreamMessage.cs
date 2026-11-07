using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x200011C")]
	public class EventStreamMessage : IEventStreamMessage
	{
		[Token(Token = "0x400044A")]
		internal const int SizeOfInt32 = 4;

		[Token(Token = "0x400044B")]
		internal const int PreludeLen = 12;

		[Token(Token = "0x400044C")]
		internal const int TrailerLen = 4;

		[Token(Token = "0x400044D")]
		internal const int FramingSize = 16;

		[Token(Token = "0x400044E")]
		public const string ContentType = "vnd.amazon.eventstream";

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DD8", Offset = "0x26DD8")]
		private Dictionary<string, IEventStreamHeader> Headers__BackingField;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DE8", Offset = "0x26DE8")]
		private byte[] Payload__BackingField;

		[Token(Token = "0x17000271")]
		public Dictionary<string, IEventStreamHeader> Headers
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x1205450", Offset = "0x1205450", VA = "0x1205450", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x298DC", Offset = "0x298DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x1205458", Offset = "0x1205458", VA = "0x1205458", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x298EC", Offset = "0x298EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000272")]
		public byte[] Payload
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x1205460", Offset = "0x1205460", VA = "0x1205460", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x298FC", Offset = "0x298FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x1205468", Offset = "0x1205468", VA = "0x1205468", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2990C", Offset = "0x2990C")]
			set
			{
			}
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1205470", Offset = "0x1205470", VA = "0x1205470")]
		private EventStreamMessage()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1205478", Offset = "0x1205478", VA = "0x1205478")]
		public EventStreamMessage(List<IEventStreamHeader> headers, byte[] payload)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1202C68", Offset = "0x1202C68", VA = "0x1202C68")]
		public static EventStreamMessage FromBuffer(byte[] buffer, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x120578C", Offset = "0x120578C", VA = "0x120578C", Slot = "8")]
		public byte[] ToByteArray()
		{
			return null;
		}
	}
}
