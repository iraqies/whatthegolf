using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200059D")]
public class FollowParticles : MonoBehaviour
{
	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem System;

	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ObjectsThatFollow;

	[Token(Token = "0x4001CB7")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] objects;

	[Token(Token = "0x4001CB9")]
	[FieldOffset(Offset = "0x38")]
	public float m_Drift;

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x146F9D4", Offset = "0x146F9D4", VA = "0x146F9D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0x146FB48", Offset = "0x146FB48", VA = "0x146FB48")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600199B")]
	[Address(RVA = "0x146FDB4", Offset = "0x146FDB4", VA = "0x146FDB4")]
	private void InitializeIfNeeded()
	{
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0x146FE6C", Offset = "0x146FE6C", VA = "0x146FE6C")]
	public FollowParticles()
	{
	}
}
