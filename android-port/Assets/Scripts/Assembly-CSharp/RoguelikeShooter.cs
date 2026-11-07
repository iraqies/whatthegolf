using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000814")]
public class RoguelikeShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x4002B7E")]
	[FieldOffset(Offset = "0x88")]
	public List<GameObject> HealthIcons;

	[Token(Token = "0x4002B7F")]
	[FieldOffset(Offset = "0x90")]
	public ParticleSystem HeartBreakParticles;

	[Token(Token = "0x4002B80")]
	[FieldOffset(Offset = "0x98")]
	public LayerMask HitLayers;

	[Token(Token = "0x4002B81")]
	[FieldOffset(Offset = "0x9C")]
	public float StepSize;

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x165BE6C", Offset = "0x165BE6C", VA = "0x165BE6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x165BF40", Offset = "0x165BF40", VA = "0x165BF40", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x165BB94", Offset = "0x165BB94", VA = "0x165BB94")]
	public void TakeDamage()
	{
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x165C168", Offset = "0x165C168", VA = "0x165C168")]
	public RoguelikeShooter()
	{
	}
}
