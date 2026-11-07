using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000020")]
	internal delegate object ImporterFunc(object input);
	[Token(Token = "0x2000021")]
	public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
}
