using System.Collections.Generic;
using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200041D")]
public class StoneInOneChallenge : Challenge
{
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0xA1")]
	public bool failOnHitFlagBeforeMaxSwallow;

	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0xA4")]
	public float stoneScaleSpeed;

	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0xA8")]
	private ChallengeHoleAbsorber _absorber;

	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0xB0")]
	private GolfBallController _controller;

	[Token(Token = "0x4001685")]
	[FieldOffset(Offset = "0xB8")]
	private int _swallowCount;

	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0xBC")]
	public int swallowsToWin;

	[Token(Token = "0x4001687")]
	[FieldOffset(Offset = "0xC0")]
	public bool completeOnSwallowCount;

	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0xC1")]
	[SerializeField]
	private bool clampSize;

	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	private float maxSize;

	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0xC8")]
	private GolfCoursePinGoal golfGoal;

	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0xD0")]
	private readonly List<GameObject> _collectedStones;

	[Token(Token = "0x600135C")]
	[Address(RVA = "0x16E1B00", Offset = "0x16E1B00", VA = "0x16E1B00", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600135D")]
	[Address(RVA = "0x16E1D44", Offset = "0x16E1D44", VA = "0x16E1D44")]
	private void OnStoneSwallow(GameObject obj)
	{
	}

	[Token(Token = "0x600135E")]
	[Address(RVA = "0x16E1E78", Offset = "0x16E1E78", VA = "0x16E1E78", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x600135F")]
	[Address(RVA = "0x16E21B4", Offset = "0x16E21B4", VA = "0x16E21B4", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001360")]
	[Address(RVA = "0x16E21E0", Offset = "0x16E21E0", VA = "0x16E21E0", Slot = "7")]
	public override void OnLevelFail(GolfBallController arg1, string arg2, Level.State arg3)
	{
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0x16E21E8", Offset = "0x16E21E8", VA = "0x16E21E8")]
	public StoneInOneChallenge()
	{
	}
}
