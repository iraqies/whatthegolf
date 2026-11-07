using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000724")]
public class RagdollShooter2D : GolfBall2DShooterBase
{
	[Token(Token = "0x40025A7")]
	[FieldOffset(Offset = "0x48")]
	public float Force;

	[Token(Token = "0x40025A8")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 RandomRange;

	[Token(Token = "0x40025A9")]
	[FieldOffset(Offset = "0x58")]
	public Rigidbody2D[] rigidbodies;

	[Token(Token = "0x40025AA")]
	[FieldOffset(Offset = "0x60")]
	public List<Rigidbody2D> blacklistRigidbodies;

	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x163DA68", Offset = "0x163DA68", VA = "0x163DA68", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x163DB7C", Offset = "0x163DB7C", VA = "0x163DB7C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x163DC60", Offset = "0x163DC60", VA = "0x163DC60")]
	public RagdollShooter2D()
	{
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x163DC7C", Offset = "0x163DC7C", VA = "0x163DC7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AD0", Offset = "0x65AD0")]
	private bool _003CAwake_003Eb__4_0(Rigidbody2D r)
	{
		return default;
	}
}
