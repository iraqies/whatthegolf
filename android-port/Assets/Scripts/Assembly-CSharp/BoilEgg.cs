using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DC")]
public class BoilEgg : MonoBehaviour
{
	[Token(Token = "0x20006DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41150", Offset = "0x41150")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x10")]
		public BoilEgg _003C_003E4__this;

		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x17735B8", Offset = "0x17735B8", VA = "0x17735B8")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x17735C0", Offset = "0x17735C0", VA = "0x17735C0")]
		internal void _003CBoilRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20006DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41160", Offset = "0x41160")]
	private sealed class _003CBoilRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x20")]
		public BoilEgg _003C_003E4__this;

		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x170003A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x1773ABC", Offset = "0x1773ABC", VA = "0x1773ABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x1773B04", Offset = "0x1773B04", VA = "0x1773B04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x1773708", Offset = "0x1773708", VA = "0x1773708")]
		[DebuggerHidden]
		public _003CBoilRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x1773734", Offset = "0x1773734", VA = "0x1773734", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x1773738", Offset = "0x1773738", VA = "0x1773738", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x1773ABC", Offset = "0x1773ABC", VA = "0x1773ABC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x1773AC4", Offset = "0x1773AC4", VA = "0x1773AC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x1773B04", Offset = "0x1773B04", VA = "0x1773B04", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40023E9")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Egg;

	[Token(Token = "0x40023EA")]
	[FieldOffset(Offset = "0x20")]
	public float BoilDuration;

	[Token(Token = "0x40023EB")]
	[FieldOffset(Offset = "0x28")]
	public LoopRandomAudioClips boilingBubbleSFX;

	[Token(Token = "0x40023EC")]
	[FieldOffset(Offset = "0x30")]
	public IntroLoopOutro eggTimerIntroLoopOutro;

	[Token(Token = "0x40023ED")]
	[FieldOffset(Offset = "0x38")]
	public float ShakeSpeed;

	[Token(Token = "0x40023EE")]
	[FieldOffset(Offset = "0x3C")]
	public float ShakeAmount;

	[Token(Token = "0x40023EF")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine buildRoutine;

	[Token(Token = "0x40023F0")]
	[FieldOffset(Offset = "0x48")]
	public Action OnBoilStart;

	[Token(Token = "0x40023F1")]
	[FieldOffset(Offset = "0x50")]
	public Action OnBoilComplete;

	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0x161752C", Offset = "0x161752C", VA = "0x161752C")]
	private IEnumerator BoilRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x16175A0", Offset = "0x16175A0", VA = "0x16175A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x16176AC", Offset = "0x16176AC", VA = "0x16176AC")]
	public BoilEgg()
	{
	}
}
