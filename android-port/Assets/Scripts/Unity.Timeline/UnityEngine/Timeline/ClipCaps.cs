using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200001C")]
	[Flags]
	public enum ClipCaps
	{
		[Token(Token = "0x40000AC")]
		None = 0,
		[Token(Token = "0x40000AD")]
		Looping = 1,
		[Token(Token = "0x40000AE")]
		Extrapolation = 2,
		[Token(Token = "0x40000AF")]
		ClipIn = 4,
		[Token(Token = "0x40000B0")]
		SpeedMultiplier = 8,
		[Token(Token = "0x40000B1")]
		Blending = 0x10,
		[Token(Token = "0x40000B2")]
		AutoScale = 0x28,
		[Token(Token = "0x40000B3")]
		All = -1
	}
}
