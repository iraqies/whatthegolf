using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B08")]
public class Fan : MonoBehaviour
{
	[Token(Token = "0x4003D99")]
	[FieldOffset(Offset = "0x18")]
	public float SphereCastRadius;

	[Token(Token = "0x4003D9A")]
	[FieldOffset(Offset = "0x1C")]
	public float SphereCastDistance;

	[Token(Token = "0x4003D9B")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider EffectTrigger;

	[Token(Token = "0x4003D9C")]
	[FieldOffset(Offset = "0x28")]
	public float MaxForce;

	[Token(Token = "0x4003D9D")]
	[FieldOffset(Offset = "0x2C")]
	public bool CheckForTimeline;

	[Token(Token = "0x4003D9E")]
	[FieldOffset(Offset = "0x2D")]
	public bool OnlyAddTimelines;

	[Token(Token = "0x4003D9F")]
	[FieldOffset(Offset = "0x30")]
	public HashSet<Rigidbody> affectedObjects;

	[Token(Token = "0x4003DA0")]
	[FieldOffset(Offset = "0x38")]
	public HashSet<Timeline> affectedTimelines;

	[Token(Token = "0x4003DA1")]
	[FieldOffset(Offset = "0x40")]
	public ForceMode ForceMode;

	[Token(Token = "0x4003DA2")]
	[FieldOffset(Offset = "0x44")]
	public bool IsOn;

	[Token(Token = "0x4003DA3")]
	[FieldOffset(Offset = "0x45")]
	public bool ForceDependsOnDistance;

	[Token(Token = "0x4003DA4")]
	[FieldOffset(Offset = "0x48")]
	private RotateAxis rotator;

	[Token(Token = "0x4003DA5")]
	[FieldOffset(Offset = "0x50")]
	private float rotatorSpeed;

	[Token(Token = "0x4003DA6")]
	[FieldOffset(Offset = "0x54")]
	private float rotatorSpeedTarget;

	[Token(Token = "0x4003DA7")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem particles;

	[Token(Token = "0x4003DA8")]
	[FieldOffset(Offset = "0x60")]
	private AudioSource Source;

	[Token(Token = "0x4003DA9")]
	[FieldOffset(Offset = "0x68")]
	private float baseVolume;

	[Token(Token = "0x4003DAA")]
	[FieldOffset(Offset = "0x6C")]
	private float startEmission;

	[Token(Token = "0x4003DAB")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool shouldOverrideForceDirection;

	[Token(Token = "0x4003DAC")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private Vector3 overrideForceDirection;

	[Token(Token = "0x17000568")]
	private Vector3 forceDirection
	{
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x145E1D4", Offset = "0x145E1D4", VA = "0x145E1D4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60034A8")]
	[Address(RVA = "0x145E220", Offset = "0x145E220", VA = "0x145E220")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034A9")]
	[Address(RVA = "0x145E754", Offset = "0x145E754", VA = "0x145E754")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60034AA")]
	[Address(RVA = "0x145E96C", Offset = "0x145E96C", VA = "0x145E96C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60034AB")]
	[Address(RVA = "0x145EAE4", Offset = "0x145EAE4", VA = "0x145EAE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034AC")]
	[Address(RVA = "0x145F0D8", Offset = "0x145F0D8", VA = "0x145F0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60034AD")]
	[Address(RVA = "0x145F5AC", Offset = "0x145F5AC", VA = "0x145F5AC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60034AE")]
	[Address(RVA = "0x145F748", Offset = "0x145F748", VA = "0x145F748")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60034AF")]
	[Address(RVA = "0x145E48C", Offset = "0x145E48C", VA = "0x145E48C")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x60034B0")]
	[Address(RVA = "0x145F758", Offset = "0x145F758", VA = "0x145F758")]
	public Fan()
	{
	}

	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x145F770", Offset = "0x145F770", VA = "0x145F770")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A868", Offset = "0x6A868")]
	private void _003CToggle_003Eb__29_0(float t)
	{
	}

	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x145F7B0", Offset = "0x145F7B0", VA = "0x145F7B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A878", Offset = "0x6A878")]
	private void _003CToggle_003Eb__29_1(float t)
	{
	}

	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x145F7F0", Offset = "0x145F7F0", VA = "0x145F7F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A888", Offset = "0x6A888")]
	private void _003CToggle_003Eb__29_2()
	{
	}
}
