using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AC1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x430E4", Offset = "0x430E4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x430E4", Offset = "0x430E4")]
public class OverworldPlant : GolfBehaviour, IAudioEvent
{
	[Token(Token = "0x4003BEC")]
	[FieldOffset(Offset = "0x1C")]
	private float nextHitSound;

	[Token(Token = "0x4003BED")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider2D col;

	[Token(Token = "0x4003BEE")]
	[FieldOffset(Offset = "0x28")]
	private Transform baseTransform;

	[Token(Token = "0x4003BEF")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion baseRotation;

	[Token(Token = "0x4003BF0")]
	[FieldOffset(Offset = "0x40")]
	public int particleAmount;

	[Token(Token = "0x4003BF1")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50688", Offset = "0x50688")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x4003BF2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PlantParticles plantParticles;

	[Token(Token = "0x4003BF3")]
	[FieldOffset(Offset = "0x58")]
	private OverworldBallManager overworldBallManager;

	[Token(Token = "0x17000551")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x15C8F8C", Offset = "0x15C8F8C", VA = "0x15C8F8C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A3F8", Offset = "0x6A3F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x15C8F94", Offset = "0x15C8F94", VA = "0x15C8F94", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A408", Offset = "0x6A408")]
		set
		{
		}
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x15C8F9C", Offset = "0x15C8F9C", VA = "0x15C8F9C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x15C9028", Offset = "0x15C9028", VA = "0x15C9028")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x15C9068", Offset = "0x15C9068", VA = "0x15C9068")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003376")]
	[Address(RVA = "0x15C9090", Offset = "0x15C9090", VA = "0x15C9090")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003377")]
	[Address(RVA = "0x15C938C", Offset = "0x15C938C", VA = "0x15C938C")]
	public OverworldPlant()
	{
	}

	[Token(Token = "0x6003378")]
	[Address(RVA = "0x15C939C", Offset = "0x15C939C", VA = "0x15C939C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A418", Offset = "0x6A418")]
	private void _003COnCollisionEnter2D_003Eb__14_0(float t)
	{
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0x15C9408", Offset = "0x15C9408", VA = "0x15C9408")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A428", Offset = "0x6A428")]
	private void _003COnCollisionEnter2D_003Eb__14_1()
	{
	}
}
