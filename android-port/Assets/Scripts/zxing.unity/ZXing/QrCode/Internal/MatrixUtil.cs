using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	public static class MatrixUtil
	{
		private static readonly int[][] POSITION_DETECTION_PATTERN;

		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN;

		private static readonly int[][] POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE;

		private static readonly int[][] TYPE_INFO_COORDINATES;

		public static void clearMatrix(ByteMatrix matrix)
		{
		}

		public static void buildMatrix(BitArray dataBits, ErrorCorrectionLevel ecLevel, Version version, int maskPattern, ByteMatrix matrix)
		{
		}

		public static void embedBasicPatterns(Version version, ByteMatrix matrix)
		{
		}

		public static void embedTypeInfo(ErrorCorrectionLevel ecLevel, int maskPattern, ByteMatrix matrix)
		{
		}

		public static void maybeEmbedVersionInfo(Version version, ByteMatrix matrix)
		{
		}

		public static void embedDataBits(BitArray dataBits, int maskPattern, ByteMatrix matrix)
		{
		}

		public static int findMSBSet(int value_Renamed)
		{
			return 0;
		}

		public static int calculateBCHCode(int value, int poly)
		{
			return 0;
		}

		public static void makeTypeInfoBits(ErrorCorrectionLevel ecLevel, int maskPattern, BitArray bits)
		{
		}

		public static void makeVersionInfoBits(Version version, BitArray bits)
		{
		}

		private static bool isEmpty(int value)
		{
			return false;
		}

		private static void embedTimingPatterns(ByteMatrix matrix)
		{
		}

		private static void embedDarkDotAtLeftBottomCorner(ByteMatrix matrix)
		{
		}

		private static void embedHorizontalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		private static void embedVerticalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		private static void embedPositionAdjustmentPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		private static void embedPositionDetectionPattern(int xStart, int yStart, ByteMatrix matrix)
		{
		}

		private static void embedPositionDetectionPatternsAndSeparators(ByteMatrix matrix)
		{
		}

		private static void maybeEmbedPositionAdjustmentPatterns(Version version, ByteMatrix matrix)
		{
		}
	}
}
