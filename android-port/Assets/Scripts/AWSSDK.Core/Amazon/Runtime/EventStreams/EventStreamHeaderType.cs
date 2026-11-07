using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000116")]
	public enum EventStreamHeaderType : byte
	{
		[Token(Token = "0x4000437")]
		BoolTrue = 0,
		[Token(Token = "0x4000438")]
		BoolFalse = 1,
		[Token(Token = "0x4000439")]
		Byte = 2,
		[Token(Token = "0x400043A")]
		Int16 = 3,
		[Token(Token = "0x400043B")]
		Int32 = 4,
		[Token(Token = "0x400043C")]
		Int64 = 5,
		[Token(Token = "0x400043D")]
		ByteBuf = 6,
		[Token(Token = "0x400043E")]
		String = 7,
		[Token(Token = "0x400043F")]
		Timestamp = 8,
		[Token(Token = "0x4000440")]
		UUID = 9
	}
}
