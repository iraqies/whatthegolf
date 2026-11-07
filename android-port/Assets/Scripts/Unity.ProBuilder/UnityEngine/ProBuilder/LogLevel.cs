using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200000D")]
	[Flags]
	internal enum LogLevel
	{
		[Token(Token = "0x400002E")]
		None = 0,
		[Token(Token = "0x400002F")]
		Error = 1,
		[Token(Token = "0x4000030")]
		Warning = 2,
		[Token(Token = "0x4000031")]
		Info = 4,
		[Token(Token = "0x4000032")]
		Default = Error | Warning,
		[Token(Token = "0x4000033")]
		All = 0xFF
	}
}
