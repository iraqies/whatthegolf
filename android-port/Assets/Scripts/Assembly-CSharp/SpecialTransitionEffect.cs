using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EAD")]
public class SpecialTransitionEffect : BaseTransitionEffect
{
	[Token(Token = "0x2000EAE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45250", Offset = "0x45250")]
	private sealed class _003CBegin_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F4B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F4C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F4D")]
		[FieldOffset(Offset = "0x20")]
		public SpecialTransitionEffect _003C_003E4__this;

		[Token(Token = "0x1700070D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004490")]
			[Address(RVA = "0x18568E4", Offset = "0x18568E4", VA = "0x18568E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700070E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x185692C", Offset = "0x185692C", VA = "0x185692C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600448D")]
		[Address(RVA = "0x1856750", Offset = "0x1856750", VA = "0x1856750")]
		[DebuggerHidden]
		public _003CBegin_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600448E")]
		[Address(RVA = "0x185677C", Offset = "0x185677C", VA = "0x185677C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600448F")]
		[Address(RVA = "0x1856780", Offset = "0x1856780", VA = "0x1856780", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004490")]
		[Address(RVA = "0x18568E4", Offset = "0x18568E4", VA = "0x18568E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004491")]
		[Address(RVA = "0x18568EC", Offset = "0x18568EC", VA = "0x18568EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004492")]
		[Address(RVA = "0x185692C", Offset = "0x185692C", VA = "0x185692C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EAF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45260", Offset = "0x45260")]
	private sealed class _003CEnd_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F4E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F4F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F50")]
		[FieldOffset(Offset = "0x20")]
		public SpecialTransitionEffect _003C_003E4__this;

		[Token(Token = "0x1700070F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x1856AC8", Offset = "0x1856AC8", VA = "0x1856AC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000710")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004498")]
			[Address(RVA = "0x1856B10", Offset = "0x1856B10", VA = "0x1856B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004493")]
		[Address(RVA = "0x1856934", Offset = "0x1856934", VA = "0x1856934")]
		[DebuggerHidden]
		public _003CEnd_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004494")]
		[Address(RVA = "0x1856960", Offset = "0x1856960", VA = "0x1856960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004495")]
		[Address(RVA = "0x1856964", Offset = "0x1856964", VA = "0x1856964", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004496")]
		[Address(RVA = "0x1856AC8", Offset = "0x1856AC8", VA = "0x1856AC8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004497")]
		[Address(RVA = "0x1856AD0", Offset = "0x1856AD0", VA = "0x1856AD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004498")]
		[Address(RVA = "0x1856B10", Offset = "0x1856B10", VA = "0x1856B10", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004F41")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator landscapeAnim;

	[Token(Token = "0x4004F42")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator portraitAnim;

	[Token(Token = "0x4004F43")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Renderer> landscapeRenders;

	[Token(Token = "0x4004F44")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Renderer> portraitRenders;

	[Token(Token = "0x4004F45")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ClipSettingsCollection transitionInClips;

	[Token(Token = "0x4004F46")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection transitionOutClips;

	[Token(Token = "0x4004F47")]
	[FieldOffset(Offset = "0x48")]
	private string transitionIn;

	[Token(Token = "0x4004F48")]
	[FieldOffset(Offset = "0x50")]
	private string prepareIn;

	[Token(Token = "0x4004F49")]
	[FieldOffset(Offset = "0x58")]
	private string prepareOut;

	[Token(Token = "0x4004F4A")]
	[FieldOffset(Offset = "0x60")]
	private Sprite specialDaySpriteSilhouette;

	[Token(Token = "0x1700070A")]
	private List<Renderer> currentRenderers
	{
		[Token(Token = "0x6004482")]
		[Address(RVA = "0x16CC300", Offset = "0x16CC300", VA = "0x16CC300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070B")]
	private Animator anim
	{
		[Token(Token = "0x6004483")]
		[Address(RVA = "0x16CC408", Offset = "0x16CC408", VA = "0x16CC408")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070C")]
	private bool usePortrait
	{
		[Token(Token = "0x6004484")]
		[Address(RVA = "0x16CC394", Offset = "0x16CC394", VA = "0x16CC394")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6004485")]
	[Address(RVA = "0x16CC49C", Offset = "0x16CC49C", VA = "0x16CC49C")]
	public void SetSpriteToUse(Sprite sprite)
	{
	}

	[Token(Token = "0x6004486")]
	[Address(RVA = "0x16CC4A4", Offset = "0x16CC4A4", VA = "0x16CC4A4", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6004487")]
	[Address(RVA = "0x16CC6F8", Offset = "0x16CC6F8", VA = "0x16CC6F8", Slot = "7")]
	public override void PreBegin(Color? color)
	{
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0x16CCA58", Offset = "0x16CCA58", VA = "0x16CCA58", Slot = "4")]
	public override IEnumerator Begin()
	{
		return null;
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0x16CCACC", Offset = "0x16CCACC", VA = "0x16CCACC", Slot = "8")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0x16CCD08", Offset = "0x16CCD08", VA = "0x16CCD08", Slot = "5")]
	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x600448B")]
	[Address(RVA = "0x16CCD7C", Offset = "0x16CCD7C", VA = "0x16CCD7C", Slot = "9")]
	public override void InstantTransitionCover(Color? color)
	{
	}

	[Token(Token = "0x600448C")]
	[Address(RVA = "0x16CD03C", Offset = "0x16CD03C", VA = "0x16CD03C")]
	public SpecialTransitionEffect()
	{
	}
}
