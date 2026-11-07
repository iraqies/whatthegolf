using System;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200003F")]
	[Flags]
	public enum OrientationChange
	{
		[Token(Token = "0x400014A")]
		None = 0,
		[Token(Token = "0x400014B")]
		Rotation = 1,
		[Token(Token = "0x400014C")]
		Translation = 2,
		[Token(Token = "0x400014D")]
		Scale = 4
	}
}
