using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200043F")]
public class BombChallengeTarget : MonoBehaviour
{
	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x18")]
	public Action<BombChallengeTarget> onBombed;

	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x20")]
	private bool _isBombed;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x28")]
	private ExplosionBarrel _barrel;

	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x1617D90", Offset = "0x1617D90", VA = "0x1617D90")]
	private void Start()
	{
	}

	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x1617E64", Offset = "0x1617E64", VA = "0x1617E64")]
	private void BarrelOnOnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x1617ED4", Offset = "0x1617ED4", VA = "0x1617ED4")]
	public BombChallengeTarget()
	{
	}
}
