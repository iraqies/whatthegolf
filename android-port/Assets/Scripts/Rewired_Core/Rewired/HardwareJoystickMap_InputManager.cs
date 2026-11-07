using Il2CppDummyDll;
using Rewired.Data.Mapping;

namespace Rewired
{
	[Token(Token = "0x20000FE")]
	internal class HardwareJoystickMap_InputManager
	{
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x10")]
		public string controllerName;

		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x18")]
		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier;

		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x38")]
		public readonly HardwareJoystickMap.Platform map;

		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x40")]
		public readonly int buttonCount;

		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x44")]
		public readonly int axisCount;

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x48")]
		public readonly ControllerElementIdentifier[] elementIdentifiers;

		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x50")]
		public readonly HardwareJoystickMap.CompoundElement[] compoundElements;

		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x58")]
		public bool useSystemName;

		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x59")]
		public readonly bool isUnknownController;

		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x60")]
		public readonly JoystickType[] joystickTypes;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x23CF3A0", Offset = "0x23CF3A0", VA = "0x23CF3A0")]
		public HardwareJoystickMap_InputManager(HardwareControllerMapIdentifier P_0, JoystickType[] P_1, HardwareJoystickMap.Platform P_2, string P_3, int P_4, int P_5, int P_6, HardwareJoystickMap.CompoundElement[] P_7)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x23CF4C4", Offset = "0x23CF4C4", VA = "0x23CF4C4")]
		public HardwareControllerMap_Game ToGameHardwareControllerMap()
		{
			return null;
		}
	}
}
