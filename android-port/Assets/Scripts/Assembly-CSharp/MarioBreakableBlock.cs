using System;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007DB")]
public class MarioBreakableBlock : MonoBehaviour
{
	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x18")]
	public int ParticlesToEmitOnHit;

	[Token(Token = "0x40029B1")]
	[FieldOffset(Offset = "0x1C")]
	public int ParticlesToEmitOnBreak;

	[Token(Token = "0x40029B2")]
	[FieldOffset(Offset = "0x20")]
	public int Health;

	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x24")]
	public bool Hidden;

	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem OnHitParticles;

	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem OnBreakParticles;

	[Token(Token = "0x40029B6")]
	[FieldOffset(Offset = "0x38")]
	public MarioLevelController Controller;

	[Token(Token = "0x40029B7")]
	[FieldOffset(Offset = "0x40")]
	public bool playClipOnHitForLastHealth;

	[Token(Token = "0x40029B8")]
	[FieldOffset(Offset = "0x48")]
	public RandomAudioClips ClipOnHit;

	[Token(Token = "0x40029B9")]
	[FieldOffset(Offset = "0x50")]
	public RandomAudioClips ClipOnBreak;

	[Token(Token = "0x40029BA")]
	[FieldOffset(Offset = "0x58")]
	public List<RumbleEventAsset> RumbleOnBreak;

	[Token(Token = "0x40029BB")]
	[FieldOffset(Offset = "0x60")]
	public Action<MarioBreakableBlock> OnBlockHit;

	[Token(Token = "0x40029BC")]
	[FieldOffset(Offset = "0x68")]
	public Action<MarioBreakableBlock> OnBlockBreak;

	[Token(Token = "0x40029BD")]
	[FieldOffset(Offset = "0x70")]
	private int currentHealth;

	[Token(Token = "0x40029BE")]
	[FieldOffset(Offset = "0x78")]
	private Renderer[] renderer;

	[Token(Token = "0x40029BF")]
	[FieldOffset(Offset = "0x80")]
	public GameObject DeadCubeObject;

	[Token(Token = "0x6002409")]
	[Address(RVA = "0x155AF7C", Offset = "0x155AF7C", VA = "0x155AF7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0x155B0D0", Offset = "0x155B0D0", VA = "0x155B0D0")]
	private void OnLevelReset()
	{
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0x155B17C", Offset = "0x155B17C", VA = "0x155B17C")]
	private void OnCollisionEnter(Collision c)
	{
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0x155B2F8", Offset = "0x155B2F8", VA = "0x155B2F8")]
	private void OnHit()
	{
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0x155B438", Offset = "0x155B438", VA = "0x155B438")]
	private void OnBreak()
	{
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0x155B6B4", Offset = "0x155B6B4", VA = "0x155B6B4")]
	public MarioBreakableBlock()
	{
	}
}
