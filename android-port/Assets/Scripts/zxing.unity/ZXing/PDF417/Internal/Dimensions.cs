using Il2CppDummyDll;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x2000031")]
	public sealed class Dimensions
	{
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		private readonly int minCols;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x14")]
		private readonly int maxCols;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		private readonly int minRows;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int maxRows;

		[Token(Token = "0x1700002F")]
		public int MinCols
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2EB0EEC", Offset = "0x2EB0EEC", VA = "0x2EB0EEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000030")]
		public int MaxCols
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2EB0EF4", Offset = "0x2EB0EF4", VA = "0x2EB0EF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000031")]
		public int MinRows
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x2EB0EFC", Offset = "0x2EB0EFC", VA = "0x2EB0EFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000032")]
		public int MaxRows
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2EB0F04", Offset = "0x2EB0F04", VA = "0x2EB0F04")]
			get
			{
				return default;
			}
		}
	}
}
