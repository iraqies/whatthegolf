using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000858")]
public class SetSoccerPlayerTargetToBowlingBall : MonoBehaviour
{
	[Token(Token = "0x4002D54")]
	[FieldOffset(Offset = "0x18")]
	public BowlingShooter Shooter;

	[Token(Token = "0x4002D55")]
	[FieldOffset(Offset = "0x20")]
	public List<SoccerPlayer> SoccerPlayers;

	[Token(Token = "0x6002680")]
	[Address(RVA = "0x168F904", Offset = "0x168F904", VA = "0x168F904")]
	private void Start()
	{
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0x168F9E8", Offset = "0x168F9E8", VA = "0x168F9E8")]
	private void BallShot(Rigidbody bowlingBall)
	{
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0x168FB40", Offset = "0x168FB40", VA = "0x168FB40")]
	public SetSoccerPlayerTargetToBowlingBall()
	{
	}
}
