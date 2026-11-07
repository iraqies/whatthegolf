using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x200004C")]
	public sealed class PlesseyWriter : OneDimensionalCodeWriter
	{
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] startWidths;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] terminationWidths;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] endWidths;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[][] numberWidths;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] crcGrid;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] crc0Widths;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int[] crc1Widths;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x1700003F")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x2ED07AC", Offset = "0x2ED07AC", VA = "0x2ED07AC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2ED0810", Offset = "0x2ED0810", VA = "0x2ED0810", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2ED0DA0", Offset = "0x2ED0DA0", VA = "0x2ED0DA0")]
		public PlesseyWriter()
		{
		}
	}
}
