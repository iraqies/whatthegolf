using Il2CppDummyDll;

namespace Rewired.Platforms
{
	[Token(Token = "0x2000187")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x191180", Offset = "0x191180")]
	public enum ScriptingAPILevel
	{
		[Token(Token = "0x40008BF")]
		Net20 = 0,
		[Token(Token = "0x40008C0")]
		Net20Subset = 1,
		[Token(Token = "0x40008C1")]
		Net46 = 2,
		[Token(Token = "0x40008C2")]
		NetStandard20 = 3
	}
}
