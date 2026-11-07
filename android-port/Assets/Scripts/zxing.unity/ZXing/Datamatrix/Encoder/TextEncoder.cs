using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class TextEncoder : C40Encoder
	{
		public override int EncodingMode => 0;

		protected override int encodeChar(char c, StringBuilder sb)
		{
			return 0;
		}
	}
}
