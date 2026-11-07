using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20001D7")]
public class PoleVaultController : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x20001D8")]
	public struct OneshotTime
	{
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x0")]
		public float delay;

		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x8")]
		public ClipSettingsCollection sfx;
	}

	[Token(Token = "0x20001D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E2E0", Offset = "0x3E2E0")]
	private sealed class _003C_003COnCollisionEnter_003Eg__ReenablePuppet_007C35_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x20")]
		public PoleVaultController _003C_003E4__this;

		[Token(Token = "0x17000111")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1829E30", Offset = "0x1829E30", VA = "0x1829E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000112")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1829E78", Offset = "0x1829E78", VA = "0x1829E78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1829CBC", Offset = "0x1829CBC", VA = "0x1829CBC")]
		[DebuggerHidden]
		public _003C_003COnCollisionEnter_003Eg__ReenablePuppet_007C35_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1829CE8", Offset = "0x1829CE8", VA = "0x1829CE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1829CEC", Offset = "0x1829CEC", VA = "0x1829CEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1829E30", Offset = "0x1829E30", VA = "0x1829E30", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1829E38", Offset = "0x1829E38", VA = "0x1829E38", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1829E78", Offset = "0x1829E78", VA = "0x1829E78", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x60")]
	public Joint HandJoint;

	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x68")]
	public HingeJoint PoleJoint;

	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x70")]
	public HingeJoint PoleAnchor;

	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0x78")]
	public float MinTargetVelocity;

	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x7C")]
	public float MaxTargetVelocity;

	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x80")]
	public PuppetMaster PoleVaulter;

	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x88")]
	public bool SpawnFakeArrowOnShoot;

	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x90")]
	public Transform FakeArrowParent;

	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x98")]
	public bool CanShootAgainAfterGettingUp;

	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x9C")]
	public float ReleasePoleThreshold;

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0xA0")]
	public bool ReleaseWhenAboutToGetUp;

	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0xA8")]
	public Collider PoleCollider;

	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0xB0")]
	public bool IgnoreBoundsAfterAnchored;

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0xB8")]
	public ClipSettingsCollection ReleaseClip;

	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0xC0")]
	public List<OneshotTime> oneshotsOnVault;

	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0xC8")]
	private float target;

	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0xCC")]
	private bool hasShot;

	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0xD0")]
	private Quaternion startRot;

	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 startOffset;

	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 anchor;

	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0xF8")]
	private Rigidbody hingeJointConnectedBody;

	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x100")]
	private GameObject handJointGameObject;

	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x108")]
	private PuppetAutoRun puppet;

	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x110")]
	private GameObject fakeArrow;

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x1604494", Offset = "0x1604494", VA = "0x1604494", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x160466C", Offset = "0x160466C", VA = "0x160466C")]
	private void Start()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x1604714", Offset = "0x1604714", VA = "0x1604714")]
	public void OnRegainBalance()
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x1604A80", Offset = "0x1604A80", VA = "0x1604A80")]
	public void AboutToGetUp()
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x1604B38", Offset = "0x1604B38", VA = "0x1604B38")]
	private void OnShootArrowInitialized(ShootArrow arrow)
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x1604B60", Offset = "0x1604B60", VA = "0x1604B60", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x1604C10", Offset = "0x1604C10", VA = "0x1604C10", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x1604CC4", Offset = "0x1604CC4", VA = "0x1604CC4")]
	private void SetJointMotorTargetVel(float val)
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x1604DC8", Offset = "0x1604DC8", VA = "0x1604DC8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x160508C", Offset = "0x160508C", VA = "0x160508C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x1605284", Offset = "0x1605284", VA = "0x1605284")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x160580C", Offset = "0x160580C", VA = "0x160580C")]
	public PoleVaultController()
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0x1605798", Offset = "0x1605798", VA = "0x1605798")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F41C", Offset = "0x5F41C")]
	private IEnumerator _003COnCollisionEnter_003Eg__ReenablePuppet_007C35_0()
	{
		return null;
	}
}
