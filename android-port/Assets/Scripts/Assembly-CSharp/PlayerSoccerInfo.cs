using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000856")]
public class PlayerSoccerInfo : MonoBehaviour
{
	[Token(Token = "0x4002D2E")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x4002D2F")]
	[FieldOffset(Offset = "0x20")]
	public Transform BallPosition;

	[Token(Token = "0x4002D30")]
	[FieldOffset(Offset = "0x28")]
	public Animator Animator;

	[Token(Token = "0x4002D31")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem SlideParticles;

	[Token(Token = "0x4002D32")]
	[FieldOffset(Offset = "0x38")]
	public RandomAudioClips SlideClips;

	[Token(Token = "0x4002D33")]
	[FieldOffset(Offset = "0x40")]
	public BoxCollider FieldArea;

	[Token(Token = "0x4002D34")]
	[FieldOffset(Offset = "0x48")]
	public Action OnOutOfBounds;

	[Token(Token = "0x4002D35")]
	[FieldOffset(Offset = "0x50")]
	public Action OnBallRecieved;

	[Token(Token = "0x4002D36")]
	[FieldOffset(Offset = "0x58")]
	public Action OnBallLost;

	[Token(Token = "0x6002673")]
	[Address(RVA = "0x15FB7FC", Offset = "0x15FB7FC", VA = "0x15FB7FC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0x15F6BE0", Offset = "0x15F6BE0", VA = "0x15F6BE0")]
	public bool IsSliding()
	{
		return default;
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0x15FB8D4", Offset = "0x15FB8D4", VA = "0x15FB8D4")]
	public void Slide(Vector3 dir)
	{
	}

	[Token(Token = "0x6002676")]
	[Address(RVA = "0x15FB950", Offset = "0x15FB950", VA = "0x15FB950")]
	public PlayerSoccerInfo()
	{
	}
}
