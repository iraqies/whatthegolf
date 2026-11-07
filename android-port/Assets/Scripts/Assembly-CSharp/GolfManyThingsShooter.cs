using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007CD")]
public class GolfManyThingsShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x88")]
	public List<Rigidbody> AdditionalThings;

	[Token(Token = "0x400294F")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 RandomForceMod;

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x14A1F2C", Offset = "0x14A1F2C", VA = "0x14A1F2C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x14A21CC", Offset = "0x14A21CC", VA = "0x14A21CC")]
	public GolfManyThingsShooter()
	{
	}
}
