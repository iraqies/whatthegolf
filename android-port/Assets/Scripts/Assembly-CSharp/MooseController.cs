using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003B")]
public class MooseController : GolfBallShooterBase
{
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D388", Offset = "0x3D388")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x200003D")]
		private sealed class _003C_003COnShoot_003Eg__OneFrameWait_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x20")]
			public _003C_003Ec__DisplayClass19_0 _003C_003E4__this;

			[Token(Token = "0x17000034")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60000F9")]
				[Address(RVA = "0x18826BC", Offset = "0x18826BC", VA = "0x18826BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000035")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60000FB")]
				[Address(RVA = "0x1882704", Offset = "0x1882704", VA = "0x1882704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x18824C4", Offset = "0x18824C4", VA = "0x18824C4")]
			[DebuggerHidden]
			public _003C_003COnShoot_003Eg__OneFrameWait_007C0_003Ed(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x18824F0", Offset = "0x18824F0", VA = "0x18824F0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x18824F4", Offset = "0x18824F4", VA = "0x18824F4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x18826BC", Offset = "0x18826BC", VA = "0x18826BC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x18826C4", Offset = "0x18826C4", VA = "0x18826C4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1882704", Offset = "0x1882704", VA = "0x1882704", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		public MooseController _003C_003E4__this;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 boost;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17F91A4", Offset = "0x17F91A4", VA = "0x17F91A4")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17F91AC", Offset = "0x17F91AC", VA = "0x17F91AC")]
		internal IEnumerator _003COnShoot_003Eg__OneFrameWait_007C0()
		{
			return null;
		}
	}

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x60")]
	public float MoveSpeed;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x64")]
	public float RotateSpeed;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x68")]
	public float HeightCheck;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask GroundLayer;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x70")]
	public float RunSpeed;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x78")]
	public List<MooseLegJoint> Joints;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x80")]
	public List<SpringJoint> CarryJoints;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x88")]
	public Rigidbody Moose;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x90")]
	public Rigidbody MooseHead;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x98")]
	public float ShootForce;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0xA0")]
	public OutOfBoundsTrigger OutOfBoundsTrigger;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 boost;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<SpringJoint, float> springJointSettings;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 offset;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0xCC")]
	private bool grounded;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0xD0")]
	private List<Rigidbody> MooseRigidbodies;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 lastBoost;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x156E644", Offset = "0x156E644", VA = "0x156E644", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x156EB8C", Offset = "0x156EB8C", VA = "0x156EB8C")]
	private void OnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x156EBF8", Offset = "0x156EBF8", VA = "0x156EBF8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x156EE20", Offset = "0x156EE20", VA = "0x156EE20", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x156EE28", Offset = "0x156EE28", VA = "0x156EE28", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x156EE30", Offset = "0x156EE30", VA = "0x156EE30", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x156ECAC", Offset = "0x156ECAC", VA = "0x156ECAC")]
	private void ToggleJoints(bool state)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x156EE3C", Offset = "0x156EE3C", VA = "0x156EE3C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x156F7A0", Offset = "0x156F7A0", VA = "0x156F7A0")]
	private void MoveTransformToRigidbody()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x156F968", Offset = "0x156F968", VA = "0x156F968")]
	public MooseController()
	{
	}
}
