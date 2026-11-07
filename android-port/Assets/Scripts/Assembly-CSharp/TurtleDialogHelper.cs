using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D1F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x446D8", Offset = "0x446D8")]
public class TurtleDialogHelper : MonoBehaviour
{
	[Token(Token = "0x2000D20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44740", Offset = "0x44740")]
	private sealed class _003CDoEvent_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004730")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004731")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004732")]
		[FieldOffset(Offset = "0x20")]
		public TurtleDialogHelper _003C_003E4__this;

		[Token(Token = "0x17000657")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DEE")]
			[Address(RVA = "0x1870768", Offset = "0x1870768", VA = "0x1870768", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000658")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DF0")]
			[Address(RVA = "0x18707B0", Offset = "0x18707B0", VA = "0x18707B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x1870670", Offset = "0x1870670", VA = "0x1870670")]
		[DebuggerHidden]
		public _003CDoEvent_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x187069C", Offset = "0x187069C", VA = "0x187069C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x18706A0", Offset = "0x18706A0", VA = "0x18706A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x1870768", Offset = "0x1870768", VA = "0x1870768", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x1870770", Offset = "0x1870770", VA = "0x1870770", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x18707B0", Offset = "0x18707B0", VA = "0x18707B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400472C")]
	[FieldOffset(Offset = "0x18")]
	public SpeechbubbleList ReplaceOnEnd;

	[Token(Token = "0x400472D")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent AfterEndSpeech;

	[Token(Token = "0x400472E")]
	[FieldOffset(Offset = "0x28")]
	public float EndDelay;

	[Token(Token = "0x400472F")]
	[FieldOffset(Offset = "0x2C")]
	private bool isEnd;

	[Token(Token = "0x6003DE7")]
	[Address(RVA = "0x17317A4", Offset = "0x17317A4", VA = "0x17317A4")]
	public void SwapSpeechBubble()
	{
	}

	[Token(Token = "0x6003DE8")]
	[Address(RVA = "0x1731814", Offset = "0x1731814", VA = "0x1731814")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6003DE9")]
	[Address(RVA = "0x17318B4", Offset = "0x17318B4", VA = "0x17318B4")]
	private IEnumerator DoEvent()
	{
		return null;
	}

	[Token(Token = "0x6003DEA")]
	[Address(RVA = "0x1731928", Offset = "0x1731928", VA = "0x1731928")]
	public TurtleDialogHelper()
	{
	}
}
