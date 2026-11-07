using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200080E")]
public class RobotArmHitter : MonoBehaviour
{
	[Token(Token = "0x200080F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41780", Offset = "0x41780")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x10")]
		public RobotArmHitter _003C_003E4__this;

		[Token(Token = "0x4002B66")]
		[FieldOffset(Offset = "0x18")]
		public Quaternion startRot;

		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion endRot;

		[Token(Token = "0x4002B68")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion orig;

		[Token(Token = "0x600250A")]
		[Address(RVA = "0x183555C", Offset = "0x183555C", VA = "0x183555C")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x600250B")]
		[Address(RVA = "0x1835564", Offset = "0x1835564", VA = "0x1835564")]
		internal void _003CSwingAtTarget_003Eb__0(float t)
		{
		}

		[Token(Token = "0x600250C")]
		[Address(RVA = "0x1835608", Offset = "0x1835608", VA = "0x1835608")]
		internal void _003CSwingAtTarget_003Eb__1(float t)
		{
		}

		[Token(Token = "0x600250D")]
		[Address(RVA = "0x183565C", Offset = "0x183565C", VA = "0x183565C")]
		internal void _003CSwingAtTarget_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x2000810")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41790", Offset = "0x41790")]
	private sealed class _003CSwingAtTarget_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002B69")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x20")]
		public RobotArmHitter _003C_003E4__this;

		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x17000406")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002511")]
			[Address(RVA = "0x1835B60", Offset = "0x1835B60", VA = "0x1835B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000407")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002513")]
			[Address(RVA = "0x1835BA8", Offset = "0x1835BA8", VA = "0x1835BA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600250E")]
		[Address(RVA = "0x1835700", Offset = "0x1835700", VA = "0x1835700")]
		[DebuggerHidden]
		public _003CSwingAtTarget_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600250F")]
		[Address(RVA = "0x183572C", Offset = "0x183572C", VA = "0x183572C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002510")]
		[Address(RVA = "0x1835730", Offset = "0x1835730", VA = "0x1835730", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002511")]
		[Address(RVA = "0x1835B60", Offset = "0x1835B60", VA = "0x1835B60", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002512")]
		[Address(RVA = "0x1835B68", Offset = "0x1835B68", VA = "0x1835B68", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002513")]
		[Address(RVA = "0x1835BA8", Offset = "0x1835BA8", VA = "0x1835BA8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002B4F")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x4002B50")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody RotatePivot;

	[Token(Token = "0x4002B51")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody ArmTwister;

	[Token(Token = "0x4002B52")]
	[FieldOffset(Offset = "0x30")]
	public Transform HandTwister;

	[Token(Token = "0x4002B53")]
	[FieldOffset(Offset = "0x38")]
	public Transform HitPoint;

	[Token(Token = "0x4002B54")]
	[FieldOffset(Offset = "0x40")]
	public float SwingHeight;

	[Token(Token = "0x4002B55")]
	[FieldOffset(Offset = "0x44")]
	public float SwingSpeed;

	[Token(Token = "0x4002B56")]
	[FieldOffset(Offset = "0x48")]
	public float SwingRange;

	[Token(Token = "0x4002B57")]
	[FieldOffset(Offset = "0x4C")]
	public float FacingOffset;

	[Token(Token = "0x4002B58")]
	[FieldOffset(Offset = "0x50")]
	public float MaxReach;

	[Token(Token = "0x4002B59")]
	[FieldOffset(Offset = "0x54")]
	public bool CanRotate;

	[Token(Token = "0x4002B5A")]
	[FieldOffset(Offset = "0x58")]
	public float offset;

	[Token(Token = "0x4002B5B")]
	[FieldOffset(Offset = "0x5C")]
	public bool test;

	[Token(Token = "0x4002B5C")]
	[FieldOffset(Offset = "0x60")]
	private Quaternion restingRotation;

	[Token(Token = "0x4002B5D")]
	[FieldOffset(Offset = "0x70")]
	private Quaternion restingHandRotation;

	[Token(Token = "0x4002B5E")]
	[FieldOffset(Offset = "0x80")]
	private WaitForSeconds wait;

	[Token(Token = "0x4002B5F")]
	[FieldOffset(Offset = "0x88")]
	private bool isSwinging;

	[Token(Token = "0x4002B60")]
	[FieldOffset(Offset = "0x8C")]
	private Quaternion targetSwingRotation;

	[Token(Token = "0x4002B61")]
	[FieldOffset(Offset = "0x9C")]
	private float rotTarget;

	[Token(Token = "0x4002B62")]
	[FieldOffset(Offset = "0xA0")]
	private float rotCurrent;

	[Token(Token = "0x4002B63")]
	[FieldOffset(Offset = "0xA4")]
	private bool canSwing;

	[Token(Token = "0x4002B64")]
	[FieldOffset(Offset = "0xA8")]
	private float swingDelay;

	[Token(Token = "0x6002504")]
	[Address(RVA = "0x16587C8", Offset = "0x16587C8", VA = "0x16587C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002505")]
	[Address(RVA = "0x16589A4", Offset = "0x16589A4", VA = "0x16589A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002506")]
	[Address(RVA = "0x1658BB8", Offset = "0x1658BB8", VA = "0x1658BB8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002507")]
	[Address(RVA = "0x1658B44", Offset = "0x1658B44", VA = "0x1658B44")]
	private IEnumerator SwingAtTarget()
	{
		return null;
	}

	[Token(Token = "0x6002508")]
	[Address(RVA = "0x1658EF0", Offset = "0x1658EF0", VA = "0x1658EF0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x1658F28", Offset = "0x1658F28", VA = "0x1658F28")]
	public RobotArmHitter()
	{
	}
}
