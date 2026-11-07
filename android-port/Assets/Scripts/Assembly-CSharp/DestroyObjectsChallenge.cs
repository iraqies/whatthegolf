using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000405")]
public class DestroyObjectsChallenge : Challenge
{
	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0xA8")]
	public List<GameObject> ObjectsToDestroy;

	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0xB0")]
	private int destroyed;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0xB8")]
	private GolfBallController controller;

	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0xC0")]
	private bool running;

	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x18DAE28", Offset = "0x18DAE28", VA = "0x18DAE28", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x18DAF08", Offset = "0x18DAF08", VA = "0x18DAF08", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x18DB0D4", Offset = "0x18DB0D4", VA = "0x18DB0D4")]
	public DestroyObjectsChallenge()
	{
	}
}
