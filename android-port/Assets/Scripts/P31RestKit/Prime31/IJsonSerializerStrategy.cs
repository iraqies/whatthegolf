using System;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000016")]
	public interface IJsonSerializerStrategy
	{
		[Token(Token = "0x6000080")]
		bool serializeNonPrimitiveObject(object input, out object output);

		[Token(Token = "0x6000081")]
		object deserializeObject(object value, Type type);
	}
}
