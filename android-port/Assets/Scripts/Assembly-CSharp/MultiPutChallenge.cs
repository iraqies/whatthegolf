using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000412")]
public class MultiPutChallenge : Challenge
{
	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0xA4")]
	public int ballsToWin;

	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0xA8")]
	public bool dontUsePlayer;

	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject ballDisappearParticles;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0xB8")]
	public bool isManualSet;

	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0xC0")]
	public List<GameObject> objectsToPut;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0xC8")]
	private GolfBallController[] _controllers;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0xD0")]
	private MultiBallFlag _multiBallFlag;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0xD8")]
	private ObjectDestroyable _objectDestroyTrigger;

	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0xE0")]
	private int _currentPutCount;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0xE4")]
	private int _activeBallCount;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0xE8")]
	private TiltChallengeSFX SFX;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0xF0")]
	private bool isUnloadingLevel;

	[Token(Token = "0x6001325")]
	[Address(RVA = "0x1579EE0", Offset = "0x1579EE0", VA = "0x1579EE0", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001326")]
	[Address(RVA = "0x157A444", Offset = "0x157A444", VA = "0x157A444")]
	private void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6001327")]
	[Address(RVA = "0x157A450", Offset = "0x157A450", VA = "0x157A450")]
	private void OnObjectWillDestroy(GameObject go)
	{
	}

	[Token(Token = "0x6001328")]
	[Address(RVA = "0x157A530", Offset = "0x157A530", VA = "0x157A530")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001329")]
	[Address(RVA = "0x157A664", Offset = "0x157A664", VA = "0x157A664")]
	private void OnMultiballFlagHit(GameObject go)
	{
	}

	[Token(Token = "0x600132A")]
	[Address(RVA = "0x157A910", Offset = "0x157A910", VA = "0x157A910", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600132B")]
	[Address(RVA = "0x157AA44", Offset = "0x157AA44", VA = "0x157AA44", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x600132C")]
	[Address(RVA = "0x157AAA8", Offset = "0x157AAA8", VA = "0x157AAA8", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600132D")]
	[Address(RVA = "0x157AAAC", Offset = "0x157AAAC", VA = "0x157AAAC")]
	public MultiPutChallenge()
	{
	}
}
