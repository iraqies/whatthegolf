using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x2000008")]
	public class ScalingType : ConstantClass
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ScalingType UNIFORM_SCALING;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x12C5EF4", Offset = "0x12C5EF4", VA = "0x12C5EF4")]
		public ScalingType(string value)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x12C5F80", Offset = "0x12C5F80", VA = "0x12C5F80")]
		public static ScalingType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x12C6010", Offset = "0x12C6010", VA = "0x12C6010")]
		public static implicit operator ScalingType(string value)
		{
			return null;
		}
	}
}
