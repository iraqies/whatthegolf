using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200031B")]
public class SimpleSpiderShooter : ShooterBase
{
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody hook;

	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody arm;

	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LayerMask HitLayer;

	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float HookSpeed;

	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float boostY;

	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float HookForwardMovement;

	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x40")]
	private bool HasHit;

	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0x41")]
	private bool HasShot;

	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float HitDotResult;

	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float ExtraUpwardsPullForce;

	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float realInSpeed;

	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float minDistance;

	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x16AF518", Offset = "0x16AF518", VA = "0x16AF518", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x16AF5A0", Offset = "0x16AF5A0", VA = "0x16AF5A0", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x16AF664", Offset = "0x16AF664", VA = "0x16AF664", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x16AF670", Offset = "0x16AF670", VA = "0x16AF670")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x16AF980", Offset = "0x16AF980", VA = "0x16AF980")]
	public SimpleSpiderShooter()
	{
	}
}
