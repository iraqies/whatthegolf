using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC6")]
public class BuildDate : MonoBehaviour
{
	[Token(Token = "0x400419E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string format;

	[Token(Token = "0x400419F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string buildText;

	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x170B340", Offset = "0x170B340", VA = "0x170B340")]
	private void Start()
	{
	}

	[Token(Token = "0x60038B5")]
	[Address(RVA = "0x170B434", Offset = "0x170B434", VA = "0x170B434")]
	public static Version Version()
	{
		return null;
	}

	[Token(Token = "0x60038B6")]
	[Address(RVA = "0x170B49C", Offset = "0x170B49C", VA = "0x170B49C")]
	public static DateTime Date()
	{
		return default;
	}

	[Token(Token = "0x60038B7")]
	[Address(RVA = "0x170B3F4", Offset = "0x170B3F4", VA = "0x170B3F4")]
	public static string ToString([Optional] string format)
	{
		return null;
	}

	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x170B564", Offset = "0x170B564", VA = "0x170B564")]
	public BuildDate()
	{
	}
}
