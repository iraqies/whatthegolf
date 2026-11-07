using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000038")]
	[Flags]
	public enum TypeNameHandling
	{
		[Token(Token = "0x4000134")]
		None = 0,
		[Token(Token = "0x4000135")]
		Objects = 1,
		[Token(Token = "0x4000136")]
		Arrays = 2,
		[Token(Token = "0x4000137")]
		All = Objects | Arrays,
		[Token(Token = "0x4000138")]
		Auto = 4
	}
}
