using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x200018A")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x1911BC", Offset = "0x1911BC")]
	public enum LinuxStandalonePrimaryInputSource
	{
		[Token(Token = "0x40008CF")]
		Native = 0,
		[Token(Token = "0x40008D0")]
		SDL2 = 10,
		[Token(Token = "0x40008D1")]
		Unity = 100
	}
}
