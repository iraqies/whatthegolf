using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000A")]
	[Flags]
	public enum DefaultValueHandling
	{
		[Token(Token = "0x400001A")]
		Include = 0,
		[Token(Token = "0x400001B")]
		Ignore = 1,
		[Token(Token = "0x400001C")]
		Populate = 2,
		[Token(Token = "0x400001D")]
		IgnoreAndPopulate = Ignore | Populate
	}
}
