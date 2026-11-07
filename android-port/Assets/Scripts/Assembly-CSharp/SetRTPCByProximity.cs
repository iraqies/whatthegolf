using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BF")]
public class SetRTPCByProximity : MonoBehaviour
{
	[Token(Token = "0x20003C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F7C4", Offset = "0x3F7C4")]
	private sealed class _003CSlowFixedUpdate_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x20")]
		public SetRTPCByProximity _003C_003E4__this;

		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSecondsRealtime _003Cwait_003E5__2;

		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x30")]
		private int _003CdelayInMs_003E5__3;

		[Token(Token = "0x17000212")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60011C5")]
			[Address(RVA = "0x184305C", Offset = "0x184305C", VA = "0x184305C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000213")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60011C7")]
			[Address(RVA = "0x18430A4", Offset = "0x18430A4", VA = "0x18430A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x1842D50", Offset = "0x1842D50", VA = "0x1842D50")]
		[DebuggerHidden]
		public _003CSlowFixedUpdate_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x1842D7C", Offset = "0x1842D7C", VA = "0x1842D7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x1842D80", Offset = "0x1842D80", VA = "0x1842D80", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x184305C", Offset = "0x184305C", VA = "0x184305C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x1843064", Offset = "0x1843064", VA = "0x1843064", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x18430A4", Offset = "0x18430A4", VA = "0x18430A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x18")]
	public float minDistance;

	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x20")]
	public Transform proximityFromTarget;

	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x28")]
	public Transform[] proximityToTargets;

	[Token(Token = "0x40014A7")]
	private const float delay = 0.1f;

	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x30")]
	private float currentBaseRTPC;

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x168EA2C", Offset = "0x168EA2C", VA = "0x168EA2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x168EAA8", Offset = "0x168EAA8", VA = "0x168EAA8")]
	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x168EB1C", Offset = "0x168EB1C", VA = "0x168EB1C")]
	public SetRTPCByProximity()
	{
	}
}
