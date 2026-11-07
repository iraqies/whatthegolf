using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006ED")]
public class FPGFlying : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x20006EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x411C0", Offset = "0x411C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__31_0;

		[Token(Token = "0x6002000")]
		[Address(RVA = "0x17A20B0", Offset = "0x17A20B0", VA = "0x17A20B0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002001")]
		[Address(RVA = "0x17A20B8", Offset = "0x17A20B8", VA = "0x17A20B8")]
		internal void _003COnAimStart_003Eb__31_0(AudioSource m)
		{
		}
	}

	[Token(Token = "0x4002443")]
	[FieldOffset(Offset = "0x60")]
	public Animator Animator;

	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x68")]
	public float RotateSpeed;

	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x6C")]
	public float ModelRotateSpeed;

	[Token(Token = "0x4002446")]
	[FieldOffset(Offset = "0x70")]
	public float SoarThreshold;

	[Token(Token = "0x4002447")]
	[FieldOffset(Offset = "0x74")]
	public float FlySpeed;

	[Token(Token = "0x4002448")]
	[FieldOffset(Offset = "0x78")]
	public float WalkSpeed;

	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x7C")]
	public float MaxSpeed;

	[Token(Token = "0x400244A")]
	[FieldOffset(Offset = "0x80")]
	public float MaxDiveSpeed;

	[Token(Token = "0x400244B")]
	[FieldOffset(Offset = "0x84")]
	public float GroundedDistance;

	[Token(Token = "0x400244C")]
	[FieldOffset(Offset = "0x88")]
	public float ModelRotateAngleMax;

	[Token(Token = "0x400244D")]
	[FieldOffset(Offset = "0x8C")]
	public LayerMask GroundedLayers;

	[Token(Token = "0x400244E")]
	[FieldOffset(Offset = "0x90")]
	public Transform Model;

	[Token(Token = "0x400244F")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 HeadRanges;

	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0xA0")]
	public float MaxHeight;

	[Token(Token = "0x4002451")]
	[FieldOffset(Offset = "0xA4")]
	public float ExtraDownForceWhenNotFlying;

	[Token(Token = "0x4002452")]
	[FieldOffset(Offset = "0xA8")]
	public float TakeOffDotThreshold;

	[Token(Token = "0x4002453")]
	[FieldOffset(Offset = "0xB0")]
	public ParticleSystem DiveParticles;

	[Token(Token = "0x4002454")]
	[FieldOffset(Offset = "0xB8")]
	public List<AudioClip> FlyStartClips;

	[Token(Token = "0x4002455")]
	[FieldOffset(Offset = "0xC0")]
	public AudioSource DiveSource;

	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0xC8")]
	private bool isFlying;

	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0xC9")]
	private bool isSoaring;

	[Token(Token = "0x4002458")]
	[FieldOffset(Offset = "0xCA")]
	private bool isGrounded;

	[Token(Token = "0x4002459")]
	[FieldOffset(Offset = "0xD0")]
	private Rigidbody rigid;

	[Token(Token = "0x400245A")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 flyDirection;

	[Token(Token = "0x400245B")]
	[FieldOffset(Offset = "0xE4")]
	private Quaternion startModelRotation;

	[Token(Token = "0x400245C")]
	[FieldOffset(Offset = "0xF4")]
	private float extraAnimationSpeed;

	[Token(Token = "0x400245D")]
	[FieldOffset(Offset = "0xF8")]
	private BoxCollider collider;

	[Token(Token = "0x400245E")]
	[FieldOffset(Offset = "0x100")]
	private float headPos;

	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0x104")]
	private Vector3 lastDir;

	[Token(Token = "0x4002460")]
	[FieldOffset(Offset = "0x110")]
	private bool lastFrameGrounded;

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x14569F0", Offset = "0x14569F0", VA = "0x14569F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x1456AB4", Offset = "0x1456AB4", VA = "0x1456AB4", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x1456C10", Offset = "0x1456C10", VA = "0x1456C10")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x145743C", Offset = "0x145743C", VA = "0x145743C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x1457ACC", Offset = "0x1457ACC", VA = "0x1457ACC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x1457BEC", Offset = "0x1457BEC", VA = "0x1457BEC")]
	public FPGFlying()
	{
	}
}
