using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x200005B")]
	public static class ErrorCorrection
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] FACTOR_SETS;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[][] FACTORS;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] LOG;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] ALOG;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2EB8B9C", Offset = "0x2EB8B9C", VA = "0x2EB8B9C")]
		static ErrorCorrection()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2EB9294", Offset = "0x2EB9294", VA = "0x2EB9294")]
		public static string encodeECC200(string codewords, SymbolInfo symbolInfo)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2EB964C", Offset = "0x2EB964C", VA = "0x2EB964C")]
		private static string createECCBlock(string codewords, int numECWords)
		{
			return null;
		}
	}
}
