using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAB")]
public class LoopMovement : MonoBehaviour
{
	[Token(Token = "0x2000DAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C00", Offset = "0x44C00")]
	private sealed class _003CMoveProp_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A8F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A90")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A91")]
		[FieldOffset(Offset = "0x20")]
		public LoopMovement _003C_003E4__this;

		[Token(Token = "0x4004A92")]
		[FieldOffset(Offset = "0x28")]
		private float _003CmovementTime_003E5__2;

		[Token(Token = "0x17000695")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004052")]
			[Address(RVA = "0x17EF348", Offset = "0x17EF348", VA = "0x17EF348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000696")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004054")]
			[Address(RVA = "0x17EF390", Offset = "0x17EF390", VA = "0x17EF390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600404F")]
		[Address(RVA = "0x17EEE84", Offset = "0x17EEE84", VA = "0x17EEE84")]
		[DebuggerHidden]
		public _003CMoveProp_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004050")]
		[Address(RVA = "0x17EEEB0", Offset = "0x17EEEB0", VA = "0x17EEEB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004051")]
		[Address(RVA = "0x17EEEB4", Offset = "0x17EEEB4", VA = "0x17EEEB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004052")]
		[Address(RVA = "0x17EF348", Offset = "0x17EF348", VA = "0x17EF348", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004053")]
		[Address(RVA = "0x17EF350", Offset = "0x17EF350", VA = "0x17EF350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004054")]
		[Address(RVA = "0x17EF390", Offset = "0x17EF390", VA = "0x17EF390", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004A82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 endPosition;

	[Token(Token = "0x4004A83")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float movementSpeed;

	[Token(Token = "0x4004A84")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float pauseTime;

	[Token(Token = "0x4004A85")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool invertedCycle;

	[Token(Token = "0x4004A86")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve animationCurve;

	[Token(Token = "0x4004A87")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float offset;

	[Token(Token = "0x4004A88")]
	[FieldOffset(Offset = "0x3C")]
	public bool useRigidbody;

	[Token(Token = "0x4004A89")]
	[FieldOffset(Offset = "0x3D")]
	public bool UseCustomInterval;

	[Token(Token = "0x4004A8A")]
	[FieldOffset(Offset = "0x40")]
	public List<float> CustomIntervals;

	[Token(Token = "0x4004A8B")]
	[FieldOffset(Offset = "0x48")]
	private int m_IntervalIndex;

	[Token(Token = "0x4004A8C")]
	[FieldOffset(Offset = "0x4C")]
	private int cycles;

	[Token(Token = "0x4004A8D")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rb;

	[Token(Token = "0x4004A8E")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 startPosition;

	[Token(Token = "0x600404B")]
	[Address(RVA = "0x154BC60", Offset = "0x154BC60", VA = "0x154BC60")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600404C")]
	[Address(RVA = "0x154BCEC", Offset = "0x154BCEC", VA = "0x154BCEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600404D")]
	[Address(RVA = "0x154BE24", Offset = "0x154BE24", VA = "0x154BE24")]
	private IEnumerator MoveProp()
	{
		return null;
	}

	[Token(Token = "0x600404E")]
	[Address(RVA = "0x154BE98", Offset = "0x154BE98", VA = "0x154BE98")]
	public LoopMovement()
	{
	}
}
