using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class CodaBarWriter : OneDimensionalCodeWriter
	{
		private static readonly char[] START_END_CHARS;

		private static readonly char[] ALT_START_END_CHARS;

		private static readonly char[] CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED;

		private static readonly char DEFAULT_GUARD;

		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}
	}
}
