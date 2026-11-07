using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009A8")]
public class DoorBubble : MonoBehaviour
{
	[Token(Token = "0x20009A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42660", Offset = "0x42660")]
	private sealed class _003CBubbleShow_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x20")]
		public DoorBubble _003C_003E4__this;

		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x28")]
		private float _003CscaleUpDuration_003E5__2;

		[Token(Token = "0x170004B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D74")]
			[Address(RVA = "0x179D8E4", Offset = "0x179D8E4", VA = "0x179D8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D76")]
			[Address(RVA = "0x179D92C", Offset = "0x179D92C", VA = "0x179D92C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x179D680", Offset = "0x179D680", VA = "0x179D680")]
		[DebuggerHidden]
		public _003CBubbleShow_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x179D6AC", Offset = "0x179D6AC", VA = "0x179D6AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x179D6B0", Offset = "0x179D6B0", VA = "0x179D6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x179D8E4", Offset = "0x179D8E4", VA = "0x179D8E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x179D8EC", Offset = "0x179D8EC", VA = "0x179D8EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x179D92C", Offset = "0x179D92C", VA = "0x179D92C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400352C")]
	[FieldOffset(Offset = "0x18")]
	private DoorBubbleState state;

	[Token(Token = "0x400352D")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine scaleCoroutine;

	[Token(Token = "0x400352E")]
	[FieldOffset(Offset = "0x28")]
	private bool hasShot;

	[Token(Token = "0x400352F")]
	[FieldOffset(Offset = "0x2C")]
	private float maxBubbleScale;

	[Token(Token = "0x170004B4")]
	public DoorBubbleState State
	{
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x14329BC", Offset = "0x14329BC", VA = "0x14329BC")]
		set
		{
		}
	}

	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x14326A4", Offset = "0x14326A4", VA = "0x14326A4")]
	public void Init()
	{
	}

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x14327EC", Offset = "0x14327EC", VA = "0x14327EC")]
	public void UpdateBubbleSize()
	{
	}

	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x1432750", Offset = "0x1432750", VA = "0x1432750")]
	private void SetBubbleScale()
	{
	}

	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x143285C", Offset = "0x143285C", VA = "0x143285C")]
	public void Hit()
	{
	}

	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x1432948", Offset = "0x1432948", VA = "0x1432948")]
	private IEnumerator BubbleShow()
	{
		return null;
	}

	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x1432AC0", Offset = "0x1432AC0", VA = "0x1432AC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x1432AC8", Offset = "0x1432AC8", VA = "0x1432AC8")]
	public DoorBubble()
	{
	}

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x1432AD0", Offset = "0x1432AD0", VA = "0x1432AD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68594", Offset = "0x68594")]
	private void _003CInit_003Eb__4_0()
	{
	}

	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x1432ADC", Offset = "0x1432ADC", VA = "0x1432ADC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685A4", Offset = "0x685A4")]
	private void _003CBubbleShow_003Eb__8_0(float t)
	{
	}

	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x1432B5C", Offset = "0x1432B5C", VA = "0x1432B5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685B4", Offset = "0x685B4")]
	private void _003CBubbleShow_003Eb__8_1(float t)
	{
	}
}
