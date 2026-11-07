using System.Collections.Generic;

namespace ZXing.OneD
{
	public sealed class Code128Writer : OneDimensionalCodeWriter
	{
		private enum CType
		{
			UNCODABLE = 0,
			ONE_DIGIT = 1,
			TWO_DIGITS = 2,
			FNC_1 = 3
		}

		private bool forceCodesetB;

		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		protected override IList<BarcodeFormat> SupportedWriteFormats => null;

		public override bool[] encode(string contents)
		{
			return null;
		}

		public override bool[] encode(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private int check(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return 0;
		}

		private bool[] encodeFast(string contents, int forcedCodeSet)
		{
			return null;
		}

		internal static bool[] produceResult(List<int[]> patterns, int checkSum)
		{
			return null;
		}

		private static CType findCType(string value, int start)
		{
			return CType.UNCODABLE;
		}

		private int chooseCode(string value, int start, int oldCode)
		{
			return 0;
		}
	}
}
