using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000725")]
public class SkiShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x40025AB")]
	[FieldOffset(Offset = "0x48")]
	public float JumpUpForce;

	[Token(Token = "0x40025AC")]
	[FieldOffset(Offset = "0x4C")]
	public float JumpForwardForce;

	[Token(Token = "0x40025AD")]
	[FieldOffset(Offset = "0x50")]
	public bool Grounded;

	[Token(Token = "0x40025AE")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 OrthographicSizeRange;

	[Token(Token = "0x40025AF")]
	[FieldOffset(Offset = "0x5C")]
	public bool DontModifyAngularDragInFlight;

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x16B4E6C", Offset = "0x16B4E6C", VA = "0x16B4E6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x16B4EBC", Offset = "0x16B4EBC", VA = "0x16B4EBC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x16B4FA8", Offset = "0x16B4FA8", VA = "0x16B4FA8")]
	private void OnCollisionStay2D(Collision2D other)
	{
	}

	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x16B5038", Offset = "0x16B5038", VA = "0x16B5038")]
	private void OnCollisionExit2D(Collision2D other)
	{
	}

	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x16B50C4", Offset = "0x16B50C4", VA = "0x16B50C4")]
	public SkiShooter()
	{
	}
}
