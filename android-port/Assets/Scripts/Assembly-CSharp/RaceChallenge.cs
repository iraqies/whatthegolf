using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200026A")]
public class RaceChallenge : Challenge
{
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject[] playerObjects;

	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject[] enemyObjects;

	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GolfCoursePinGoal pinGoal;

	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0xC0")]
	private RigidbodyCollisionInfo collisionInfo;

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x163A6EC", Offset = "0x163A6EC", VA = "0x163A6EC", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x163A8A8", Offset = "0x163A8A8", VA = "0x163A8A8")]
	private void OnFlagCollision(HitInfo hitInfo)
	{
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x163AA30", Offset = "0x163AA30", VA = "0x163AA30", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x163AA34", Offset = "0x163AA34", VA = "0x163AA34")]
	public RaceChallenge()
	{
	}
}
