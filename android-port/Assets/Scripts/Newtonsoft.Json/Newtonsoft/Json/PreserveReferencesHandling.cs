using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000033")]
	[Flags]
	public enum PreserveReferencesHandling
	{
		[Token(Token = "0x400011F")]
		None = 0,
		[Token(Token = "0x4000120")]
		Objects = 1,
		[Token(Token = "0x4000121")]
		Arrays = 2,
		[Token(Token = "0x4000122")]
		All = Objects | Arrays
	}
}
