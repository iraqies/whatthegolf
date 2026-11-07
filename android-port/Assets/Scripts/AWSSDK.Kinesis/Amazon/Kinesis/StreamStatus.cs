using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x200000A")]
	public class StreamStatus : ConstantClass
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StreamStatus ACTIVE;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		public static readonly StreamStatus CREATING;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		public static readonly StreamStatus DELETING;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x18")]
		public static readonly StreamStatus UPDATING;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12CD3BC", Offset = "0x12CD3BC", VA = "0x12CD3BC")]
		public StreamStatus(string value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x12CD448", Offset = "0x12CD448", VA = "0x12CD448")]
		public static StreamStatus FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x12CC730", Offset = "0x12CC730", VA = "0x12CC730")]
		public static implicit operator StreamStatus(string value)
		{
			return null;
		}
	}
}
