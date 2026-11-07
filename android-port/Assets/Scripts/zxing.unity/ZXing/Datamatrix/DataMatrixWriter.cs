using System.Collections.Generic;
using Il2CppDummyDll;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode.Internal;

namespace ZXing.Datamatrix
{
	[Token(Token = "0x2000052")]
	public sealed class DataMatrixWriter : Writer
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2EAF770", Offset = "0x2EAF770", VA = "0x2EAF770", Slot = "4")]
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2EB02BC", Offset = "0x2EB02BC", VA = "0x2EB02BC")]
		private static BitMatrix encodeLowLevel(DefaultPlacement placement, SymbolInfo symbolInfo, int width, int height, int margin, bool noPadding)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2EB0684", Offset = "0x2EB0684", VA = "0x2EB0684")]
		private static BitMatrix convertByteMatrixToBitMatrix(ByteMatrix matrix, int reqWidth, int reqHeight, int margin, bool noPadding)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2EB0878", Offset = "0x2EB0878", VA = "0x2EB0878")]
		public DataMatrixWriter()
		{
		}
	}
}
