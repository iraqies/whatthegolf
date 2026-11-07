namespace ZXing.QrCode.Internal
{
	public sealed class QRCode
	{
		public static int NUM_MASK_PATTERNS;

		public Mode Mode { get; set; }

		public ErrorCorrectionLevel ECLevel { get; set; }

		public Version Version { get; set; }

		public int MaskPattern { get; set; }

		public ByteMatrix Matrix { get; set; }

		public override string ToString()
		{
			return null;
		}

		public static bool isValidMaskPattern(int maskPattern)
		{
			return false;
		}
	}
}
