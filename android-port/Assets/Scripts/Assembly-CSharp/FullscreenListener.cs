using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A6")]
public class FullscreenListener : MonoBehaviour
{
	[Token(Token = "0x4001CDF")]
	[FieldOffset(Offset = "0x18")]
	private FullScreenMode screenMode;

	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x20")]
	public Action OnFullScreenChanged;

	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x1475B68", Offset = "0x1475B68", VA = "0x1475B68")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x1475C80", Offset = "0x1475C80", VA = "0x1475C80")]
	private void Update()
	{
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x1475CD4", Offset = "0x1475CD4", VA = "0x1475CD4")]
	public FullscreenListener()
	{
	}
}
