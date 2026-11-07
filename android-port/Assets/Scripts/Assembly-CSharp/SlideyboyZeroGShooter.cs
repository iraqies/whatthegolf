using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E2")]
public class SlideyboyZeroGShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x20007E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416D0", Offset = "0x416D0")]
	private sealed class _003CStart_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x20")]
		public SlideyboyZeroGShooter _003C_003E4__this;

		[Token(Token = "0x170003F5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002444")]
			[Address(RVA = "0x1851134", Offset = "0x1851134", VA = "0x1851134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003F6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x185117C", Offset = "0x185117C", VA = "0x185117C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002441")]
		[Address(RVA = "0x185106C", Offset = "0x185106C", VA = "0x185106C")]
		[DebuggerHidden]
		public _003CStart_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002442")]
		[Address(RVA = "0x1851098", Offset = "0x1851098", VA = "0x1851098", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002443")]
		[Address(RVA = "0x185109C", Offset = "0x185109C", VA = "0x185109C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002444")]
		[Address(RVA = "0x1851134", Offset = "0x1851134", VA = "0x1851134", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002445")]
		[Address(RVA = "0x185113C", Offset = "0x185113C", VA = "0x185113C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002446")]
		[Address(RVA = "0x185117C", Offset = "0x185117C", VA = "0x185117C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x4C")]
	public float fullShootVelocity;

	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	protected float spin;

	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x58")]
	public float MaxVelocity;

	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x5C")]
	public float MinInAirVelocity;

	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x60")]
	public float MinGroundVelocity;

	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x64")]
	public float SlideBrake;

	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0x68")]
	public float groundedDrag;

	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0x70")]
	public Action OnLevelReset;

	[Token(Token = "0x4002A24")]
	[FieldOffset(Offset = "0x78")]
	public float KillAddForce;

	[Token(Token = "0x4002A25")]
	[FieldOffset(Offset = "0x80")]
	public Transform LookTransform;

	[Token(Token = "0x4002A26")]
	[FieldOffset(Offset = "0x88")]
	public float RotateSpeed;

	[Token(Token = "0x4002A27")]
	[FieldOffset(Offset = "0x8C")]
	public LayerMask GroundLayer;

	[Token(Token = "0x4002A28")]
	[FieldOffset(Offset = "0x90")]
	public float GroundCheckDist;

	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0x94")]
	public float HelperCheckDist;

	[Token(Token = "0x4002A2A")]
	[FieldOffset(Offset = "0x98")]
	public float ExtraHorizontalForceTime;

	[Token(Token = "0x4002A2B")]
	[FieldOffset(Offset = "0x9C")]
	public float HelperForce;

	[Token(Token = "0x4002A2C")]
	[FieldOffset(Offset = "0xA0")]
	public bool BlockShootingInAir;

	[Token(Token = "0x4002A2D")]
	[FieldOffset(Offset = "0xA8")]
	public ParticleSystem RunParticles;

	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0xB0")]
	public float SphereCastRadius;

	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0xB8")]
	public Animator Animator;

	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0xC0")]
	private bool resetting;

	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 currentDirection;

	[Token(Token = "0x4002A32")]
	[FieldOffset(Offset = "0xD0")]
	private float applyForceTimer;

	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0xD4")]
	private float origDrag;

	[Token(Token = "0x4002A34")]
	[FieldOffset(Offset = "0xD8")]
	private bool IsInAir;

	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0xDC")]
	private Vector2 lastVelocity;

	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0xE4")]
	private float lastCollisionStay;

	[Token(Token = "0x4002A37")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 lastNormal;

	[Token(Token = "0x4002A38")]
	[FieldOffset(Offset = "0xF4")]
	private bool didShoot;

	[Token(Token = "0x4002A39")]
	[FieldOffset(Offset = "0xF8")]
	private float lastShootTime;

	[Token(Token = "0x6002439")]
	[Address(RVA = "0x16B6764", Offset = "0x16B6764", VA = "0x16B6764", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600243A")]
	[Address(RVA = "0x16B67AC", Offset = "0x16B67AC", VA = "0x16B67AC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600243B")]
	[Address(RVA = "0x16B6820", Offset = "0x16B6820", VA = "0x16B6820", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x16B68C8", Offset = "0x16B68C8", VA = "0x16B68C8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x16B6904", Offset = "0x16B6904", VA = "0x16B6904", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x16B6D84", Offset = "0x16B6D84", VA = "0x16B6D84")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600243F")]
	[Address(RVA = "0x16B6EB0", Offset = "0x16B6EB0", VA = "0x16B6EB0")]
	private void OnCollisionStay2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002440")]
	[Address(RVA = "0x16B6F1C", Offset = "0x16B6F1C", VA = "0x16B6F1C")]
	public SlideyboyZeroGShooter()
	{
	}
}
