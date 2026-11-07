namespace ZXing.Common
{
	public sealed class BitMatrix
	{
		private int width;

		private int height;

		private int rowSize;

		private int[] bits;

		public int Width => 0;

		public int Height => 0;

		// C# has no syntax for parameterized property 'Item'.
		public bool get_Item(int x, int y)
		{
			return false;
		}

		public void set_Item(int x, int y, bool value)
		{
		}

		public BitMatrix(int dimension)
		{
		}

		public BitMatrix(int width, int height)
		{
		}

		public void setRegion(int left, int top, int width, int height)
		{
		}

		public BitArray getRow(int y, BitArray row)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string setString, string unsetString, string lineSeparator)
		{
			return null;
		}

		private string buildToString(string setString, string unsetString, string lineSeparator)
		{
			return null;
		}
	}
}
