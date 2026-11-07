using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200071E")]
public class HorseThrowerShooter : GolfBall2DShooterExperimental
{
	[Token(Token = "0x4002589")]
	[FieldOffset(Offset = "0x5C")]
	public float TrackLength;

	[Token(Token = "0x400258A")]
	[FieldOffset(Offset = "0x60")]
	public Animator HorseAnimator;

	[Token(Token = "0x400258B")]
	[FieldOffset(Offset = "0x68")]
	public FixedJoint2D ManJoint;

	[Token(Token = "0x400258C")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody2D ManRigid;

	[Token(Token = "0x400258D")]
	[FieldOffset(Offset = "0x78")]
	private float currentSpeed;

	[Token(Token = "0x400258E")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 lastPos;

	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x14D8E70", Offset = "0x14D8E70", VA = "0x14D8E70", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x14D8F34", Offset = "0x14D8F34", VA = "0x14D8F34", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x14D9174", Offset = "0x14D9174", VA = "0x14D9174")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x14D920C", Offset = "0x14D920C", VA = "0x14D920C")]
	public HorseThrowerShooter()
	{
	}
}
