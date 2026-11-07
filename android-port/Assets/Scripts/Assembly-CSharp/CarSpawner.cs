using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000766")]
public class CarSpawner : MonoBehaviour
{
	[Token(Token = "0x2000767")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41440", Offset = "0x41440")]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0x20")]
		public CarSpawner _003C_003E4__this;

		[Token(Token = "0x170003C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x1781BCC", Offset = "0x1781BCC", VA = "0x1781BCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x1781C14", Offset = "0x1781C14", VA = "0x1781C14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002218")]
		[Address(RVA = "0x1781ABC", Offset = "0x1781ABC", VA = "0x1781ABC")]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002219")]
		[Address(RVA = "0x1781AE8", Offset = "0x1781AE8", VA = "0x1781AE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600221A")]
		[Address(RVA = "0x1781AEC", Offset = "0x1781AEC", VA = "0x1781AEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600221B")]
		[Address(RVA = "0x1781BCC", Offset = "0x1781BCC", VA = "0x1781BCC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600221C")]
		[Address(RVA = "0x1781BD4", Offset = "0x1781BD4", VA = "0x1781BD4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600221D")]
		[Address(RVA = "0x1781C14", Offset = "0x1781C14", VA = "0x1781C14", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002735")]
	[FieldOffset(Offset = "0x18")]
	public float distance;

	[Token(Token = "0x4002736")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 dir;

	[Token(Token = "0x4002737")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D rigid;

	[Token(Token = "0x4002738")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 startPos;

	[Token(Token = "0x4002739")]
	[FieldOffset(Offset = "0x3C")]
	public float delay;

	[Token(Token = "0x400273A")]
	[FieldOffset(Offset = "0x40")]
	private bool isMoving;

	[Token(Token = "0x6002215")]
	[Address(RVA = "0x188A4D8", Offset = "0x188A4D8", VA = "0x188A4D8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002216")]
	[Address(RVA = "0x188A54C", Offset = "0x188A54C", VA = "0x188A54C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002217")]
	[Address(RVA = "0x188A62C", Offset = "0x188A62C", VA = "0x188A62C")]
	public CarSpawner()
	{
	}
}
