using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200008A")]
public class AASplashScreen : MonoBehaviour
{
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D648", Offset = "0x3D648")]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AASplashScreen _003C_003E4__this;

		[Token(Token = "0x17000062")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x17679E8", Offset = "0x17679E8", VA = "0x17679E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000063")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1767A30", Offset = "0x1767A30", VA = "0x1767A30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1767894", Offset = "0x1767894", VA = "0x1767894")]
		[DebuggerHidden]
		public _003CStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x17678C0", Offset = "0x17678C0", VA = "0x17678C0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x17678C4", Offset = "0x17678C4", VA = "0x17678C4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17679E8", Offset = "0x17679E8", VA = "0x17679E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17679F0", Offset = "0x17679F0", VA = "0x17679F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1767A30", Offset = "0x1767A30", VA = "0x1767A30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D658", Offset = "0x3D658")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool videoDone;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1767024", Offset = "0x1767024", VA = "0x1767024")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x176702C", Offset = "0x176702C", VA = "0x176702C")]
		internal void _003CShow_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D668", Offset = "0x3D668")]
	private sealed class _003CShow_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action OnCoveredBySplash;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action OnCompleted;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AASplashScreen _003C_003E4__this;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action OnCanShowGCBanner;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _003CsplashVideoPath_003E5__2;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _003Cc_003E5__4;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private VideoClipResult _003CvideoClipResult_003E5__5;

		[Token(Token = "0x17000064")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x17675C8", Offset = "0x17675C8", VA = "0x17675C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000065")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1767610", Offset = "0x1767610", VA = "0x1767610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1767038", Offset = "0x1767038", VA = "0x1767038")]
		[DebuggerHidden]
		public _003CShow_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1767064", Offset = "0x1767064", VA = "0x1767064", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1767068", Offset = "0x1767068", VA = "0x1767068", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17675C8", Offset = "0x17675C8", VA = "0x17675C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17675D0", Offset = "0x17675D0", VA = "0x17675D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1767610", Offset = "0x1767610", VA = "0x1767610", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D678", Offset = "0x3D678")]
	private sealed class _003CShowTribandLogoCR_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AASplashScreen _003C_003E4__this;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction onDone;

		[Token(Token = "0x17000066")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1767844", Offset = "0x1767844", VA = "0x1767844", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000067")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x176788C", Offset = "0x176788C", VA = "0x176788C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1767618", Offset = "0x1767618", VA = "0x1767618")]
		[DebuggerHidden]
		public _003CShowTribandLogoCR_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1767644", Offset = "0x1767644", VA = "0x1767644", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1767648", Offset = "0x1767648", VA = "0x1767648", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1767844", Offset = "0x1767844", VA = "0x1767844", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x176784C", Offset = "0x176784C", VA = "0x176784C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x176788C", Offset = "0x176788C", VA = "0x176788C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CanvasGroup logoCanvasGroup;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AAScreens splashScreens;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VideoContainer videoContainer;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Camera videoCamera;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SplashScreenAudioSource splashAudioSource;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool splashScreenExecuted;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool tribandLogoDone;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine tribandLogoCR;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Logo logo;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private IVideoPathProvider videoPathProvider;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1402E50", Offset = "0x1402E50", VA = "0x1402E50")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x5D99C", Offset = "0x5D99C")]
	private static void Init()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1402EB4", Offset = "0x1402EB4", VA = "0x1402EB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1402F20", Offset = "0x1402F20", VA = "0x1402F20")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1402F94", Offset = "0x1402F94", VA = "0x1402F94")]
	private bool shouldShowLogoScreen()
	{
		return default;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x14030D0", Offset = "0x14030D0", VA = "0x14030D0")]
	public IEnumerator Show([Optional] Action OnCoveredBySplash, [Optional] Action OnCompleted, [Optional] Action OnCanShowGCBanner)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1403160", Offset = "0x1403160", VA = "0x1403160")]
	private void StartLogoAnimation()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1403474", Offset = "0x1403474", VA = "0x1403474")]
	private void OnLogoAnimationEnd(bool skipped)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1403568", Offset = "0x1403568", VA = "0x1403568")]
	private bool CheckForButtonSkip()
	{
		return default;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x14033FC", Offset = "0x14033FC", VA = "0x14033FC")]
	private IEnumerator ShowTribandLogoCR(UnityAction onDone)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x140361C", Offset = "0x140361C", VA = "0x140361C")]
	public AASplashScreen()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1403628", Offset = "0x1403628", VA = "0x1403628")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D9B0", Offset = "0x5D9B0")]
	private void _003CStartLogoAnimation_003Eb__15_0()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1403630", Offset = "0x1403630", VA = "0x1403630")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D9C0", Offset = "0x5D9C0")]
	private void _003CShowTribandLogoCR_003Eb__18_0(float t)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1403654", Offset = "0x1403654", VA = "0x1403654")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D9D0", Offset = "0x5D9D0")]
	private void _003CShowTribandLogoCR_003Eb__18_1(float t)
	{
	}
}
