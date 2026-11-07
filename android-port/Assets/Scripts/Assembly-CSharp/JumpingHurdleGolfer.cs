using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022E")]
public class JumpingHurdleGolfer : MonoBehaviour
{
	[Token(Token = "0x200022F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E5F4", Offset = "0x3E5F4")]
	private sealed class _003CJump_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x20")]
		public JumpingHurdleGolfer _003C_003E4__this;

		[Token(Token = "0x17000135")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x17CC188", Offset = "0x17CC188", VA = "0x17CC188", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000136")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x17CC1D0", Offset = "0x17CC1D0", VA = "0x17CC1D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x17CBFA8", Offset = "0x17CBFA8", VA = "0x17CBFA8")]
		[DebuggerHidden]
		public _003CJump_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x17CBFD4", Offset = "0x17CBFD4", VA = "0x17CBFD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x17CBFD8", Offset = "0x17CBFD8", VA = "0x17CBFD8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x17CC188", Offset = "0x17CC188", VA = "0x17CC188", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x17CC190", Offset = "0x17CC190", VA = "0x17CC190", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x17CC1D0", Offset = "0x17CC1D0", VA = "0x17CC1D0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x18")]
	public float jumpVelocity;

	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x1C")]
	public float timeBetweenJumps;

	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 boost;

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x14F92D4", Offset = "0x14F92D4", VA = "0x14F92D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x14F93E4", Offset = "0x14F93E4", VA = "0x14F93E4")]
	private IEnumerator Jump()
	{
		return null;
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x14F9458", Offset = "0x14F9458", VA = "0x14F9458")]
	public JumpingHurdleGolfer()
	{
	}
}
