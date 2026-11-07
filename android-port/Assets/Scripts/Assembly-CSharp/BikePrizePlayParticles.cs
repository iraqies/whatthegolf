using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E72")]
public class BikePrizePlayParticles : MonoBehaviour
{
	[Token(Token = "0x4004E2C")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem ps1;

	[Token(Token = "0x4004E2D")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ps2;

	[Token(Token = "0x6004389")]
	[Address(RVA = "0x1610D40", Offset = "0x1610D40", VA = "0x1610D40")]
	public void PlayParticleSystem1()
	{
	}

	[Token(Token = "0x600438A")]
	[Address(RVA = "0x1610D5C", Offset = "0x1610D5C", VA = "0x1610D5C")]
	public void PlayParticleSystem2()
	{
	}

	[Token(Token = "0x600438B")]
	[Address(RVA = "0x1610D78", Offset = "0x1610D78", VA = "0x1610D78")]
	public BikePrizePlayParticles()
	{
	}
}
