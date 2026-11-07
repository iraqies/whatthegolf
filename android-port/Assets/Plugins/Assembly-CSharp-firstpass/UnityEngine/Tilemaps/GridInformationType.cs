using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000BF")]
	internal enum GridInformationType
	{
		[Token(Token = "0x40003A1")]
		Integer = 0,
		[Token(Token = "0x40003A2")]
		String = 1,
		[Token(Token = "0x40003A3")]
		Float = 2,
		[Token(Token = "0x40003A4")]
		Double = 3,
		[Token(Token = "0x40003A5")]
		UnityObject = 4,
		[Token(Token = "0x40003A6")]
		Color = 5
	}
}
