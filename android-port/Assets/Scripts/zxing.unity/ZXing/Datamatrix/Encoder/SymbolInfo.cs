namespace ZXing.Datamatrix.Encoder
{
	public class SymbolInfo
	{
		internal static readonly SymbolInfo[] PROD_SYMBOLS;

		private static SymbolInfo[] symbols;

		private readonly bool rectangular;

		internal readonly int dataCapacity;

		internal readonly int errorCodewords;

		public readonly int matrixWidth;

		public readonly int matrixHeight;

		private readonly int dataRegions;

		private readonly int rsBlockData;

		private readonly int rsBlockError;

		public SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions)
		{
		}

		internal SymbolInfo(bool rectangular, int dataCapacity, int errorCodewords, int matrixWidth, int matrixHeight, int dataRegions, int rsBlockData, int rsBlockError)
		{
		}

		public static SymbolInfo lookup(int dataCodewords, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, bool fail)
		{
			return null;
		}

		private int getHorizontalDataRegions()
		{
			return 0;
		}

		private int getVerticalDataRegions()
		{
			return 0;
		}

		public int getSymbolDataWidth()
		{
			return 0;
		}

		public int getSymbolDataHeight()
		{
			return 0;
		}

		public int getSymbolWidth()
		{
			return 0;
		}

		public int getSymbolHeight()
		{
			return 0;
		}

		public virtual int getInterleavedBlockCount()
		{
			return 0;
		}

		public virtual int getDataLengthForInterleavedBlock(int index)
		{
			return 0;
		}

		public int getErrorLengthForInterleavedBlock(int index)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
