using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x2000399")]
public class FlagAudioForChallenges : MonoBehaviour
{
	[Token(Token = "0x200039A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6BC", Offset = "0x3F6BC")]
	private sealed class _003CPlayAfterDelay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0x20")]
		public FlagAudioForChallenges _003C_003E4__this;

		[Token(Token = "0x17000208")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001112")]
			[Address(RVA = "0x17A77AC", Offset = "0x17A77AC", VA = "0x17A77AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000209")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001114")]
			[Address(RVA = "0x17A77F4", Offset = "0x17A77F4", VA = "0x17A77F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0x17A768C", Offset = "0x17A768C", VA = "0x17A768C")]
		[DebuggerHidden]
		public _003CPlayAfterDelay_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001110")]
		[Address(RVA = "0x17A76B8", Offset = "0x17A76B8", VA = "0x17A76B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001111")]
		[Address(RVA = "0x17A76BC", Offset = "0x17A76BC", VA = "0x17A76BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001112")]
		[Address(RVA = "0x17A77AC", Offset = "0x17A77AC", VA = "0x17A77AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001113")]
		[Address(RVA = "0x17A77B4", Offset = "0x17A77B4", VA = "0x17A77B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001114")]
		[Address(RVA = "0x17A77F4", Offset = "0x17A77F4", VA = "0x17A77F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float playAfterDelay;

	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip sfxHit;

	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection hitFullApplauseSFX;

	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RumbleEventAsset rumble;

	[Token(Token = "0x40013E1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioMixerSnapshot snapshot;

	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0x40")]
	private float nextAudio;

	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CEE0", Offset = "0x4CEE0")]
	private bool PlayAudioRemotely__BackingField;

	[Token(Token = "0x17000207")]
	public bool PlayAudioRemotely
	{
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x146A4C4", Offset = "0x146A4C4", VA = "0x146A4C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617EC", Offset = "0x617EC")]
		get
		{
			return default;
		}
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x146A4CC", Offset = "0x146A4CC", VA = "0x146A4CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617FC", Offset = "0x617FC")]
		set
		{
		}
	}

	[Token(Token = "0x600110B")]
	[Address(RVA = "0x146A4D4", Offset = "0x146A4D4", VA = "0x146A4D4")]
	public void PlayFlagAudio()
	{
	}

	[Token(Token = "0x600110C")]
	[Address(RVA = "0x146A620", Offset = "0x146A620", VA = "0x146A620")]
	private void GoodHit()
	{
	}

	[Token(Token = "0x600110D")]
	[Address(RVA = "0x146A5AC", Offset = "0x146A5AC", VA = "0x146A5AC")]
	private IEnumerator PlayAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x600110E")]
	[Address(RVA = "0x146A750", Offset = "0x146A750", VA = "0x146A750")]
	public FlagAudioForChallenges()
	{
	}
}
