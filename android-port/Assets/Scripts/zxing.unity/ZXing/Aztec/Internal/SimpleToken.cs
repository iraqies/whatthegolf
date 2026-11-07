using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	public sealed class SimpleToken : Token
	{
		private readonly short value;

		private readonly short bitCount;

		public SimpleToken(Token previous, int value, int bitCount)
			: base(null)
		{
		}

		public override void appendTo(BitArray bitArray, byte[] text)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
