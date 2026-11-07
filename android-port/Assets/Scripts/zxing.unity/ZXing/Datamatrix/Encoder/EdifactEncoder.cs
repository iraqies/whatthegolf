using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class EdifactEncoder : Encoder
	{
		public int EncodingMode => 0;

		public void encode(EncoderContext context)
		{
		}

		private static void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}

		private static void encodeChar(char c, StringBuilder sb)
		{
		}

		private static string encodeToCodewords(StringBuilder sb)
		{
			return null;
		}
	}
}
