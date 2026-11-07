using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200042C")]
public class BeachPartyManager : MonoBehaviour
{
	[Token(Token = "0x200042D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA1C", Offset = "0x3FA1C")]
	private sealed class _003CPartyRoutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x20")]
		public BeachPartyManager _003C_003E4__this;

		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x30")]
		private QuestState _003Ccurrent_003E5__3;

		[Token(Token = "0x1700022E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x1772014", Offset = "0x1772014", VA = "0x1772014", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700022F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x177205C", Offset = "0x177205C", VA = "0x177205C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600139D")]
		[Address(RVA = "0x1771CAC", Offset = "0x1771CAC", VA = "0x1771CAC")]
		[DebuggerHidden]
		public _003CPartyRoutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600139E")]
		[Address(RVA = "0x1771CD8", Offset = "0x1771CD8", VA = "0x1771CD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600139F")]
		[Address(RVA = "0x1771CDC", Offset = "0x1771CDC", VA = "0x1771CDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x1772014", Offset = "0x1772014", VA = "0x1772014", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x177201C", Offset = "0x177201C", VA = "0x177201C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x177205C", Offset = "0x177205C", VA = "0x177205C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0x18")]
	public float StartDelay;

	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x1C")]
	public float EndDelay;

	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem HintParticleSystem;

	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x30")]
	private QuestState[] allStates;

	[Token(Token = "0x6001399")]
	[Address(RVA = "0x160C274", Offset = "0x160C274", VA = "0x160C274")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x160C50C", Offset = "0x160C50C", VA = "0x160C50C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x160C498", Offset = "0x160C498", VA = "0x160C498")]
	private IEnumerator PartyRoutine()
	{
		return null;
	}

	[Token(Token = "0x600139C")]
	[Address(RVA = "0x160C618", Offset = "0x160C618", VA = "0x160C618")]
	public BeachPartyManager()
	{
	}
}
