using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000008")]
	public class StreamingStatus : ConstantClass
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StreamingStatus DISABLED;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly StreamingStatus ENABLED;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x11AA1D8", Offset = "0x11AA1D8", VA = "0x11AA1D8")]
		public StreamingStatus(string value)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x11AA264", Offset = "0x11AA264", VA = "0x11AA264")]
		public static StreamingStatus FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1192B6C", Offset = "0x1192B6C", VA = "0x1192B6C")]
		public static implicit operator StreamingStatus(string value)
		{
			return null;
		}
	}
}
