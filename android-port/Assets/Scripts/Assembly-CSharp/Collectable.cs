using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000498")]
public class Collectable : ScriptableObject
{
	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x18")]
	public string serializationId;

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x20")]
	public Sprite icon;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x28")]
	public bool IsImportant;

	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x30")]
	public Action OnUnlocked;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool requireUnlock;

	[Token(Token = "0x6001549")]
	[Address(RVA = "0x18A7988", Offset = "0x18A7988", VA = "0x18A7988")]
	public bool IsUnlocked()
	{
		return default;
	}

	[Token(Token = "0x600154A")]
	[Address(RVA = "0x18A7A6C", Offset = "0x18A7A6C", VA = "0x18A7A6C")]
	public void Unlock()
	{
	}

	[Token(Token = "0x600154B")]
	[Address(RVA = "0x18A7B50", Offset = "0x18A7B50", VA = "0x18A7B50")]
	public bool WasCollected(string id)
	{
		return default;
	}

	[Token(Token = "0x600154C")]
	[Address(RVA = "0x18A7BDC", Offset = "0x18A7BDC", VA = "0x18A7BDC")]
	public void Collect(string id)
	{
	}

	[Token(Token = "0x600154D")]
	[Address(RVA = "0x18A7C74", Offset = "0x18A7C74", VA = "0x18A7C74")]
	public Collectable()
	{
	}
}
