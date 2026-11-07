using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000049")]
	public sealed class MSIWriter : OneDimensionalCodeWriter
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] startWidths;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] endWidths;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[][] numberWidths;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x1700003C")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2EC0860", Offset = "0x2EC0860", VA = "0x2EC0860", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2EC08C4", Offset = "0x2EC08C4", VA = "0x2EC08C4", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2EC0C30", Offset = "0x2EC0C30", VA = "0x2EC0C30")]
		public MSIWriter()
		{
		}
	}
}
