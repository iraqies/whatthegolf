using System.Collections.Generic;
using ZXing.Common;
using ZXing.PDF417.Internal;

namespace ZXing.PDF417
{
	public sealed class PDF417Writer : Writer
	{
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private static BitMatrix bitMatrixFromEncoder(ZXing.PDF417.Internal.PDF417 encoder, string contents, int errorCorrectionLevel, int width, int height, int margin, int aspectRatio, bool autoECI)
		{
			return null;
		}

		private static BitMatrix bitMatrixFromBitArray(sbyte[][] input, int margin)
		{
			return null;
		}

		private static sbyte[][] rotateArray(sbyte[][] bitarray)
		{
			return null;
		}
	}
}
