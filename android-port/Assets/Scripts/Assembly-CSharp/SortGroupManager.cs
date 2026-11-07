using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A4B")]
public class SortGroupManager : GolfBehaviour
{
	[Token(Token = "0x40038E5")]
	[FieldOffset(Offset = "0x20")]
	public List<SortByY> sceneSortingGroups;

	[Token(Token = "0x40038E6")]
	[FieldOffset(Offset = "0x28")]
	public int divideSortingOverFrames;

	[Token(Token = "0x40038E7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<SortByY> sortingByYObjects;

	[Token(Token = "0x40038E8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int maxSortingPerFrame;

	[Token(Token = "0x40038E9")]
	[FieldOffset(Offset = "0x3C")]
	private int offset;

	[Token(Token = "0x6003110")]
	[Address(RVA = "0x16C1010", Offset = "0x16C1010", VA = "0x16C1010", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6003111")]
	[Address(RVA = "0x16C1014", Offset = "0x16C1014", VA = "0x16C1014")]
	public void PreCache()
	{
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0x16C12BC", Offset = "0x16C12BC", VA = "0x16C12BC")]
	public void UpdateSorting()
	{
	}

	[Token(Token = "0x6003113")]
	[Address(RVA = "0x16C1428", Offset = "0x16C1428", VA = "0x16C1428")]
	public SortGroupManager()
	{
	}
}
