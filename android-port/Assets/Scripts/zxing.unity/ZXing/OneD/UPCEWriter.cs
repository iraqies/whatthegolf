using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000051")]
	public class UPCEWriter : UPCEANWriter
	{
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000040")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x2ED6CB4", Offset = "0x2ED6CB4", VA = "0x2ED6CB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2ED6D18", Offset = "0x2ED6D18", VA = "0x2ED6D18", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2ED730C", Offset = "0x2ED730C", VA = "0x2ED730C")]
		public UPCEWriter()
		{
		}
	}
}
