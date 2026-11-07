using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class ITFWriter : OneDimensionalCodeWriter
	{
		private static readonly int[] START_PATTERN;

		private static readonly int[] END_PATTERN;

		internal static int[][] PATTERNS;

		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}
	}
}
