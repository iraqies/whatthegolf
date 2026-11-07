using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C3")]
public class GifMomentTrigger : MonoBehaviour
{
	[Token(Token = "0x20005C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40840", Offset = "0x40840")]
	private sealed class _003CSaveAfterDelayCR_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D7C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D7D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D7E")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4001D7F")]
		[FieldOffset(Offset = "0x28")]
		public GifMomentTrigger _003C_003E4__this;

		[Token(Token = "0x170002D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001A40")]
			[Address(RVA = "0x17B3590", Offset = "0x17B3590", VA = "0x17B3590", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A42")]
			[Address(RVA = "0x17B35D8", Offset = "0x17B35D8", VA = "0x17B35D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x17B3340", Offset = "0x17B3340", VA = "0x17B3340")]
		[DebuggerHidden]
		public _003CSaveAfterDelayCR_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x17B336C", Offset = "0x17B336C", VA = "0x17B336C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x17B3370", Offset = "0x17B3370", VA = "0x17B3370", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x17B3590", Offset = "0x17B3590", VA = "0x17B3590", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x17B3598", Offset = "0x17B3598", VA = "0x17B3598", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x17B35D8", Offset = "0x17B35D8", VA = "0x17B35D8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001D73")]
	[FieldOffset(Offset = "0x18")]
	public EGifMoment momentId;

	[Token(Token = "0x4001D74")]
	[FieldOffset(Offset = "0x1C")]
	public float durationBeforeTrigger;

	[Token(Token = "0x4001D75")]
	[FieldOffset(Offset = "0x20")]
	public float durationAfterTrigger;

	[Token(Token = "0x4001D76")]
	[FieldOffset(Offset = "0x24")]
	private bool canOverwrite;

	[Token(Token = "0x4001D77")]
	[FieldOffset(Offset = "0x28")]
	private IGifRecorder recorder;

	[Token(Token = "0x4001D78")]
	[FieldOffset(Offset = "0x30")]
	private bool wasTriggered;

	[Token(Token = "0x4001D79")]
	[FieldOffset(Offset = "0x38")]
	private GifMomentManager manager;

	[Token(Token = "0x4001D7A")]
	[FieldOffset(Offset = "0x40")]
	private bool isRecording;

	[Token(Token = "0x4001D7B")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine saveAfterDelayCR;

	[Token(Token = "0x170002D5")]
	private bool canRecordThisLevel
	{
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x1487F90", Offset = "0x1487F90", VA = "0x1487F90")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x1487D50", Offset = "0x1487D50", VA = "0x1487D50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x1488090", Offset = "0x1488090", VA = "0x1488090")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x14884F4", Offset = "0x14884F4", VA = "0x14884F4")]
	public void ManualTrigger()
	{
	}

	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x14883F4", Offset = "0x14883F4", VA = "0x14883F4")]
	private void StartRecording()
	{
	}

	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x148862C", Offset = "0x148862C", VA = "0x148862C")]
	private void CancelRecording()
	{
	}

	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x1488724", Offset = "0x1488724", VA = "0x1488724")]
	private void OnLevelRestart()
	{
	}

	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x1488634", Offset = "0x1488634", VA = "0x1488634")]
	private void StopRecording(bool save)
	{
	}

	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x1488764", Offset = "0x1488764", VA = "0x1488764")]
	private void OnLevelCompleted(Level.CompletedState state)
	{
	}

	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x1488768", Offset = "0x1488768", VA = "0x1488768")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x1488840", Offset = "0x1488840", VA = "0x1488840")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x1488930", Offset = "0x1488930", VA = "0x1488930")]
	private void OnTriggerEnter2D(Collider2D c)
	{
	}

	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x14885A8", Offset = "0x14885A8", VA = "0x14885A8")]
	private IEnumerator SaveAfterDelayCR(float delay)
	{
		return null;
	}

	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x1488A20", Offset = "0x1488A20", VA = "0x1488A20")]
	public GifMomentTrigger()
	{
	}
}
