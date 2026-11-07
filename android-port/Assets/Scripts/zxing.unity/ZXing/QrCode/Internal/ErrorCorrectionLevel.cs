using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x200001A")]
	public sealed class ErrorCorrectionLevel
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ErrorCorrectionLevel L;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ErrorCorrectionLevel M;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ErrorCorrectionLevel Q;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ErrorCorrectionLevel H;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ErrorCorrectionLevel[] FOR_BITS;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		private readonly int bits;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x14")]
		private readonly int ordinal_Renamed_Field;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		private readonly string name;

		[Token(Token = "0x1700000E")]
		public int Bits
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2EB9BAC", Offset = "0x2EB9BAC", VA = "0x2EB9BAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2EB9B6C", Offset = "0x2EB9B6C", VA = "0x2EB9B6C")]
		private ErrorCorrectionLevel(int ordinal, int bits, string name)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2EB9BB4", Offset = "0x2EB9BB4", VA = "0x2EB9BB4")]
		public int ordinal()
		{
			return default;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2EB9BBC", Offset = "0x2EB9BBC", VA = "0x2EB9BBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
