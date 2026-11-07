using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F27")]
public class SpeechBubbleRandomText : MonoBehaviour
{
	[Token(Token = "0x2000F28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45720", Offset = "0x45720")]
	private sealed class _003CHideAfter_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40051BF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40051C0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40051C1")]
		[FieldOffset(Offset = "0x20")]
		public SpeechBubbleRandomText _003C_003E4__this;

		[Token(Token = "0x17000754")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x1857A6C", Offset = "0x1857A6C", VA = "0x1857A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000755")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x1857AB4", Offset = "0x1857AB4", VA = "0x1857AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x185796C", Offset = "0x185796C", VA = "0x185796C")]
		[DebuggerHidden]
		public _003CHideAfter_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x1857998", Offset = "0x1857998", VA = "0x1857998", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x185799C", Offset = "0x185799C", VA = "0x185799C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x1857A6C", Offset = "0x1857A6C", VA = "0x1857A6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x1857A74", Offset = "0x1857A74", VA = "0x1857A74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x1857AB4", Offset = "0x1857AB4", VA = "0x1857AB4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40051BA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProLocalized LocalizedText;

	[Token(Token = "0x40051BB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40051BC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string IdIndexOnSheet;

	[Token(Token = "0x40051BD")]
	[FieldOffset(Offset = "0x30")]
	public int numberOfQuotes;

	[Token(Token = "0x40051BE")]
	[FieldOffset(Offset = "0x34")]
	private int index;

	[Token(Token = "0x60046CF")]
	[Address(RVA = "0x16CF288", Offset = "0x16CF288", VA = "0x16CF288")]
	public void ShowNewRandomText()
	{
	}

	[Token(Token = "0x60046D0")]
	[Address(RVA = "0x16CF398", Offset = "0x16CF398", VA = "0x16CF398")]
	private IEnumerator HideAfter()
	{
		return null;
	}

	[Token(Token = "0x60046D1")]
	[Address(RVA = "0x16CF40C", Offset = "0x16CF40C", VA = "0x16CF40C")]
	public SpeechBubbleRandomText()
	{
	}
}
