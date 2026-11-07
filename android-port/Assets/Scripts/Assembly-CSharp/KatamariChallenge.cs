using System.Collections.Generic;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000409")]
public class KatamariChallenge : Challenge
{
	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4D5AC", Offset = "0x4D5AC")]
	public List<GameObject> objectsToDeactivateDEPRICATED;

	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0xB0")]
	private ChallengeKatamariBall _katamariBall;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0xB8")]
	public int objectCountToWin;

	[Token(Token = "0x4001607")]
	[FieldOffset(Offset = "0xC0")]
	private CBFollow[] _cbFollows;

	[Token(Token = "0x4001608")]
	[FieldOffset(Offset = "0xC8")]
	private float _ballSize;

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x14FBDBC", Offset = "0x14FBDBC", VA = "0x14FBDBC", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x14FC204", Offset = "0x14FC204", VA = "0x14FC204")]
	private void OnBallGrow(int objectCount, float size)
	{
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x14FC394", Offset = "0x14FC394", VA = "0x14FC394")]
	public KatamariChallenge()
	{
	}
}
