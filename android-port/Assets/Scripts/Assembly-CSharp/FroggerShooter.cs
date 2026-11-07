using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000770")]
public class FroggerShooter : BallShooter
{
	[Token(Token = "0x400275D")]
	[FieldOffset(Offset = "0x58")]
	public float moveDistnace;

	[Token(Token = "0x400275E")]
	[FieldOffset(Offset = "0x5C")]
	public float speed;

	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 target;

	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 bounds;

	[Token(Token = "0x600223F")]
	[Address(RVA = "0x1475980", Offset = "0x1475980", VA = "0x1475980", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002240")]
	[Address(RVA = "0x14759C8", Offset = "0x14759C8", VA = "0x14759C8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002241")]
	[Address(RVA = "0x1475A84", Offset = "0x1475A84", VA = "0x1475A84", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002242")]
	[Address(RVA = "0x1475B58", Offset = "0x1475B58", VA = "0x1475B58")]
	public FroggerShooter()
	{
	}
}
