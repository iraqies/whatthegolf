using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA2")]
public class CowTippable : MonoBehaviour
{
	[Token(Token = "0x2000AA3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42EE0", Offset = "0x42EE0")]
	private sealed class _003CTipRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B2B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B2C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x20")]
		public CowTippable _003C_003E4__this;

		[Token(Token = "0x1700053D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032C3")]
			[Address(RVA = "0x1791304", Offset = "0x1791304", VA = "0x1791304", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700053E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032C5")]
			[Address(RVA = "0x179134C", Offset = "0x179134C", VA = "0x179134C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x17910D4", Offset = "0x17910D4", VA = "0x17910D4")]
		[DebuggerHidden]
		public _003CTipRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x1791100", Offset = "0x1791100", VA = "0x1791100", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x1791104", Offset = "0x1791104", VA = "0x1791104", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x1791304", Offset = "0x1791304", VA = "0x1791304", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x179130C", Offset = "0x179130C", VA = "0x179130C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x179134C", Offset = "0x179134C", VA = "0x179134C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B22")]
	[FieldOffset(Offset = "0x18")]
	public List<string> ActivatorTags;

	[Token(Token = "0x4003B23")]
	[FieldOffset(Offset = "0x20")]
	private Animator CowAnimator;

	[Token(Token = "0x4003B24")]
	[FieldOffset(Offset = "0x28")]
	private bool isTipped;

	[Token(Token = "0x4003B25")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection mooClips;

	[Token(Token = "0x4003B26")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection switchClips;

	[Token(Token = "0x4003B27")]
	[FieldOffset(Offset = "0x40")]
	public OnCollisionEnter2DHandler cowCollisionHandler;

	[Token(Token = "0x4003B28")]
	[FieldOffset(Offset = "0x48")]
	private bool isTipping;

	[Token(Token = "0x4003B29")]
	[FieldOffset(Offset = "0x50")]
	public ShowSpeechbubbleOnHit SpeechStanding;

	[Token(Token = "0x4003B2A")]
	[FieldOffset(Offset = "0x58")]
	public ShowSpeechbubbleOnHit SpeechLying;

	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x18BAC88", Offset = "0x18BAC88", VA = "0x18BAC88")]
	private void Awake()
	{
	}

	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x18BAD5C", Offset = "0x18BAD5C", VA = "0x18BAD5C")]
	private void Handle_OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x18BAE54", Offset = "0x18BAE54", VA = "0x18BAE54")]
	private IEnumerator TipRoutine()
	{
		return null;
	}

	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x18BAEC8", Offset = "0x18BAEC8", VA = "0x18BAEC8")]
	public CowTippable()
	{
	}
}
