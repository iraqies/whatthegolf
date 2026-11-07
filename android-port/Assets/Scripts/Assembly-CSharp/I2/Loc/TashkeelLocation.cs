using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x200132B")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x40066A2")]
		[FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x40066A3")]
		[FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x600596B")]
		[Address(RVA = "0x16F79D8", Offset = "0x16F79D8", VA = "0x16F79D8")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
}
