using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000018")]
	[Flags]
	public enum MeshArrays
	{
		[Token(Token = "0x400005E")]
		Position = 1,
		[Token(Token = "0x400005F")]
		Texture0 = 2,
		[Token(Token = "0x4000060")]
		Texture1 = 4,
		[Token(Token = "0x4000061")]
		Lightmap = Texture1,
		[Token(Token = "0x4000062")]
		Texture2 = 8,
		[Token(Token = "0x4000063")]
		Texture3 = 0x10,
		[Token(Token = "0x4000064")]
		Color = 0x20,
		[Token(Token = "0x4000065")]
		Normal = 0x40,
		[Token(Token = "0x4000066")]
		Tangent = 0x80,
		[Token(Token = "0x4000067")]
		All = Position | Texture0 | Texture1 | Texture2 | Texture3 | Color | Normal | Tangent
	}
}
