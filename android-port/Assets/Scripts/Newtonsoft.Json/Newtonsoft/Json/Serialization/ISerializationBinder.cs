using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183980", Offset = "0x183980")]
	public interface ISerializationBinder
	{
		[Token(Token = "0x60003D5")]
		Type BindToType([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB94", Offset = "0x18CB94")] string assemblyName, string typeName);

		[Token(Token = "0x60003D6")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189740", Offset = "0x189740")]
		void BindToName([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CBA8", Offset = "0x18CBA8")] Type serializedType, out string assemblyName, out string typeName);
	}
}
