using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F8")]
public class BilliardGolf : MonoBehaviour
{
	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> Balls;

	[Token(Token = "0x4001E80")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController PlayerBall;

	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0x28")]
	public GolfGoal Goal;

	[Token(Token = "0x4001E82")]
	[FieldOffset(Offset = "0x30")]
	public RandomAudioClips BallToHoleClips;

	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x16114B8", Offset = "0x16114B8", VA = "0x16114B8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x1610ECC", Offset = "0x1610ECC", VA = "0x1610ECC")]
	public void HoleHit(Collider other, bool destroy = true)
	{
	}

	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x16114C0", Offset = "0x16114C0", VA = "0x16114C0")]
	private void CheckBall(Collider other, bool destroy)
	{
	}

	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x1610DE0", Offset = "0x1610DE0", VA = "0x1610DE0")]
	public void CheckIfPlayer(GameObject go)
	{
	}

	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x1611648", Offset = "0x1611648", VA = "0x1611648")]
	public BilliardGolf()
	{
	}
}
