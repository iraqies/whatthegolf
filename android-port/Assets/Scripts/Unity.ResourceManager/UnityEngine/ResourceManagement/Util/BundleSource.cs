using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200003D")]
	[Flags]
	internal enum BundleSource
	{
		[Token(Token = "0x400009A")]
		None = 0,
		[Token(Token = "0x400009B")]
		Local = 1,
		[Token(Token = "0x400009C")]
		Cache = 2,
		[Token(Token = "0x400009D")]
		Download = 4
	}
}
