using System.Collections.Generic;

namespace ZXing.OneD
{
	internal sealed class MinimalEncoder
	{
		private enum Charset
		{
			A = 0,
			B = 1,
			C = 2,
			NONE = 3
		}

		private enum Latch
		{
			A = 0,
			B = 1,
			C = 2,
			SHIFT = 3,
			NONE = 4
		}

		private static string A;

		private static string B;

		private static int CODE_SHIFT;

		private int[][] memoizedCost;

		private Latch[][] minPath;

		public bool[] encode(string contents)
		{
			return null;
		}

		private static void addPattern(List<int[]> patterns, int patternIndex, int[] checkSum, int[] checkWeight, int position)
		{
		}

		private static bool isDigit(char c)
		{
			return false;
		}

		private bool canEncode(string contents, Charset charset, int position)
		{
			return false;
		}

		private int encode(string contents, Charset charset, int position)
		{
			return 0;
		}
	}
}
