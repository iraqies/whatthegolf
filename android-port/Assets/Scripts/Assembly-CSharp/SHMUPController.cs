using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000697")]
public class SHMUPController : GolfBallShooterBase
{
	[Token(Token = "0x2000698")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F00", Offset = "0x40F00")]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x10")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x18")]
		public float from;

		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x1837584", Offset = "0x1837584", VA = "0x1837584")]
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x183758C", Offset = "0x183758C", VA = "0x183758C")]
		internal void _003CPlayShootSequence_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000699")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F10", Offset = "0x40F10")]
	private sealed class _003CPlayShootSequence_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x1700036D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E46")]
			[Address(RVA = "0x1837D48", Offset = "0x1837D48", VA = "0x1837D48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700036E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E48")]
			[Address(RVA = "0x1837D90", Offset = "0x1837D90", VA = "0x1837D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x183789C", Offset = "0x183789C", VA = "0x183789C")]
		[DebuggerHidden]
		public _003CPlayShootSequence_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x18378C8", Offset = "0x18378C8", VA = "0x18378C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x18378CC", Offset = "0x18378CC", VA = "0x18378CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x1837D48", Offset = "0x1837D48", VA = "0x1837D48", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x1837D50", Offset = "0x1837D50", VA = "0x1837D50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x1837D90", Offset = "0x1837D90", VA = "0x1837D90", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200069A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F20", Offset = "0x40F20")]
	private sealed class _003CDestroyBall_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x28")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x1700036F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E4C")]
			[Address(RVA = "0x183784C", Offset = "0x183784C", VA = "0x183784C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000370")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E4E")]
			[Address(RVA = "0x1837894", Offset = "0x1837894", VA = "0x1837894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x1837768", Offset = "0x1837768", VA = "0x1837768")]
		[DebuggerHidden]
		public _003CDestroyBall_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x1837794", Offset = "0x1837794", VA = "0x1837794", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x1837798", Offset = "0x1837798", VA = "0x1837798", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x183784C", Offset = "0x183784C", VA = "0x183784C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x1837854", Offset = "0x1837854", VA = "0x1837854", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x1837894", Offset = "0x1837894", VA = "0x1837894", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200069B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F30", Offset = "0x40F30")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x10")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startLerpPos;

		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endLerpPos;

		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x30")]
		public float angularVelocity;

		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x1837620", Offset = "0x1837620", VA = "0x1837620")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x1837628", Offset = "0x1837628", VA = "0x1837628")]
		internal void _003CSinkRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200069C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F40", Offset = "0x40F40")]
	private sealed class _003CSinkRoutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x28")]
		public float angularVelocity;

		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x2C")]
		public float initialWaitTime;

		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 sinkDirection;

		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x44")]
		public float moveTime;

		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x48")]
		public float waitTimeBeforeTransition;

		[Token(Token = "0x17000371")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E54")]
			[Address(RVA = "0x1838224", Offset = "0x1838224", VA = "0x1838224", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000372")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E56")]
			[Address(RVA = "0x183826C", Offset = "0x183826C", VA = "0x183826C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x1837D98", Offset = "0x1837D98", VA = "0x1837D98")]
		[DebuggerHidden]
		public _003CSinkRoutine_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x1837DC4", Offset = "0x1837DC4", VA = "0x1837DC4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x1837DC8", Offset = "0x1837DC8", VA = "0x1837DC8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x1838224", Offset = "0x1838224", VA = "0x1838224", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x183822C", Offset = "0x183822C", VA = "0x183822C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x183826C", Offset = "0x183826C", VA = "0x183826C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200069D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F50", Offset = "0x40F50")]
	private sealed class _003CSinkRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPController _003C_003E4__this;

		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x28")]
		public SinkBoat settings;

		[Token(Token = "0x17000373")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0x1838340", Offset = "0x1838340", VA = "0x1838340", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000374")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0x1838388", Offset = "0x1838388", VA = "0x1838388", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x1838274", Offset = "0x1838274", VA = "0x1838274")]
		[DebuggerHidden]
		public _003CSinkRoutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x18382A0", Offset = "0x18382A0", VA = "0x18382A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x18382A4", Offset = "0x18382A4", VA = "0x18382A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x1838340", Offset = "0x1838340", VA = "0x1838340", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x1838348", Offset = "0x1838348", VA = "0x1838348", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x1838388", Offset = "0x1838388", VA = "0x1838388", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002256")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 Speed;

	[Token(Token = "0x4002257")]
	[FieldOffset(Offset = "0x68")]
	public float MoveWarmupTime;

	[Token(Token = "0x4002258")]
	[FieldOffset(Offset = "0x6C")]
	public float AimResetSpeed;

	[Token(Token = "0x4002259")]
	[FieldOffset(Offset = "0x70")]
	public float TurnSpeed;

	[Token(Token = "0x400225A")]
	[FieldOffset(Offset = "0x78")]
	public CinemachineVirtualCamera ShootCamera;

	[Token(Token = "0x400225B")]
	[FieldOffset(Offset = "0x80")]
	public Animator GolfAnimator;

	[Token(Token = "0x400225C")]
	[FieldOffset(Offset = "0x88")]
	public GameObject FakeGolfBall;

	[Token(Token = "0x400225D")]
	[FieldOffset(Offset = "0x90")]
	public Rigidbody GolfBall;

	[Token(Token = "0x400225E")]
	[FieldOffset(Offset = "0x98")]
	public float BallForce;

	[Token(Token = "0x400225F")]
	[FieldOffset(Offset = "0xA0")]
	public Transform FrogTarget;

	[Token(Token = "0x4002260")]
	[FieldOffset(Offset = "0xA8")]
	public SHMUPFrogKing FrogKing;

	[Token(Token = "0x4002261")]
	[FieldOffset(Offset = "0xB0")]
	public Animator BoatController;

	[Token(Token = "0x4002262")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject ColliderContainer;

	[Token(Token = "0x4002263")]
	[FieldOffset(Offset = "0xC0")]
	public AudioEventAsset sfxEventOnPush;

	[Token(Token = "0x4002264")]
	[FieldOffset(Offset = "0xC8")]
	public AudioEventAsset sfxEventOnSink;

	[Token(Token = "0x4002265")]
	[FieldOffset(Offset = "0xD0")]
	public AudioEventAsset sfxEventOnballPickup;

	[Token(Token = "0x4002266")]
	[FieldOffset(Offset = "0xD8")]
	public AudioEventAsset sfxEventOnShoot;

	[Token(Token = "0x4002267")]
	[FieldOffset(Offset = "0xE0")]
	public Action OnSinkBefore;

	[Token(Token = "0x4002268")]
	[FieldOffset(Offset = "0xE8")]
	public Action OnSinkReset;

	[Token(Token = "0x4002269")]
	[FieldOffset(Offset = "0xF0")]
	public Action OnSinkAfterTransition;

	[Token(Token = "0x400226A")]
	[FieldOffset(Offset = "0xF8")]
	public Action OnEnterMouth;

	[Token(Token = "0x400226B")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 targetBlend;

	[Token(Token = "0x400226C")]
	[FieldOffset(Offset = "0x10C")]
	private float currentSpeed;

	[Token(Token = "0x400226D")]
	[FieldOffset(Offset = "0x110")]
	private float aimDirTarget;

	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x114")]
	private float currentAim;

	[Token(Token = "0x400226F")]
	[FieldOffset(Offset = "0x118")]
	private float velRef;

	[Token(Token = "0x4002270")]
	[FieldOffset(Offset = "0x11C")]
	private Vector3 externalForce;

	[Token(Token = "0x4002271")]
	[FieldOffset(Offset = "0x128")]
	private bool isSinking;

	[Token(Token = "0x4002272")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 startPos;

	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x138")]
	private TimeControl timeControl;

	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x166728C", Offset = "0x166728C", VA = "0x166728C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x1667338", Offset = "0x1667338", VA = "0x1667338", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x16673AC", Offset = "0x16673AC", VA = "0x16673AC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x166749C", Offset = "0x166749C", VA = "0x166749C", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x16674A0", Offset = "0x16674A0", VA = "0x16674A0", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x1667910", Offset = "0x1667910", VA = "0x1667910")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x1667AB8", Offset = "0x1667AB8", VA = "0x1667AB8")]
	private IEnumerator PlayShootSequence()
	{
		return null;
	}

	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x1667B2C", Offset = "0x1667B2C", VA = "0x1667B2C")]
	private IEnumerator DestroyBall(GameObject ball)
	{
		return null;
	}

	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x16673B0", Offset = "0x16673B0", VA = "0x16673B0")]
	public void ShootBall()
	{
	}

	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x166716C", Offset = "0x166716C", VA = "0x166716C")]
	public void CollectedBalls()
	{
	}

	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x1667BA4", Offset = "0x1667BA4", VA = "0x1667BA4")]
	private IEnumerator SinkRoutine(float initialWaitTime, Vector3 sinkDirection, float angularVelocity, float waitTimeBeforeTransition, float moveTime)
	{
		return null;
	}

	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x1667C64", Offset = "0x1667C64", VA = "0x1667C64")]
	private IEnumerator SinkRoutine(SinkBoat settings)
	{
		return null;
	}

	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x1667CDC", Offset = "0x1667CDC", VA = "0x1667CDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x1668120", Offset = "0x1668120", VA = "0x1668120")]
	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}

	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x1668298", Offset = "0x1668298", VA = "0x1668298")]
	public SHMUPController()
	{
	}
}
