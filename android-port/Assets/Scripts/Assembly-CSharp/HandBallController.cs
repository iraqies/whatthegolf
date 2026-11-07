using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Arena;
using Audio;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200021F")]
public class HandBallController : UserControlThirdPerson
{
	[Token(Token = "0x2000220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E528", Offset = "0x3E528")]
	private sealed class _003CShootRoutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x20")]
		public HandBallController _003C_003E4__this;

		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x34")]
		private float _003CswingEnd_003E5__2;

		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x38")]
		private float _003CstartT_003E5__3;

		[Token(Token = "0x17000129")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x17B9F4C", Offset = "0x17B9F4C", VA = "0x17B9F4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700012A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x17B9F94", Offset = "0x17B9F94", VA = "0x17B9F94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x17B9B90", Offset = "0x17B9B90", VA = "0x17B9B90")]
		[DebuggerHidden]
		public _003CShootRoutine_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x17B9BBC", Offset = "0x17B9BBC", VA = "0x17B9BBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x17B9BC0", Offset = "0x17B9BC0", VA = "0x17B9BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x17B9F4C", Offset = "0x17B9F4C", VA = "0x17B9F4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x17B9F54", Offset = "0x17B9F54", VA = "0x17B9F54", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x17B9F94", Offset = "0x17B9F94", VA = "0x17B9F94", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x48")]
	public HandBallObject StartTarget;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x50")]
	public Animator CameraController;

	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x58")]
	public GolfBallController Controller;

	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x60")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x68")]
	public float MaxDistanceWhenAiming;

	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x6C")]
	public float ChargeSpeed;

	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x70")]
	public float ShootForce;

	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x74")]
	public float ShootUpForce;

	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x78")]
	public CinemachineCameraShake Shaker;

	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x80")]
	public FreezeTimescale TimeFreezer;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x88")]
	public ParticleSystem SpeedParticles;

	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x98")]
	private HandBallObject currentHeld;

	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 aimDir;

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0xAC")]
	private bool shooting;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0xAD")]
	private bool shotConnected;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0xB0")]
	private float ignoreBallTimer;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0xB8")]
	private CinemachineStateDrivenCamera cinemachineCam;

	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private float ingnoreBallAfterShotTime;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float golfSwingPrepareTime;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float golfSwingHitTime;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float golferAimSideOffset;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private float propExtraPushForce;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0xE0")]
	private float sphereCastRadius;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0xE4")]
	private float sphereCastDist;

	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0xE8")]
	private string animParamIsGolfSwinging;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0xF0")]
	private string animParamIsGolfSwingBlend;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0xF8")]
	private string staticObstacleLayer;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x100")]
	private int obstacleLayerMask;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x104")]
	private float lastNotGolfSwingingTime;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x108")]
	private PuppetMaster puppetMaster;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x110")]
	public float maxRunTime;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x114")]
	private float runTime;

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x14C2604", Offset = "0x14C2604", VA = "0x14C2604", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x14C2824", Offset = "0x14C2824", VA = "0x14C2824")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0x14C2974", Offset = "0x14C2974", VA = "0x14C2974")]
	private IEnumerator ShootRoutine(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0x14C2A0C", Offset = "0x14C2A0C", VA = "0x14C2A0C")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0x14C2A48", Offset = "0x14C2A48", VA = "0x14C2A48", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0x14C34CC", Offset = "0x14C34CC", VA = "0x14C34CC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0x14C3400", Offset = "0x14C3400", VA = "0x14C3400")]
	private void HoldBall(HandBallObject handball)
	{
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x14C3690", Offset = "0x14C3690", VA = "0x14C3690")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x14C3720", Offset = "0x14C3720", VA = "0x14C3720")]
	public HandBallController()
	{
	}
}
