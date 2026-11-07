using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C76")]
public class WaterParticles : MonoBehaviour
{
	[Token(Token = "0x2000C77")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44128", Offset = "0x44128")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400444B")]
		[FieldOffset(Offset = "0x10")]
		public WaterParticles _003C_003E4__this;

		[Token(Token = "0x400444C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x6003B24")]
		[Address(RVA = "0x1876E88", Offset = "0x1876E88", VA = "0x1876E88")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6003B25")]
		[Address(RVA = "0x1876E90", Offset = "0x1876E90", VA = "0x1876E90")]
		internal void _003CDoSplash_003Eb__0(AudioSource m)
		{
		}
	}

	[Token(Token = "0x4004440")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem SplashParticles;

	[Token(Token = "0x4004441")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem WaterSplash;

	[Token(Token = "0x4004442")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 SplashOffset;

	[Token(Token = "0x4004443")]
	[FieldOffset(Offset = "0x34")]
	public int ParticlesToEmit;

	[Token(Token = "0x4004444")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> SplashClips;

	[Token(Token = "0x4004445")]
	[FieldOffset(Offset = "0x40")]
	public float SplashVolume;

	[Token(Token = "0x4004446")]
	[FieldOffset(Offset = "0x44")]
	public float SizeMod;

	[Token(Token = "0x4004447")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 SizeRange;

	[Token(Token = "0x4004448")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem.EmitParams emitParams;

	[Token(Token = "0x4004449")]
	[FieldOffset(Offset = "0xE0")]
	private ParticleSystem.EmitParams waterParams;

	[Token(Token = "0x400444A")]
	[FieldOffset(Offset = "0x170")]
	private Transform root;

	[Token(Token = "0x6003B20")]
	[Address(RVA = "0x17507F0", Offset = "0x17507F0", VA = "0x17507F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B21")]
	[Address(RVA = "0x1750828", Offset = "0x1750828", VA = "0x1750828")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003B22")]
	[Address(RVA = "0x17508BC", Offset = "0x17508BC", VA = "0x17508BC")]
	public void DoSplash(Vector3 position, Bounds bounds, bool onlyRings = false, bool ignoreSound = false)
	{
	}

	[Token(Token = "0x6003B23")]
	[Address(RVA = "0x1750BAC", Offset = "0x1750BAC", VA = "0x1750BAC")]
	public WaterParticles()
	{
	}
}
