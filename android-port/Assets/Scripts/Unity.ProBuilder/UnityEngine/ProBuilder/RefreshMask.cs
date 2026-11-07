using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000019")]
	[Flags]
	public enum RefreshMask
	{
		[Token(Token = "0x4000069")]
		UV = 1,
		[Token(Token = "0x400006A")]
		Colors = 2,
		[Token(Token = "0x400006B")]
		Normals = 4,
		[Token(Token = "0x400006C")]
		Tangents = 8,
		[Token(Token = "0x400006D")]
		Collisions = 0x10,
		[Token(Token = "0x400006E")]
		All = UV | Colors | Normals | Tangents | Collisions
	}
}
