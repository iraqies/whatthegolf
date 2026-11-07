namespace ZXing.Datamatrix.Encoder
{
	internal sealed class Base256Encoder : Encoder
	{
		public int EncodingMode => 0;

		public void encode(EncoderContext context)
		{
		}

		private static char randomize255State(char ch, int codewordPosition)
		{
			return '\0';
		}
	}
}
