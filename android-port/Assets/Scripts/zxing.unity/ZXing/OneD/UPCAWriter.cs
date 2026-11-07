using System.Collections.Generic;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.OneD
{
	[Token(Token = "0x200004D")]
	public class UPCAWriter : Writer
	{
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x10")]
		private readonly EAN13Writer subWriter;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2ED5D30", Offset = "0x2ED5D30", VA = "0x2ED5D30", Slot = "4")]
		public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2ED5E7C", Offset = "0x2ED5E7C", VA = "0x2ED5E7C")]
		public UPCAWriter()
		{
		}
	}
}
