using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200002B")]
	internal class WriterContext
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x14")]
		public bool InArray;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x15")]
		public bool InObject;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x18")]
		public int Padding;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1283338", Offset = "0x1283338", VA = "0x1283338")]
		public WriterContext()
		{
		}
	}
}
