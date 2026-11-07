using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A64")]
public class OpenLeaderboardOnHit : MonoBehaviour
{
	[Token(Token = "0x2000A65")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CE0", Offset = "0x42CE0")]
	private sealed class _003CHandleHit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40039AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40039AB")]
		[FieldOffset(Offset = "0x20")]
		public OpenLeaderboardOnHit _003C_003E4__this;

		[Token(Token = "0x17000521")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600319D")]
			[Address(RVA = "0x180BAFC", Offset = "0x180BAFC", VA = "0x180BAFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000522")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600319F")]
			[Address(RVA = "0x180BB44", Offset = "0x180BB44", VA = "0x180BB44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600319A")]
		[Address(RVA = "0x180B928", Offset = "0x180B928", VA = "0x180B928")]
		[DebuggerHidden]
		public _003CHandleHit_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600319B")]
		[Address(RVA = "0x180B954", Offset = "0x180B954", VA = "0x180B954", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600319C")]
		[Address(RVA = "0x180B958", Offset = "0x180B958", VA = "0x180B958", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600319D")]
		[Address(RVA = "0x180BAFC", Offset = "0x180BAFC", VA = "0x180BAFC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600319E")]
		[Address(RVA = "0x180BB04", Offset = "0x180BB04", VA = "0x180BB04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600319F")]
		[Address(RVA = "0x180BB44", Offset = "0x180BB44", VA = "0x180BB44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40039A1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject playfabLeaderboard;

	[Token(Token = "0x40039A2")]
	[FieldOffset(Offset = "0x20")]
	public List<string> ActivatorTags;

	[Token(Token = "0x40039A3")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> OnHitClip;

	[Token(Token = "0x40039A4")]
	[FieldOffset(Offset = "0x30")]
	public float delay;

	[Token(Token = "0x40039A5")]
	[FieldOffset(Offset = "0x34")]
	public float bounceFactor;

	[Token(Token = "0x40039A6")]
	[FieldOffset(Offset = "0x38")]
	public bool ignoreActivatorTags;

	[Token(Token = "0x40039A7")]
	[FieldOffset(Offset = "0x3C")]
	public LeaderboardBoard board;

	[Token(Token = "0x40039A8")]
	[FieldOffset(Offset = "0x40")]
	private bool isHandlingHit;

	[Token(Token = "0x6003197")]
	[Address(RVA = "0x159CC7C", Offset = "0x159CC7C", VA = "0x159CC7C")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6003198")]
	[Address(RVA = "0x159CE5C", Offset = "0x159CE5C", VA = "0x159CE5C")]
	public IEnumerator HandleHit()
	{
		return null;
	}

	[Token(Token = "0x6003199")]
	[Address(RVA = "0x159CED0", Offset = "0x159CED0", VA = "0x159CED0")]
	public OpenLeaderboardOnHit()
	{
	}
}
