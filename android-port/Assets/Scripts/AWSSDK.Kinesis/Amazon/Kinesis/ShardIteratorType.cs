using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000009")]
	public class ShardIteratorType : ConstantClass
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ShardIteratorType AFTER_SEQUENCE_NUMBER;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ShardIteratorType AT_SEQUENCE_NUMBER;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ShardIteratorType AT_TIMESTAMP;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ShardIteratorType LATEST;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ShardIteratorType TRIM_HORIZON;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x12C65E4", Offset = "0x12C65E4", VA = "0x12C65E4")]
		public ShardIteratorType(string value)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12C6670", Offset = "0x12C6670", VA = "0x12C6670")]
		public static ShardIteratorType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12C6700", Offset = "0x12C6700", VA = "0x12C6700")]
		public static implicit operator ShardIteratorType(string value)
		{
			return null;
		}
	}
}
