using System.Collections.Generic;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode.Internal;

namespace ZXing.Datamatrix
{
	public sealed class DataMatrixWriter : Writer
	{
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private static BitMatrix encodeLowLevel(DefaultPlacement placement, SymbolInfo symbolInfo, int width, int height, int margin, bool noPadding)
		{
			return null;
		}

		private static BitMatrix convertByteMatrixToBitMatrix(ByteMatrix matrix, int reqWidth, int reqHeight, int margin, bool noPadding)
		{
			return null;
		}
	}
}
