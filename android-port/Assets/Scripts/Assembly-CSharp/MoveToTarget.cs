using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200034B")]
public class MoveToTarget : MonoBehaviour
{
	[Token(Token = "0x200034C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F1B0", Offset = "0x3F1B0")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x10")]
		public MoveToTarget _003C_003E4__this;

		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x17F9EC4", Offset = "0x17F9EC4", VA = "0x17F9EC4")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x17F9ECC", Offset = "0x17F9ECC", VA = "0x17F9ECC")]
		internal void _003CMoveCR_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200034D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F1C0", Offset = "0x3F1C0")]
	private sealed class _003CMoveCR_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x20")]
		public MoveToTarget _003C_003E4__this;

		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x170001CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x17FA1D0", Offset = "0x17FA1D0", VA = "0x17FA1D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x17FA218", Offset = "0x17FA218", VA = "0x17FA218", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x17F9FA4", Offset = "0x17F9FA4", VA = "0x17F9FA4")]
		[DebuggerHidden]
		public _003CMoveCR_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x17F9FD0", Offset = "0x17F9FD0", VA = "0x17F9FD0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x17F9FD4", Offset = "0x17F9FD4", VA = "0x17F9FD4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x17FA1D0", Offset = "0x17FA1D0", VA = "0x17FA1D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x17FA1D8", Offset = "0x17FA1D8", VA = "0x17FA1D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x17FA218", Offset = "0x17FA218", VA = "0x17FA218", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve _AnimationCurve;

	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool usePhysics;

	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x2D")]
	[SerializeField]
	private bool enableOnStart;

	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody rigid;

	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent OnObjectMoved;

	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool useDefaultCollision;

	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool useCollision;

	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool useTrigger;

	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<string> AcceptedTags;

	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<Collider> Blacklist;

	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x60")]
	private bool isMoving;

	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x157468C", Offset = "0x157468C", VA = "0x157468C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x15746A0", Offset = "0x15746A0", VA = "0x15746A0")]
	public void Move()
	{
	}

	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x15747B4", Offset = "0x15747B4", VA = "0x15747B4")]
	private IEnumerator MoveCR()
	{
		return null;
	}

	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x1574828", Offset = "0x1574828", VA = "0x1574828")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x157493C", Offset = "0x157493C", VA = "0x157493C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x1574A58", Offset = "0x1574A58", VA = "0x1574A58")]
	public MoveToTarget()
	{
	}
}
