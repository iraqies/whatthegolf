using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B3")]
public class TruckForceHelper : MonoBehaviour
{
	[Token(Token = "0x400230A")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController controller;

	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody forceSource;

	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody forceTarget;

	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x30")]
	public float multiplier;

	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x34")]
	public float baseForce;

	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x38")]
	public Transform localTargetPosition;

	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x40")]
	public float extraBaseWhenAiming;

	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x172F4FC", Offset = "0x172F4FC", VA = "0x172F4FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x172F680", Offset = "0x172F680", VA = "0x172F680")]
	public TruckForceHelper()
	{
	}
}
