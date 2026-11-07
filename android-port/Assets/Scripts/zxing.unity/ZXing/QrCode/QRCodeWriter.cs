using System.Collections.Generic;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace ZXing.QrCode
{
	public sealed class QRCodeWriter : Writer
	{
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		public static BitMatrix renderResult(QRCode code, int width, int height, int quietZone, bool noPadding)
		{
			return null;
		}
	}
}
