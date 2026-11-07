using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x2000186")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x19116C", Offset = "0x19116C")]
	public enum ScriptingBackend
	{
		[Token(Token = "0x40008BB")]
		Mono = 0,
		[Token(Token = "0x40008BC")]
		DotNet = 1,
		[Token(Token = "0x40008BD")]
		IL2CPP = 2
	}
}
