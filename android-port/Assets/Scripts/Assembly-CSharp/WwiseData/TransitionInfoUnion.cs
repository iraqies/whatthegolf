using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001002")]
	public struct TransitionInfoUnion
	{
		[Token(Token = "0x40054A4")]
		[FieldOffset(Offset = "0x0")]
		public string String;

		[Token(Token = "0x40054A5")]
		[FieldOffset(Offset = "0x8")]
		public TransitionInfoClass TransitionInfoClass;
	}
}
