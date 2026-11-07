using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D96")]
public class LerpRotationChooseObject : MonoBehaviour
{
	[Token(Token = "0x2000D97")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B80", Offset = "0x44B80")]
	private sealed class _003CStartRotating_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049F8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049F9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049FA")]
		[FieldOffset(Offset = "0x20")]
		public LerpRotationChooseObject _003C_003E4__this;

		[Token(Token = "0x40049FB")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion endValue;

		[Token(Token = "0x40049FC")]
		[FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x40049FD")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CmovementTime_003E5__2;

		[Token(Token = "0x40049FE")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion _003CstartValue_003E5__3;

		[Token(Token = "0x17000687")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FE5")]
			[Address(RVA = "0x17D0994", Offset = "0x17D0994", VA = "0x17D0994", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000688")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FE7")]
			[Address(RVA = "0x17D09DC", Offset = "0x17D09DC", VA = "0x17D09DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x17D076C", Offset = "0x17D076C", VA = "0x17D076C")]
		[DebuggerHidden]
		public _003CStartRotating_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x17D0798", Offset = "0x17D0798", VA = "0x17D0798", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x17D079C", Offset = "0x17D079C", VA = "0x17D079C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x17D0994", Offset = "0x17D0994", VA = "0x17D0994", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x17D099C", Offset = "0x17D099C", VA = "0x17D099C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x17D09DC", Offset = "0x17D09DC", VA = "0x17D09DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40049F2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToRotate;

	[Token(Token = "0x40049F3")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 targetRotation;

	[Token(Token = "0x40049F4")]
	[FieldOffset(Offset = "0x2C")]
	public float movementSpeed;

	[Token(Token = "0x40049F5")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x40049F6")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnRotated;

	[Token(Token = "0x40049F7")]
	[FieldOffset(Offset = "0x40")]
	private float movementDuration;

	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0x1522D40", Offset = "0x1522D40", VA = "0x1522D40")]
	public void Rotate()
	{
	}

	[Token(Token = "0x6003FE0")]
	[Address(RVA = "0x1522E04", Offset = "0x1522E04", VA = "0x1522E04")]
	private IEnumerator StartRotating(Quaternion endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0x1522EB0", Offset = "0x1522EB0", VA = "0x1522EB0")]
	public LerpRotationChooseObject()
	{
	}
}
