using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal class C40Encoder : Encoder
	{
		public virtual int EncodingMode => 0;

		public void encodeMaximal(EncoderContext context)
		{
		}

		public virtual void encode(EncoderContext context)
		{
		}

		private int backtrackOneCharacter(EncoderContext context, StringBuilder buffer, StringBuilder removed, int lastCharSize)
		{
			return 0;
		}

		internal static void writeNextTriplet(EncoderContext context, StringBuilder buffer)
		{
		}

		protected virtual void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}

		protected virtual int encodeChar(char c, StringBuilder sb)
		{
			return 0;
		}

		private static string encodeToCodewords(StringBuilder sb)
		{
			return null;
		}
	}
}
