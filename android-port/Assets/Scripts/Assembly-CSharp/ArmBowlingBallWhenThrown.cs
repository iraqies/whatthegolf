using System;
using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FB")]
public class ArmBowlingBallWhenThrown : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x4001E99")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem Explosion;

	[Token(Token = "0x4001E9A")]
	[FieldOffset(Offset = "0x20")]
	public float Timer;

	[Token(Token = "0x4001E9B")]
	[FieldOffset(Offset = "0x24")]
	public float Range;

	[Token(Token = "0x4001E9C")]
	[FieldOffset(Offset = "0x28")]
	public float RangeMobile;

	[Token(Token = "0x4001E9D")]
	[FieldOffset(Offset = "0x2C")]
	public float Power;

	[Token(Token = "0x4001E9E")]
	[FieldOffset(Offset = "0x30")]
	public float UpFactor;

	[Token(Token = "0x4001E9F")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> Clips;

	[Token(Token = "0x4001EA0")]
	[FieldOffset(Offset = "0x40")]
	public float Volume;

	[Token(Token = "0x4001EA1")]
	[FieldOffset(Offset = "0x44")]
	public float VolumeDeviance;

	[Token(Token = "0x4001EA2")]
	[FieldOffset(Offset = "0x48")]
	public AudioSource FuseSource;

	[Token(Token = "0x4001EA3")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem FuseParticles;

	[Token(Token = "0x4001EA4")]
	[FieldOffset(Offset = "0x58")]
	public int AffectedPinsStandalone;

	[Token(Token = "0x4001EA5")]
	[FieldOffset(Offset = "0x5C")]
	public int AffectedPinsMobile;

	[Token(Token = "0x4001EA6")]
	[FieldOffset(Offset = "0x60")]
	public List<string> ExplodeWhenHittingTags;

	[Token(Token = "0x4001EA7")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody rigid;

	[Token(Token = "0x4001EA8")]
	[FieldOffset(Offset = "0x70")]
	private bool armed;

	[Token(Token = "0x4001EA9")]
	[FieldOffset(Offset = "0x74")]
	private float timer;

	[Token(Token = "0x4001EAA")]
	[FieldOffset(Offset = "0x78")]
	private List<Rigidbody> affectedRigidbodies;

	[Token(Token = "0x4001EAB")]
	[FieldOffset(Offset = "0x80")]
	private Collider[] collider;

	[Token(Token = "0x4001EAC")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E37C", Offset = "0x4E37C")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x170002F8")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x1424CD4", Offset = "0x1424CD4", VA = "0x1424CD4", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63A9C", Offset = "0x63A9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x1424CDC", Offset = "0x1424CDC", VA = "0x1424CDC", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63AAC", Offset = "0x63AAC")]
		set
		{
		}
	}

	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x1424CE4", Offset = "0x1424CE4", VA = "0x1424CE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x1424DFC", Offset = "0x1424DFC", VA = "0x1424DFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x1424EA0", Offset = "0x1424EA0", VA = "0x1424EA0")]
	private void Explode()
	{
	}

	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x142542C", Offset = "0x142542C", VA = "0x142542C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x14254CC", Offset = "0x14254CC", VA = "0x14254CC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x142558C", Offset = "0x142558C", VA = "0x142558C")]
	public ArmBowlingBallWhenThrown()
	{
	}

	[Token(Token = "0x6001B39")]
	[Address(RVA = "0x14255C0", Offset = "0x14255C0", VA = "0x14255C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63ABC", Offset = "0x63ABC")]
	private void _003CExplode_003Eb__25_0(AudioSource s)
	{
	}
}
