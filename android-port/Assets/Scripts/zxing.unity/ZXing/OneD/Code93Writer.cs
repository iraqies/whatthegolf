using System.Collections.Generic;

namespace ZXing.OneD
{
	public class Code93Writer : OneDimensionalCodeWriter
	{
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}

		private static int appendPattern(bool[] target, int pos, int a)
		{
			return 0;
		}

		private static int computeChecksumIndex(string contents, int maxWeight)
		{
			return 0;
		}

		internal static string convertToExtended(string contents)
		{
			return null;
		}
	}
}
