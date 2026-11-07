using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070C")]
public class Arrow2D : MonoBehaviour
{
	[Token(Token = "0x4002511")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D Collider;

	[Token(Token = "0x4002512")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D Rigidbody;

	[Token(Token = "0x4002513")]
	[FieldOffset(Offset = "0x28")]
	public Action OnHitGoal;

	[Token(Token = "0x4002514")]
	[FieldOffset(Offset = "0x30")]
	public Action OnMissGoal;

	[Token(Token = "0x4002515")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask HitLayers;

	[Token(Token = "0x4002516")]
	[FieldOffset(Offset = "0x40")]
	public Action OnReset;

	[Token(Token = "0x4002517")]
	[FieldOffset(Offset = "0x48")]
	public bool CanWin;

	[Token(Token = "0x4002518")]
	[FieldOffset(Offset = "0x49")]
	public bool Initialized;

	[Token(Token = "0x4002519")]
	[FieldOffset(Offset = "0x4A")]
	public bool stuck;

	[Token(Token = "0x400251A")]
	[FieldOffset(Offset = "0x50")]
	private RotateWithVelocity2D rotator;

	[Token(Token = "0x6002083")]
	[Address(RVA = "0x1425EC4", Offset = "0x1425EC4", VA = "0x1425EC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002084")]
	[Address(RVA = "0x1426034", Offset = "0x1426034", VA = "0x1426034")]
	private void HitSomething(Collider2D hit)
	{
	}

	[Token(Token = "0x6002085")]
	[Address(RVA = "0x1426314", Offset = "0x1426314", VA = "0x1426314")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x6002086")]
	[Address(RVA = "0x142634C", Offset = "0x142634C", VA = "0x142634C")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x14263FC", Offset = "0x14263FC", VA = "0x14263FC")]
	public void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x14265F4", Offset = "0x14265F4", VA = "0x14265F4")]
	public Arrow2D()
	{
	}
}
