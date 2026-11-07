using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000045")]
	public sealed class EAN13Writer : UPCEANWriter
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000039")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2EB0FA4", Offset = "0x2EB0FA4", VA = "0x2EB0FA4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2EB1008", Offset = "0x2EB1008", VA = "0x2EB1008", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2EB164C", Offset = "0x2EB164C", VA = "0x2EB164C")]
		public EAN13Writer()
		{
		}
	}
}
