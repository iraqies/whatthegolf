using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000B62")]
public static class SaveSystem
{
	[Token(Token = "0x2000B63")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43880", Offset = "0x43880")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4003F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<byte[]> done;

		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x183DF94", Offset = "0x183DF94", VA = "0x183DF94")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x183DF9C", Offset = "0x183DF9C", VA = "0x183DF9C")]
		internal void _003CLoad_003Eb__0(byte[] d)
		{
		}
	}

	[Token(Token = "0x2000B64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43890", Offset = "0x43890")]
	private sealed class _003CInternalLoadCR_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x4003F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<byte[]> done;

		[Token(Token = "0x170005B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60036BF")]
			[Address(RVA = "0x183E150", Offset = "0x183E150", VA = "0x183E150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60036C1")]
			[Address(RVA = "0x183E198", Offset = "0x183E198", VA = "0x183E198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x183E06C", Offset = "0x183E06C", VA = "0x183E06C")]
		[DebuggerHidden]
		public _003CInternalLoadCR_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x183E098", Offset = "0x183E098", VA = "0x183E098", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x183E09C", Offset = "0x183E09C", VA = "0x183E09C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x183E150", Offset = "0x183E150", VA = "0x183E150", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x183E158", Offset = "0x183E158", VA = "0x183E158", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x183E198", Offset = "0x183E198", VA = "0x183E198", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003F47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly byte[] EmptyData;

	[Token(Token = "0x4003F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] loadData;

	[Token(Token = "0x60036B1")]
	[Address(RVA = "0x1677C3C", Offset = "0x1677C3C", VA = "0x1677C3C")]
	private static void InternalSave(string path, byte[] data, Action done)
	{
	}

	[Token(Token = "0x60036B2")]
	[Address(RVA = "0x1677C78", Offset = "0x1677C78", VA = "0x1677C78")]
	private static void InternalDelete(string path, Action done)
	{
	}

	[Token(Token = "0x60036B3")]
	[Address(RVA = "0x1677CC8", Offset = "0x1677CC8", VA = "0x1677CC8")]
	private static void InternalLoad(string path, bool streaming, Action<byte[]> done)
	{
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0x1677F60", Offset = "0x1677F60", VA = "0x1677F60")]
	public static void Save(string filePath, byte[] data, Action done)
	{
	}

	[Token(Token = "0x60036B5")]
	[Address(RVA = "0x167801C", Offset = "0x167801C", VA = "0x167801C")]
	public static void Delete(string filePath, Action done)
	{
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0x16780BC", Offset = "0x16780BC", VA = "0x16780BC")]
	public static byte[] Load(string filePath, [Optional][DefaultParameterValue(false)] bool streaming, [Optional] Action<byte[]> done)
	{
		return null;
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0x1677E20", Offset = "0x1677E20", VA = "0x1677E20")]
	private static IEnumerator InternalLoadCR(string path, Action<byte[]> done)
	{
		return null;
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0x1677E98", Offset = "0x1677E98", VA = "0x1677E98")]
	private static void DoInternalLoad(string path, Action<byte[]> done)
	{
	}
}
