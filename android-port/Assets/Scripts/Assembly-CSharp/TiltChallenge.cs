using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000424")]
public class TiltChallenge : Challenge
{
	[Token(Token = "0x40016A6")]
	[FieldOffset(Offset = "0xA8")]
	public List<GameObject> ObjectsToTilt;

	[Token(Token = "0x40016A7")]
	[FieldOffset(Offset = "0xB0")]
	private TiltChallengeSFX SFX;

	[Token(Token = "0x40016A8")]
	[FieldOffset(Offset = "0xB8")]
	private int count;

	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0xC0")]
	private GolfBallController controller;

	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject[] boundsList;

	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0xD0")]
	public bool disableBoundsOnWin;

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x1713E78", Offset = "0x1713E78", VA = "0x1713E78", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0x1714340", Offset = "0x1714340", VA = "0x1714340")]
	private void OnTip(GameObject go)
	{
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0x17144E4", Offset = "0x17144E4", VA = "0x17144E4", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0x171462C", Offset = "0x171462C", VA = "0x171462C", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x1714690", Offset = "0x1714690", VA = "0x1714690")]
	public TiltChallenge()
	{
	}
}
