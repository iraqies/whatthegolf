using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000096")]
	[Flags]
	public enum ModifierKeyFlags
	{
		[Token(Token = "0x400024E")]
		None = 0,
		[Token(Token = "0x400024F")]
		LeftControl = 1,
		[Token(Token = "0x4000250")]
		RightControl = 2,
		[Token(Token = "0x4000251")]
		LeftAlt = 4,
		[Token(Token = "0x4000252")]
		RightAlt = 8,
		[Token(Token = "0x4000253")]
		LeftShift = 0x10,
		[Token(Token = "0x4000254")]
		RightShift = 0x20,
		[Token(Token = "0x4000255")]
		LeftCommand = 0x40,
		[Token(Token = "0x4000256")]
		RightCommand = 0x80
	}
}
