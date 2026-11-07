using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000509")]
public class Onboarding : MonoBehaviour
{
	[Token(Token = "0x200050A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400DC", Offset = "0x400DC")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4001A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelData> onboardingLevels;

		[Token(Token = "0x4001A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool aborted;

		[Token(Token = "0x4001A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6001717")]
		[Address(RVA = "0x180B068", Offset = "0x180B068", VA = "0x180B068")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001718")]
		[Address(RVA = "0x180B070", Offset = "0x180B070", VA = "0x180B070")]
		internal void _003CPlayOnboardingLevels_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200050B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400EC", Offset = "0x400EC")]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		[Token(Token = "0x4001A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4001A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001719")]
		[Address(RVA = "0x180B07C", Offset = "0x180B07C", VA = "0x180B07C")]
		public _003C_003Ec__DisplayClass16_1()
		{
		}
	}

	[Token(Token = "0x200050C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400FC", Offset = "0x400FC")]
	private sealed class _003C_003Ec__DisplayClass16_2
	{
		[Token(Token = "0x4001A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LevelData level;

		[Token(Token = "0x4001A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x600171A")]
		[Address(RVA = "0x180B084", Offset = "0x180B084", VA = "0x180B084")]
		public _003C_003Ec__DisplayClass16_2()
		{
		}

		[Token(Token = "0x600171B")]
		[Address(RVA = "0x180B08C", Offset = "0x180B08C", VA = "0x180B08C")]
		internal void _003CPlayOnboardingLevels_003Eb__0(Level.CompletedState s)
		{
		}
	}

	[Token(Token = "0x200050D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4010C", Offset = "0x4010C")]
	private sealed class _003CPlayOnboardingLevels_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Onboarding _003C_003E4__this;

		[Token(Token = "0x4001A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allowMenuButtons;

		[Token(Token = "0x4001A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x4001A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass16_1 _003C_003E8__2;

		[Token(Token = "0x4001A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<bool> onTransitionCoverAfter;

		[Token(Token = "0x4001A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private _003C_003Ec__DisplayClass16_2 _003C_003E8__3;

		[Token(Token = "0x4001A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action onAbortAction;

		[Token(Token = "0x4001A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LevelManager _003ClevelManager_003E5__2;

		[Token(Token = "0x4001A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _003CisSecondOnboarding_003E5__3;

		[Token(Token = "0x17000289")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x180B8D8", Offset = "0x180B8D8", VA = "0x180B8D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700028A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x180B920", Offset = "0x180B920", VA = "0x180B920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600171C")]
		[Address(RVA = "0x180B12C", Offset = "0x180B12C", VA = "0x180B12C")]
		[DebuggerHidden]
		public _003CPlayOnboardingLevels_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600171D")]
		[Address(RVA = "0x180B158", Offset = "0x180B158", VA = "0x180B158", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600171E")]
		[Address(RVA = "0x180B15C", Offset = "0x180B15C", VA = "0x180B15C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600171F")]
		[Address(RVA = "0x180B8D8", Offset = "0x180B8D8", VA = "0x180B8D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x180B8E0", Offset = "0x180B8E0", VA = "0x180B8E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001721")]
		[Address(RVA = "0x180B920", Offset = "0x180B920", VA = "0x180B920", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D9C4", Offset = "0x4D9C4")]
	private Action<float, int> m_OnOnboardingProgressChanged;

	[Token(Token = "0x4001A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D9D4", Offset = "0x4D9D4")]
	private Action<LevelData> m_OnOnboardingLevelChanged;

	[Token(Token = "0x4001A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D9E4", Offset = "0x4D9E4")]
	private Action m_OnReadyForMusic;

	[Token(Token = "0x4001A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D9F4", Offset = "0x4D9F4")]
	private Action m_OnOnboardingCompleted;

	[Token(Token = "0x4001A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ContentPack pack;

	[Token(Token = "0x4001A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ECampaignType CampaignType;

	[Token(Token = "0x4001A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool RandomizeSecondOnboarding;

	[Token(Token = "0x14000021")]
	public event Action<float, int> OnOnboardingProgressChanged
	{
		[Token(Token = "0x600170A")]
		[Address(RVA = "0x159ADB4", Offset = "0x159ADB4", VA = "0x159ADB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A58", Offset = "0x62A58")]
		add
		{
		}
		[Token(Token = "0x600170B")]
		[Address(RVA = "0x159AE58", Offset = "0x159AE58", VA = "0x159AE58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A68", Offset = "0x62A68")]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	public event Action<LevelData> OnOnboardingLevelChanged
	{
		[Token(Token = "0x600170C")]
		[Address(RVA = "0x159AEFC", Offset = "0x159AEFC", VA = "0x159AEFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A78", Offset = "0x62A78")]
		add
		{
		}
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x159AFA0", Offset = "0x159AFA0", VA = "0x159AFA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A88", Offset = "0x62A88")]
		remove
		{
		}
	}

	[Token(Token = "0x14000023")]
	public event Action OnReadyForMusic
	{
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x159B044", Offset = "0x159B044", VA = "0x159B044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A98", Offset = "0x62A98")]
		add
		{
		}
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x159B0E8", Offset = "0x159B0E8", VA = "0x159B0E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AA8", Offset = "0x62AA8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000024")]
	public event Action OnOnboardingCompleted
	{
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x159B18C", Offset = "0x159B18C", VA = "0x159B18C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AB8", Offset = "0x62AB8")]
		add
		{
		}
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x159B230", Offset = "0x159B230", VA = "0x159B230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AC8", Offset = "0x62AC8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001712")]
	[Address(RVA = "0x159B2D4", Offset = "0x159B2D4", VA = "0x159B2D4")]
	public void StartOnBoarding(ContentPack pack, bool allowMenuButtons, [Optional] Action onAbortAction, [Optional] Action<bool> onTransitionCoverAfter)
	{
	}

	[Token(Token = "0x6001713")]
	[Address(RVA = "0x159B3FC", Offset = "0x159B3FC", VA = "0x159B3FC")]
	private IEnumerator PlayOnboardingLevels(bool allowMenuButtons, [Optional] Action onAbortAction, [Optional] Action<bool> onTransitionCoverAfter)
	{
		return null;
	}

	[Token(Token = "0x6001714")]
	[Address(RVA = "0x159B490", Offset = "0x159B490", VA = "0x159B490")]
	private List<LevelData> GetLevels(bool isSecondOnboarding)
	{
		return null;
	}

	[Token(Token = "0x6001715")]
	[Address(RVA = "0x159B700", Offset = "0x159B700", VA = "0x159B700")]
	private List<LevelData> GetRandomList(int numberOfElements, List<LevelData> list)
	{
		return null;
	}

	[Token(Token = "0x6001716")]
	[Address(RVA = "0x159B7A0", Offset = "0x159B7A0", VA = "0x159B7A0")]
	public Onboarding()
	{
	}
}
