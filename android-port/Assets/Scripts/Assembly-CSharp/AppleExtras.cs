using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x20004EC")]
public static class AppleExtras
{
	[PreserveSig]
	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x141C23C", Offset = "0x141C23C", VA = "0x141C23C")]
	public static extern string _getPreferredLanguage();

	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x141C270", Offset = "0x141C270", VA = "0x141C270")]
	public static string GetPreferredLanguage()
	{
		return null;
	}
}
