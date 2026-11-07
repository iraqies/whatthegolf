using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000854")]
public class PlayableSoccerAI : MonoBehaviour
{
	[Token(Token = "0x4002D24")]
	[FieldOffset(Offset = "0x18")]
	public FakeController Controller;

	[Token(Token = "0x4002D25")]
	[FieldOffset(Offset = "0x20")]
	public Transform GoalTarget;

	[Token(Token = "0x4002D26")]
	[FieldOffset(Offset = "0x28")]
	public PlayableSoccerBall Ball;

	[Token(Token = "0x4002D27")]
	[FieldOffset(Offset = "0x30")]
	public List<PlayerSoccerInfo> Players;

	[Token(Token = "0x6002667")]
	[Address(RVA = "0x15F65A0", Offset = "0x15F65A0", VA = "0x15F65A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002668")]
	[Address(RVA = "0x15F6814", Offset = "0x15F6814", VA = "0x15F6814")]
	private void OnBallLost()
	{
	}

	[Token(Token = "0x6002669")]
	[Address(RVA = "0x15F6850", Offset = "0x15F6850", VA = "0x15F6850")]
	private void OnBallRecieved()
	{
	}

	[Token(Token = "0x600266A")]
	[Address(RVA = "0x15F6870", Offset = "0x15F6870", VA = "0x15F6870")]
	public PlayableSoccerAI()
	{
	}
}
