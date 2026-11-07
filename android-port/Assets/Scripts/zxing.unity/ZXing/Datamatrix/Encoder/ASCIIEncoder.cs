namespace ZXing.Datamatrix.Encoder
{
	internal sealed class ASCIIEncoder : Encoder
	{
		public int EncodingMode => 0;

		public void encode(EncoderContext context)
		{
		}

		private static char encodeASCIIDigits(char digit1, char digit2)
		{
			return '\0';
		}
	}
}
