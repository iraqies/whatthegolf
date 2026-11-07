using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E5")]
public class Javelin : MonoBehaviour
{
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x18")]
	public Collider Collider;

	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x28")]
	public Action OnHitGoal;

	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x30")]
	public Action OnMissGoal;

	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask HitLayers;

	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x40")]
	public Action OnReset;

	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x48")]
	public bool CanWin;

	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x49")]
	public bool Initialized;

	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x4A")]
	public bool stuck;

	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x50")]
	private RotateWithVelocity rotator;

	[Token(Token = "0x6000874")]
	[Address(RVA = "0x14F51FC", Offset = "0x14F51FC", VA = "0x14F51FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0x14F5374", Offset = "0x14F5374", VA = "0x14F5374")]
	private void HitSomething(Collider hit)
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0x14F5714", Offset = "0x14F5714", VA = "0x14F5714")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0x14F574C", Offset = "0x14F574C", VA = "0x14F574C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0x14F57FC", Offset = "0x14F57FC", VA = "0x14F57FC")]
	public void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0x14F5A10", Offset = "0x14F5A10", VA = "0x14F5A10")]
	public Javelin()
	{
	}
}
