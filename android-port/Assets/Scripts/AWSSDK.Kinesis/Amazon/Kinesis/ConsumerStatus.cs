using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000005")]
	public class ConsumerStatus : ConstantClass
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ConsumerStatus ACTIVE;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ConsumerStatus CREATING;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ConsumerStatus DELETING;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x12A2564", Offset = "0x12A2564", VA = "0x12A2564")]
		public ConsumerStatus(string value)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x12A25F0", Offset = "0x12A25F0", VA = "0x12A25F0")]
		public static ConsumerStatus FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x12A23D8", Offset = "0x12A23D8", VA = "0x12A23D8")]
		public static implicit operator ConsumerStatus(string value)
		{
			return null;
		}
	}
}
