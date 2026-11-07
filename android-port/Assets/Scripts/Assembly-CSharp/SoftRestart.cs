using System;
using Il2CppDummyDll;

[Token(Token = "0x200052D")]
public class SoftRestart
{
	[Token(Token = "0x4001AA2")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4DA4C", Offset = "0x4DA4C")]
	private static Action m_onRestart;

	[Token(Token = "0x14000025")]
	public static event Action onRestart
	{
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x16BFC08", Offset = "0x16BFC08", VA = "0x16BFC08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62E58", Offset = "0x62E58")]
		add
		{
		}
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x16BFCC8", Offset = "0x16BFCC8", VA = "0x16BFCC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62E68", Offset = "0x62E68")]
		remove
		{
		}
	}

	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x16BFD88", Offset = "0x16BFD88", VA = "0x16BFD88")]
	public static void RestartApp()
	{
	}
}
