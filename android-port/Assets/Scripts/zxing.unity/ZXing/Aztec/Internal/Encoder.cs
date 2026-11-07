using System.Text;
using ZXing.Common;
using ZXing.Common.ReedSolomon;

namespace ZXing.Aztec.Internal
{
	public static class Encoder
	{
		private static readonly int[] WORD_SIZE;

		public static AztecCode encode(byte[] data, int minECCPercent, int userSpecifiedLayers, Encoding encoding, bool disableEci)
		{
			return null;
		}

		private static void drawBullsEye(BitMatrix matrix, int center, int size)
		{
		}

		internal static BitArray generateModeMessage(bool compact, int layers, int messageSizeInWords)
		{
			return null;
		}

		private static void drawModeMessage(BitMatrix matrix, bool compact, int matrixSize, BitArray modeMessage)
		{
		}

		private static BitArray generateCheckWords(BitArray bitArray, int totalBits, int wordSize)
		{
			return null;
		}

		private static int[] bitsToWords(BitArray stuffedBits, int wordSize, int totalWords)
		{
			return null;
		}

		private static GenericGF getGF(int wordSize)
		{
			return null;
		}

		internal static BitArray stuffBits(BitArray bits, int wordSize)
		{
			return null;
		}

		private static int TotalBitsInLayer(int layers, bool compact)
		{
			return 0;
		}
	}
}
