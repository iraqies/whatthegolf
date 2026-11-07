using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000047")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182D78", Offset = "0x182D78")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182D78", Offset = "0x182D78")]
	internal struct DateTimeParser
	{
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x0")]
		public int Year;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x4")]
		public int Month;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x8")]
		public int Day;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xC")]
		public int Hour;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x10")]
		public int Minute;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x14")]
		public int Second;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x18")]
		public int Fraction;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x28")]
		private char[] _text;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x30")]
		private int _end;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] Power10;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int Lzyyyy_MM_dd;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int Lzyyyy_MM_ddT;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int LzHH;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int LzHH_mm_;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int LzHH_mm_ss;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Lz_;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x22B5290", Offset = "0x22B5290", VA = "0x22B5290")]
		static DateTimeParser()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x22B5508", Offset = "0x22B5508", VA = "0x22B5508")]
		public bool Parse(char[] text, int startIndex, int length)
		{
			return default;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x22B5648", Offset = "0x22B5648", VA = "0x22B5648")]
		private bool ParseDate(int start)
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x22B58B4", Offset = "0x22B58B4", VA = "0x22B58B4")]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return default;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x22B5A54", Offset = "0x22B5A54", VA = "0x22B5A54")]
		private bool ParseTime(ref int start)
		{
			return default;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x22B5D50", Offset = "0x22B5D50", VA = "0x22B5D50")]
		private bool ParseZone(int start)
		{
			return default;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x22B5900", Offset = "0x22B5900", VA = "0x22B5900")]
		private bool Parse4Digit(int start, out int num)
		{
			return default;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x22B59C8", Offset = "0x22B59C8", VA = "0x22B59C8")]
		private bool Parse2Digit(int start, out int num)
		{
			return default;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x22B5858", Offset = "0x22B5858", VA = "0x22B5858")]
		private bool ParseChar(int start, char ch)
		{
			return default;
		}
	}
}
