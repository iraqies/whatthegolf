using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D2")]
public class AudioFromParticleImpact : MonoBehaviour
{
	[Token(Token = "0x4000F68")]
	[FieldOffset(Offset = "0x18")]
	public AudioSource Source;

	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x20")]
	public float minVol;

	[Token(Token = "0x4000F6A")]
	[FieldOffset(Offset = "0x24")]
	public float maxVol;

	[Token(Token = "0x4000F6B")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x2C")]
	public float decay;

	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x30")]
	private bool shouldDecay;

	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x34")]
	private float shootTime;

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x142D78C", Offset = "0x142D78C", VA = "0x142D78C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x142D7AC", Offset = "0x142D7AC", VA = "0x142D7AC")]
	public void TurnOn()
	{
	}

	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x142D7D8", Offset = "0x142D7D8", VA = "0x142D7D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x142D8A4", Offset = "0x142D8A4", VA = "0x142D8A4")]
	public AudioFromParticleImpact()
	{
	}
}
