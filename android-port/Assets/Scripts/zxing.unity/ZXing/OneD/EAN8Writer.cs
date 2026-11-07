using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000046")]
	public sealed class EAN8Writer : UPCEANWriter
	{
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x1700003A")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2EB1710", Offset = "0x2EB1710", VA = "0x2EB1710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2EB1774", Offset = "0x2EB1774", VA = "0x2EB1774", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2EB1D2C", Offset = "0x2EB1D2C", VA = "0x2EB1D2C")]
		public EAN8Writer()
		{
		}
	}
}
