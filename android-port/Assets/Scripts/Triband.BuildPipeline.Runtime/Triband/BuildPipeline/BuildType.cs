using System;
using Il2CppDummyDll;

namespace Triband.BuildPipeline
{
	[Token(Token = "0x2000003")]
	[Flags]
	public enum BuildType
	{
		[Token(Token = "0x4000005")]
		Unknown = 0,
		[Token(Token = "0x4000006")]
		Development = 1,
		[Token(Token = "0x4000007")]
		Release = 2
	}
}
