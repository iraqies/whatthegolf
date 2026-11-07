using System.Collections.Generic;
using System.Text;
using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	public static class Encoder
	{
		private static readonly int[] ALPHANUMERIC_TABLE;

		internal static Encoding DEFAULT_BYTE_MODE_ENCODING;

		private static int calculateMaskPenalty(ByteMatrix matrix)
		{
			return 0;
		}

		public static QRCode encode(string content, ErrorCorrectionLevel ecLevel, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private static Version recommendVersion(ErrorCorrectionLevel ecLevel, Mode mode, BitArray headerBits, BitArray dataBits)
		{
			return null;
		}

		private static int calculateBitsNeeded(Mode mode, BitArray headerBits, BitArray dataBits, Version version)
		{
			return 0;
		}

		internal static int getAlphanumericCode(int code)
		{
			return 0;
		}

		private static Mode chooseMode(string content, Encoding encoding)
		{
			return null;
		}

		internal static bool isOnlyDoubleByteKanji(string content)
		{
			return false;
		}

		private static int chooseMaskPattern(BitArray bits, ErrorCorrectionLevel ecLevel, Version version, ByteMatrix matrix)
		{
			return 0;
		}

		private static Version chooseVersion(int numInputBits, ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		internal static bool willFit(int numInputBits, Version version, ErrorCorrectionLevel ecLevel)
		{
			return false;
		}

		internal static void terminateBits(int numDataBytes, BitArray bits)
		{
		}

		internal static void getNumDataBytesAndNumECBytesForBlockID(int numTotalBytes, int numDataBytes, int numRSBlocks, int blockID, int[] numDataBytesInBlock, int[] numECBytesInBlock)
		{
		}

		internal static BitArray interleaveWithECBytes(BitArray bits, int numTotalBytes, int numDataBytes, int numRSBlocks)
		{
			return null;
		}

		internal static byte[] generateECBytes(byte[] dataBytes, int numEcBytesInBlock)
		{
			return null;
		}

		internal static void appendModeInfo(Mode mode, BitArray bits)
		{
		}

		internal static void appendLengthInfo(int numLetters, Version version, Mode mode, BitArray bits)
		{
		}

		internal static void appendBytes(string content, Mode mode, BitArray bits, Encoding encoding)
		{
		}

		internal static void appendNumericBytes(string content, BitArray bits)
		{
		}

		internal static void appendAlphanumericBytes(string content, BitArray bits)
		{
		}

		internal static void append8BitBytes(string content, BitArray bits, Encoding encoding)
		{
		}

		internal static void appendKanjiBytes(string content, BitArray bits)
		{
		}

		private static void appendECI(CharacterSetECI eci, BitArray bits)
		{
		}
	}
}
