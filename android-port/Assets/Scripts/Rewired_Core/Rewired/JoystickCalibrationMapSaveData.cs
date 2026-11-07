using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000DC")]
	public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData
	{
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x28")]
		private Guid RsbZaCpOLfksMClIOHgLNxONiOJl;

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x23E04C0", Offset = "0x23E04C0", VA = "0x23E04C0")]
		public JoystickCalibrationMapSaveData(CalibrationMap P_0, ControllerType P_1, string P_2, Guid P_3)
		{
		}
	}
}
