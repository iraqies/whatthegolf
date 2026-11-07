using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000864")]
public class SpiderLegsShooter : GolfBallShooterBase
{
	[Token(Token = "0x4002DAA")]
	[FieldOffset(Offset = "0x60")]
	public float fullShootVelocity;

	[Token(Token = "0x4002DAB")]
	[FieldOffset(Offset = "0x68")]
	public SpiderLegs Legs;

	[Token(Token = "0x4002DAC")]
	[FieldOffset(Offset = "0x70")]
	public Transform Body;

	[Token(Token = "0x4002DAD")]
	[FieldOffset(Offset = "0x78")]
	public Animator AnimatorCrab;

	[Token(Token = "0x4002DAE")]
	[FieldOffset(Offset = "0x80")]
	public Animator AnimatorRider;

	[Token(Token = "0x4002DAF")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F354", Offset = "0x4F354")]
	private bool UseAddForce__BackingField;

	[Token(Token = "0x17000429")]
	public bool UseAddForce
	{
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x16D4D2C", Offset = "0x16D4D2C", VA = "0x16D4D2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x66DB0", Offset = "0x66DB0")]
		get
		{
			return default;
		}
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x16D4D34", Offset = "0x16D4D34", VA = "0x16D4D34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x66DC0", Offset = "0x66DC0")]
		set
		{
		}
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x16D4D3C", Offset = "0x16D4D3C", VA = "0x16D4D3C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x16D4FE0", Offset = "0x16D4FE0", VA = "0x16D4FE0")]
	public SpiderLegsShooter()
	{
	}
}
