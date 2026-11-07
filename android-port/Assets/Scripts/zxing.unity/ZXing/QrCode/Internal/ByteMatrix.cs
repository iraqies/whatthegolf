namespace ZXing.QrCode.Internal
{
	public sealed class ByteMatrix
	{
		private readonly byte[][] bytes;

		private readonly int width;

		private readonly int height;

		public int Height => 0;

		public int Width => 0;

		// C# has no syntax for parameterized property 'Item'.
		public int get_Item(int x, int y)
		{
			return 0;
		}

		public void set_Item(int x, int y, int value)
		{
		}

		public byte[][] Array => null;

		public ByteMatrix(int width, int height)
		{
		}

		public void set(int x, int y, bool value)
		{
		}

		public void clear(byte value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
