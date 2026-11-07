using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x2000024")]
	public static class MatrixUtil
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[][] POSITION_DETECTION_PATTERN;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[][] TYPE_INFO_COORDINATES;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2EC1DF0", Offset = "0x2EC1DF0", VA = "0x2EC1DF0")]
		public static void clearMatrix(ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2EC1E0C", Offset = "0x2EC1E0C", VA = "0x2EC1E0C")]
		public static void buildMatrix(BitArray dataBits, ErrorCorrectionLevel ecLevel, Version version, int maskPattern, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2EC1EDC", Offset = "0x2EC1EDC", VA = "0x2EC1EDC")]
		public static void embedBasicPatterns(Version version, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2EC1F64", Offset = "0x2EC1F64", VA = "0x2EC1F64")]
		public static void embedTypeInfo(ErrorCorrectionLevel ecLevel, int maskPattern, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2EC2110", Offset = "0x2EC2110", VA = "0x2EC2110")]
		public static void maybeEmbedVersionInfo(Version version, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2EC2244", Offset = "0x2EC2244", VA = "0x2EC2244")]
		public static void embedDataBits(BitArray dataBits, int maskPattern, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2EC2CE0", Offset = "0x2EC2CE0", VA = "0x2EC2CE0")]
		public static int findMSBSet(int value_Renamed)
		{
			return default;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2EC2CF8", Offset = "0x2EC2CF8", VA = "0x2EC2CF8")]
		public static int calculateBCHCode(int value, int poly)
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2EC2978", Offset = "0x2EC2978", VA = "0x2EC2978")]
		public static void makeTypeInfoBits(ErrorCorrectionLevel ecLevel, int maskPattern, BitArray bits)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2EC2B94", Offset = "0x2EC2B94", VA = "0x2EC2B94")]
		public static void makeVersionInfoBits(Version version, BitArray bits)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2EC2CD4", Offset = "0x2EC2CD4", VA = "0x2EC2CD4")]
		private static bool isEmpty(int value)
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2EC282C", Offset = "0x2EC282C", VA = "0x2EC282C")]
		private static void embedTimingPatterns(ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2EC25EC", Offset = "0x2EC25EC", VA = "0x2EC25EC")]
		private static void embedDarkDotAtLeftBottomCorner(ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2EC2E38", Offset = "0x2EC2E38", VA = "0x2EC2E38")]
		private static void embedHorizontalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2EC2F38", Offset = "0x2EC2F38", VA = "0x2EC2F38")]
		private static void embedVerticalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2EC3038", Offset = "0x2EC3038", VA = "0x2EC3038")]
		private static void embedPositionAdjustmentPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2EC313C", Offset = "0x2EC313C", VA = "0x2EC313C")]
		private static void embedPositionDetectionPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2EC24AC", Offset = "0x2EC24AC", VA = "0x2EC24AC")]
		private static void embedPositionDetectionPatternsAndSeparators(ByteMatrix matrix)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2EC2674", Offset = "0x2EC2674", VA = "0x2EC2674")]
		private static void maybeEmbedPositionAdjustmentPatterns(Version version, ByteMatrix matrix)
		{
		}
	}
}
