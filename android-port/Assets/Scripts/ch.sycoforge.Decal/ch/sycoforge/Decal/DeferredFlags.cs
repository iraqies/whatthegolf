using System;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000014")]
	[Flags]
	public enum DeferredFlags
	{
		[Token(Token = "0x400006C")]
		Diffuse = 1,
		[Token(Token = "0x400006D")]
		Normal = 2,
		[Token(Token = "0x400006E")]
		SpecSmooth = 4
	}
}
