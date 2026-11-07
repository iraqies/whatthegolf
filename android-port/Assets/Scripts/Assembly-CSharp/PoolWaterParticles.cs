using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000269")]
public class PoolWaterParticles : MonoBehaviour
{
	[Token(Token = "0x4000C77")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem splashParticles;

	[Token(Token = "0x4000C78")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ringParticles;

	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0x28")]
	public MinMax splashSizeRange;

	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x30")]
	public MinMax ringSizeRange;

	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.EmitParams splashParams;

	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0xC8")]
	private ParticleSystem.EmitParams ringParams;

	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x158")]
	private Transform root;

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x1619E40", Offset = "0x1619E40", VA = "0x1619E40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x1619E78", Offset = "0x1619E78", VA = "0x1619E78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0x1619E7C", Offset = "0x1619E7C", VA = "0x1619E7C")]
	public void DoSplash(Collider other)
	{
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x161A0F0", Offset = "0x161A0F0", VA = "0x161A0F0")]
	public PoolWaterParticles()
	{
	}
}
