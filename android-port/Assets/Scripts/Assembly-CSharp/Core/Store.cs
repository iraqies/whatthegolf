using System;
using Il2CppDummyDll;

namespace Core
{
	[Token(Token = "0x200141B")]
	[Flags]
	public enum Store
	{
		[Token(Token = "0x4006C08")]
		Unknown = 0,
		[Token(Token = "0x4006C09")]
		Epic = 1,
		[Token(Token = "0x4006C0A")]
		Arcade = 2,
		[Token(Token = "0x4006C0B")]
		Switch = 4,
		[Token(Token = "0x4006C0C")]
		Steam = 8,
		[Token(Token = "0x4006C0D")]
		Oculus = 0x10,
		[Token(Token = "0x4006C0E")]
		Playstation = 0x20,
		[Token(Token = "0x4006C0F")]
		GOG = 0x40,
		[Token(Token = "0x4006C10")]
		XboxOne = 0x80
	}
}
