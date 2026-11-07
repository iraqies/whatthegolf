using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	[Token(Token = "0x20000FD")]
	internal class HardwareControllerMap_Game
	{
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x10")]
		public readonly string controllerName;

		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x18")]
		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier;

		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x34")]
		public readonly int customControllerSourceId;

		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x38")]
		public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers;

		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x40")]
		public readonly ControllerElementIdentifier[] elementIdentifiers_cache;

		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x48")]
		public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache;

		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x50")]
		public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache;

		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x58")]
		public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache;

		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x60")]
		public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache;

		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x68")]
		public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly;

		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x70")]
		public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly;

		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x78")]
		public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly;

		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x80")]
		public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly;

		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x88")]
		public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly;

		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x90")]
		public readonly int[] buttonElementIdentifierIds;

		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x98")]
		public readonly int[] axisElementIdentifierIds;

		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0xA0")]
		public readonly int[] axis2DElementIdentifierIds;

		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0xA8")]
		public readonly int[] hatElementIdentifierIds;

		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0xB0")]
		public readonly int elementIdentifierCount;

		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0xB4")]
		public readonly int axisCount;

		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0xB8")]
		public readonly int buttonCount;

		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0xBC")]
		public readonly int compoundElementCount;

		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0xC0")]
		public readonly int axis2DCount;

		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0xC4")]
		public readonly int hatCount;

		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0xC8")]
		public readonly JoystickType[] joystickTypes;

		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0xD0")]
		public readonly AxisCalibrationData[] hwAxisCalibrationData;

		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0xD8")]
		public readonly AxisRange[] hwAxisRanges;

		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0xE0")]
		public readonly HardwareAxisInfo[] hwAxisInfo;

		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0xE8")]
		public readonly HardwareButtonInfo[] hwButtonInfo;

		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0xF0")]
		public readonly HardwareJoystickMap.CompoundElement[] compoundElements;

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x23CB138", Offset = "0x23CB138", VA = "0x23CB138")]
		private HardwareControllerMap_Game(string P_0)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x23CB164", Offset = "0x23CB164", VA = "0x23CB164")]
		public HardwareControllerMap_Game(string P_0, int P_1, ControllerElementIdentifier[] P_2, int[] P_3, int[] P_4, AxisCalibrationData[] P_5, AxisRange[] P_6, HardwareAxisInfo[] P_7, HardwareButtonInfo[] P_8, HardwareJoystickMap.CompoundElement[] P_9)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x23CBABC", Offset = "0x23CBABC", VA = "0x23CBABC")]
		public HardwareControllerMap_Game(string P_0, HardwareControllerMapIdentifier P_1, JoystickType[] P_2, ControllerElementIdentifier[] P_3, int[] P_4, int[] P_5, AxisCalibrationData[] P_6, AxisRange[] P_7, HardwareAxisInfo[] P_8, HardwareButtonInfo[] P_9, HardwareJoystickMap.CompoundElement[] P_10)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x23CBBC4", Offset = "0x23CBBC4", VA = "0x23CBBC4")]
		public HardwareControllerMap_Game(string P_0, HardwareControllerMapIdentifier P_1, ControllerElementIdentifier[] P_2, int[] P_3, int[] P_4, AxisCalibrationData[] P_5, AxisRange[] P_6, HardwareAxisInfo[] P_7, HardwareButtonInfo[] P_8, HardwareJoystickMap.CompoundElement[] P_9)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x23CB1B8", Offset = "0x23CB1B8", VA = "0x23CB1B8")]
		private HardwareControllerMap_Game(string P_0, ControllerElementIdentifier[] P_1, int[] P_2, int[] P_3, AxisCalibrationData[] P_4, AxisRange[] P_5, HardwareAxisInfo[] P_6, HardwareButtonInfo[] P_7, HardwareJoystickMap.CompoundElement[] P_8)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x23CBD10", Offset = "0x23CBD10", VA = "0x23CBD10")]
		public string GetElementIdentifierName(int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x23CBDD0", Offset = "0x23CBDD0", VA = "0x23CBDD0")]
		public string GetElementIdentifierPositiveName(int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x23CBE90", Offset = "0x23CBE90", VA = "0x23CBE90")]
		public string GetElementIdentifierNegativeName(int elementIdentifierId)
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x23CBF50", Offset = "0x23CBF50", VA = "0x23CBF50")]
		public int GetAxisIndex(int elementIdentifierId)
		{
			return default;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x23CBFB4", Offset = "0x23CBFB4", VA = "0x23CBFB4")]
		public int GetButtonIndex(int elementIdentifierId)
		{
			return default;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x23CC018", Offset = "0x23CC018", VA = "0x23CC018")]
		public ControllerElementIdentifier GetElementIdentifierById(int id)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x23CC0CC", Offset = "0x23CC0CC", VA = "0x23CC0CC")]
		public HardwareJoystickMap.CompoundElement GetAxis2DData(int index)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x23CC120", Offset = "0x23CC120", VA = "0x23CC120")]
		public HardwareJoystickMap.CompoundElement GetHatData(int index)
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x23CBCC0", Offset = "0x23CBCC0", VA = "0x23CBCC0")]
		private int mTATJwIHXuihPPTCNDzzzVMJiCrt(ControllerElementIdentifier[] P_0, int P_1)
		{
			return default;
		}
	}
}
