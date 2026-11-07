using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x2000022")]
	public static class Encoder
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] ALPHANUMERIC_TABLE;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x8")]
		internal static Encoding DEFAULT_BYTE_MODE_ENCODING;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2EB4BE0", Offset = "0x2EB4BE0", VA = "0x2EB4BE0")]
		private static int calculateMaskPenalty(ByteMatrix matrix)
		{
			return default;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2EB4C48", Offset = "0x2EB4C48", VA = "0x2EB4C48")]
		public static QRCode encode(string content, ErrorCorrectionLevel ecLevel, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2EB5F9C", Offset = "0x2EB5F9C", VA = "0x2EB5F9C")]
		private static Version recommendVersion(ErrorCorrectionLevel ecLevel, Mode mode, BitArray headerBits, BitArray dataBits)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2EB5EF4", Offset = "0x2EB5EF4", VA = "0x2EB5EF4")]
		private static int calculateBitsNeeded(Mode mode, BitArray headerBits, BitArray dataBits, Version version)
		{
			return default;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2EB7000", Offset = "0x2EB7000", VA = "0x2EB7000")]
		internal static int getAlphanumericCode(int code)
		{
			return default;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2EB5798", Offset = "0x2EB5798", VA = "0x2EB5798")]
		private static Mode chooseMode(string content, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2EB70D0", Offset = "0x2EB70D0", VA = "0x2EB70D0")]
		internal static bool isOnlyDoubleByteKanji(string content)
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2EB6D20", Offset = "0x2EB6D20", VA = "0x2EB6D20")]
		private static int chooseMaskPattern(BitArray bits, ErrorCorrectionLevel ecLevel, Version version, ByteMatrix matrix)
		{
			return default;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2EB6EA8", Offset = "0x2EB6EA8", VA = "0x2EB6EA8")]
		private static Version chooseVersion(int numInputBits, ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2EB5F3C", Offset = "0x2EB5F3C", VA = "0x2EB5F3C")]
		internal static bool willFit(int numInputBits, Version version, ErrorCorrectionLevel ecLevel)
		{
			return default;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2EB618C", Offset = "0x2EB618C", VA = "0x2EB618C")]
		internal static void terminateBits(int numDataBytes, BitArray bits)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2EB7274", Offset = "0x2EB7274", VA = "0x2EB7274")]
		internal static void getNumDataBytesAndNumECBytesForBlockID(int numTotalBytes, int numDataBytes, int numRSBlocks, int blockID, int[] numDataBytesInBlock, int[] numECBytesInBlock)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2EB6408", Offset = "0x2EB6408", VA = "0x2EB6408")]
		internal static BitArray interleaveWithECBytes(BitArray bits, int numTotalBytes, int numDataBytes, int numRSBlocks)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2EB7374", Offset = "0x2EB7374", VA = "0x2EB7374")]
		internal static byte[] generateECBytes(byte[] dataBytes, int numEcBytesInBlock)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2EB5B90", Offset = "0x2EB5B90", VA = "0x2EB5B90")]
		internal static void appendModeInfo(Mode mode, BitArray bits)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2EB60AC", Offset = "0x2EB60AC", VA = "0x2EB60AC")]
		internal static void appendLengthInfo(int numLetters, Version version, Mode mode, BitArray bits)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2EB5C48", Offset = "0x2EB5C48", VA = "0x2EB5C48")]
		internal static void appendBytes(string content, Mode mode, BitArray bits, Encoding encoding)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2EB753C", Offset = "0x2EB753C", VA = "0x2EB753C")]
		internal static void appendNumericBytes(string content, BitArray bits)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2EB7798", Offset = "0x2EB7798", VA = "0x2EB7798")]
		internal static void appendAlphanumericBytes(string content, BitArray bits)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2EB79FC", Offset = "0x2EB79FC", VA = "0x2EB79FC")]
		internal static void append8BitBytes(string content, BitArray bits, Encoding encoding)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2EB7B1C", Offset = "0x2EB7B1C", VA = "0x2EB7B1C")]
		internal static void appendKanjiBytes(string content, BitArray bits)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2EB59F8", Offset = "0x2EB59F8", VA = "0x2EB59F8")]
		private static void appendECI(CharacterSetECI eci, BitArray bits)
		{
		}
	}
}
