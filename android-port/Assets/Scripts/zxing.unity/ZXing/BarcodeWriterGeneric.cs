using ZXing.Common;

namespace ZXing
{
	public class BarcodeWriterGeneric
	{
		private EncodingOptions options;

		public BarcodeFormat Format { get; set; }

		public EncodingOptions Options
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Writer Encoder { get; set; }

		public BitMatrix Encode(string contents)
		{
			return null;
		}
	}
}
