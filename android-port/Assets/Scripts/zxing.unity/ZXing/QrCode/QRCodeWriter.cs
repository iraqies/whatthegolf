using System.Collections.Generic;
using Il2CppDummyDll;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace ZXing.QrCode
{
	[Token(Token = "0x2000019")]
	public sealed class QRCodeWriter : Writer
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2ED199C", Offset = "0x2ED199C", VA = "0x2ED199C", Slot = "4")]
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2ED1E80", Offset = "0x2ED1E80", VA = "0x2ED1E80")]
		public static BitMatrix renderResult(QRCode code, int width, int height, int quietZone, bool noPadding)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2ED20C0", Offset = "0x2ED20C0", VA = "0x2ED20C0")]
		public QRCodeWriter()
		{
		}
	}
}
