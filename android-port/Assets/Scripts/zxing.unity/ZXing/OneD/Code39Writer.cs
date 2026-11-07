using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class Code39Writer : OneDimensionalCodeWriter
	{
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}

		private static void toIntArray(int a, int[] toReturn)
		{
		}

		private static string tryToConvertToExtendedMode(string contents)
		{
			return null;
		}
	}
}
