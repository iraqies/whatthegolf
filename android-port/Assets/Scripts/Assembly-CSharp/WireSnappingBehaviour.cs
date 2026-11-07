using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E37")]
public class WireSnappingBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000E38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44EE8", Offset = "0x44EE8")]
	private sealed class _003CSnapRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004D1C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004D1D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004D1E")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x4004D1F")]
		[FieldOffset(Offset = "0x28")]
		public WireSnappingBehaviour _003C_003E4__this;

		[Token(Token = "0x4004D20")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _003CstartPos_003E5__2;

		[Token(Token = "0x4004D21")]
		[FieldOffset(Offset = "0x3C")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x4004D22")]
		[FieldOffset(Offset = "0x40")]
		private float _003Cstep_003E5__4;

		[Token(Token = "0x170006D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x1879F68", Offset = "0x1879F68", VA = "0x1879F68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x1879FB0", Offset = "0x1879FB0", VA = "0x1879FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60042A8")]
		[Address(RVA = "0x1879B84", Offset = "0x1879B84", VA = "0x1879B84")]
		[DebuggerHidden]
		public _003CSnapRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x1879BB0", Offset = "0x1879BB0", VA = "0x1879BB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x1879BB4", Offset = "0x1879BB4", VA = "0x1879BB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x1879F68", Offset = "0x1879F68", VA = "0x1879F68", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60042AC")]
		[Address(RVA = "0x1879F70", Offset = "0x1879F70", VA = "0x1879F70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60042AD")]
		[Address(RVA = "0x1879FB0", Offset = "0x1879FB0", VA = "0x1879FB0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004D16")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x4004D17")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float snapTime;

	[Token(Token = "0x4004D18")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string wireColor;

	[Token(Token = "0x4004D19")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnityEvent OnSnapped;

	[Token(Token = "0x4004D1A")]
	[FieldOffset(Offset = "0x38")]
	private bool jointMade;

	[Token(Token = "0x4004D1B")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x60042A4")]
	[Address(RVA = "0x175A520", Offset = "0x175A520", VA = "0x175A520")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60042A5")]
	[Address(RVA = "0x175A788", Offset = "0x175A788", VA = "0x175A788")]
	public void StartSnapping(Transform trans)
	{
	}

	[Token(Token = "0x60042A6")]
	[Address(RVA = "0x175A710", Offset = "0x175A710", VA = "0x175A710")]
	private IEnumerator SnapRoutine(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x60042A7")]
	[Address(RVA = "0x175A808", Offset = "0x175A808", VA = "0x175A808")]
	public WireSnappingBehaviour()
	{
	}
}
