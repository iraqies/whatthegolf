using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000789")]
public class MoveBetween : MonoBehaviour
{
	[Token(Token = "0x40027D2")]
	[FieldOffset(Offset = "0x18")]
	public bool startMoving;

	[Token(Token = "0x40027D3")]
	[FieldOffset(Offset = "0x19")]
	public bool stopOnShoot;

	[Token(Token = "0x40027D4")]
	[FieldOffset(Offset = "0x1A")]
	public bool startOnShoot;

	[Token(Token = "0x40027D5")]
	[FieldOffset(Offset = "0x20")]
	public Transform A;

	[Token(Token = "0x40027D6")]
	[FieldOffset(Offset = "0x28")]
	public Transform B;

	[Token(Token = "0x40027D7")]
	[FieldOffset(Offset = "0x30")]
	public float offsetTimer;

	[Token(Token = "0x40027D8")]
	[FieldOffset(Offset = "0x34")]
	public float Speed;

	[Token(Token = "0x40027D9")]
	[FieldOffset(Offset = "0x38")]
	public float startPos;

	[Token(Token = "0x40027DA")]
	[FieldOffset(Offset = "0x40")]
	private BallShooter shooter;

	[Token(Token = "0x40027DB")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40027DC")]
	[FieldOffset(Offset = "0x50")]
	private float adjustedSpeed;

	[Token(Token = "0x40027DD")]
	[FieldOffset(Offset = "0x54")]
	private float timer;

	[Token(Token = "0x40027DE")]
	[FieldOffset(Offset = "0x58")]
	private bool isMoving;

	[Token(Token = "0x600229D")]
	[Address(RVA = "0x157088C", Offset = "0x157088C", VA = "0x157088C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600229E")]
	[Address(RVA = "0x1570AC8", Offset = "0x1570AC8", VA = "0x1570AC8")]
	private void Shooter_OnShoot(Vector2 dir)
	{
	}

	[Token(Token = "0x600229F")]
	[Address(RVA = "0x1570AEC", Offset = "0x1570AEC", VA = "0x1570AEC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x1570BD4", Offset = "0x1570BD4", VA = "0x1570BD4")]
	public MoveBetween()
	{
	}
}
