using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000039")]
	public sealed class CodaBarWriter : OneDimensionalCodeWriter
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] START_END_CHARS;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] ALT_START_END_CHARS;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly char[] CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x18")]
		private static readonly char DEFAULT_GUARD;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000035")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2EA9A38", Offset = "0x2EA9A38", VA = "0x2EA9A38", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2EA9A9C", Offset = "0x2EA9A9C", VA = "0x2EA9A9C", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2EAA214", Offset = "0x2EAA214", VA = "0x2EAA214")]
		public CodaBarWriter()
		{
		}
	}
}
