using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	public abstract class Token
	{
		public static Token EMPTY;

		private readonly Token previous;

		public Token Previous => null;

		protected Token(Token previous)
		{
		}

		public Token add(int value, int bitCount)
		{
			return null;
		}

		public Token addBinaryShift(int start, int byteCount)
		{
			return null;
		}

		public abstract void appendTo(BitArray bitArray, byte[] text);
	}
}
