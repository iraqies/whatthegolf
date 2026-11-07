using System.Text;
using Il2CppDummyDll;
using ZXing.Common;
using ZXing.Common.ReedSolomon;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x2000076")]
	public static class Encoder
	{
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] WORD_SIZE;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2E9E97C", Offset = "0x2E9E97C", VA = "0x2E9E97C")]
		public static AztecCode encode(byte[] data, int minECCPercent, int userSpecifiedLayers, Encoding encoding, bool disableEci)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2EB465C", Offset = "0x2EB465C", VA = "0x2EB465C")]
		private static void drawBullsEye(BitMatrix matrix, int center, int size)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2EB3FE8", Offset = "0x2EB3FE8", VA = "0x2EB3FE8")]
		internal static BitArray generateModeMessage(bool compact, int layers, int messageSizeInWords)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2EB431C", Offset = "0x2EB431C", VA = "0x2EB431C")]
		private static void drawModeMessage(BitMatrix matrix, bool compact, int matrixSize, BitArray modeMessage)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2EB3DC4", Offset = "0x2EB3DC4", VA = "0x2EB3DC4")]
		private static BitArray generateCheckWords(BitArray bitArray, int totalBits, int wordSize)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2EB4A20", Offset = "0x2EB4A20", VA = "0x2EB4A20")]
		private static int[] bitsToWords(BitArray stuffedBits, int wordSize, int totalWords)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2EB4848", Offset = "0x2EB4848", VA = "0x2EB4848")]
		private static GenericGF getGF(int wordSize)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2EB3C04", Offset = "0x2EB3C04", VA = "0x2EB3C04")]
		internal static BitArray stuffBits(BitArray bits, int wordSize)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2EB3BE8", Offset = "0x2EB3BE8", VA = "0x2EB3BE8")]
		private static int TotalBitsInLayer(int layers, bool compact)
		{
			return default;
		}
	}
}
