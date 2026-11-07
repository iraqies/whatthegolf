using System;
using Il2CppDummyDll;

namespace Amazon
{
	[Token(Token = "0x2000037")]
	[Flags]
	public enum LoggingOptions
	{
		[Token(Token = "0x40000FB")]
		None = 0,
		[Token(Token = "0x40000FC")]
		Log4Net = 1,
		[Token(Token = "0x40000FD")]
		SystemDiagnostics = 2,
		[Token(Token = "0x40000FE")]
		Console = 0x10
	}
}
