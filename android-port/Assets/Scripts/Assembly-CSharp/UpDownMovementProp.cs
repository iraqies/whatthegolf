using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F2C")]
public class UpDownMovementProp : MonoBehaviour
{
	[Token(Token = "0x2000F2D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45740", Offset = "0x45740")]
	private sealed class _003CMoveProp_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40051D8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40051D9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40051DA")]
		[FieldOffset(Offset = "0x20")]
		public UpDownMovementProp _003C_003E4__this;

		[Token(Token = "0x40051DB")]
		[FieldOffset(Offset = "0x28")]
		private float _003CmovementTime_003E5__2;

		[Token(Token = "0x17000758")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x18728A0", Offset = "0x18728A0", VA = "0x18728A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000759")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046EE")]
			[Address(RVA = "0x18728E8", Offset = "0x18728E8", VA = "0x18728E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x18724F4", Offset = "0x18724F4", VA = "0x18724F4")]
		[DebuggerHidden]
		public _003CMoveProp_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x1872520", Offset = "0x1872520", VA = "0x1872520", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x1872524", Offset = "0x1872524", VA = "0x1872524", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x18728A0", Offset = "0x18728A0", VA = "0x18728A0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x18728A8", Offset = "0x18728A8", VA = "0x18728A8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x18728E8", Offset = "0x18728E8", VA = "0x18728E8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40051CE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 endPosition;

	[Token(Token = "0x40051CF")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float movementSpeed;

	[Token(Token = "0x40051D0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float pauseTime;

	[Token(Token = "0x40051D1")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool invertedCycle;

	[Token(Token = "0x40051D2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve animationCurve;

	[Token(Token = "0x40051D3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float offset;

	[Token(Token = "0x40051D4")]
	[FieldOffset(Offset = "0x3C")]
	public bool useRigidbody;

	[Token(Token = "0x40051D5")]
	[FieldOffset(Offset = "0x40")]
	private int cycles;

	[Token(Token = "0x40051D6")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rb;

	[Token(Token = "0x40051D7")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPosition;

	[Token(Token = "0x60046E5")]
	[Address(RVA = "0x173D494", Offset = "0x173D494", VA = "0x173D494")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60046E6")]
	[Address(RVA = "0x173D580", Offset = "0x173D580", VA = "0x173D580")]
	private IEnumerator MoveProp()
	{
		return null;
	}

	[Token(Token = "0x60046E7")]
	[Address(RVA = "0x173D5F4", Offset = "0x173D5F4", VA = "0x173D5F4")]
	public void SetSpeed(float speed)
	{
	}

	[Token(Token = "0x60046E8")]
	[Address(RVA = "0x173D5FC", Offset = "0x173D5FC", VA = "0x173D5FC")]
	public UpDownMovementProp()
	{
	}
}
