using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A4")]
public class ParticleTriggerEvent : MonoBehaviour
{
	[Token(Token = "0x4001CD8")]
	[FieldOffset(Offset = "0x18")]
	public WaterParticles SplashParticles;

	[Token(Token = "0x4001CD9")]
	[FieldOffset(Offset = "0x20")]
	public bool ignoreSound;

	[Token(Token = "0x4001CDA")]
	[FieldOffset(Offset = "0x24")]
	public float SizeMod;

	[Token(Token = "0x4001CDB")]
	[FieldOffset(Offset = "0x28")]
	public WaterStreamSFX waterStreamSFX;

	[Token(Token = "0x4001CDC")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem particles;

	[Token(Token = "0x4001CDD")]
	[FieldOffset(Offset = "0x38")]
	private List<ParticleSystem.Particle> enter;

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x15DBF30", Offset = "0x15DBF30", VA = "0x15DBF30")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x15DBF8C", Offset = "0x15DBF8C", VA = "0x15DBF8C")]
	private void OnParticleTrigger()
	{
	}

	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x15DC2A0", Offset = "0x15DC2A0", VA = "0x15DC2A0")]
	public ParticleTriggerEvent()
	{
	}
}
