namespace ZXing.QrCode.Internal
{
	public static class MaskUtil
	{
		public static int applyMaskPenaltyRule1(ByteMatrix matrix)
		{
			return 0;
		}

		public static int applyMaskPenaltyRule2(ByteMatrix matrix)
		{
			return 0;
		}

		public static int applyMaskPenaltyRule3(ByteMatrix matrix)
		{
			return 0;
		}

		private static bool isWhiteHorizontal(byte[] rowArray, int from, int to)
		{
			return false;
		}

		private static bool isWhiteVertical(byte[][] array, int col, int from, int to)
		{
			return false;
		}

		public static int applyMaskPenaltyRule4(ByteMatrix matrix)
		{
			return 0;
		}

		public static bool getDataMaskBit(int maskPattern, int x, int y)
		{
			return false;
		}

		private static int applyMaskPenaltyRule1Internal(ByteMatrix matrix, bool isHorizontal)
		{
			return 0;
		}
	}
}
