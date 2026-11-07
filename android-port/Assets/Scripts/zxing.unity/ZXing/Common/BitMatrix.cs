using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x2000067")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x21EEC8", Offset = "0x21EEC8")]
	public sealed class BitMatrix
	{
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		private int width;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x14")]
		private int height;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x18")]
		private int rowSize;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x20")]
		private int[] bits;

		[Token(Token = "0x17000058")]
		public int Width
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2EA6624", Offset = "0x2EA6624", VA = "0x2EA6624")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000059")]
		public int Height
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2EA662C", Offset = "0x2EA662C", VA = "0x2EA662C")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700005A")]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2E9F7B0", Offset = "0x2E9F7B0", VA = "0x2E9F7B0")]
		public bool get_Item(int x, int y)
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2EA663C", Offset = "0x2EA663C", VA = "0x2EA663C")]
		public void set_Item(int x, int y, bool value)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2EA6634", Offset = "0x2EA6634", VA = "0x2EA6634")]
		public BitMatrix(int dimension)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2E9F6D8", Offset = "0x2E9F6D8", VA = "0x2E9F6D8")]
		public BitMatrix(int width, int height)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2E9F800", Offset = "0x2E9F800", VA = "0x2E9F800")]
		public void setRegion(int left, int top, int width, int height)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2EA66D8", Offset = "0x2EA66D8", VA = "0x2EA66D8")]
		public BitArray getRow(int y, BitArray row)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2EA6804", Offset = "0x2EA6804", VA = "0x2EA6804", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2EA6910", Offset = "0x2EA6910", VA = "0x2EA6910", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2EA69BC", Offset = "0x2EA69BC", VA = "0x2EA69BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2EA6A34", Offset = "0x2EA6A34", VA = "0x2EA6A34")]
		public string ToString(string setString, string unsetString, string lineSeparator)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2EA6A38", Offset = "0x2EA6A38", VA = "0x2EA6A38")]
		private string buildToString(string setString, string unsetString, string lineSeparator)
		{
			return null;
		}
	}
}
