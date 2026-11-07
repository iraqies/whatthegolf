using System;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired
{
	[Token(Token = "0x20000B5")]
	internal class UpdateControllerInfoEventArgs : EventArgs
	{
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x10")]
		public readonly IInputManagerJoystickPublic sourceJoystick;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2438EF4", Offset = "0x2438EF4", VA = "0x2438EF4")]
		public UpdateControllerInfoEventArgs(IInputManagerJoystickPublic P_0)
		{
		}
	}
}
