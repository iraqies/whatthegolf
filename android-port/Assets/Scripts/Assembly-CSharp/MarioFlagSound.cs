using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAD")]
public class MarioFlagSound : MonoBehaviour
{
	[Token(Token = "0x2000DAE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C10", Offset = "0x44C10")]
	private sealed class _003CMovePlayerAndFlagDown_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A97")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A98")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A99")]
		[FieldOffset(Offset = "0x20")]
		public MarioFlagSound _003C_003E4__this;

		[Token(Token = "0x4004A9A")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17000697")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600405B")]
			[Address(RVA = "0x17F34F0", Offset = "0x17F34F0", VA = "0x17F34F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000698")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600405D")]
			[Address(RVA = "0x17F3538", Offset = "0x17F3538", VA = "0x17F3538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004058")]
		[Address(RVA = "0x17F3314", Offset = "0x17F3314", VA = "0x17F3314")]
		[DebuggerHidden]
		public _003CMovePlayerAndFlagDown_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004059")]
		[Address(RVA = "0x17F3340", Offset = "0x17F3340", VA = "0x17F3340", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600405A")]
		[Address(RVA = "0x17F3344", Offset = "0x17F3344", VA = "0x17F3344", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600405B")]
		[Address(RVA = "0x17F34F0", Offset = "0x17F34F0", VA = "0x17F34F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600405C")]
		[Address(RVA = "0x17F34F8", Offset = "0x17F34F8", VA = "0x17F34F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600405D")]
		[Address(RVA = "0x17F3538", Offset = "0x17F3538", VA = "0x17F3538", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004A93")]
	[FieldOffset(Offset = "0x18")]
	public ScheduleHarmonics harmonicsOnEnd;

	[Token(Token = "0x4004A94")]
	[FieldOffset(Offset = "0x20")]
	private float baseVolume;

	[Token(Token = "0x4004A95")]
	[FieldOffset(Offset = "0x24")]
	private float bonusVolume;

	[Token(Token = "0x4004A96")]
	[FieldOffset(Offset = "0x28")]
	private float increaseOverTime;

	[Token(Token = "0x6004055")]
	[Address(RVA = "0x155BC94", Offset = "0x155BC94", VA = "0x155BC94")]
	public void PlayFlagSound()
	{
	}

	[Token(Token = "0x6004056")]
	[Address(RVA = "0x155BD90", Offset = "0x155BD90", VA = "0x155BD90")]
	private IEnumerator MovePlayerAndFlagDown()
	{
		return null;
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0x155BE04", Offset = "0x155BE04", VA = "0x155BE04")]
	public MarioFlagSound()
	{
	}
}
