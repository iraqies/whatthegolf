using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x2000078")]
	public sealed class SimpleToken : Token
	{
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x18")]
		private readonly short value;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x1A")]
		private readonly short bitCount;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2ED2CC0", Offset = "0x2ED2CC0", VA = "0x2ED2CC0")]
		public SimpleToken(Token previous, int value, int bitCount)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2ED2D7C", Offset = "0x2ED2D7C", VA = "0x2ED2D7C", Slot = "4")]
		public override void appendTo(BitArray bitArray, byte[] text)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2ED2DA4", Offset = "0x2ED2DA4", VA = "0x2ED2DA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
