using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class PlesseyWriter : OneDimensionalCodeWriter
	{
		private static readonly int[] startWidths;

		private static readonly int[] terminationWidths;

		private static readonly int[] endWidths;

		private static readonly int[][] numberWidths;

		private static readonly byte[] crcGrid;

		private static readonly int[] crc0Widths;

		private static readonly int[] crc1Widths;

		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}
	}
}
