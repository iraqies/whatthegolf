using System;
using System.Collections.Generic;
using ZXing.Common;

namespace ZXing
{
	public sealed class MultiFormatWriter : Writer
	{
		private static readonly IDictionary<BarcodeFormat, Func<Writer>> formatMap;

		static MultiFormatWriter()
		{
		}

		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}
	}
}
