using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	internal sealed class State
	{
		public static readonly State INITIAL_STATE;

		private readonly int mode;

		private readonly Token token;

		private readonly int binaryShiftByteCount;

		private readonly int bitCount;

		private readonly int binaryShiftCost;

		public int Mode => 0;

		public int BinaryShiftByteCount => 0;

		public int BitCount => 0;

		public State(Token token, int mode, int binaryBytes, int bitCount)
		{
		}

		public State appendFLGn(int eci)
		{
			return null;
		}

		public State latchAndAppend(int mode, int value)
		{
			return null;
		}

		public State shiftAndAppend(int mode, int value)
		{
			return null;
		}

		public State addBinaryShiftChar(int index)
		{
			return null;
		}

		public State endBinaryShift(int index)
		{
			return null;
		}

		public bool isBetterThanOrEqualTo(State other)
		{
			return false;
		}

		public BitArray toBitArray(byte[] text)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private static int calculateBinaryShiftCost(int binaryShiftByteCount)
		{
			return 0;
		}
	}
}
