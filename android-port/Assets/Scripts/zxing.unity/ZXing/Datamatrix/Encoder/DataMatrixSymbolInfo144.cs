namespace ZXing.Datamatrix.Encoder
{
	internal sealed class DataMatrixSymbolInfo144 : SymbolInfo
	{
		public DataMatrixSymbolInfo144()
			: base(rectangular: false, 0, 0, 0, 0, 0)
		{
		}

		public override int getInterleavedBlockCount()
		{
			return 0;
		}

		public override int getDataLengthForInterleavedBlock(int index)
		{
			return 0;
		}
	}
}
