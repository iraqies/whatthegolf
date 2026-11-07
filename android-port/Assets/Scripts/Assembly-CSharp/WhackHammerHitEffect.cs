using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000279")]
public class WhackHammerHitEffect : MonoBehaviour
{
	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0x18")]
	public Transform HitPosition;

	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x20")]
	public float HitRadius;

	[Token(Token = "0x4000CFE")]
	[FieldOffset(Offset = "0x28")]
	public WhackHammerController Controller;

	[Token(Token = "0x4000CFF")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection MissClip;

	[Token(Token = "0x4000D00")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection HitClip;

	[Token(Token = "0x4000D01")]
	[FieldOffset(Offset = "0x40")]
	public float Duration;

	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x44")]
	public float Speed;

	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0x48")]
	public float Magnitude;

	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem DustParticles;

	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem HoleParticles;

	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem CrackParticles;

	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem DirtParticles;

	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x1752C24", Offset = "0x1752C24", VA = "0x1752C24")]
	public void Hit()
	{
	}

	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x1752F44", Offset = "0x1752F44", VA = "0x1752F44")]
	public WhackHammerHitEffect()
	{
	}
}
