using System.Collections.Generic;
using Il2CppDummyDll;
using ZXing.Common;
using ZXing.PDF417.Internal;

namespace ZXing.PDF417
{
	[Token(Token = "0x200002C")]
	public sealed class PDF417Writer : Writer
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2ECFFE0", Offset = "0x2ECFFE0", VA = "0x2ECFFE0", Slot = "4")]
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2ED0338", Offset = "0x2ED0338", VA = "0x2ED0338")]
		private static BitMatrix bitMatrixFromEncoder(ZXing.PDF417.Internal.PDF417 encoder, string contents, int errorCorrectionLevel, int width, int height, int margin, int aspectRatio, bool autoECI)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2ED0640", Offset = "0x2ED0640", VA = "0x2ED0640")]
		private static BitMatrix bitMatrixFromBitArray(sbyte[][] input, int margin)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2ED046C", Offset = "0x2ED046C", VA = "0x2ED046C")]
		private static sbyte[][] rotateArray(sbyte[][] bitarray)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2ED07A4", Offset = "0x2ED07A4", VA = "0x2ED07A4")]
		public PDF417Writer()
		{
		}
	}
}
