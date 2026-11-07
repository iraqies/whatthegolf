using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x2000184")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x191144", Offset = "0x191144")]
	public enum EditorPlatform
	{
		[Token(Token = "0x40008B0")]
		None = 0,
		[Token(Token = "0x40008B1")]
		OSX = 1,
		[Token(Token = "0x40008B2")]
		Windows = 2,
		[Token(Token = "0x40008B3")]
		Linux = 3,
		[Token(Token = "0x40008B4")]
		Unknown = 100
	}
}
