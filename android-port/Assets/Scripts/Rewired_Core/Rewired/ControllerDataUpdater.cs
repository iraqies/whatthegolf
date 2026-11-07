using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000B4")]
	internal class ControllerDataUpdater
	{
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x10")]
		public readonly InputSource source;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x14")]
		public readonly int axisCount;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x18")]
		public readonly int buttonCount;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x20")]
		public readonly float[] axisValues;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool[] buttonValues;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x30")]
		public readonly float[] buttonPressureValues;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x38")]
		public readonly bool[] axisHasBeenPressedOSXLinux;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x40")]
		private readonly UnknownControllerHat[] lrcESnditqeEFCZgflQOGLYDXGHKc;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x48")]
		public bool hasReceivedInput;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x235C518", Offset = "0x235C518", VA = "0x235C518")]
		public ControllerDataUpdater(InputSource P_0, int P_1, int P_2, UnknownControllerHat[] P_3)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x235C62C", Offset = "0x235C62C", VA = "0x235C62C")]
		public bool IsUnknownHatCardinal(int buttonIndex)
		{
			return default;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x235C6B8", Offset = "0x235C6B8", VA = "0x235C6B8")]
		public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x235A038", Offset = "0x235A038", VA = "0x235A038")]
		public void ClearData()
		{
		}
	}
}
