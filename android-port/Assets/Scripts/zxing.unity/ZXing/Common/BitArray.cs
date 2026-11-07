using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x2000066")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x21EE90", Offset = "0x21EE90")]
	public sealed class BitArray
	{
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x0")]
		private static int[] EMPTY_BITS;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x8")]
		private static float LOAD_FACTOR;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x10")]
		private int[] bits;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x18")]
		private int size;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] _lookup;

		[Token(Token = "0x17000054")]
		public int Size
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2EA5BB4", Offset = "0x2EA5BB4", VA = "0x2EA5BB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000055")]
		public int SizeInBytes
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2EA5BBC", Offset = "0x2EA5BBC", VA = "0x2EA5BBC")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000056")]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2EA5BCC", Offset = "0x2EA5BCC", VA = "0x2EA5BCC")]
		public bool get_Item(int i)
		{
			return default;
		}

		[Token(Token = "0x17000057")]
		public int[] Array
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2EA602C", Offset = "0x2EA602C", VA = "0x2EA602C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2EA5C14", Offset = "0x2EA5C14", VA = "0x2EA5C14")]
		public BitArray()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2EA5C98", Offset = "0x2EA5C98", VA = "0x2EA5C98")]
		public BitArray(int size)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2EA5DF4", Offset = "0x2EA5DF4", VA = "0x2EA5DF4")]
		private void ensureCapacity(int newSize)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2EA5F34", Offset = "0x2EA5F34", VA = "0x2EA5F34")]
		public void setBulk(int blockIndex, int newBits)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2EA5F70", Offset = "0x2EA5F70", VA = "0x2EA5F70")]
		public void clear()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2EA5FAC", Offset = "0x2EA5FAC", VA = "0x2EA5FAC")]
		public void appendBit(bool bit)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2EA58DC", Offset = "0x2EA58DC", VA = "0x2EA58DC")]
		public void appendBits(int value, int numBits)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2EA6034", Offset = "0x2EA6034", VA = "0x2EA6034")]
		public void appendBitArray(BitArray other)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2EA611C", Offset = "0x2EA611C", VA = "0x2EA611C")]
		public void xor(BitArray other)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2EA61FC", Offset = "0x2EA61FC", VA = "0x2EA61FC")]
		public void toBytes(int bitOffset, byte[] array, int offset, int numBytes)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2EA5D9C", Offset = "0x2EA5D9C", VA = "0x2EA5D9C")]
		private static int[] makeArray(int size)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2EA62B0", Offset = "0x2EA62B0", VA = "0x2EA62B0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2EA63B4", Offset = "0x2EA63B4", VA = "0x2EA63B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2EA644C", Offset = "0x2EA644C", VA = "0x2EA644C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
