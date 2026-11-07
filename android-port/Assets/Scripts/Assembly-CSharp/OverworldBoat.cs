using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009E3")]
public class OverworldBoat : OverworldBall2D
{
	[Token(Token = "0x4003655")]
	[FieldOffset(Offset = "0xD8")]
	public float sailSpeed;

	[Token(Token = "0x4003656")]
	[FieldOffset(Offset = "0xDC")]
	public float RequiredDistanceForHittingFlags;

	[Token(Token = "0x4003657")]
	[FieldOffset(Offset = "0xE0")]
	private float distanceMovedSinceHitFlag;

	[Token(Token = "0x4003658")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 lastPos;

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x15A5CD8", Offset = "0x15A5CD8", VA = "0x15A5CD8", Slot = "16")]
	protected override void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x15A5D9C", Offset = "0x15A5D9C", VA = "0x15A5D9C", Slot = "15")]
	protected override void Controller_OnAimStart()
	{
	}

	[Token(Token = "0x6002EA9")]
	[Address(RVA = "0x15A5DA4", Offset = "0x15A5DA4", VA = "0x15A5DA4", Slot = "17")]
	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6002EAA")]
	[Address(RVA = "0x15A5DA8", Offset = "0x15A5DA8", VA = "0x15A5DA8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002EAB")]
	[Address(RVA = "0x15A5DB0", Offset = "0x15A5DB0", VA = "0x15A5DB0")]
	public OverworldBoat()
	{
	}
}
