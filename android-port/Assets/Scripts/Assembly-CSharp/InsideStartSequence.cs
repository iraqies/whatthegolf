using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079D")]
public class InsideStartSequence : MonoBehaviour
{
	[Token(Token = "0x200079E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41530", Offset = "0x41530")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x10")]
		public InsideStartSequence _003C_003E4__this;

		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 s;

		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x17C6994", Offset = "0x17C6994", VA = "0x17C6994")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x17C699C", Offset = "0x17C699C", VA = "0x17C699C")]
		internal void _003CStartSequence_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200079F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41540", Offset = "0x41540")]
	private sealed class _003CStartSequence_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x20")]
		public InsideStartSequence _003C_003E4__this;

		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x28")]
		private GolfBallController _003Cc_003E5__2;

		[Token(Token = "0x170003D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x17C6E44", Offset = "0x17C6E44", VA = "0x17C6E44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x17C6E8C", Offset = "0x17C6E8C", VA = "0x17C6E8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x17C6A70", Offset = "0x17C6A70", VA = "0x17C6A70")]
		[DebuggerHidden]
		public _003CStartSequence_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x17C6A9C", Offset = "0x17C6A9C", VA = "0x17C6A9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x17C6AA0", Offset = "0x17C6AA0", VA = "0x17C6AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x17C6E44", Offset = "0x17C6E44", VA = "0x17C6E44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x17C6E4C", Offset = "0x17C6E4C", VA = "0x17C6E4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x17C6E8C", Offset = "0x17C6E8C", VA = "0x17C6E8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400283F")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> Boards;

	[Token(Token = "0x4002840")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody Player;

	[Token(Token = "0x4002841")]
	[FieldOffset(Offset = "0x28")]
	public InsideObserver Observer;

	[Token(Token = "0x4002842")]
	[FieldOffset(Offset = "0x30")]
	public InsideQueueManager Manager;

	[Token(Token = "0x4002843")]
	[FieldOffset(Offset = "0x38")]
	private bool hasRunSequence;

	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x14F148C", Offset = "0x14F148C", VA = "0x14F148C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x14F159C", Offset = "0x14F159C", VA = "0x14F159C")]
	private IEnumerator StartSequence()
	{
		return null;
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x14F1610", Offset = "0x14F1610", VA = "0x14F1610")]
	public InsideStartSequence()
	{
	}
}
