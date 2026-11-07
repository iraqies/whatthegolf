using Audio;
using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200026E")]
public class SimpleRaceChallenge : Challenge
{
	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject[] playerObjects;

	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject[] enemyObjects;

	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GolfCoursePinGoal pinGoal;

	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private int preplayCountdownTime;

	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0xC8")]
	private RigidbodyCollisionInfo collisionInfo;

	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0xD0")]
	private GolfBallController controller;

	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0xD8")]
	private StopwatchSFX stopwatchSFX;

	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0xE0")]
	private float countdownTimer;

	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0xE4")]
	private int wholeSecTimer;

	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0xE8")]
	private FlagAudio flagAudio;

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x16AE808", Offset = "0x16AE808", VA = "0x16AE808", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x16AEABC", Offset = "0x16AEABC", VA = "0x16AEABC", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x16AEC04", Offset = "0x16AEC04", VA = "0x16AEC04")]
	private void OnFlagCollision(HitInfo hitInfo)
	{
	}

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x16AEE34", Offset = "0x16AEE34", VA = "0x16AEE34", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x16AEE38", Offset = "0x16AEE38", VA = "0x16AEE38")]
	public SimpleRaceChallenge()
	{
	}
}
