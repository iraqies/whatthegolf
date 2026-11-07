using System.Collections.Generic;
using System.Text.RegularExpressions;
using ZXing.Common;

namespace ZXing.OneD
{
	public abstract class OneDimensionalCodeWriter : Writer
	{
		private static readonly Regex NUMERIC;

		private int defaultMargin;

		protected abstract IList<BarcodeFormat> SupportedWriteFormats { get; }

		public int DefaultMargin
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public abstract bool[] encode(string contents);

		public virtual bool[] encode(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		public virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		private static BitMatrix renderResult(bool[] code, int width, int height, int sidesMargin, bool noPadding)
		{
			return null;
		}

		protected static void checkNumeric(string contents)
		{
		}

		protected static int appendPattern(bool[] target, int pos, int[] pattern, bool startColor)
		{
			return 0;
		}
	}
}
