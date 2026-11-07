using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183958", Offset = "0x183958")]
	public interface IContractResolver
	{
		[Token(Token = "0x60003D0")]
		JsonContract ResolveContract(Type type);
	}
}
