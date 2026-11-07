using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x2000079")]
	internal sealed class State
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly State INITIAL_STATE;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x10")]
		private readonly int mode;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x18")]
		private readonly Token token;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x20")]
		private readonly int binaryShiftByteCount;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x24")]
		private readonly int bitCount;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x28")]
		private readonly int binaryShiftCost;

		[Token(Token = "0x1700006E")]
		public int Mode
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x2ED2FFC", Offset = "0x2ED2FFC", VA = "0x2ED2FFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006F")]
		public int BinaryShiftByteCount
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2ED3004", Offset = "0x2ED3004", VA = "0x2ED3004")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000070")]
		public int BitCount
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2ED300C", Offset = "0x2ED300C", VA = "0x2ED300C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2ED2F10", Offset = "0x2ED2F10", VA = "0x2ED2F10")]
		public State(Token token, int mode, int binaryBytes, int bitCount)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2ED3014", Offset = "0x2ED3014", VA = "0x2ED3014")]
		public State appendFLGn(int eci)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2ED3730", Offset = "0x2ED3730", VA = "0x2ED3730")]
		public State latchAndAppend(int mode, int value)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2ED33F0", Offset = "0x2ED33F0", VA = "0x2ED33F0")]
		public State shiftAndAppend(int mode, int value)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2ED39D4", Offset = "0x2ED39D4", VA = "0x2ED39D4")]
		public State addBinaryShiftChar(int index)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2ED3C58", Offset = "0x2ED3C58", VA = "0x2ED3C58")]
		public State endBinaryShift(int index)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2ED3E04", Offset = "0x2ED3E04", VA = "0x2ED3E04")]
		public bool isBetterThanOrEqualTo(State other)
		{
			return default;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2ED3F0C", Offset = "0x2ED3F0C", VA = "0x2ED3F0C")]
		public BitArray toBitArray(byte[] text)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2ED4074", Offset = "0x2ED4074", VA = "0x2ED4074", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2ED2FD4", Offset = "0x2ED2FD4", VA = "0x2ED2FD4")]
		private static int calculateBinaryShiftCost(int binaryShiftByteCount)
		{
			return default;
		}
	}
}
