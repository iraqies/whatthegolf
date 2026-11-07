using System;
using Il2CppDummyDll;

namespace Prime31.Reflection
{
	[Token(Token = "0x200001C")]
	public delegate void MemberMapLoader(Type type, SafeDictionary<string, CacheResolver.MemberMap> memberMaps);
}
