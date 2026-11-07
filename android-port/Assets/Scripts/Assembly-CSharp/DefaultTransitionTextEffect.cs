using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000585")]
public class DefaultTransitionTextEffect : TransitionTextEffect
{
	[Token(Token = "0x2000586")]
	private class Text
	{
		[Token(Token = "0x4001C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshPro textMeshPro;

		[Token(Token = "0x4001C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer renderer;

		[Token(Token = "0x4001C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform rectTransform;

		[Token(Token = "0x4001C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color initialTextColor;

		[Token(Token = "0x4001C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color initialTextOutlineColor;

		[Token(Token = "0x600192D")]
		[Address(RVA = "0x179AAA8", Offset = "0x179AAA8", VA = "0x179AAA8")]
		public Text()
		{
		}
	}

	[Token(Token = "0x2000587")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405E4", Offset = "0x405E4")]
	private sealed class _003CShow_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefaultTransitionTextEffect _003C_003E4__this;

		[Token(Token = "0x170002BC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x179AA58", Offset = "0x179AA58", VA = "0x179AA58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002BD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x179AAA0", Offset = "0x179AAA0", VA = "0x179AAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600192E")]
		[Address(RVA = "0x179A8E8", Offset = "0x179A8E8", VA = "0x179A8E8")]
		[DebuggerHidden]
		public _003CShow_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600192F")]
		[Address(RVA = "0x179A914", Offset = "0x179A914", VA = "0x179A914", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001930")]
		[Address(RVA = "0x179A918", Offset = "0x179A918", VA = "0x179A918", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001931")]
		[Address(RVA = "0x179AA58", Offset = "0x179AA58", VA = "0x179AA58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001932")]
		[Address(RVA = "0x179AA60", Offset = "0x179AA60", VA = "0x179AA60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001933")]
		[Address(RVA = "0x179AAA0", Offset = "0x179AAA0", VA = "0x179AAA0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000588")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405F4", Offset = "0x405F4")]
	private sealed class _003CHide_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefaultTransitionTextEffect _003C_003E4__this;

		[Token(Token = "0x4001C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float transitionOutDuration;

		[Token(Token = "0x170002BE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x179A898", Offset = "0x179A898", VA = "0x179A898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002BF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001939")]
			[Address(RVA = "0x179A8E0", Offset = "0x179A8E0", VA = "0x179A8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001934")]
		[Address(RVA = "0x179A6F4", Offset = "0x179A6F4", VA = "0x179A6F4")]
		[DebuggerHidden]
		public _003CHide_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001935")]
		[Address(RVA = "0x179A720", Offset = "0x179A720", VA = "0x179A720", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001936")]
		[Address(RVA = "0x179A724", Offset = "0x179A724", VA = "0x179A724", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001937")]
		[Address(RVA = "0x179A898", Offset = "0x179A898", VA = "0x179A898", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001938")]
		[Address(RVA = "0x179A8A0", Offset = "0x179A8A0", VA = "0x179A8A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001939")]
		[Address(RVA = "0x179A8E0", Offset = "0x179A8E0", VA = "0x179A8E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001C51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshPro[] _texts;

	[Token(Token = "0x4001C52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rootTransform;

	[Token(Token = "0x4001C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isBusy;

	[Token(Token = "0x4001C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CanvasScaler canvasScaler;

	[Token(Token = "0x4001C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Text[] texts;

	[Token(Token = "0x170002BB")]
	public override bool IsBusy
	{
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x18D8C54", Offset = "0x18D8C54", VA = "0x18D8C54", Slot = "7")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001924")]
	[Address(RVA = "0x18D8758", Offset = "0x18D8758", VA = "0x18D8758")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001925")]
	[Address(RVA = "0x18D875C", Offset = "0x18D875C", VA = "0x18D875C", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6001926")]
	[Address(RVA = "0x18D8AF8", Offset = "0x18D8AF8", VA = "0x18D8AF8", Slot = "5")]
	public override void Prepare([Optional] string text, bool onTheSide = false)
	{
	}

	[Token(Token = "0x6001927")]
	[Address(RVA = "0x18D8BE0", Offset = "0x18D8BE0", VA = "0x18D8BE0", Slot = "6")]
	public override IEnumerator Show(float transitionInDuration)
	{
		return null;
	}

	[Token(Token = "0x6001929")]
	[Address(RVA = "0x18D8C5C", Offset = "0x18D8C5C", VA = "0x18D8C5C")]
	public void HideImmidiate()
	{
	}

	[Token(Token = "0x600192A")]
	[Address(RVA = "0x18D8CE4", Offset = "0x18D8CE4", VA = "0x18D8CE4", Slot = "8")]
	public override IEnumerator Hide(float transitionOutDuration)
	{
		return null;
	}

	[Token(Token = "0x600192B")]
	[Address(RVA = "0x18D8D68", Offset = "0x18D8D68", VA = "0x18D8D68")]
	public DefaultTransitionTextEffect()
	{
	}

	[Token(Token = "0x600192C")]
	[Address(RVA = "0x18D8D70", Offset = "0x18D8D70", VA = "0x18D8D70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63358", Offset = "0x63358")]
	private void _003CHide_003Eb__13_0(float t)
	{
	}
}
