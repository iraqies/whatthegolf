using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D02")]
public class IceCubeShatter : MonoBehaviour
{
	[Token(Token = "0x40046AB")]
	[FieldOffset(Offset = "0x18")]
	private ObjectShatter shatter;

	[Token(Token = "0x40046AC")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem shatterParticles;

	[Token(Token = "0x40046AD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int ParticlesOnBreak;

	[Token(Token = "0x40046AE")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float ShatterForce;

	[Token(Token = "0x40046AF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioEventAsset sfxOnShatter;

	[Token(Token = "0x6003D75")]
	[Address(RVA = "0x14E2A4C", Offset = "0x14E2A4C", VA = "0x14E2A4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D76")]
	[Address(RVA = "0x14E2ACC", Offset = "0x14E2ACC", VA = "0x14E2ACC")]
	public void Shatter()
	{
	}

	[Token(Token = "0x6003D77")]
	[Address(RVA = "0x14E2B9C", Offset = "0x14E2B9C", VA = "0x14E2B9C")]
	public IceCubeShatter()
	{
	}
}
