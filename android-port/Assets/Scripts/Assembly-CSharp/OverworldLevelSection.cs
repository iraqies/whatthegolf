using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004C6")]
public class OverworldLevelSection
{
	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x18")]
	public bool hasBoss;

	[Token(Token = "0x40018F5")]
	[FieldOffset(Offset = "0x20")]
	public Sprite image;

	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x28")]
	public List<LevelData> levels;

	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0x30")]
	public string saveSpotId;

	[Token(Token = "0x40018F8")]
	[FieldOffset(Offset = "0x38")]
	public Transmogrif.BALLSHAPES ballShape;

	[Token(Token = "0x40018F9")]
	[FieldOffset(Offset = "0x40")]
	public string unlockTriggerId;

	[NonSerialized]
	[Token(Token = "0x40018FA")]
	[FieldOffset(Offset = "0x48")]
	public bool isAvailable;

	[NonSerialized]
	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x4C")]
	public float completionPercentage;

	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x15BABE0", Offset = "0x15BABE0", VA = "0x15BABE0")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x15BAE90", Offset = "0x15BAE90", VA = "0x15BAE90")]
	private bool GetIsAvailable()
	{
		return default;
	}

	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x15BAC20", Offset = "0x15BAC20", VA = "0x15BAC20")]
	private float GetCompletionPercentage()
	{
		return default;
	}

	[Token(Token = "0x6001600")]
	[Address(RVA = "0x15BAF60", Offset = "0x15BAF60", VA = "0x15BAF60")]
	public OverworldLevelSection()
	{
	}
}
