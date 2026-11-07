using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000411")]
public class MultiBallParChallenge : Challenge
{
	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0xA4")]
	public int ScoreToBeat;

	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0xA8")]
	private List<GolfBallController> controllers;

	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0xB0")]
	private int strokeCount;

	[Token(Token = "0x600131F")]
	[Address(RVA = "0x15795D0", Offset = "0x15795D0", VA = "0x15795D0", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0x157986C", Offset = "0x157986C", VA = "0x157986C")]
	private void OnObjectDestroyed(GameObject obj)
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x1579AB4", Offset = "0x1579AB4", VA = "0x1579AB4", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x1579BAC", Offset = "0x1579BAC", VA = "0x1579BAC")]
	private void OnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6001323")]
	[Address(RVA = "0x1579CA8", Offset = "0x1579CA8", VA = "0x1579CA8", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x1579D48", Offset = "0x1579D48", VA = "0x1579D48")]
	public MultiBallParChallenge()
	{
	}
}
