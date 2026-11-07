using System;
using Il2CppDummyDll;

namespace Rewired.Config
{
	[Token(Token = "0x20002BE")]
	[Flags]
	public enum LogLevelFlags
	{
		[Token(Token = "0x4000E87")]
		Off = 0,
		[Token(Token = "0x4000E88")]
		Info = 1,
		[Token(Token = "0x4000E89")]
		Warning = 2,
		[Token(Token = "0x4000E8A")]
		Error = 4,
		[Token(Token = "0x4000E8B")]
		Debug = 8
	}
}
