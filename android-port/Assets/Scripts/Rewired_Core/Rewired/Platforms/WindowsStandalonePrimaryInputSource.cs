using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x2000188")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x191194", Offset = "0x191194")]
	public enum WindowsStandalonePrimaryInputSource
	{
		[Token(Token = "0x40008C4")]
		RawInput = 0,
		[Token(Token = "0x40008C5")]
		DirectInput = 1,
		[Token(Token = "0x40008C6")]
		XInput = 2,
		[Token(Token = "0x40008C7")]
		SDL2 = 10,
		[Token(Token = "0x40008C8")]
		Unity = 100
	}
}
