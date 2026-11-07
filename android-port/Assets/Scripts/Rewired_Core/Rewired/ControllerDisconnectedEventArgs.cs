using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000B6")]
	internal class ControllerDisconnectedEventArgs : EventArgs
	{
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x10")]
		public readonly int rewiredId;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x235C760", Offset = "0x235C760", VA = "0x235C760")]
		public ControllerDisconnectedEventArgs(int P_0)
		{
		}
	}
}
