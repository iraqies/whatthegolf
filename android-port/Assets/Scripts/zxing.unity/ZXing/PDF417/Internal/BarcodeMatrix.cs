using Il2CppDummyDll;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x200002E")]
	internal sealed class BarcodeMatrix
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		private readonly BarcodeRow[] matrix;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		private int currentRow;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int height;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		private readonly int width;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2E9F960", Offset = "0x2E9F960", VA = "0x2E9F960")]
		internal BarcodeMatrix(int height, int width, bool compact)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2E9FB6C", Offset = "0x2E9FB6C", VA = "0x2E9FB6C")]
		internal void startRow()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2E9FB7C", Offset = "0x2E9FB7C", VA = "0x2E9FB7C")]
		internal BarcodeRow getCurrentRow()
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2E9FBBC", Offset = "0x2E9FBBC", VA = "0x2E9FBBC")]
		internal sbyte[][] getScaledMatrix(int xScale, int yScale)
		{
			return null;
		}
	}
}
