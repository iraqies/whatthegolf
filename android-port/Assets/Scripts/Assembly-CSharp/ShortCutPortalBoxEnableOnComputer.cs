using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A41")]
public class ShortCutPortalBoxEnableOnComputer : MonoBehaviour
{
	[Token(Token = "0x400389F")]
	[FieldOffset(Offset = "0x18")]
	public OverworldMainDoorRobot computer;

	[Token(Token = "0x40038A0")]
	[FieldOffset(Offset = "0x20")]
	public SimplePortal toEnableOnComputerOpen;

	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x16A46D4", Offset = "0x16A46D4", VA = "0x16A46D4")]
	public void Init()
	{
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x16A4A54", Offset = "0x16A4A54", VA = "0x16A4A54")]
	private void Computer_OnOpen()
	{
	}

	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x16A4AF0", Offset = "0x16A4AF0", VA = "0x16A4AF0")]
	private void Portal_OnPortalEnabledIfDidntStartEnabled()
	{
	}

	[Token(Token = "0x60030DD")]
	[Address(RVA = "0x16A496C", Offset = "0x16A496C", VA = "0x16A496C")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x60030DE")]
	[Address(RVA = "0x16A4AF4", Offset = "0x16A4AF4", VA = "0x16A4AF4")]
	public ShortCutPortalBoxEnableOnComputer()
	{
	}
}
