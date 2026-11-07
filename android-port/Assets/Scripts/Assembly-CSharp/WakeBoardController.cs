using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E2")]
public class WakeBoardController : GolfBallShooterBase
{
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x60")]
	public Transform Boat;

	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x68")]
	public float MoveForce;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x6C")]
	public float JumpForce;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 targetDir;

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x174F670", Offset = "0x174F670", VA = "0x174F670", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0x174F7EC", Offset = "0x174F7EC", VA = "0x174F7EC", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0x174F818", Offset = "0x174F818", VA = "0x174F818", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0x174F874", Offset = "0x174F874", VA = "0x174F874", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0x174F9E8", Offset = "0x174F9E8", VA = "0x174F9E8")]
	public WakeBoardController()
	{
	}
}
