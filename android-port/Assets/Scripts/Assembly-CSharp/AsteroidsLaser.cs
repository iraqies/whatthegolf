using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B1")]
public class AsteroidsLaser : MonoBehaviour
{
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x18")]
	public float LaserSpeed;

	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x1C")]
	public float Lifetime;

	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x20")]
	public Animator anim;

	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x28")]
	private bool deathStarted;

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x142B014", Offset = "0x142B014", VA = "0x142B014")]
	private void Start()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x142B0A4", Offset = "0x142B0A4", VA = "0x142B0A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x142B1A4", Offset = "0x142B1A4", VA = "0x142B1A4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x142B298", Offset = "0x142B298", VA = "0x142B298")]
	public AsteroidsLaser()
	{
	}
}
