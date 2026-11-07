using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE1")]
public class SwitchUndockMessage : MonoBehaviour
{
	[Token(Token = "0x40045FC")]
	[FieldOffset(Offset = "0x18")]
	public Animator MessageAnimator;

	[Token(Token = "0x40045FD")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsShowing;

	[Token(Token = "0x40045FE")]
	[FieldOffset(Offset = "0x20")]
	private bool _shoouldShow;

	[Token(Token = "0x40045FF")]
	[FieldOffset(Offset = "0x21")]
	private bool _menuShowing;

	[Token(Token = "0x4004600")]
	private const string HNAME = "Handheld";

	[Token(Token = "0x4004601")]
	[FieldOffset(Offset = "0x22")]
	private bool hasBeenDisabledOnce;

	[Token(Token = "0x4004602")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51484", Offset = "0x51484")]
	private Action<bool> m_OnDockingStateChanged;

	[Token(Token = "0x4004603")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<GolfBallController, bool> controllers;

	[Token(Token = "0x14000078")]
	public event Action<bool> OnDockingStateChanged
	{
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x16F5B64", Offset = "0x16F5B64", VA = "0x16F5B64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BE7C", Offset = "0x6BE7C")]
		add
		{
		}
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x16F5C08", Offset = "0x16F5C08", VA = "0x16F5C08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BE8C", Offset = "0x6BE8C")]
		remove
		{
		}
	}

	[Token(Token = "0x6003CF0")]
	[Address(RVA = "0x16F5CAC", Offset = "0x16F5CAC", VA = "0x16F5CAC")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6BE9C", Offset = "0x6BE9C")]
	private static void Init()
	{
	}

	[Token(Token = "0x6003CF1")]
	[Address(RVA = "0x16F5D10", Offset = "0x16F5D10", VA = "0x16F5D10")]
	public SwitchUndockMessage()
	{
	}
}
