using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000272")]
public class TotemController : GolfBallShooterBase
{
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x60")]
	public float MoveSpeed;

	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x64")]
	public float ShootSpeed;

	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x68")]
	public float RotateSpeed;

	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody Rigid;

	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 targetRot;

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x171E4DC", Offset = "0x171E4DC", VA = "0x171E4DC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x171E4EC", Offset = "0x171E4EC", VA = "0x171E4EC", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x171E518", Offset = "0x171E518", VA = "0x171E518", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x171E574", Offset = "0x171E574", VA = "0x171E574", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x171E6A8", Offset = "0x171E6A8", VA = "0x171E6A8")]
	public TotemController()
	{
	}
}
