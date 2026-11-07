using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000428")]
public class TouchChallenge : Challenge
{
	[Token(Token = "0x2000429")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9FC", Offset = "0x3F9FC")]
	private sealed class _003CWaitAndComplete_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x20")]
		public TouchChallenge _003C_003E4__this;

		[Token(Token = "0x1700022C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x1869348", Offset = "0x1869348", VA = "0x1869348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700022D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x1869390", Offset = "0x1869390", VA = "0x1869390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600138B")]
		[Address(RVA = "0x1869268", Offset = "0x1869268", VA = "0x1869268")]
		[DebuggerHidden]
		public _003CWaitAndComplete_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600138C")]
		[Address(RVA = "0x1869294", Offset = "0x1869294", VA = "0x1869294", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600138D")]
		[Address(RVA = "0x1869298", Offset = "0x1869298", VA = "0x1869298", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600138E")]
		[Address(RVA = "0x1869348", Offset = "0x1869348", VA = "0x1869348", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600138F")]
		[Address(RVA = "0x1869350", Offset = "0x1869350", VA = "0x1869350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001390")]
		[Address(RVA = "0x1869390", Offset = "0x1869390", VA = "0x1869390", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0xA8")]
	public List<GameObject> objectsToDeactivate;

	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0xB0")]
	private TiltChallengeSFX SFX;

	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject touchTarget;

	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0xC0")]
	private ChallengeTouchObject[] _challengeTouchObjects;

	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0xC8")]
	public ObjectDestroyTrigger objectDestroyTrigger;

	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0xD0")]
	private List<ChallengeTouchObject> touchingObjects;

	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0xD8")]
	public bool attachTouchObject;

	[Token(Token = "0x6001384")]
	[Address(RVA = "0x171E780", Offset = "0x171E780", VA = "0x171E780", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001385")]
	[Address(RVA = "0x171EAD8", Offset = "0x171EAD8", VA = "0x171EAD8")]
	private void OnDestroyObject(GameObject obj)
	{
	}

	[Token(Token = "0x6001386")]
	[Address(RVA = "0x171EB98", Offset = "0x171EB98", VA = "0x171EB98")]
	private void OnToughTarget(ChallengeTouchObject obj)
	{
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x171EDE0", Offset = "0x171EDE0", VA = "0x171EDE0")]
	private IEnumerator WaitAndComplete()
	{
		return null;
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x171ED14", Offset = "0x171ED14", VA = "0x171ED14")]
	private void CheckTouches()
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x171EE54", Offset = "0x171EE54", VA = "0x171EE54", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x171EE9C", Offset = "0x171EE9C", VA = "0x171EE9C")]
	public TouchChallenge()
	{
	}
}
