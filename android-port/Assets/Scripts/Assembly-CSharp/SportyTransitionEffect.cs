using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002A7")]
public class SportyTransitionEffect : BaseTransitionEffect
{
	[Token(Token = "0x20002A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E984", Offset = "0x3E984")]
	private sealed class _003CBegin_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x20")]
		public SportyTransitionEffect _003C_003E4__this;

		[Token(Token = "0x1700017E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x1859960", Offset = "0x1859960", VA = "0x1859960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700017F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x18599A8", Offset = "0x18599A8", VA = "0x18599A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x18597CC", Offset = "0x18597CC", VA = "0x18597CC")]
		[DebuggerHidden]
		public _003CBegin_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x18597F8", Offset = "0x18597F8", VA = "0x18597F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x18597FC", Offset = "0x18597FC", VA = "0x18597FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x1859960", Offset = "0x1859960", VA = "0x1859960", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x1859968", Offset = "0x1859968", VA = "0x1859968", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x18599A8", Offset = "0x18599A8", VA = "0x18599A8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E994", Offset = "0x3E994")]
	private sealed class _003CEnd_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x20")]
		public SportyTransitionEffect _003C_003E4__this;

		[Token(Token = "0x17000180")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x1859B44", Offset = "0x1859B44", VA = "0x1859B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000181")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x1859B8C", Offset = "0x1859B8C", VA = "0x1859B8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x18599B0", Offset = "0x18599B0", VA = "0x18599B0")]
		[DebuggerHidden]
		public _003CEnd_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x18599DC", Offset = "0x18599DC", VA = "0x18599DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x18599E0", Offset = "0x18599E0", VA = "0x18599E0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x1859B44", Offset = "0x1859B44", VA = "0x1859B44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x1859B4C", Offset = "0x1859B4C", VA = "0x1859B4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x1859B8C", Offset = "0x1859B8C", VA = "0x1859B8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator landscapeAnim;

	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator portraitAnim;

	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Renderer> landscapeRenders;

	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Renderer> portraitRenders;

	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ClipSettingsCollection transitionInClips;

	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection transitionOutClips;

	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x48")]
	private string transitionIn;

	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x50")]
	private string prepareIn;

	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x58")]
	private string prepareOut;

	[Token(Token = "0x1700017B")]
	private List<Renderer> currentRenderers
	{
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x16D8048", Offset = "0x16D8048", VA = "0x16D8048")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700017C")]
	private Animator anim
	{
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x16D8150", Offset = "0x16D8150", VA = "0x16D8150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700017D")]
	private bool usePortrait
	{
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x16D80DC", Offset = "0x16D80DC", VA = "0x16D80DC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x16D81E4", Offset = "0x16D81E4", VA = "0x16D81E4", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x16D8438", Offset = "0x16D8438", VA = "0x16D8438", Slot = "7")]
	public override void PreBegin(Color? color)
	{
	}

	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x16D8748", Offset = "0x16D8748", VA = "0x16D8748", Slot = "4")]
	public override IEnumerator Begin()
	{
		return null;
	}

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x16D87BC", Offset = "0x16D87BC", VA = "0x16D87BC", Slot = "8")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x16D89F8", Offset = "0x16D89F8", VA = "0x16D89F8", Slot = "5")]
	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x16D8A6C", Offset = "0x16D8A6C", VA = "0x16D8A6C", Slot = "9")]
	public override void InstantTransitionCover(Color? color)
	{
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x16D8D2C", Offset = "0x16D8D2C", VA = "0x16D8D2C")]
	public SportyTransitionEffect()
	{
	}
}
