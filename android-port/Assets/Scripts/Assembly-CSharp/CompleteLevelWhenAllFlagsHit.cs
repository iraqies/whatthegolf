using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000223")]
public class CompleteLevelWhenAllFlagsHit : MonoBehaviour
{
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x18")]
	public List<FlagAppearOnPoleOnCollision> Poles;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x20")]
	private int count;

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x18AA148", Offset = "0x18AA148", VA = "0x18AA148")]
	private void Awake()
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x18AA344", Offset = "0x18AA344", VA = "0x18AA344")]
	private void OnFlagAppeared(FlagAppearOnPoleOnCollision obj)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0x18AA42C", Offset = "0x18AA42C", VA = "0x18AA42C")]
	public CompleteLevelWhenAllFlagsHit()
	{
	}
}
