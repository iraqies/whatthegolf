using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000435")]
public class ChallengeCompletedUI : MonoBehaviour
{
	[Token(Token = "0x2000436")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA4C", Offset = "0x3FA4C")]
	private sealed class _003CRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001701")]
		[FieldOffset(Offset = "0x20")]
		public ChallengeCompletedUI _003C_003E4__this;

		[Token(Token = "0x4001702")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x4001703")]
		[FieldOffset(Offset = "0x30")]
		public bool success;

		[Token(Token = "0x17000232")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x1782EB0", Offset = "0x1782EB0", VA = "0x1782EB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000233")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x1782EF8", Offset = "0x1782EF8", VA = "0x1782EF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x1782BC4", Offset = "0x1782BC4", VA = "0x1782BC4")]
		[DebuggerHidden]
		public _003CRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x1782BF0", Offset = "0x1782BF0", VA = "0x1782BF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x1782BF4", Offset = "0x1782BF4", VA = "0x1782BF4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x1782EB0", Offset = "0x1782EB0", VA = "0x1782EB0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x1782EB8", Offset = "0x1782EB8", VA = "0x1782EB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x1782EF8", Offset = "0x1782EF8", VA = "0x1782EF8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40016F6")]
	[FieldOffset(Offset = "0x18")]
	public Transform Container;

	[Token(Token = "0x40016F7")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI ChallengeTitle;

	[Token(Token = "0x40016F8")]
	[FieldOffset(Offset = "0x28")]
	public float AppearDuration;

	[Token(Token = "0x40016F9")]
	[FieldOffset(Offset = "0x2C")]
	public float DisappearDuration;

	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x30")]
	public float HoldDuration;

	[Token(Token = "0x40016FB")]
	[FieldOffset(Offset = "0x34")]
	public float PunchMax;

	[Token(Token = "0x40016FC")]
	[FieldOffset(Offset = "0x38")]
	public float SpeechSpeed;

	[Token(Token = "0x40016FD")]
	[FieldOffset(Offset = "0x40")]
	public RandomAudioClips TextClips;

	[Token(Token = "0x40016FE")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip DisappearClip;

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x1892BCC", Offset = "0x1892BCC", VA = "0x1892BCC")]
	public void ChallengeCompleted(string title, bool success)
	{
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x1892C5C", Offset = "0x1892C5C", VA = "0x1892C5C")]
	private IEnumerator Routine(string title, bool success)
	{
		return null;
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x1892CE4", Offset = "0x1892CE4", VA = "0x1892CE4")]
	public ChallengeCompletedUI()
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x1892D10", Offset = "0x1892D10", VA = "0x1892D10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F5C", Offset = "0x61F5C")]
	private void _003CRoutine_003Eb__10_0(float t)
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x1892DE8", Offset = "0x1892DE8", VA = "0x1892DE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F6C", Offset = "0x61F6C")]
	private void _003CRoutine_003Eb__10_1(float t)
	{
	}
}
