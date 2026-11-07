using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007DC")]
public class MarioEndFlag : MonoBehaviour
{
	[Token(Token = "0x20007DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416B0", Offset = "0x416B0")]
	private sealed class _003CMovePlayerAndFlagDown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029C9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029CA")]
		[FieldOffset(Offset = "0x20")]
		public MarioEndFlag _003C_003E4__this;

		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody player;

		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x170003F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002417")]
			[Address(RVA = "0x17F32C4", Offset = "0x17F32C4", VA = "0x17F32C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002419")]
			[Address(RVA = "0x17F330C", Offset = "0x17F330C", VA = "0x17F330C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002414")]
		[Address(RVA = "0x17F2FB8", Offset = "0x17F2FB8", VA = "0x17F2FB8")]
		[DebuggerHidden]
		public _003CMovePlayerAndFlagDown_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002415")]
		[Address(RVA = "0x17F2FE4", Offset = "0x17F2FE4", VA = "0x17F2FE4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002416")]
		[Address(RVA = "0x17F2FE8", Offset = "0x17F2FE8", VA = "0x17F2FE8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002417")]
		[Address(RVA = "0x17F32C4", Offset = "0x17F32C4", VA = "0x17F32C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002418")]
		[Address(RVA = "0x17F32CC", Offset = "0x17F32CC", VA = "0x17F32CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002419")]
		[Address(RVA = "0x17F330C", Offset = "0x17F330C", VA = "0x17F330C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x18")]
	public float FlagMoveSpeed;

	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x20")]
	public ScheduleHarmonics harmonicsOnEnd;

	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x28")]
	private float baseVolume;

	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x2C")]
	private float bonusVolume;

	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x30")]
	private float increaseOverTime;

	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody player;

	[Token(Token = "0x40029C6")]
	[FieldOffset(Offset = "0x40")]
	private bool isDone;

	[Token(Token = "0x40029C7")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 debugStart;

	[Token(Token = "0x600240F")]
	[Address(RVA = "0x155B988", Offset = "0x155B988", VA = "0x155B988")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0x155B9C4", Offset = "0x155B9C4", VA = "0x155B9C4")]
	public void DebugReset()
	{
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x155BA04", Offset = "0x155BA04", VA = "0x155BA04")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x155BBF8", Offset = "0x155BBF8", VA = "0x155BBF8")]
	private IEnumerator MovePlayerAndFlagDown(Rigidbody player)
	{
		return null;
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x155BC70", Offset = "0x155BC70", VA = "0x155BC70")]
	public MarioEndFlag()
	{
	}
}
