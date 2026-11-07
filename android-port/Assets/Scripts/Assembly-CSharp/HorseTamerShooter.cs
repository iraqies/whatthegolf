using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B7")]
public class HorseTamerShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4001D30")]
	[FieldOffset(Offset = "0x48")]
	public float Force;

	[Token(Token = "0x4001D31")]
	[FieldOffset(Offset = "0x50")]
	public Rigidbody2D[] rigidbodies;

	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x14D8D90", Offset = "0x14D8D90", VA = "0x14D8D90", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x14D8D98", Offset = "0x14D8D98", VA = "0x14D8D98", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x14D8E68", Offset = "0x14D8E68", VA = "0x14D8E68")]
	public HorseTamerShooter()
	{
	}
}
