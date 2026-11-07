using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x200005C")]
	internal static class HighLevelEncoder
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2EBD9B8", Offset = "0x2EBD9B8", VA = "0x2EBD9B8")]
		private static char randomize253State(int codewordPosition)
		{
			return default;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2EBDA00", Offset = "0x2EBDA00", VA = "0x2EBDA00")]
		public static string encodeHighLevel(string msg, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, int defaultEncodation, bool forceC40, Encoding encoding, bool disableEci)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2EBE110", Offset = "0x2EBE110", VA = "0x2EBE110")]
		internal static int lookAheadTest(string msg, int startpos, int currentMode)
		{
			return default;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2EBE2C4", Offset = "0x2EBE2C4", VA = "0x2EBE2C4")]
		internal static int lookAheadTestIntern(string msg, int startpos, int currentMode)
		{
			return default;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2EBEDE8", Offset = "0x2EBEDE8", VA = "0x2EBEDE8")]
		private static int min(int f1, int f2, int f3, int f4, int f5)
		{
			return default;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2EBEEE8", Offset = "0x2EBEEE8", VA = "0x2EBEEE8")]
		private static int min(int f1, int f2, int f3, int f4)
		{
			return default;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2EBEBC0", Offset = "0x2EBEBC0", VA = "0x2EBEBC0")]
		private static int findMinimums(float[] charCounts, int[] intCharCounts, int min, byte[] mins)
		{
			return default;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2EBED18", Offset = "0x2EBED18", VA = "0x2EBED18")]
		private static int getMinimumCount(byte[] mins)
		{
			return default;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2EBED6C", Offset = "0x2EBED6C", VA = "0x2EBED6C")]
		internal static bool isDigit(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2EBED7C", Offset = "0x2EBED7C", VA = "0x2EBED7C")]
		internal static bool isExtendedASCII(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2EBED8C", Offset = "0x2EBED8C", VA = "0x2EBED8C")]
		internal static bool isNativeC40(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2EBEDB4", Offset = "0x2EBEDB4", VA = "0x2EBEDB4")]
		internal static bool isNativeText(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2EBEB64", Offset = "0x2EBEB64", VA = "0x2EBEB64")]
		internal static bool isNativeX12(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2EBEF8C", Offset = "0x2EBEF8C", VA = "0x2EBEF8C")]
		internal static bool isX12TermSep(char ch)
		{
			return default;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2EBEBB0", Offset = "0x2EBEBB0", VA = "0x2EBEBB0")]
		internal static bool isNativeEDIFACT(char ch)
		{
			return default;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2EBEDE0", Offset = "0x2EBEDE0", VA = "0x2EBEDE0")]
		internal static bool isSpecialB256(char ch)
		{
			return default;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2EBEFAC", Offset = "0x2EBEFAC", VA = "0x2EBEFAC")]
		public static int determineConsecutiveDigitCount(string msg, int startpos)
		{
			return default;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2EBF020", Offset = "0x2EBF020", VA = "0x2EBF020")]
		internal static void illegalCharacter(char c)
		{
		}
	}
}
