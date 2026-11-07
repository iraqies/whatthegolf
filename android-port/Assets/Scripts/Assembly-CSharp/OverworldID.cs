using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B46")]
[ExecuteInEditMode]
public class OverworldID : MonoBehaviour
{
	[Token(Token = "0x4003EBC")]
	[FieldOffset(Offset = "0x18")]
	public string ID;

	[Token(Token = "0x4003EBD")]
	[FieldOffset(Offset = "0x0")]
	private static System.Random random;

	[Token(Token = "0x6003598")]
	[Address(RVA = "0x15B90E0", Offset = "0x15B90E0", VA = "0x15B90E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003599")]
	[Address(RVA = "0x15B9124", Offset = "0x15B9124", VA = "0x15B9124")]
	public string GenerateId(int length)
	{
		return null;
	}

	[Token(Token = "0x600359A")]
	[Address(RVA = "0x15B9254", Offset = "0x15B9254", VA = "0x15B9254", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600359B")]
	[Address(RVA = "0x15B925C", Offset = "0x15B925C", VA = "0x15B925C")]
	public OverworldID()
	{
	}
}
