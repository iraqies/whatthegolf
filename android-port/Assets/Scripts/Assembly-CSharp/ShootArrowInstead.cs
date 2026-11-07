using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C1")]
public class ShootArrowInstead : GolfBallShooterBase
{
	[Token(Token = "0x20007C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415D0", Offset = "0x415D0")]
	private sealed class _003CStart_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x20")]
		public ShootArrowInstead _003C_003E4__this;

		[Token(Token = "0x170003E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600238C")]
			[Address(RVA = "0x1849AA0", Offset = "0x1849AA0", VA = "0x1849AA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600238E")]
			[Address(RVA = "0x1849AE8", Offset = "0x1849AE8", VA = "0x1849AE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002389")]
		[Address(RVA = "0x1849668", Offset = "0x1849668", VA = "0x1849668")]
		[DebuggerHidden]
		public _003CStart_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600238A")]
		[Address(RVA = "0x1849694", Offset = "0x1849694", VA = "0x1849694", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600238B")]
		[Address(RVA = "0x1849698", Offset = "0x1849698", VA = "0x1849698", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600238C")]
		[Address(RVA = "0x1849AA0", Offset = "0x1849AA0", VA = "0x1849AA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600238D")]
		[Address(RVA = "0x1849AA8", Offset = "0x1849AA8", VA = "0x1849AA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600238E")]
		[Address(RVA = "0x1849AE8", Offset = "0x1849AE8", VA = "0x1849AE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002906")]
	[FieldOffset(Offset = "0x60")]
	public Transform ColliderObject;

	[Token(Token = "0x4002907")]
	[FieldOffset(Offset = "0x68")]
	public float MaxColliderLength;

	[Token(Token = "0x4002908")]
	[FieldOffset(Offset = "0x6C")]
	public float MaxVelocity;

	[Token(Token = "0x4002909")]
	[FieldOffset(Offset = "0x70")]
	public float MinVelocity;

	[Token(Token = "0x400290A")]
	[FieldOffset(Offset = "0x74")]
	public float Spin;

	[Token(Token = "0x400290B")]
	[FieldOffset(Offset = "0x78")]
	public float Pitch;

	[Token(Token = "0x400290C")]
	[FieldOffset(Offset = "0x80")]
	public GolfBallController OtherController;

	[Token(Token = "0x400290D")]
	[FieldOffset(Offset = "0x88")]
	public LayerMask GroundLayer;

	[Token(Token = "0x400290E")]
	[FieldOffset(Offset = "0x8C")]
	public float GroundCheckSize;

	[Token(Token = "0x400290F")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 ColliderResizeRange;

	[Token(Token = "0x4002910")]
	[FieldOffset(Offset = "0x98")]
	public List<OnCollisionAudioRemote> collisionAudioToApply;

	[Token(Token = "0x4002911")]
	[FieldOffset(Offset = "0xA0")]
	public AudioMaterial materialToApply;

	[Token(Token = "0x4002912")]
	[FieldOffset(Offset = "0xA8")]
	public float startDrag;

	[Token(Token = "0x4002913")]
	[FieldOffset(Offset = "0xAC")]
	private bool hasShot;

	[Token(Token = "0x4002914")]
	[FieldOffset(Offset = "0xB0")]
	private CBFollow followCamera;

	[Token(Token = "0x4002915")]
	[FieldOffset(Offset = "0xB8")]
	private bool firstShot;

	[Token(Token = "0x4002916")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 aimDirection;

	[Token(Token = "0x4002917")]
	[FieldOffset(Offset = "0xC8")]
	private Rigidbody oldRigid;

	[Token(Token = "0x4002918")]
	[FieldOffset(Offset = "0xD0")]
	private int shotCount;

	[Token(Token = "0x4002919")]
	[FieldOffset(Offset = "0xD4")]
	private float lastInputTarget;

	[Token(Token = "0x400291A")]
	[FieldOffset(Offset = "0xD8")]
	private CapsuleCollider spawnedCollider;

	[Token(Token = "0x400291B")]
	[FieldOffset(Offset = "0xE0")]
	private bool initialized;

	[Token(Token = "0x6002380")]
	[Address(RVA = "0x16A1630", Offset = "0x16A1630", VA = "0x16A1630", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0x16A1734", Offset = "0x16A1734", VA = "0x16A1734")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0x16A17A8", Offset = "0x16A17A8", VA = "0x16A17A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0x16A183C", Offset = "0x16A183C", VA = "0x16A183C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0x16A1A88", Offset = "0x16A1A88", VA = "0x16A1A88", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0x16A1AFC", Offset = "0x16A1AFC", VA = "0x16A1AFC", Slot = "6")]
	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0x16A1B08", Offset = "0x16A1B08", VA = "0x16A1B08", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0x16A1B18", Offset = "0x16A1B18", VA = "0x16A1B18", Slot = "7")]
	public override void OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0x16A1E44", Offset = "0x16A1E44", VA = "0x16A1E44")]
	public ShootArrowInstead()
	{
	}
}
