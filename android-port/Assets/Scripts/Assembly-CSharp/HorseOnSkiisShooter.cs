using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E4")]
public class HorseOnSkiisShooter : GolfBallShooterBase
{
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x60")]
	public float Force;

	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x64")]
	public float Pitch;

	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 RandomRange;

	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody[] blacklist;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x80")]
	private GolfBallController horseController;

	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x88")]
	public GolfBallController catController;

	[Token(Token = "0x6000871")]
	[Address(RVA = "0x14D7F6C", Offset = "0x14D7F6C", VA = "0x14D7F6C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0x14D7FF8", Offset = "0x14D7FF8", VA = "0x14D7FF8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0x14D81D0", Offset = "0x14D81D0", VA = "0x14D81D0")]
	public HorseOnSkiisShooter()
	{
	}
}
