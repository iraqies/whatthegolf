using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x20001B6")]
public class MenuOfflineNotifier
{
	[Token(Token = "0x20001B7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DFE0", Offset = "0x3DFE0")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x10")]
		public UnityAction onClose;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x17F6ED0", Offset = "0x17F6ED0", VA = "0x17F6ED0")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x17F6ED8", Offset = "0x17F6ED8", VA = "0x17F6ED8")]
		internal void _003CShowOfflineMode_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x0")]
	private static bool _shownOfflineWarning;

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x1566204", Offset = "0x1566204", VA = "0x1566204")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x5F248", Offset = "0x5F248")]
	private static void Init()
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x1566250", Offset = "0x1566250", VA = "0x1566250")]
	public static bool ShouldShowOfflineWarning()
	{
		return default;
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x1566310", Offset = "0x1566310", VA = "0x1566310")]
	public static void ShowOfflineMode(UnityAction onClose)
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x1566588", Offset = "0x1566588", VA = "0x1566588")]
	public MenuOfflineNotifier()
	{
	}
}
