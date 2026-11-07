using System;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x200118F")]
	[Flags]
	public enum PlayFabLogLevel
	{
		[Token(Token = "0x4005EEB")]
		None = 0,
		[Token(Token = "0x4005EEC")]
		Debug = 1,
		[Token(Token = "0x4005EED")]
		Info = 2,
		[Token(Token = "0x4005EEE")]
		Warning = 4,
		[Token(Token = "0x4005EEF")]
		Error = 8,
		[Token(Token = "0x4005EF0")]
		All = Debug | Info | Warning | Error
	}
}
