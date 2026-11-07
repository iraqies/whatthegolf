using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000403")]
public class BadBallChallenge : Challenge
{
	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0xA8")]
	public List<GolfBallController> goodBalls;

	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject goalPin;

	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0xB8")]
	private BadBallChecker checker;

	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0xC0")]
	private FlagAudio audio;

	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x151668C", Offset = "0x151668C", VA = "0x151668C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x1516894", Offset = "0x1516894", VA = "0x1516894")]
	public void OnFlagHit(GolfBallController ball)
	{
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x1516940", Offset = "0x1516940", VA = "0x1516940", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x1516A10", Offset = "0x1516A10", VA = "0x1516A10", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x1516A74", Offset = "0x1516A74", VA = "0x1516A74")]
	public BadBallChallenge()
	{
	}
}
