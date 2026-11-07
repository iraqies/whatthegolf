using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000062")]
	public class SymbolInfo
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly SymbolInfo[] PROD_SYMBOLS;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		private static SymbolInfo[] symbols;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool rectangular;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x14")]
		internal readonly int dataCapacity;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int errorCodewords;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int matrixWidth;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		public readonly int matrixHeight;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x24")]
		private readonly int dataRegions;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		private readonly int rsBlockData;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x2C")]
		private readonly int rsBlockError;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2ED4540", Offset = "0x2ED4540", VA = "0x2ED4540")]
		public SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2ED45A8", Offset = "0x2ED45A8", VA = "0x2ED45A8")]
		internal SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions, int rsBlockData, int rsBlockError)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2ED4620", Offset = "0x2ED4620", VA = "0x2ED4620")]
		public static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, bool fail)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2ED48E0", Offset = "0x2ED48E0", VA = "0x2ED48E0")]
		private int getHorizontalDataRegions()
		{
			return default;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2ED499C", Offset = "0x2ED499C", VA = "0x2ED499C")]
		private int getVerticalDataRegions()
		{
			return default;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2ED4A40", Offset = "0x2ED4A40", VA = "0x2ED4A40")]
		public int getSymbolDataWidth()
		{
			return default;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2ED4A68", Offset = "0x2ED4A68", VA = "0x2ED4A68")]
		public int getSymbolDataHeight()
		{
			return default;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2ED4878", Offset = "0x2ED4878", VA = "0x2ED4878")]
		public int getSymbolWidth()
		{
			return default;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2ED48AC", Offset = "0x2ED48AC", VA = "0x2ED48AC")]
		public int getSymbolHeight()
		{
			return default;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2ED4A90", Offset = "0x2ED4A90", VA = "0x2ED4A90", Slot = "4")]
		public virtual int getInterleavedBlockCount()
		{
			return default;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2ED4AA0", Offset = "0x2ED4AA0", VA = "0x2ED4AA0", Slot = "5")]
		public virtual int getDataLengthForInterleavedBlock(int index)
		{
			return default;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2ED4AA8", Offset = "0x2ED4AA8", VA = "0x2ED4AA8")]
		public int getErrorLengthForInterleavedBlock(int index)
		{
			return default;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2ED4AB0", Offset = "0x2ED4AB0", VA = "0x2ED4AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
