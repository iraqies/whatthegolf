using System.Collections.Generic;
using System.Text;
using ZXing.Aztec.Internal;
using ZXing.Common;

namespace ZXing.Aztec
{
	public sealed class AztecWriter : Writer
	{
		public static readonly Encoding DEFAULT_CHARSET;

		static AztecWriter()
		{
		}

		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		public BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, Encoding charset, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private static BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, Encoding charset, int eccPercent, int layers, bool disableEci, int margin)
		{
			return null;
		}

		private static BitMatrix renderResult(AztecCode code, int width, int height, int margin)
		{
			return null;
		}
	}
}
