namespace ZXing.Datamatrix.Encoder
{
	public class DefaultPlacement
	{
		private readonly string codewords;

		private readonly int numrows;

		private readonly int numcols;

		private readonly byte[] bits;

		public DefaultPlacement(string codewords, int numcols, int numrows)
		{
		}

		public bool getBit(int col, int row)
		{
			return false;
		}

		private void setBit(int col, int row, bool bit)
		{
		}

		private bool noBit(int col, int row)
		{
			return false;
		}

		public void place()
		{
		}

		private void module(int row, int col, int pos, int bit)
		{
		}

		private void utah(int row, int col, int pos)
		{
		}

		private void corner1(int pos)
		{
		}

		private void corner2(int pos)
		{
		}

		private void corner3(int pos)
		{
		}

		private void corner4(int pos)
		{
		}
	}
}
