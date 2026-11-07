using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal static class HighLevelEncoder
	{
		private static char randomize253State(int codewordPosition)
		{
			return '\0';
		}

		public static string encodeHighLevel(string msg, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, int defaultEncodation, bool forceC40, Encoding encoding, bool disableEci)
		{
			return null;
		}

		internal static int lookAheadTest(string msg, int startpos, int currentMode)
		{
			return 0;
		}

		internal static int lookAheadTestIntern(string msg, int startpos, int currentMode)
		{
			return 0;
		}

		private static int min(int f1, int f2, int f3, int f4, int f5)
		{
			return 0;
		}

		private static int min(int f1, int f2, int f3, int f4)
		{
			return 0;
		}

		private static int findMinimums(float[] charCounts, int[] intCharCounts, int min, byte[] mins)
		{
			return 0;
		}

		private static int getMinimumCount(byte[] mins)
		{
			return 0;
		}

		internal static bool isDigit(char ch)
		{
			return false;
		}

		internal static bool isExtendedASCII(char ch)
		{
			return false;
		}

		internal static bool isNativeC40(char ch)
		{
			return false;
		}

		internal static bool isNativeText(char ch)
		{
			return false;
		}

		internal static bool isNativeX12(char ch)
		{
			return false;
		}

		internal static bool isX12TermSep(char ch)
		{
			return false;
		}

		internal static bool isNativeEDIFACT(char ch)
		{
			return false;
		}

		internal static bool isSpecialB256(char ch)
		{
			return false;
		}

		public static int determineConsecutiveDigitCount(string msg, int startpos)
		{
			return 0;
		}

		internal static void illegalCharacter(char c)
		{
		}
	}
}
