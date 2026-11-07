using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000278")]
public class WhackHammerController : GolfBallShooterBase
{
	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Animator hammerAnimator;

	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float rotateSpeed;

	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float blockTime;

	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x78")]
	public Action<float> OnHit;

	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x80")]
	private float blockTimer;

	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody rigid;

	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0x90")]
	private float lastShootVelMag;

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x17528AC", Offset = "0x17528AC", VA = "0x17528AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x1752908", Offset = "0x1752908", VA = "0x1752908")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x1752948", Offset = "0x1752948", VA = "0x1752948", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x17529BC", Offset = "0x17529BC", VA = "0x17529BC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x1752B0C", Offset = "0x1752B0C", VA = "0x1752B0C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x1752BA8", Offset = "0x1752BA8", VA = "0x1752BA8")]
	public void HitSomething()
	{
	}

	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x1752C08", Offset = "0x1752C08", VA = "0x1752C08")]
	public WhackHammerController()
	{
	}
}
