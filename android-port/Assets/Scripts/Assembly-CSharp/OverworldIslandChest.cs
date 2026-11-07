using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A95")]
public class OverworldIslandChest : MonoBehaviour
{
	[Token(Token = "0x4003AD8")]
	[FieldOffset(Offset = "0x18")]
	public ChestManager ChestManager;

	[Token(Token = "0x4003AD9")]
	[FieldOffset(Offset = "0x20")]
	public Chest ChestOnIsland;

	[Token(Token = "0x4003ADA")]
	[FieldOffset(Offset = "0x28")]
	public Transmogrif BallTransmogrif;

	[Token(Token = "0x4003ADB")]
	[FieldOffset(Offset = "0x30")]
	public OverworldIsland Island;

	[Token(Token = "0x4003ADC")]
	[FieldOffset(Offset = "0x38")]
	public List<PierTransmogrif> Piers;

	[Token(Token = "0x600328F")]
	[Address(RVA = "0x15BA038", Offset = "0x15BA038", VA = "0x15BA038")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003290")]
	[Address(RVA = "0x15BA130", Offset = "0x15BA130", VA = "0x15BA130")]
	private void OnPreChestOpen(Chest chest)
	{
	}

	[Token(Token = "0x6003291")]
	[Address(RVA = "0x15BA14C", Offset = "0x15BA14C", VA = "0x15BA14C")]
	private void OnPostChestOpen(Chest chest)
	{
	}

	[Token(Token = "0x6003292")]
	[Address(RVA = "0x15BA324", Offset = "0x15BA324", VA = "0x15BA324")]
	public OverworldIslandChest()
	{
	}
}
