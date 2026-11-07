using System.Collections.Generic;
using ZXing.Common;

namespace ZXing.OneD
{
	public class UPCAWriter : Writer
	{
		private readonly EAN13Writer subWriter;

		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}
	}
}
