using System;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x20011A3")]
	public interface IJsonSerializerStrategy
	{
		[Token(Token = "0x6005085")]
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		[Token(Token = "0x6005086")]
		object DeserializeObject(object value, Type type);
	}
}
