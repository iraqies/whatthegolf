using Il2CppDummyDll;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x2000033")]
	internal static class PDF417ErrorCorrection
	{
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[][] EC_COEFFICIENTS;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2ECC660", Offset = "0x2ECC660", VA = "0x2ECC660")]
		internal static int getErrorCorrectionCodewordCount(int errorCorrectionLevel)
		{
			return default;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2ECC5D4", Offset = "0x2ECC5D4", VA = "0x2ECC5D4")]
		internal static int getErrorCorrectionLevel(int errorCorrectionLevel, int sourceCodeWords)
		{
			return default;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2ECD348", Offset = "0x2ECD348", VA = "0x2ECD348")]
		internal static int getRecommendedMinimumErrorCorrectionLevel(int n)
		{
			return default;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2ECCB6C", Offset = "0x2ECCB6C", VA = "0x2ECCB6C")]
		internal static string generateErrorCorrection(string dataCodewords, int errorCorrectionLevel)
		{
			return null;
		}
	}
}
