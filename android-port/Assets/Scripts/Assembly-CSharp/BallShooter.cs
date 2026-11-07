using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000760")]
public class BallShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x48")]
	public float offsetDistance;

	[Token(Token = "0x4002726")]
	[FieldOffset(Offset = "0x4C")]
	public bool didShoot;

	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x50")]
	public Action<Vector2> OnShootEvent;

	[Token(Token = "0x6002203")]
	[Address(RVA = "0x15191B4", Offset = "0x15191B4", VA = "0x15191B4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002204")]
	[Address(RVA = "0x1519294", Offset = "0x1519294", VA = "0x1519294")]
	public BallShooter()
	{
	}
}
