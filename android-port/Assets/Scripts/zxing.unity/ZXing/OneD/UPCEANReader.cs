namespace ZXing.OneD
{
	public abstract class UPCEANReader : OneDReader
	{
		private static readonly int MAX_AVG_VARIANCE;

		private static readonly int MAX_INDIVIDUAL_VARIANCE;

		internal static int[] START_END_PATTERN;

		internal static int[] MIDDLE_PATTERN;

		internal static int[] END_PATTERN;

		internal static int[][] L_PATTERNS;

		internal static int[][] L_AND_G_PATTERNS;

		static UPCEANReader()
		{
		}

		internal static bool checkStandardUPCEANChecksum(string s)
		{
			return false;
		}

		internal static int? getStandardUPCEANChecksum(string s)
		{
			return null;
		}
	}
}
