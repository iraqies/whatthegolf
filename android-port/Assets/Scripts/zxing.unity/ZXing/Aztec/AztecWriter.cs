using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ZXing.Aztec.Internal;
using ZXing.Common;

namespace ZXing.Aztec
{
	[Token(Token = "0x2000073")]
	public sealed class AztecWriter : Writer
	{
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Encoding DEFAULT_CHARSET;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2E9E008", Offset = "0x2E9E008", VA = "0x2E9E008")]
		static AztecWriter()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2E9E07C", Offset = "0x2E9E07C", VA = "0x2E9E07C", Slot = "4")]
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2E9E15C", Offset = "0x2E9E15C", VA = "0x2E9E15C")]
		public BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2E9E1BC", Offset = "0x2E9E1BC", VA = "0x2E9E1BC")]
		private BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, Encoding charset, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2E9E7CC", Offset = "0x2E9E7CC", VA = "0x2E9E7CC")]
		private static BitMatrix encode(byte[] contents, BarcodeFormat format, int width, int height, Encoding charset, int eccPercent, int layers, bool disableEci, int margin)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2E9F4C4", Offset = "0x2E9F4C4", VA = "0x2E9F4C4")]
		private static BitMatrix renderResult(AztecCode code, int width, int height, int margin)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2E9F958", Offset = "0x2E9F958", VA = "0x2E9F958")]
		public AztecWriter()
		{
		}
	}
}
