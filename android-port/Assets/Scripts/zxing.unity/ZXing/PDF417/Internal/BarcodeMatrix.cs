namespace ZXing.PDF417.Internal
{
	internal sealed class BarcodeMatrix
	{
		private readonly BarcodeRow[] matrix;

		private int currentRow;

		private readonly int height;

		private readonly int width;

		internal BarcodeMatrix(int height, int width, bool compact)
		{
		}

		internal void startRow()
		{
		}

		internal BarcodeRow getCurrentRow()
		{
			return null;
		}

		internal sbyte[][] getScaledMatrix(int xScale, int yScale)
		{
			return null;
		}
	}
}
