namespace ZXing.QrCode.Internal
{
	public sealed class ErrorCorrectionLevel
	{
		public static readonly ErrorCorrectionLevel L;

		public static readonly ErrorCorrectionLevel M;

		public static readonly ErrorCorrectionLevel Q;

		public static readonly ErrorCorrectionLevel H;

		private static readonly ErrorCorrectionLevel[] FOR_BITS;

		private readonly int bits;

		private readonly int ordinal_Renamed_Field;

		private readonly string name;

		public int Bits => 0;

		private ErrorCorrectionLevel(int ordinal, int bits, string name)
		{
		}

		public int ordinal()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
