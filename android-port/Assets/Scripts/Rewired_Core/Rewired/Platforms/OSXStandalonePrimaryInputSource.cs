using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x2000189")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x1911A8", Offset = "0x1911A8")]
	public enum OSXStandalonePrimaryInputSource
	{
		[Token(Token = "0x40008CA")]
		Native = 0,
		[Token(Token = "0x40008CB")]
		GameController = 1,
		[Token(Token = "0x40008CC")]
		SDL2 = 10,
		[Token(Token = "0x40008CD")]
		Unity = 100
	}
}
