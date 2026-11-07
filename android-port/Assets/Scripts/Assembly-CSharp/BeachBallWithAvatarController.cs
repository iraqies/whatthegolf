using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000F7")]
public class BeachBallWithAvatarController : GolfBallShooterBase
{
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAA0", Offset = "0x3DAA0")]
	private sealed class _003CBallInflationSoundRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x20")]
		public BeachBallWithAvatarController _003C_003E4__this;

		[Token(Token = "0x1700009C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1771AE4", Offset = "0x1771AE4", VA = "0x1771AE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700009D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1771B2C", Offset = "0x1771B2C", VA = "0x1771B2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x17719D4", Offset = "0x17719D4", VA = "0x17719D4")]
		[DebuggerHidden]
		public _003CBallInflationSoundRoutine_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1771A00", Offset = "0x1771A00", VA = "0x1771A00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1771A04", Offset = "0x1771A04", VA = "0x1771A04", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1771AE4", Offset = "0x1771AE4", VA = "0x1771AE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1771AEC", Offset = "0x1771AEC", VA = "0x1771AEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1771B2C", Offset = "0x1771B2C", VA = "0x1771B2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAB0", Offset = "0x3DAB0")]
	private sealed class _003CRemoveExplosionLock_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x20")]
		public BeachBallWithAvatarController _003C_003E4__this;

		[Token(Token = "0x1700009E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1771C5C", Offset = "0x1771C5C", VA = "0x1771C5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700009F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1771CA4", Offset = "0x1771CA4", VA = "0x1771CA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1771B34", Offset = "0x1771B34", VA = "0x1771B34")]
		[DebuggerHidden]
		public _003CRemoveExplosionLock_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1771B60", Offset = "0x1771B60", VA = "0x1771B60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1771B64", Offset = "0x1771B64", VA = "0x1771B64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1771C5C", Offset = "0x1771C5C", VA = "0x1771C5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1771C64", Offset = "0x1771C64", VA = "0x1771C64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1771CA4", Offset = "0x1771CA4", VA = "0x1771CA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x60")]
	public float RollSpeed;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x64")]
	public float ForceSpeed;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x68")]
	public float ShootSpeed;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x70")]
	public Animator Animator;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x78")]
	public float AnimatorRotateSpeed;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x7C")]
	public float AnimatorOffset;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x80")]
	public float AnimationSpeedMod;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x88")]
	public SphereCollider BallCollider;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x90")]
	public float MaxSpeed;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x94")]
	public bool AddForcesInFixedUpdate;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x95")]
	public bool SetAnimationSpeed;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x96")]
	public bool CanDash;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x98")]
	public float DashTime;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0xA0")]
	public ParticleSystem DashParticles;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0xA8")]
	public float TimeToInflate;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 InflateScaleRange;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0xB8")]
	public AnimationCurve inflationCurve;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject DashSphere;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0xC8")]
	public bool UseVelocityAsInflationTimer;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0xD0")]
	public ClipSettingsCollection ReadyToDash;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0xD8")]
	public ClipSettingsCollection DashSound;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0xE0")]
	private bool dashing;

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0xE1")]
	private bool dashExplosionLock;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0xE4")]
	private float explosionY;

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 dashDirection;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0xF4")]
	private float dashTimer;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0xF8")]
	private Vector3 preDashVelocity;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x104")]
	private Vector3 preDashScale;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x110")]
	private float inflateTimer;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 currentBoost;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 lastPos;

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x160B44C", Offset = "0x160B44C", VA = "0x160B44C")]
	private void Start()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x160B488", Offset = "0x160B488", VA = "0x160B488", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x160B554", Offset = "0x160B554", VA = "0x160B554")]
	public void OnExplode()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x160B694", Offset = "0x160B694", VA = "0x160B694")]
	public void ExplosionLock()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x160B788", Offset = "0x160B788", VA = "0x160B788", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x160B7B8", Offset = "0x160B7B8", VA = "0x160B7B8", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x160B5F4", Offset = "0x160B5F4", VA = "0x160B5F4")]
	private void StopDashing()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x160C078", Offset = "0x160C078", VA = "0x160C078")]
	public void OnCollision(Collision collision)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x160C004", Offset = "0x160C004", VA = "0x160C004")]
	private IEnumerator BallInflationSoundRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x160B714", Offset = "0x160B714", VA = "0x160B714")]
	private IEnumerator RemoveExplosionLock()
	{
		return null;
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x160C0FC", Offset = "0x160C0FC", VA = "0x160C0FC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x160C20C", Offset = "0x160C20C", VA = "0x160C20C")]
	public BeachBallWithAvatarController()
	{
	}
}
