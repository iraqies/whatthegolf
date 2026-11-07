using System;
using System.Collections.Generic;
using Core;
using Core.UI;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200057D")]
public class ModalWindowSingleton : AddressableSingleton<ModalWindowSingleton>
{
	[Token(Token = "0x200057E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405B4", Offset = "0x405B4")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x10")]
		public ModalWindowType type;

		[Token(Token = "0x6001904")]
		[Address(RVA = "0x17F8978", Offset = "0x17F8978", VA = "0x17F8978")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6001905")]
		[Address(RVA = "0x17F8980", Offset = "0x17F8980", VA = "0x17F8980")]
		internal bool _003CGetModalWindow_003Eb__0(ModalWindow m)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200057F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405C4", Offset = "0x405C4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ModalWindow, bool> _003C_003E9__2_0;

		[Token(Token = "0x6001907")]
		[Address(RVA = "0x17F8944", Offset = "0x17F8944", VA = "0x17F8944")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001908")]
		[Address(RVA = "0x17F894C", Offset = "0x17F894C", VA = "0x17F894C")]
		internal bool _003CIsAnyOpen_003Eb__2_0(ModalWindow m)
		{
			return default;
		}
	}

	[Token(Token = "0x4001C35")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<ModalWindow> _modalWindows;

	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x156643C", Offset = "0x156643C", VA = "0x156643C")]
	public static ModalWindow GetModalWindow(ModalWindowType type)
	{
		return null;
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x156A268", Offset = "0x156A268", VA = "0x156A268")]
	public static bool IsAnyOpen()
	{
		return default;
	}

	[Token(Token = "0x6001900")]
	[Address(RVA = "0x156A3BC", Offset = "0x156A3BC", VA = "0x156A3BC")]
	public static void ForceClose()
	{
	}

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x156A524", Offset = "0x156A524", VA = "0x156A524")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x156A5A8", Offset = "0x156A5A8", VA = "0x156A5A8")]
	private void CloseOnRestart()
	{
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x156A84C", Offset = "0x156A84C", VA = "0x156A84C")]
	public ModalWindowSingleton()
	{
	}
}
