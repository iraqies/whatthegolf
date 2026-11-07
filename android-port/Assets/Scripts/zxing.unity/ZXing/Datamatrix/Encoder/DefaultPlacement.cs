using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000057")]
	public class DefaultPlacement
	{
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x10")]
		private readonly string codewords;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x18")]
		private readonly int numrows;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int numcols;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[] bits;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2EAFF60", Offset = "0x2EAFF60", VA = "0x2EAFF60")]
		public DefaultPlacement(string codewords, int numcols, int numrows)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2EB0638", Offset = "0x2EB0638", VA = "0x2EB0638")]
		public bool getBit(int col, int row)
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2EB0880", Offset = "0x2EB0880", VA = "0x2EB0880")]
		private void setBit(int col, int row, bool bit)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2EB08C4", Offset = "0x2EB08C4", VA = "0x2EB08C4")]
		private bool noBit(int col, int row)
		{
			return default;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2EB0008", Offset = "0x2EB0008", VA = "0x2EB0008")]
		public void place()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2EB0DF4", Offset = "0x2EB0DF4", VA = "0x2EB0DF4")]
		private void module(int row, int col, int pos, int bit)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2EB0CF0", Offset = "0x2EB0CF0", VA = "0x2EB0CF0")]
		private void utah(int row, int col, int pos)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2EB0910", Offset = "0x2EB0910", VA = "0x2EB0910")]
		private void corner1(int pos)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2EB0A08", Offset = "0x2EB0A08", VA = "0x2EB0A08")]
		private void corner2(int pos)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2EB0B00", Offset = "0x2EB0B00", VA = "0x2EB0B00")]
		private void corner3(int pos)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2EB0BF8", Offset = "0x2EB0BF8", VA = "0x2EB0BF8")]
		private void corner4(int pos)
		{
		}
	}
}
