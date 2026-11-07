using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Buoyancy;
using Core;
using Il2CppDummyDll;
using MPuppet;
using UnityEngine;

[Token(Token = "0x200026C")]
public class SharkShooter : GolfBallShooterBase
{
	[Token(Token = "0x200026D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E724", Offset = "0x3E724")]
	private sealed class _003CDeactivateBuoyancyOnGrabObject_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x20")]
		public RealisticFloatingProp floater;

		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x17000152")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x1848DE4", Offset = "0x1848DE4", VA = "0x1848DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000153")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x1848E2C", Offset = "0x1848E2C", VA = "0x1848E2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1848CEC", Offset = "0x1848CEC", VA = "0x1848CEC")]
		[DebuggerHidden]
		public _003CDeactivateBuoyancyOnGrabObject_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x1848D18", Offset = "0x1848D18", VA = "0x1848D18", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1848D1C", Offset = "0x1848D1C", VA = "0x1848D1C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1848DE4", Offset = "0x1848DE4", VA = "0x1848DE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1848DEC", Offset = "0x1848DEC", VA = "0x1848DEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x1848E2C", Offset = "0x1848E2C", VA = "0x1848E2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float speedMultiplierWhileGrabbing;

	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float turnSpeed;

	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Animator horseAnimator;

	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Rigidbody headRigid;

	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool useSetVelocity;

	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float maxShootForce;

	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float maxShootForceUp;

	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private JointDriveSettings grabJointDriveSettings;

	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private JointDriveSettings defaultJointDriveSettings;

	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private ConfigurableJoint[] neckAndHeadJoints;

	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ClipSettingsCollection sfxOnGrab;

	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ClipSettingsCollection sfxOnShoot;

	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private ClipSettingsCollection sfxHorse;

	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0xC8")]
	private SharkGrab currentlyGrabbed;

	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 lastBoost;

	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 velocity;

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x169E244", Offset = "0x169E244", VA = "0x169E244", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x169E330", Offset = "0x169E330", VA = "0x169E330", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x169E410", Offset = "0x169E410", VA = "0x169E410", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x169E51C", Offset = "0x169E51C", VA = "0x169E51C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x169E574", Offset = "0x169E574", VA = "0x169E574")]
	private void Throw(Vector3 boost)
	{
	}

	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x169E8DC", Offset = "0x169E8DC", VA = "0x169E8DC")]
	private void Grab(SharkGrab grab)
	{
	}

	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x169E858", Offset = "0x169E858", VA = "0x169E858")]
	private IEnumerator DeactivateBuoyancyOnGrabObject(RealisticFloatingProp floater, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x169EAD8", Offset = "0x169EAD8", VA = "0x169EAD8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x169E284", Offset = "0x169E284", VA = "0x169E284")]
	private void SetNeckDrive(JointDriveSettings driveSettings)
	{
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x169EBBC", Offset = "0x169EBBC", VA = "0x169EBBC")]
	public SharkShooter()
	{
	}
}
