using System.Collections.Generic;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000112")]
public class StikboldHitEffect : MonoBehaviour
{
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x18")]
	public FinalLevel FinalLevel;

	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x20")]
	public BallSpawner BallSpawner;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x28")]
	public Transform Center;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x30")]
	public float Force;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Collider;

	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem Particles;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x48")]
	public CameraManager Manager;

	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x50")]
	private List<GolfBallController> controllers;

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x16E0E24", Offset = "0x16E0E24", VA = "0x16E0E24")]
	private void Start()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x16E0FE4", Offset = "0x16E0FE4", VA = "0x16E0FE4")]
	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x16E12BC", Offset = "0x16E12BC", VA = "0x16E12BC")]
	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo hitPlayer, int health)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x16E1A70", Offset = "0x16E1A70", VA = "0x16E1A70")]
	public StikboldHitEffect()
	{
	}
}
