using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000007")]
	public class MetricsName : ConstantClass
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MetricsName ALL;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		public static readonly MetricsName IncomingBytes;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly MetricsName IncomingRecords;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		public static readonly MetricsName IteratorAgeMilliseconds;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public static readonly MetricsName OutgoingBytes;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly MetricsName OutgoingRecords;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		public static readonly MetricsName ReadProvisionedThroughputExceeded;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		public static readonly MetricsName WriteProvisionedThroughputExceeded;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x12BDE34", Offset = "0x12BDE34", VA = "0x12BDE34")]
		public MetricsName(string value)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12BDEC0", Offset = "0x12BDEC0", VA = "0x12BDEC0")]
		public static MetricsName FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x12BDF50", Offset = "0x12BDF50", VA = "0x12BDF50")]
		public static implicit operator MetricsName(string value)
		{
			return null;
		}
	}
}
