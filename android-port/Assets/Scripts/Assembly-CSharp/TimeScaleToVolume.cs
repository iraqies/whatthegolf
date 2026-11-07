using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E4")]
public class TimeScaleToVolume : MonoBehaviour
{
	[Token(Token = "0x20003E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F8D4", Offset = "0x3F8D4")]
	private sealed class _003CLookForAudio_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x20")]
		public TimeScaleToVolume _003C_003E4__this;

		[Token(Token = "0x1700021D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600124F")]
			[Address(RVA = "0x18674A8", Offset = "0x18674A8", VA = "0x18674A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700021E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001251")]
			[Address(RVA = "0x18674F0", Offset = "0x18674F0", VA = "0x18674F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600124C")]
		[Address(RVA = "0x18673A0", Offset = "0x18673A0", VA = "0x18673A0")]
		[DebuggerHidden]
		public _003CLookForAudio_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600124D")]
		[Address(RVA = "0x18673CC", Offset = "0x18673CC", VA = "0x18673CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600124E")]
		[Address(RVA = "0x18673D0", Offset = "0x18673D0", VA = "0x18673D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600124F")]
		[Address(RVA = "0x18674A8", Offset = "0x18674A8", VA = "0x18674A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001250")]
		[Address(RVA = "0x18674B0", Offset = "0x18674B0", VA = "0x18674B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001251")]
		[Address(RVA = "0x18674F0", Offset = "0x18674F0", VA = "0x18674F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x18")]
	public float minVolume;

	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x1C")]
	public float maxVolume;

	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x20")]
	public float minPitch;

	[Token(Token = "0x400153B")]
	[FieldOffset(Offset = "0x24")]
	public float maxPitch;

	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource audio;

	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x30")]
	private Clock clock;

	[Token(Token = "0x400153E")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine findAudio;

	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x40")]
	private float volumeRef;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x44")]
	private float pitchRef;

	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x48")]
	private float volume;

	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x4C")]
	private float pitch;

	[Token(Token = "0x6001249")]
	[Address(RVA = "0x1716A30", Offset = "0x1716A30", VA = "0x1716A30")]
	private void Update()
	{
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0x1716C84", Offset = "0x1716C84", VA = "0x1716C84")]
	private IEnumerator LookForAudio()
	{
		return null;
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x1716CF8", Offset = "0x1716CF8", VA = "0x1716CF8")]
	public TimeScaleToVolume()
	{
	}
}
