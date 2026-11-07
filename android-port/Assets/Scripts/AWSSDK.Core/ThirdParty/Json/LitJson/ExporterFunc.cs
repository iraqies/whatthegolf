using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200001E")]
	internal delegate void ExporterFunc(object obj, JsonWriter writer);
	[Token(Token = "0x200001F")]
	public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
}
