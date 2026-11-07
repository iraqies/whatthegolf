using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x2000075")]
	public sealed class BinaryShiftToken : Token
	{
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x18")]
		private readonly int binaryShiftStart;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int binaryShiftByteCount;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2EA5510", Offset = "0x2EA5510", VA = "0x2EA5510")]
		public BinaryShiftToken(Token previous, int binaryShiftStart, int binaryShiftByteCount)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2EA55A4", Offset = "0x2EA55A4", VA = "0x2EA55A4", Slot = "4")]
		public override void appendTo(BitArray bitArray, byte[] text)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2EA59DC", Offset = "0x2EA59DC", VA = "0x2EA59DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
