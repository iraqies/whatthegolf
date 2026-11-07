using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A57")]
public class ShowSpeechbubbleOnHit : ShowSpeechBubble
{
	[Token(Token = "0x2000A58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CA0", Offset = "0x42CA0")]
	private sealed class _003CHandleHit_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400393A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400393B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowSpeechbubbleOnHit _003C_003E4__this;

		[Token(Token = "0x400393C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<string, string> OnPreprocessText;

		[Token(Token = "0x400393D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onTextShown;

		[Token(Token = "0x400393E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onDone;

		[Token(Token = "0x400393F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpeechbubbleList.SpeechbubbleTextInfo _003CtextInfo_003E5__2;

		[Token(Token = "0x4003940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpeechBubbleUI.Task _003CshowTask_003E5__3;

		[Token(Token = "0x17000519")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003156")]
			[Address(RVA = "0x184B2F8", Offset = "0x184B2F8", VA = "0x184B2F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700051A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003158")]
			[Address(RVA = "0x184B340", Offset = "0x184B340", VA = "0x184B340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003153")]
		[Address(RVA = "0x184AB34", Offset = "0x184AB34", VA = "0x184AB34")]
		[DebuggerHidden]
		public _003CHandleHit_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003154")]
		[Address(RVA = "0x184AB60", Offset = "0x184AB60", VA = "0x184AB60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003155")]
		[Address(RVA = "0x184AB64", Offset = "0x184AB64", VA = "0x184AB64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003156")]
		[Address(RVA = "0x184B2F8", Offset = "0x184B2F8", VA = "0x184B2F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003157")]
		[Address(RVA = "0x184B300", Offset = "0x184B300", VA = "0x184B300", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003158")]
		[Address(RVA = "0x184B340", Offset = "0x184B340", VA = "0x184B340", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SpeechbubbleList TextList;

	[Token(Token = "0x4003929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<string> ActivatorTags;

	[Token(Token = "0x400392A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<AudioClip> OnHitClip;

	[Token(Token = "0x400392B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float delay;

	[Token(Token = "0x400392C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float bounceFactor;

	[Token(Token = "0x400392D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 bubbleDir;

	[Token(Token = "0x400392E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector2 localBubblePivot;

	[Token(Token = "0x400392F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float bubbleRotation;

	[Token(Token = "0x4003930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool ignoreActivatorTags;

	[Token(Token = "0x4003931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool UseRestartTimeLimit;

	[Token(Token = "0x4003932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float ConversationRestartTimeLimit;

	[Token(Token = "0x4003933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool isAbleToTalk;

	[Token(Token = "0x4003934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform speechBubblePreferredCenterTransform;

	[Token(Token = "0x4003935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action onHit;

	[Token(Token = "0x4003936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private IConversation conversation;

	[Token(Token = "0x4003937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float lastConversationTime;

	[Token(Token = "0x4003938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5049C", Offset = "0x5049C")]
	private bool textDisplayed__BackingField;

	[Token(Token = "0x17000518")]
	public bool textDisplayed
	{
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x16A6688", Offset = "0x16A6688", VA = "0x16A6688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x698E4", Offset = "0x698E4")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x16A6690", Offset = "0x16A6690", VA = "0x16A6690")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x698F4", Offset = "0x698F4")]
		set
		{
		}
	}

	[Token(Token = "0x600314A")]
	[Address(RVA = "0x16A6698", Offset = "0x16A6698", VA = "0x16A6698")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x600314B")]
	[Address(RVA = "0x16A6960", Offset = "0x16A6960", VA = "0x16A6960")]
	public void ResetConversation()
	{
	}

	[Token(Token = "0x600314C")]
	[Address(RVA = "0x16A69A0", Offset = "0x16A69A0", VA = "0x16A69A0")]
	public void Interrupt()
	{
	}

	[Token(Token = "0x600314D")]
	[Address(RVA = "0x16A69AC", Offset = "0x16A69AC", VA = "0x16A69AC")]
	public void ForceStartSpeechBubble()
	{
	}

	[Token(Token = "0x600314E")]
	[Address(RVA = "0x16A68D4", Offset = "0x16A68D4", VA = "0x16A68D4")]
	public IEnumerator HandleHit([Optional] Action onDone, [Optional] Action onTextShown, [Optional] Func<string, string> OnPreprocessText)
	{
		return null;
	}

	[Token(Token = "0x600314F")]
	[Address(RVA = "0x16A6A2C", Offset = "0x16A6A2C", VA = "0x16A6A2C")]
	public void SetState(bool state)
	{
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0x16A6A34", Offset = "0x16A6A34", VA = "0x16A6A34")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003151")]
	[Address(RVA = "0x16A6B1C", Offset = "0x16A6B1C", VA = "0x16A6B1C")]
	public void SetConversation(IConversation conv)
	{
	}

	[Token(Token = "0x6003152")]
	[Address(RVA = "0x16A6B24", Offset = "0x16A6B24", VA = "0x16A6B24")]
	public ShowSpeechbubbleOnHit()
	{
	}
}
