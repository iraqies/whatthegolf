using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000B65")]
public class SaveSystemsManager
{
	[Token(Token = "0x2000B66")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438A0", Offset = "0x438A0")]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x4003F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action callback;

		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x183E1A0", Offset = "0x183E1A0", VA = "0x183E1A0")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x183E1A8", Offset = "0x183E1A8", VA = "0x183E1A8")]
		internal void _003CSaveData_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000B67")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438B0", Offset = "0x438B0")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4003F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<byte[]> callback;

		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x183E1E4", Offset = "0x183E1E4", VA = "0x183E1E4")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x183E1EC", Offset = "0x183E1EC", VA = "0x183E1EC")]
		internal void _003CLoadData_003Eb__0(byte[] data)
		{
		}
	}

	[Token(Token = "0x2000B68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438C0", Offset = "0x438C0")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4003F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action callback;

		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x183E264", Offset = "0x183E264", VA = "0x183E264")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x183E26C", Offset = "0x183E26C", VA = "0x183E26C")]
		internal void _003CDeleteData_003Eb__0()
		{
		}
	}

	[Token(Token = "0x60036C2")]
	[Address(RVA = "0x16782D4", Offset = "0x16782D4", VA = "0x16782D4")]
	public static void SaveData(string path, byte[] data, Action done)
	{
	}

	[Token(Token = "0x60036C3")]
	[Address(RVA = "0x1678618", Offset = "0x1678618", VA = "0x1678618")]
	public static byte[] LoadData(string path, [Optional][DefaultParameterValue(false)] bool streaming, [Optional] Action<byte[]> done)
	{
		return null;
	}

	[Token(Token = "0x60036C4")]
	[Address(RVA = "0x1678814", Offset = "0x1678814", VA = "0x1678814")]
	public static void DeleteData(string path, Action done)
	{
	}

	[Token(Token = "0x60036C5")]
	[Address(RVA = "0x1678A80", Offset = "0x1678A80", VA = "0x1678A80")]
	public static string GetPlatformSpecificPath()
	{
		return null;
	}
}
