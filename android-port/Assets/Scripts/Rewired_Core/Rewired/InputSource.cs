using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000AA")]
	internal enum InputSource
	{
		[Token(Token = "0x400036B")]
		None = 0,
		[Token(Token = "0x400036C")]
		DirectInput = 1,
		[Token(Token = "0x400036D")]
		XInput = 2,
		[Token(Token = "0x400036E")]
		OSX = 3,
		[Token(Token = "0x400036F")]
		Fallback = 4,
		[Token(Token = "0x4000370")]
		RawInput = 5,
		[Token(Token = "0x4000371")]
		Fallback_PreConfigured = 6,
		[Token(Token = "0x4000372")]
		Linux = 7,
		[Token(Token = "0x4000373")]
		WindowsUWP = 8,
		[Token(Token = "0x4000374")]
		WebGL = 9,
		[Token(Token = "0x4000375")]
		Steam = 18,
		[Token(Token = "0x4000376")]
		SDL2 = 19,
		[Token(Token = "0x4000377")]
		Ouya = 20,
		[Token(Token = "0x4000378")]
		XboxOne = 21,
		[Token(Token = "0x4000379")]
		PS4 = 22,
		[Token(Token = "0x400037A")]
		NintendoSwitch = 24,
		[Token(Token = "0x400037B")]
		Stadia = 25,
		[Token(Token = "0x400037C")]
		GameCoreXboxOne = 26,
		[Token(Token = "0x400037D")]
		GameCoreScarlett = 27,
		[Token(Token = "0x400037E")]
		PS5 = 28,
		[Token(Token = "0x400037F")]
		AppleGameController = 29,
		[Token(Token = "0x4000380")]
		InternalDriver = 49,
		[Token(Token = "0x4000381")]
		UnityKeyboardAndMouse = 50,
		[Token(Token = "0x4000382")]
		Custom = 100
	}
}
