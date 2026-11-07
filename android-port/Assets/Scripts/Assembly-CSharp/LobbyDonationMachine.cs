using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000176")]
public class LobbyDonationMachine : MonoBehaviour
{
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x18")]
	public UnlockablesManager Manager;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x20")]
	public Action<UnlockableContentPackage> ContentUnlocked;

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x28")]
	public Action OnNoCoinsAvailable;

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x1539EDC", Offset = "0x1539EDC", VA = "0x1539EDC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x153A028", Offset = "0x153A028", VA = "0x153A028")]
	public LobbyDonationMachine()
	{
	}
}
