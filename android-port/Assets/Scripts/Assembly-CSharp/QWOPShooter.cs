using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200025B")]
public class QWOPShooter : GolfBallShooterBase
{
	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x60")]
	public float Force;

	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x68")]
	private GolfBallController thisLeg;

	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x70")]
	public GolfBallController otherLeg;

	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 RandomRange;

	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x80")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x88")]
	public Rigidbody[] blacklist;

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x163255C", Offset = "0x163255C", VA = "0x163255C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x16325E8", Offset = "0x16325E8", VA = "0x16325E8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x1632708", Offset = "0x1632708", VA = "0x1632708")]
	public QWOPShooter()
	{
	}
}
