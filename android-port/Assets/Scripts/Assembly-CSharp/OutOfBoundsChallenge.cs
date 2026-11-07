using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000414")]
public class OutOfBoundsChallenge : Challenge
{
	[Token(Token = "0x4001643")]
	[FieldOffset(Offset = "0xA1")]
	public bool useCustomAmount;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0xA4")]
	public int customAmount;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0xA8")]
	public List<GameObject> ObjectsToObserve;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0xB0")]
	private TiltChallengeSFX sfx;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0xB8")]
	private CBFollow _cbFollow;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0xC0")]
	private GolfBallController _golfBallController;

	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0xC8")]
	private int knockoutCount;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0xCC")]
	private int count;

	[Token(Token = "0x6001331")]
	[Address(RVA = "0x159E2E8", Offset = "0x159E2E8", VA = "0x159E2E8", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001332")]
	[Address(RVA = "0x159E7D4", Offset = "0x159E7D4", VA = "0x159E7D4")]
	private void OnOnOutOfBounds(OutOfBoundsTrigger outOfBoundsTrigger)
	{
	}

	[Token(Token = "0x6001333")]
	[Address(RVA = "0x159E97C", Offset = "0x159E97C", VA = "0x159E97C")]
	public OutOfBoundsChallenge()
	{
	}
}
