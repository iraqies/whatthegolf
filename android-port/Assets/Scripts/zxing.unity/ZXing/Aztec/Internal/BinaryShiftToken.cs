using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	public sealed class BinaryShiftToken : Token
	{
		private readonly int binaryShiftStart;

		private readonly int binaryShiftByteCount;

		public BinaryShiftToken(Token previous, int binaryShiftStart, int binaryShiftByteCount)
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
