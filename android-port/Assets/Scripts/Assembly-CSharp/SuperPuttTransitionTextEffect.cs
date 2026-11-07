using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000843")]
public class SuperPuttTransitionTextEffect : TransitionTextEffect
{
	[Serializable]
	[Token(Token = "0x2000844")]
	public class SuperPuttEffect
	{
		[Token(Token = "0x4002CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Text;

		[Token(Token = "0x4002CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Duration;

		[Token(Token = "0x4002CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<AudioClip> Clip;

		[Token(Token = "0x4002CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Volume;

		[Token(Token = "0x6002625")]
		[Address(RVA = "0x185F1C0", Offset = "0x185F1C0", VA = "0x185F1C0")]
		public SuperPuttEffect()
		{
		}
	}

	[Token(Token = "0x2000845")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41968", Offset = "0x41968")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4002CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SuperPuttEffect message1;

		[Token(Token = "0x6002626")]
		[Address(RVA = "0x185EB10", Offset = "0x185EB10", VA = "0x185EB10")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6002627")]
		[Address(RVA = "0x185EB18", Offset = "0x185EB18", VA = "0x185EB18")]
		internal void _003CShow_003Eb__0(AudioSource t)
		{
		}
	}

	[Token(Token = "0x2000846")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41978", Offset = "0x41978")]
	private sealed class _003CShow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SuperPuttTransitionTextEffect _003C_003E4__this;

		[Token(Token = "0x4002CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Cloops_003E5__2;

		[Token(Token = "0x4002CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<SuperPuttEffect>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x1700041F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600262C")]
			[Address(RVA = "0x185F170", Offset = "0x185F170", VA = "0x185F170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000420")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x185F1B8", Offset = "0x185F1B8", VA = "0x185F1B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002628")]
		[Address(RVA = "0x185EC58", Offset = "0x185EC58", VA = "0x185EC58")]
		[DebuggerHidden]
		public _003CShow_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002629")]
		[Address(RVA = "0x185EC84", Offset = "0x185EC84", VA = "0x185EC84", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600262A")]
		[Address(RVA = "0x185ED58", Offset = "0x185ED58", VA = "0x185ED58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600262B")]
		[Address(RVA = "0x185ECFC", Offset = "0x185ECFC", VA = "0x185ECFC")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x600262C")]
		[Address(RVA = "0x185F170", Offset = "0x185F170", VA = "0x185F170", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600262D")]
		[Address(RVA = "0x185F178", Offset = "0x185F178", VA = "0x185F178", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600262E")]
		[Address(RVA = "0x185F1B8", Offset = "0x185F1B8", VA = "0x185F1B8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000847")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41988", Offset = "0x41988")]
	private sealed class _003CHide_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SuperPuttTransitionTextEffect _003C_003E4__this;

		[Token(Token = "0x17000421")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002632")]
			[Address(RVA = "0x185EC08", Offset = "0x185EC08", VA = "0x185EC08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000422")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002634")]
			[Address(RVA = "0x185EC50", Offset = "0x185EC50", VA = "0x185EC50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600262F")]
		[Address(RVA = "0x185EB44", Offset = "0x185EB44", VA = "0x185EB44")]
		[DebuggerHidden]
		public _003CHide_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002630")]
		[Address(RVA = "0x185EB70", Offset = "0x185EB70", VA = "0x185EB70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002631")]
		[Address(RVA = "0x185EB74", Offset = "0x185EB74", VA = "0x185EB74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002632")]
		[Address(RVA = "0x185EC08", Offset = "0x185EC08", VA = "0x185EC08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002633")]
		[Address(RVA = "0x185EC10", Offset = "0x185EC10", VA = "0x185EC10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002634")]
		[Address(RVA = "0x185EC50", Offset = "0x185EC50", VA = "0x185EC50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SuperPuttEffect> Messages;

	[Token(Token = "0x4002CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI Text;

	[Token(Token = "0x4002CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool TestSequence;

	[Token(Token = "0x4002CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool isBusy;

	[Token(Token = "0x4002CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CanvasScaler canvasScaler;

	[Token(Token = "0x4002CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform rootTransform;

	[Token(Token = "0x4002CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int repeats;

	[Token(Token = "0x1700041E")]
	public override bool IsBusy
	{
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x16EF0C0", Offset = "0x16EF0C0", VA = "0x16EF0C0", Slot = "7")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600261E")]
	[Address(RVA = "0x16EEE94", Offset = "0x16EEE94", VA = "0x16EEE94")]
	private void Awake()
	{
	}

	[Token(Token = "0x600261F")]
	[Address(RVA = "0x16EEFD0", Offset = "0x16EEFD0", VA = "0x16EEFD0", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002620")]
	[Address(RVA = "0x16EEFD4", Offset = "0x16EEFD4", VA = "0x16EEFD4", Slot = "5")]
	public override void Prepare([Optional] string text, bool onTheSide = false)
	{
	}

	[Token(Token = "0x6002621")]
	[Address(RVA = "0x16EF04C", Offset = "0x16EF04C", VA = "0x16EF04C", Slot = "6")]
	public override IEnumerator Show(float transitionInDuration)
	{
		return null;
	}

	[Token(Token = "0x6002623")]
	[Address(RVA = "0x16EF0C8", Offset = "0x16EF0C8", VA = "0x16EF0C8", Slot = "8")]
	public override IEnumerator Hide(float transitionOutDuration)
	{
		return null;
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0x16EF13C", Offset = "0x16EF13C", VA = "0x16EF13C")]
	public SuperPuttTransitionTextEffect()
	{
	}
}
