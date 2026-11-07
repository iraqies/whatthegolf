using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076F")]
public class FollowArrowSlow : MonoBehaviour
{
	[Token(Token = "0x4002758")]
	[FieldOffset(Offset = "0x18")]
	public BallShooter shooter;

	[Token(Token = "0x4002759")]
	[FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	[Token(Token = "0x400275A")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 smoothVel;

	[Token(Token = "0x400275B")]
	[FieldOffset(Offset = "0x30")]
	private bool isAdjusting;

	[Token(Token = "0x400275C")]
	[FieldOffset(Offset = "0x38")]
	private Collider2D collider;

	[Token(Token = "0x600223B")]
	[Address(RVA = "0x146F0A0", Offset = "0x146F0A0", VA = "0x146F0A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600223C")]
	[Address(RVA = "0x146F298", Offset = "0x146F298", VA = "0x146F298")]
	private void UpdateFollow(Vector3 boost, bool t)
	{
	}

	[Token(Token = "0x600223D")]
	[Address(RVA = "0x146F3F4", Offset = "0x146F3F4", VA = "0x146F3F4")]
	private void Shooter_OnShoot(Vector2 obj)
	{
	}

	[Token(Token = "0x600223E")]
	[Address(RVA = "0x146F4A0", Offset = "0x146F4A0", VA = "0x146F4A0")]
	public FollowArrowSlow()
	{
	}
}
