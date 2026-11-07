using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000AE")]
	[Flags]
	internal enum ButtonStateFlags
	{
		[Token(Token = "0x40003C4")]
		Off = 0,
		[Token(Token = "0x40003C5")]
		On = 1,
		[Token(Token = "0x40003C6")]
		Down = 2,
		[Token(Token = "0x40003C7")]
		Up = 4
	}
}
