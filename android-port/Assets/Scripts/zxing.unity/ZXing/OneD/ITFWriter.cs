using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000047")]
	public sealed class ITFWriter : OneDimensionalCodeWriter
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] START_PATTERN;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] END_PATTERN;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x10")]
		internal static int[][] PATTERNS;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x1700003B")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2EBFAB4", Offset = "0x2EBFAB4", VA = "0x2EBFAB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2EBFB18", Offset = "0x2EBFB18", VA = "0x2EBFB18", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2EC01A0", Offset = "0x2EC01A0", VA = "0x2EC01A0")]
		public ITFWriter()
		{
		}
	}
}
