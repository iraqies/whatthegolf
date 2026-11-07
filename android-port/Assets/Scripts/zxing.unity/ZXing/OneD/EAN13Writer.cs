using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class EAN13Writer : UPCEANWriter
	{
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}
	}
}
