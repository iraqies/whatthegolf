using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FD")]
public class BowlerShooterRagdoll : GolfBallShooterBase
{
	[Token(Token = "0x20005FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40930", Offset = "0x40930")]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x20")]
		public BowlerShooterRagdoll _003C_003E4__this;

		[Token(Token = "0x170002F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x177B3C0", Offset = "0x177B3C0", VA = "0x177B3C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x177B408", Offset = "0x177B408", VA = "0x177B408", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x177B218", Offset = "0x177B218", VA = "0x177B218")]
		[DebuggerHidden]
		public _003CStart_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x177B244", Offset = "0x177B244", VA = "0x177B244", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x177B248", Offset = "0x177B248", VA = "0x177B248", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x177B3C0", Offset = "0x177B3C0", VA = "0x177B3C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x177B3C8", Offset = "0x177B3C8", VA = "0x177B3C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x177B408", Offset = "0x177B408", VA = "0x177B408", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001EB0")]
	[FieldOffset(Offset = "0x60")]
	public GolfBallController OriginalController;

	[Token(Token = "0x4001EB1")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody HandRigid;

	[Token(Token = "0x4001EB2")]
	[FieldOffset(Offset = "0x70")]
	public float Velocity;

	[Token(Token = "0x4001EB3")]
	[FieldOffset(Offset = "0x74")]
	public float Pitch;

	[Token(Token = "0x4001EB4")]
	[FieldOffset(Offset = "0x78")]
	public float Spin;

	[Token(Token = "0x4001EB5")]
	[FieldOffset(Offset = "0x80")]
	public Transform Anchor;

	[Token(Token = "0x4001EB6")]
	[FieldOffset(Offset = "0x88")]
	public bool UseJoint;

	[Token(Token = "0x4001EB7")]
	[FieldOffset(Offset = "0x89")]
	public bool DisableOnStart;

	[Token(Token = "0x4001EB8")]
	[FieldOffset(Offset = "0x90")]
	public Rigidbody NonJointRigid;

	[Token(Token = "0x4001EB9")]
	[FieldOffset(Offset = "0x98")]
	private Rigidbody rigid;

	[Token(Token = "0x4001EBA")]
	[FieldOffset(Offset = "0xA0")]
	private CBFollow follow;

	[Token(Token = "0x4001EBB")]
	[FieldOffset(Offset = "0xA8")]
	private ConfigurableJoint joint;

	[Token(Token = "0x4001EBC")]
	[FieldOffset(Offset = "0xB0")]
	private BowlingShooter shooter;

	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x1702F74", Offset = "0x1702F74", VA = "0x1702F74", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x1703014", Offset = "0x1703014", VA = "0x1703014")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x1703088", Offset = "0x1703088", VA = "0x1703088")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x17032B0", Offset = "0x17032B0", VA = "0x17032B0", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x1703370", Offset = "0x1703370", VA = "0x1703370")]
	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x1703664", Offset = "0x1703664", VA = "0x1703664", Slot = "7")]
	public override void OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x1703730", Offset = "0x1703730", VA = "0x1703730")]
	public BowlerShooterRagdoll()
	{
	}
}
