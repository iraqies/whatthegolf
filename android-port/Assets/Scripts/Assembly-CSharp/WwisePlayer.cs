using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D49")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x44840", Offset = "0x44840")]
public class WwisePlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D4A")]
	public class PreloadData
	{
		[Token(Token = "0x400485A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicState state;

		[Token(Token = "0x400485B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicTransition transition;

		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x187D500", Offset = "0x187D500", VA = "0x187D500")]
		public PreloadData()
		{
		}
	}

	[Token(Token = "0x2000D4B")]
	public enum MusicTime
	{
		[Token(Token = "0x400485D")]
		beat = 0,
		[Token(Token = "0x400485E")]
		bar = 1,
		[Token(Token = "0x400485F")]
		exitcue = 2
	}

	[Token(Token = "0x2000D4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448A8", Offset = "0x448A8")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4004860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int loadCount;

		[Token(Token = "0x4004861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__0;

		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x187C3E0", Offset = "0x187C3E0", VA = "0x187C3E0")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x187C3E8", Offset = "0x187C3E8", VA = "0x187C3E8")]
		internal void _003CPreload_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000D4D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448B8", Offset = "0x448B8")]
	private sealed class _003CPreload_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WwisePlayer _003C_003E4__this;

		[Token(Token = "0x4004865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		[Token(Token = "0x4004866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action OnPreloadDone;

		[Token(Token = "0x4004867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<PreloadData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x4004868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PreloadData _003Cdata_003E5__3;

		[Token(Token = "0x17000663")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003EAE")]
			[Address(RVA = "0x187D4B0", Offset = "0x187D4B0", VA = "0x187D4B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000664")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003EB0")]
			[Address(RVA = "0x187D4F8", Offset = "0x187D4F8", VA = "0x187D4F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x187CFF0", Offset = "0x187CFF0", VA = "0x187CFF0")]
		[DebuggerHidden]
		public _003CPreload_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x187D01C", Offset = "0x187D01C", VA = "0x187D01C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x187D0F0", Offset = "0x187D0F0", VA = "0x187D0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x187D094", Offset = "0x187D094", VA = "0x187D094")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x187D4B0", Offset = "0x187D4B0", VA = "0x187D4B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x187D4B8", Offset = "0x187D4B8", VA = "0x187D4B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x187D4F8", Offset = "0x187D4F8", VA = "0x187D4F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D4E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448C8", Offset = "0x448C8")]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x4004869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double transitionExitCue;

		[Token(Token = "0x400486A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double transitionEntryCue;

		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x187C3F8", Offset = "0x187C3F8", VA = "0x187C3F8")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x187C400", Offset = "0x187C400", VA = "0x187C400")]
		internal void _003CChangeStateRoutine_003Eb__0(double start, double end)
		{
		}
	}

	[Token(Token = "0x2000D4F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448D8", Offset = "0x448D8")]
	private sealed class _003CChangeStateRoutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400486B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400486C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400486D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WwisePlayer _003C_003E4__this;

		[Token(Token = "0x400486E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		[Token(Token = "0x400486F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSecondsRealtime _003CwaitZeroPointOneSecond_003E5__2;

		[Token(Token = "0x4004870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MusicState _003Cstate_003E5__3;

		[Token(Token = "0x4004871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MusicTransition _003CcurrentTransition_003E5__4;

		[Token(Token = "0x4004872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _003CstartLoadTime_003E5__5;

		[Token(Token = "0x4004873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double _003ClastEntryCue_003E5__6;

		[Token(Token = "0x4004874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MusicTransition.DestinationSyncTo _003Cpreset_003E5__7;

		[Token(Token = "0x4004875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private double _003CfadeOutTime_003E5__8;

		[Token(Token = "0x4004876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private double _003CexitStartOffsetForFade_003E5__9;

		[Token(Token = "0x4004877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _003CmaxWaitForTransitionToLoad_003E5__10;

		[Token(Token = "0x17000665")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003EB6")]
			[Address(RVA = "0x187CFA0", Offset = "0x187CFA0", VA = "0x187CFA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000666")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003EB8")]
			[Address(RVA = "0x187CFE8", Offset = "0x187CFE8", VA = "0x187CFE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x187C5C8", Offset = "0x187C5C8", VA = "0x187C5C8")]
		[DebuggerHidden]
		public _003CChangeStateRoutine_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x187C5F4", Offset = "0x187C5F4", VA = "0x187C5F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x187C5F8", Offset = "0x187C5F8", VA = "0x187C5F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x187CFA0", Offset = "0x187CFA0", VA = "0x187CFA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x187CFA8", Offset = "0x187CFA8", VA = "0x187CFA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x187CFE8", Offset = "0x187CFE8", VA = "0x187CFE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x448E8", Offset = "0x448E8")]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		[Token(Token = "0x4004878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicPlaylist source;

		[Token(Token = "0x4004879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicPlaylist destination;

		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x187C408", Offset = "0x187C408", VA = "0x187C408")]
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6003EBA")]
		[Address(RVA = "0x187C410", Offset = "0x187C410", VA = "0x187C410")]
		internal bool _003CGetTransitionFromPlaylists_003Eb__0(MusicTransition t)
		{
			return default;
		}

		[Token(Token = "0x6003EBB")]
		[Address(RVA = "0x187C4EC", Offset = "0x187C4EC", VA = "0x187C4EC")]
		internal bool _003CGetTransitionFromPlaylists_003Eb__1(MusicTransition t)
		{
			return default;
		}
	}

	[Token(Token = "0x4004846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isVerbose;

	[Token(Token = "0x4004847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MusicState currentState;

	[Token(Token = "0x4004848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MusicPlaylist currentPlaylist;

	[Token(Token = "0x4004849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MusicPlaylist nextPlayList;

	[Token(Token = "0x400484A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MusicTransition currentTransition;

	[Token(Token = "0x400484B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip offTheMapShort;

	[Token(Token = "0x400484C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip offTheMapLong;

	[Token(Token = "0x400484D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isInTransition;

	[Token(Token = "0x400484E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Wwise wwise;

	[Token(Token = "0x400484F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private double minBufferTime;

	[Token(Token = "0x4004850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isDebugStart;

	[Token(Token = "0x4004851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static WwisePlayer Instance;

	[Token(Token = "0x4004852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public WwiseClipLoader clipLoader;

	[Token(Token = "0x4004853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool isChangingState;

	[Token(Token = "0x4004854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool isNextStateFromLoading;

	[Token(Token = "0x4004855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MusicTransition nextTransition;

	[Token(Token = "0x4004856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<PreloadData> preloadMusicData;

	[Token(Token = "0x4004857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float lastOffTheMapTrigger;

	[Token(Token = "0x4004858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private MusicState queuedState;

	[Token(Token = "0x4004859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public MusicTransition ignoreTransitionFadeTransition;

	[Token(Token = "0x6003E97")]
	[Address(RVA = "0x175FE34", Offset = "0x175FE34", VA = "0x175FE34")]
	public void PostTrigger(uint triggerID)
	{
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x175FFC0", Offset = "0x175FFC0", VA = "0x175FFC0")]
	public void Init(bool startsWithOnboarding, Action OnPreloadDone)
	{
	}

	[Token(Token = "0x6003E99")]
	[Address(RVA = "0x1760150", Offset = "0x1760150", VA = "0x1760150")]
	private IEnumerator Preload(bool startsWithOnboarding, Action OnPreloadDone)
	{
		return null;
	}

	[Token(Token = "0x6003E9A")]
	[Address(RVA = "0x1760240", Offset = "0x1760240", VA = "0x1760240")]
	private void Log(string message)
	{
	}

	[Token(Token = "0x6003E9B")]
	[Address(RVA = "0x17602E4", Offset = "0x17602E4", VA = "0x17602E4")]
	public double GetFutureTime(MusicTime time)
	{
		return default;
	}

	[Token(Token = "0x6003E9C")]
	[Address(RVA = "0x1760460", Offset = "0x1760460", VA = "0x1760460")]
	private double GetNextPossibleDSPTime(double offset = 0.0)
	{
		return default;
	}

	[Token(Token = "0x6003E9D")]
	[Address(RVA = "0x17604B4", Offset = "0x17604B4", VA = "0x17604B4")]
	public void SetState(uint wwiseState, bool fromLoading, [Optional] Action onLoaded, bool ignoreTransition = false)
	{
	}

	[Token(Token = "0x6003E9E")]
	[Address(RVA = "0x176085C", Offset = "0x176085C", VA = "0x176085C")]
	public void SetRTPC(uint rtpc, float value)
	{
	}

	[Token(Token = "0x6003E9F")]
	[Address(RVA = "0x17609DC", Offset = "0x17609DC", VA = "0x17609DC")]
	public void SetRTPC(uint rtpc, float value, int timeMS)
	{
	}

	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0x1760B64", Offset = "0x1760B64", VA = "0x1760B64")]
	public float GetRTPC(uint rtcp)
	{
		return default;
	}

	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0x1760D10", Offset = "0x1760D10", VA = "0x1760D10")]
	public void ResetRTPC(uint rtpc, int timeInMs)
	{
	}

	[Token(Token = "0x6003EA2")]
	[Address(RVA = "0x1760E8C", Offset = "0x1760E8C", VA = "0x1760E8C")]
	private void PlayTransition(double entryCue, MusicTransition transition, Action<double, double> OnSetNext)
	{
	}

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x17606DC", Offset = "0x17606DC", VA = "0x17606DC")]
	private void State_OnPlay(MusicState state, bool fromLoading, Action onLoaded, bool ignoreTransition)
	{
	}

	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0x17601CC", Offset = "0x17601CC", VA = "0x17601CC")]
	private IEnumerator ChangeStateRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003EA5")]
	[Address(RVA = "0x1760F40", Offset = "0x1760F40", VA = "0x1760F40")]
	private MusicTransition GetTransitionFromPlaylists(MusicPlaylist source, MusicPlaylist destination, bool ignoreTransition)
	{
		return null;
	}

	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0x17610F0", Offset = "0x17610F0", VA = "0x17610F0")]
	public WwisePlayer()
	{
	}
}
