using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200007B")]
public class InputFieldCharacterCountFeedback : TMP_InputField
{
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5D8", Offset = "0x3D5D8")]
	private sealed class _003CAnimateImageColor_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x20")]
		public InputFieldCharacterCountFeedback _003C_003E4__this;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x28")]
		private float _003CendWaitTime_003E5__2;

		[Token(Token = "0x17000055")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x17C6658", Offset = "0x17C6658", VA = "0x17C6658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000056")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x17C66A0", Offset = "0x17C66A0", VA = "0x17C66A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x17C644C", Offset = "0x17C644C", VA = "0x17C644C")]
		[DebuggerHidden]
		public _003CAnimateImageColor_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x17C6478", Offset = "0x17C6478", VA = "0x17C6478", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x17C647C", Offset = "0x17C647C", VA = "0x17C647C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x17C6658", Offset = "0x17C6658", VA = "0x17C6658", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x17C6660", Offset = "0x17C6660", VA = "0x17C6660", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x17C66A0", Offset = "0x17C66A0", VA = "0x17C66A0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5E8", Offset = "0x3D5E8")]
	private sealed class _003CAnimateImageColorV2_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x20")]
		public InputFieldCharacterCountFeedback _003C_003E4__this;

		[Token(Token = "0x17000057")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x17C67C0", Offset = "0x17C67C0", VA = "0x17C67C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000058")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x17C6808", Offset = "0x17C6808", VA = "0x17C6808", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x17C66A8", Offset = "0x17C66A8", VA = "0x17C66A8")]
		[DebuggerHidden]
		public _003CAnimateImageColorV2_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x17C66D4", Offset = "0x17C66D4", VA = "0x17C66D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x17C66D8", Offset = "0x17C66D8", VA = "0x17C66D8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x17C67C0", Offset = "0x17C67C0", VA = "0x17C67C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x17C67C8", Offset = "0x17C67C8", VA = "0x17C67C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x17C6808", Offset = "0x17C6808", VA = "0x17C6808", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x2F0")]
	[SerializeField]
	private TextMeshProUGUI countRenderer;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x2F8")]
	[SerializeField]
	private Graphic inputFieldBackground;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	private Color inputBackgroundColor;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x310")]
	[SerializeField]
	private Color badInputFeedbackColor;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x320")]
	[SerializeField]
	private float badInputFadeTime;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x328")]
	private string lastContent;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x330")]
	private Coroutine backgroundFeedbackAnimCo;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x338")]
	private Color originalColor;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x348")]
	private bool keyPressed;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x34C")]
	private float badInputAnimEndTime;

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x14ED8A0", Offset = "0x14ED8A0", VA = "0x14ED8A0")]
	private new void Start()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x14ED9BC", Offset = "0x14ED9BC", VA = "0x14ED9BC", Slot = "64")]
	protected override bool IsValidChar(char c)
	{
		return default;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x14ED9F0", Offset = "0x14ED9F0", VA = "0x14ED9F0")]
	private void HandleCharacterLimit()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x14EDB40", Offset = "0x14EDB40", VA = "0x14EDB40")]
	private void HandleValueChanged(string content)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x14EDBBC", Offset = "0x14EDBBC", VA = "0x14EDBBC")]
	private IEnumerator AnimateImageColor()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x14EDACC", Offset = "0x14EDACC", VA = "0x14EDACC")]
	private IEnumerator AnimateImageColorV2()
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x14EDC30", Offset = "0x14EDC30", VA = "0x14EDC30")]
	public InputFieldCharacterCountFeedback()
	{
	}
}
