using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009C")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x18396C", Offset = "0x18396C")]
	public interface IReferenceResolver
	{
		[Token(Token = "0x60003D1")]
		object ResolveReference(object context, string reference);

		[Token(Token = "0x60003D2")]
		string GetReference(object context, object value);

		[Token(Token = "0x60003D3")]
		bool IsReferenced(object context, object value);

		[Token(Token = "0x60003D4")]
		void AddReference(object context, string reference, object value);
	}
}
