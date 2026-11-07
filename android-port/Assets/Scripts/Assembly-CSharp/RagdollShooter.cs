using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000723")]
public class RagdollShooter : GolfBallShooterBase
{
	[Token(Token = "0x400259F")]
	[FieldOffset(Offset = "0x60")]
	public float Force;

	[Token(Token = "0x40025A0")]
	[FieldOffset(Offset = "0x64")]
	public float Pitch;

	[Token(Token = "0x40025A1")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 RandomRange;

	[Token(Token = "0x40025A2")]
	[FieldOffset(Offset = "0x70")]
	public bool ignoreTail;

	[Token(Token = "0x40025A3")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x40025A4")]
	[FieldOffset(Offset = "0x80")]
	public Rigidbody[] blacklist;

	[Token(Token = "0x40025A5")]
	[FieldOffset(Offset = "0x88")]
	public UnityEvent BeforeFirstShot;

	[Token(Token = "0x40025A6")]
	[FieldOffset(Offset = "0x90")]
	public bool FullPowerOnFirstShot;

	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x163D77C", Offset = "0x163D77C", VA = "0x163D77C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x163D7E4", Offset = "0x163D7E4", VA = "0x163D7E4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x163DA4C", Offset = "0x163DA4C", VA = "0x163DA4C")]
	public RagdollShooter()
	{
	}
}
