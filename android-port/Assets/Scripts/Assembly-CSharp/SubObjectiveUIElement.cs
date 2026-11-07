using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000A83")]
public class SubObjectiveUIElement : MonoBehaviour
{
	[Token(Token = "0x2000A84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E30", Offset = "0x42E30")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4003A5C")]
		[FieldOffset(Offset = "0x10")]
		public SubObjectiveUIElement _003C_003E4__this;

		[Token(Token = "0x4003A5D")]
		[FieldOffset(Offset = "0x18")]
		public Color startColor;

		[Token(Token = "0x6003233")]
		[Address(RVA = "0x185B640", Offset = "0x185B640", VA = "0x185B640")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6003234")]
		[Address(RVA = "0x185B648", Offset = "0x185B648", VA = "0x185B648")]
		internal void _003CUnlockRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000A85")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E40", Offset = "0x42E40")]
	private sealed class _003CUnlockRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A5E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A5F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A60")]
		[FieldOffset(Offset = "0x20")]
		public SubObjectiveUIElement _003C_003E4__this;

		[Token(Token = "0x4003A61")]
		[FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x1700052D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003238")]
			[Address(RVA = "0x185B898", Offset = "0x185B898", VA = "0x185B898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700052E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600323A")]
			[Address(RVA = "0x185B8E0", Offset = "0x185B8E0", VA = "0x185B8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003235")]
		[Address(RVA = "0x185B6AC", Offset = "0x185B6AC", VA = "0x185B6AC")]
		[DebuggerHidden]
		public _003CUnlockRoutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003236")]
		[Address(RVA = "0x185B6D8", Offset = "0x185B6D8", VA = "0x185B6D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003237")]
		[Address(RVA = "0x185B6DC", Offset = "0x185B6DC", VA = "0x185B6DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003238")]
		[Address(RVA = "0x185B898", Offset = "0x185B898", VA = "0x185B898", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003239")]
		[Address(RVA = "0x185B8A0", Offset = "0x185B8A0", VA = "0x185B8A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600323A")]
		[Address(RVA = "0x185B8E0", Offset = "0x185B8E0", VA = "0x185B8E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003A46")]
	[FieldOffset(Offset = "0x18")]
	public SVGImage Image;

	[Token(Token = "0x4003A47")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Text;

	[Token(Token = "0x4003A48")]
	[FieldOffset(Offset = "0x28")]
	public Button Button;

	[Token(Token = "0x4003A49")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform RectTransform;

	[Token(Token = "0x4003A4A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ChallengedLocked;

	[Token(Token = "0x4003A4B")]
	[FieldOffset(Offset = "0x40")]
	public Color LockedColor;

	[Token(Token = "0x4003A4C")]
	[FieldOffset(Offset = "0x50")]
	public Color UnlockedColor;

	[Token(Token = "0x4003A4D")]
	[FieldOffset(Offset = "0x60")]
	public string ChallengeID;

	[Token(Token = "0x4003A4E")]
	[FieldOffset(Offset = "0x68")]
	public string ChallengeTitleID;

	[Token(Token = "0x4003A4F")]
	[FieldOffset(Offset = "0x70")]
	public SVGImage ImageDisabled;

	[Token(Token = "0x4003A50")]
	[FieldOffset(Offset = "0x78")]
	public SVGImage ImageButton;

	[Token(Token = "0x4003A51")]
	[FieldOffset(Offset = "0x80")]
	public Sprite SpriteButton;

	[Token(Token = "0x4003A52")]
	[FieldOffset(Offset = "0x88")]
	public Sprite SpriteDisabled;

	[Token(Token = "0x4003A53")]
	[FieldOffset(Offset = "0x90")]
	public Animator ElementAnimator;

	[Token(Token = "0x4003A54")]
	[FieldOffset(Offset = "0x98")]
	public Sprite ArrowSprite;

	[Token(Token = "0x4003A55")]
	[FieldOffset(Offset = "0xA0")]
	public Sprite SquareSprite;

	[Token(Token = "0x4003A56")]
	[FieldOffset(Offset = "0xA8")]
	public Sprite ArrowSpriteMask;

	[Token(Token = "0x4003A57")]
	[FieldOffset(Offset = "0xB0")]
	public Sprite SquareSpriteMask;

	[Token(Token = "0x4003A58")]
	[FieldOffset(Offset = "0xB8")]
	public ClipSettingsCollection sfxOnSelect;

	[Token(Token = "0x4003A59")]
	[FieldOffset(Offset = "0xC0")]
	private SVGImage lockedImage;

	[Token(Token = "0x4003A5A")]
	[FieldOffset(Offset = "0xC8")]
	private bool routineRunning;

	[Token(Token = "0x4003A5B")]
	[FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50568", Offset = "0x50568")]
	private bool IsLast__BackingField;

	[Token(Token = "0x1700052C")]
	public bool IsLast
	{
		[Token(Token = "0x600322B")]
		[Address(RVA = "0x16E6BA8", Offset = "0x16E6BA8", VA = "0x16E6BA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69CC4", Offset = "0x69CC4")]
		get
		{
			return default;
		}
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x16E6BB0", Offset = "0x16E6BB0", VA = "0x16E6BB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69CD4", Offset = "0x69CD4")]
		private set
		{
		}
	}

	[Token(Token = "0x600322D")]
	[Address(RVA = "0x16E6BB8", Offset = "0x16E6BB8", VA = "0x16E6BB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x16E6C14", Offset = "0x16E6C14", VA = "0x16E6C14")]
	public void Init(bool isLast)
	{
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0x16E6C1C", Offset = "0x16E6C1C", VA = "0x16E6C1C")]
	public void Lock()
	{
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0x16E6C6C", Offset = "0x16E6C6C", VA = "0x16E6C6C")]
	public void Unlock(float duration)
	{
	}

	[Token(Token = "0x6003231")]
	[Address(RVA = "0x16E6D74", Offset = "0x16E6D74", VA = "0x16E6D74")]
	private IEnumerator UnlockRoutine(float duration)
	{
		return null;
	}

	[Token(Token = "0x6003232")]
	[Address(RVA = "0x16E6DF8", Offset = "0x16E6DF8", VA = "0x16E6DF8")]
	public SubObjectiveUIElement()
	{
	}
}
