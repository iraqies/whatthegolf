using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F29")]
public class SpringPlatform : MonoBehaviour
{
	[Token(Token = "0x2000F2A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45730", Offset = "0x45730")]
	private sealed class _003CDelaySpring_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40051C8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40051C9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40051CA")]
		[FieldOffset(Offset = "0x20")]
		public SpringPlatform _003C_003E4__this;

		[Token(Token = "0x17000756")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046E0")]
			[Address(RVA = "0x185A0B4", Offset = "0x185A0B4", VA = "0x185A0B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000757")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046E2")]
			[Address(RVA = "0x185A0FC", Offset = "0x185A0FC", VA = "0x185A0FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x1859FC4", Offset = "0x1859FC4", VA = "0x1859FC4")]
		[DebuggerHidden]
		public _003CDelaySpring_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x1859FF0", Offset = "0x1859FF0", VA = "0x1859FF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x1859FF4", Offset = "0x1859FF4", VA = "0x1859FF4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x185A0B4", Offset = "0x185A0B4", VA = "0x185A0B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x185A0BC", Offset = "0x185A0BC", VA = "0x185A0BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x185A0FC", Offset = "0x185A0FC", VA = "0x185A0FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40051C2")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 forceVector;

	[Token(Token = "0x40051C3")]
	[FieldOffset(Offset = "0x24")]
	public float upForce;

	[Token(Token = "0x40051C4")]
	[FieldOffset(Offset = "0x28")]
	public int objectsBeforeBlowingUp;

	[Token(Token = "0x40051C5")]
	[FieldOffset(Offset = "0x2C")]
	public float delayBeforeBlowingUp;

	[Token(Token = "0x40051C6")]
	[FieldOffset(Offset = "0x30")]
	public Animator platformAnimator;

	[Token(Token = "0x40051C7")]
	[FieldOffset(Offset = "0x38")]
	private List<Rigidbody> rigidbodies;

	[Token(Token = "0x60046D8")]
	[Address(RVA = "0x16D9C2C", Offset = "0x16D9C2C", VA = "0x16D9C2C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60046D9")]
	[Address(RVA = "0x16D9E5C", Offset = "0x16D9E5C", VA = "0x16D9E5C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60046DA")]
	[Address(RVA = "0x16D9DE8", Offset = "0x16D9DE8", VA = "0x16D9DE8")]
	private IEnumerator DelaySpring()
	{
		return null;
	}

	[Token(Token = "0x60046DB")]
	[Address(RVA = "0x16D9FCC", Offset = "0x16D9FCC", VA = "0x16D9FCC")]
	public void Spring()
	{
	}

	[Token(Token = "0x60046DC")]
	[Address(RVA = "0x16DA15C", Offset = "0x16DA15C", VA = "0x16DA15C")]
	public SpringPlatform()
	{
	}
}
