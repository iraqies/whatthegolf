namespace ZXing.Common
{
	public sealed class BitArray
	{
		private static int[] EMPTY_BITS;

		private static float LOAD_FACTOR;

		private int[] bits;

		private int size;

		private static readonly int[] _lookup;

		public int Size => 0;

		public int SizeInBytes => 0;

		// C# has no syntax for parameterized property 'Item'.
		public bool get_Item(int i)
		{
			return false;
		}

		public int[] Array => null;

		public BitArray()
		{
		}

		public BitArray(int size)
		{
		}

		private void ensureCapacity(int newSize)
		{
		}

		public void setBulk(int blockIndex, int newBits)
		{
		}

		public void clear()
		{
		}

		public void appendBit(bool bit)
		{
		}

		public void appendBits(int value, int numBits)
		{
		}

		public void appendBitArray(BitArray other)
		{
		}

		public void xor(BitArray other)
		{
		}

		public void toBytes(int bitOffset, byte[] array, int offset, int numBytes)
		{
		}

		private static int[] makeArray(int size)
		{
			return null;
		}

		public override bool Equals(object o)
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
	}
}
