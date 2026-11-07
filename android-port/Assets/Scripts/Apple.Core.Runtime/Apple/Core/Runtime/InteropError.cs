using Il2CppDummyDll;

namespace Apple.Core.Runtime
{
	[Token(Token = "0x2000005")]
	public struct InteropError
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public int Code;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public string LocalizedDescription;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public string TaskId;
	}
}
