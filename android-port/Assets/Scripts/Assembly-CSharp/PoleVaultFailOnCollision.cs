using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DA")]
public class PoleVaultFailOnCollision : MonoBehaviour
{
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x18")]
	public ImpactUser impactSfx;

	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x20")]
	public List<Joint> JointsToDestroy;

	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask CollisionLayer;

	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x2C")]
	public float FailLevelDelay;

	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection FailClip;

	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x38")]
	public bool AddExplosiveForce;

	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x3C")]
	public float ExplosionForce;

	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x40")]
	public float ExplosionRadius;

	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x44")]
	public float Upwards;

	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x48")]
	private bool hasFailed;

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x160582C", Offset = "0x160582C", VA = "0x160582C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x1605E94", Offset = "0x1605E94", VA = "0x1605E94")]
	public PoleVaultFailOnCollision()
	{
	}
}
