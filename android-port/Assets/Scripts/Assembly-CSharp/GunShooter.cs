using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005DD")]
public class GunShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4001DD9")]
	[FieldOffset(Offset = "0x48")]
	public Rigidbody2D BulletPrefab;

	[Token(Token = "0x4001DDA")]
	[FieldOffset(Offset = "0x50")]
	public float BulletSpeed;

	[Token(Token = "0x4001DDB")]
	[FieldOffset(Offset = "0x58")]
	public Transform SpawnPosition;

	[Token(Token = "0x4001DDC")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 LookRanges;

	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x14BEE8C", Offset = "0x14BEE8C", VA = "0x14BEE8C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x14BEFE4", Offset = "0x14BEFE4", VA = "0x14BEFE4", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x14BF0B0", Offset = "0x14BF0B0", VA = "0x14BF0B0")]
	public GunShooter()
	{
	}
}
