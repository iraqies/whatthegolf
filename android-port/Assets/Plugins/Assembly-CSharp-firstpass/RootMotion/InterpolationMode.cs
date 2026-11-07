using System;
using Il2CppDummyDll;

namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x20000EA")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000512")]
		None = 0,
		[Token(Token = "0x4000513")]
		InOutCubic = 1,
		[Token(Token = "0x4000514")]
		InOutQuintic = 2,
		[Token(Token = "0x4000515")]
		InOutSine = 3,
		[Token(Token = "0x4000516")]
		InQuintic = 4,
		[Token(Token = "0x4000517")]
		InQuartic = 5,
		[Token(Token = "0x4000518")]
		InCubic = 6,
		[Token(Token = "0x4000519")]
		InQuadratic = 7,
		[Token(Token = "0x400051A")]
		InElastic = 8,
		[Token(Token = "0x400051B")]
		InElasticSmall = 9,
		[Token(Token = "0x400051C")]
		InElasticBig = 10,
		[Token(Token = "0x400051D")]
		InSine = 11,
		[Token(Token = "0x400051E")]
		InBack = 12,
		[Token(Token = "0x400051F")]
		OutQuintic = 13,
		[Token(Token = "0x4000520")]
		OutQuartic = 14,
		[Token(Token = "0x4000521")]
		OutCubic = 15,
		[Token(Token = "0x4000522")]
		OutInCubic = 16,
		[Token(Token = "0x4000523")]
		OutInQuartic = 17,
		[Token(Token = "0x4000524")]
		OutElastic = 18,
		[Token(Token = "0x4000525")]
		OutElasticSmall = 19,
		[Token(Token = "0x4000526")]
		OutElasticBig = 20,
		[Token(Token = "0x4000527")]
		OutSine = 21,
		[Token(Token = "0x4000528")]
		OutBack = 22,
		[Token(Token = "0x4000529")]
		OutBackCubic = 23,
		[Token(Token = "0x400052A")]
		OutBackQuartic = 24,
		[Token(Token = "0x400052B")]
		BackInCubic = 25,
		[Token(Token = "0x400052C")]
		BackInQuartic = 26
	}
}
