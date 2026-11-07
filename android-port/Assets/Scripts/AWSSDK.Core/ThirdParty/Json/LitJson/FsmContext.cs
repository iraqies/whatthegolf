using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200002D")]
	internal class FsmContext
	{
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x120CD6C", Offset = "0x120CD6C", VA = "0x120CD6C")]
		public FsmContext()
		{
		}
	}
}
