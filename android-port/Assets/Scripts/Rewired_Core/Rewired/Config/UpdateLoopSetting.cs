using System;
using Il2CppDummyDll;

namespace Rewired.Config
{
	[Token(Token = "0x20002BC")]
	[Flags]
	public enum UpdateLoopSetting
	{
		[Token(Token = "0x4000E7F")]
		None = 0,
		[Token(Token = "0x4000E80")]
		Update = 1,
		[Token(Token = "0x4000E81")]
		FixedUpdate = 2,
		[Token(Token = "0x4000E82")]
		OnGUI = 4
	}
}
