using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200096F")]
public class Bridge : MonoBehaviour
{
	[Token(Token = "0x40033C6")]
	[FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40033C7")]
	[FieldOffset(Offset = "0x20")]
	public List<OverworldGoal> requireGoals;

	[Token(Token = "0x40033C8")]
	[FieldOffset(Offset = "0x28")]
	public int requireCount;

	[Token(Token = "0x40033C9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject leftStartPillar;

	[Token(Token = "0x40033CA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject rightStartPillar;

	[Token(Token = "0x40033CB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject leftEndPillar;

	[Token(Token = "0x40033CC")]
	[FieldOffset(Offset = "0x48")]
	public GameObject rightEndPillar;

	[Token(Token = "0x40033CD")]
	[FieldOffset(Offset = "0x50")]
	public GameObject plank;

	[Token(Token = "0x40033CE")]
	[FieldOffset(Offset = "0x58")]
	public BoxCollider boxCollider;

	[Token(Token = "0x40033CF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject pivot;

	[Token(Token = "0x40033D0")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshPro text;

	[Token(Token = "0x40033D1")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Sign;

	[Token(Token = "0x40033D2")]
	[FieldOffset(Offset = "0x78")]
	private bool isUnlocked;

	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x1708BE4", Offset = "0x1708BE4", VA = "0x1708BE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x1708F90", Offset = "0x1708F90", VA = "0x1708F90")]
	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x1708DF0", Offset = "0x1708DF0", VA = "0x1708DF0")]
	private void UpdateLockStatus(bool instant)
	{
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x1708F98", Offset = "0x1708F98", VA = "0x1708F98")]
	private void Unlock(bool instant)
	{
	}

	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x1709020", Offset = "0x1709020", VA = "0x1709020")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x17090E0", Offset = "0x17090E0", VA = "0x17090E0")]
	public void Make()
	{
	}

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x1709714", Offset = "0x1709714", VA = "0x1709714")]
	public Bridge()
	{
	}
}
