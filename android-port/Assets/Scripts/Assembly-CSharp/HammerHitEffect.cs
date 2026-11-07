using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000119")]
public class HammerHitEffect : MonoBehaviour
{
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x18")]
	public Transform HitPosition;

	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x20")]
	public float HitRadius;

	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x28")]
	public WhackAMoleController Controller;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection MissClip;

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection HitClip;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x40")]
	public float Duration;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x44")]
	public float Speed;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x48")]
	public float Magnitude;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem DustParticles;

	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem HoleParticles;

	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem CrackParticles;

	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem DirtParticles;

	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x70")]
	private List<HoleToWhack> holes;

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x14C0E90", Offset = "0x14C0E90", VA = "0x14C0E90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x14C0F30", Offset = "0x14C0F30", VA = "0x14C0F30")]
	public void Hit()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x14C124C", Offset = "0x14C124C", VA = "0x14C124C")]
	public HammerHitEffect()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x14C1274", Offset = "0x14C1274", VA = "0x14C1274")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E608", Offset = "0x5E608")]
	private float _003CHit_003Eb__14_0(HoleToWhack h)
	{
		return default;
	}
}
