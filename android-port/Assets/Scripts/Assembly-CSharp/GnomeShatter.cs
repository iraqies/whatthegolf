using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000043")]
public class GnomeShatter : MonoBehaviour
{
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x18")]
	private ObjectShatter shatter;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem shatterParticles;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int ParticlesOnBreak;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float ShatterForce;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioEventAsset sfxOnShatter;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x148E6A8", Offset = "0x148E6A8", VA = "0x148E6A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x148E728", Offset = "0x148E728", VA = "0x148E728")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x148E8B4", Offset = "0x148E8B4", VA = "0x148E8B4")]
	public GnomeShatter()
	{
	}
}
