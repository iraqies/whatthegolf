using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000317")]
public class ReplicatingHoleShooter : ShooterBase
{
	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x20")]
	public GameObject replicatingHolePrefab;

	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x30")]
	private GameObject instantiatedNextHole;

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x164A3E0", Offset = "0x164A3E0", VA = "0x164A3E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x164A43C", Offset = "0x164A43C", VA = "0x164A43C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x164A5B0", Offset = "0x164A5B0", VA = "0x164A5B0")]
	public ReplicatingHoleShooter()
	{
	}
}
