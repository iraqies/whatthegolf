using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B8")]
public class Katamari2DShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x4001D33")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float fullShootVelocity;

	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float directionalSpin;

	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x14FA33C", Offset = "0x14FA33C", VA = "0x14FA33C", Slot = "4")]
	public override void OnActivate()
	{
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x14FA374", Offset = "0x14FA374", VA = "0x14FA374", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x14FA3D4", Offset = "0x14FA3D4", VA = "0x14FA3D4")]
	public Katamari2DShooter()
	{
	}
}
