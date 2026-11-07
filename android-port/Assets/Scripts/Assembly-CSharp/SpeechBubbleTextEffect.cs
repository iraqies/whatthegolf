using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200052E")]
public class SpeechBubbleTextEffect : ScriptableObject
{
	[Token(Token = "0x200052F")]
	public enum CharSoundMode
	{
		[Token(Token = "0x4001AAC")]
		Characters = 0,
		[Token(Token = "0x4001AAD")]
		Syllables = 1
	}

	[Token(Token = "0x2000530")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402E4", Offset = "0x402E4")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x10")]
		public SpeechBubbleTextEffect _003C_003E4__this;

		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> changeTextCallback;

		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x1857ABC", Offset = "0x1857ABC", VA = "0x1857ABC")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x1857AC4", Offset = "0x1857AC4", VA = "0x1857AC4")]
		internal string _003CPlaySequence_003Eg__AlphaTag_007C0(float t)
		{
			return null;
		}
	}

	[Token(Token = "0x2000531")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402F4", Offset = "0x402F4")]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x1857B50", Offset = "0x1857B50", VA = "0x1857B50")]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x1857B58", Offset = "0x1857B58", VA = "0x1857B58")]
		internal void _003CPlaySequence_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000532")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40304", Offset = "0x40304")]
	private sealed class _003CPlaySequence_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x20")]
		public SpeechBubbleTextEffect _003C_003E4__this;

		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x30")]
		public Action<string> changeTextCallback;

		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass8_1 _003C_003E8__1;

		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x40")]
		private IEnumerator _003Cco_003E5__2;

		[Token(Token = "0x170002A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x18581EC", Offset = "0x18581EC", VA = "0x18581EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x1858234", Offset = "0x1858234", VA = "0x1858234", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x1857ECC", Offset = "0x1857ECC", VA = "0x1857ECC")]
		[DebuggerHidden]
		public _003CPlaySequence_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x1857EF8", Offset = "0x1857EF8", VA = "0x1857EF8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x1857EFC", Offset = "0x1857EFC", VA = "0x1857EFC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x18581EC", Offset = "0x18581EC", VA = "0x18581EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x18581F4", Offset = "0x18581F4", VA = "0x18581F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x1858234", Offset = "0x1858234", VA = "0x1858234", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001AA3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip charSound;

	[Token(Token = "0x4001AA4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CharSoundMode charSoundMode;

	[Token(Token = "0x4001AA5")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float charTime;

	[Token(Token = "0x4001AA6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float spaceTime;

	[Token(Token = "0x4001AA7")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float newLineTime;

	[Token(Token = "0x4001AA8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float punctuationTime;

	[Token(Token = "0x4001AA9")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder sb;

	[Token(Token = "0x4001AAA")]
	[FieldOffset(Offset = "0x40")]
	private readonly HashSet<char> vowels;

	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x16CF414", Offset = "0x16CF414", VA = "0x16CF414")]
	public IEnumerator PlaySequence(string text, Action<string> changeTextCallback)
	{
		return null;
	}

	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x16CF49C", Offset = "0x16CF49C", VA = "0x16CF49C")]
	private void PlayCharSound(string remainingText)
	{
	}

	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x16CF618", Offset = "0x16CF618", VA = "0x16CF618")]
	private bool IsVowel(char c)
	{
		return default;
	}

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x16CF6B8", Offset = "0x16CF6B8", VA = "0x16CF6B8")]
	private float CharDuration(char c)
	{
		return default;
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x16CF784", Offset = "0x16CF784", VA = "0x16CF784")]
	private string RatioToHex(float t)
	{
		return null;
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x16CF804", Offset = "0x16CF804", VA = "0x16CF804")]
	public SpeechBubbleTextEffect()
	{
	}
}
