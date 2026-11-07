using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class X12Encoder : C40Encoder
	{
		public override int EncodingMode => 0;

		public override void encode(EncoderContext context)
		{
		}

		protected override int encodeChar(char c, StringBuilder sb)
		{
			return 0;
		}

		protected override void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}
	}
}
