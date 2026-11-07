using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000FA")]
public class ChairBeachBall : MonoBehaviour
{
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem HitParticles;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x20")]
	public float pushForce;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x28")]
	public CrabsController CrabController;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x30")]
	public PlayerHit playhit;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x38")]
	private GolfBallController owner;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x40")]
	private SuperGolfShooter superShooter;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x50")]
	private float baseMaxShoot;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x54")]
	private float nextPushTime;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine shootSpeedRoutine;

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x1890F74", Offset = "0x1890F74", VA = "0x1890F74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x1891030", Offset = "0x1891030", VA = "0x1891030")]
	public void Push(Vector3 dir)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x18911D0", Offset = "0x18911D0", VA = "0x18911D0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x189173C", Offset = "0x189173C", VA = "0x189173C")]
	public ChairBeachBall()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x189174C", Offset = "0x189174C", VA = "0x189174C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E3E8", Offset = "0x5E3E8")]
	private void _003CPush_003Eb__11_0(float t)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x189178C", Offset = "0x189178C", VA = "0x189178C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E3F8", Offset = "0x5E3F8")]
	private void _003CPush_003Eb__11_1()
	{
	}
}
