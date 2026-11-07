using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using Menu;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

[Token(Token = "0x20004CD")]
public class LevelManager : AddressableSingleton<LevelManager>
{
	[Token(Token = "0x20004CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE54", Offset = "0x3FE54")]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x4001923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Level level;

		[Token(Token = "0x4001924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x4001925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerConfiguration multiplayerConfiguration;

		[Token(Token = "0x4001926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelData levelData;

		[Token(Token = "0x4001927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<LevelData> onLevelLoaded;

		[Token(Token = "0x4001928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string challengeID;

		[Token(Token = "0x4001929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action _003C_003E9__0;

		[Token(Token = "0x400192A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6001635")]
		[Address(RVA = "0x17E6700", Offset = "0x17E6700", VA = "0x17E6700")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6001636")]
		[Address(RVA = "0x17E6708", Offset = "0x17E6708", VA = "0x17E6708")]
		internal void _003CPlay_003Eb__0()
		{
		}

		[Token(Token = "0x6001637")]
		[Address(RVA = "0x17E672C", Offset = "0x17E672C", VA = "0x17E672C")]
		internal void _003CPlay_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20004CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE64", Offset = "0x3FE64")]
	private sealed class _003C_003Ec__DisplayClass33_1
	{
		[Token(Token = "0x400192B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Level.State state;

		[Token(Token = "0x400192C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001638")]
		[Address(RVA = "0x17E6750", Offset = "0x17E6750", VA = "0x17E6750")]
		public _003C_003Ec__DisplayClass33_1()
		{
		}

		[Token(Token = "0x6001639")]
		[Address(RVA = "0x17E6758", Offset = "0x17E6758", VA = "0x17E6758")]
		internal void _003CPlay_003Eb__2(Level.State s)
		{
		}
	}

	[Token(Token = "0x20004D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE74", Offset = "0x3FE74")]
	private sealed class _003C_003Ec__DisplayClass33_2
	{
		[Token(Token = "0x400192D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int levels;

		[Token(Token = "0x400192E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass33_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x17E6760", Offset = "0x17E6760", VA = "0x17E6760")]
		public _003C_003Ec__DisplayClass33_2()
		{
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x17E6768", Offset = "0x17E6768", VA = "0x17E6768")]
		internal void _003CPlay_003Eb__3(Level newLevel)
		{
		}
	}

	[Token(Token = "0x20004D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE84", Offset = "0x3FE84")]
	private sealed class _003CPlay_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400192F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x4001932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerConfiguration multiplayerConfiguration;

		[Token(Token = "0x4001933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LevelData levelData;

		[Token(Token = "0x4001934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<LevelData> onLevelLoaded;

		[Token(Token = "0x4001935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string challengeID;

		[Token(Token = "0x4001936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool skipTransitionIn;

		[Token(Token = "0x4001937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool showStrokeCounter;

		[Token(Token = "0x4001938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public StrokeCounter.CounterTypes StrokeCounterType;

		[Token(Token = "0x4001939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

		[Token(Token = "0x400193A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int strokesFromPreviousLevels;

		[Token(Token = "0x400193B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action onTransitionCoverBefore;

		[Token(Token = "0x400193C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IEnumerator onTransitionBeforeCoroutine;

		[Token(Token = "0x400193D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool discardLoadedScenes;

		[Token(Token = "0x400193E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private _003C_003Ec__DisplayClass33_1 _003C_003E8__2;

		[Token(Token = "0x400193F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool disableExitButton;

		[Token(Token = "0x4001940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool disableRestartButton;

		[Token(Token = "0x4001941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Action<Level.CompletedState> onComplete;

		[Token(Token = "0x4001942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool alwaysReloadOnFail;

		[Token(Token = "0x4001943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action<Level.FailState> onFail;

		[Token(Token = "0x4001944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Func<bool> addStrokesOnFailToStrokesFromPreviousLevels;

		[Token(Token = "0x4001945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Action onAbort;

		[Token(Token = "0x4001946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool resetStrokesWhenFinished;

		[Token(Token = "0x4001947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool skipTransitionOut;

		[Token(Token = "0x4001948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Action<Level.RestartState> onRestart;

		[Token(Token = "0x4001949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public IEnumerator onTransitionAfterCoroutineIfComplete;

		[Token(Token = "0x400194A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool hideLevelCompletionText;

		[Token(Token = "0x400194B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Action<bool> onTransitionCoverAfter;

		[Token(Token = "0x400194C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool countStrokesAndTime;

		[Token(Token = "0x400194D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _003ConTheSide_003E5__2;

		[Token(Token = "0x400194E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ApplicationExitGameSaver _003CexitTimer_003E5__3;

		[Token(Token = "0x400194F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Color? _003CcustomTransitionColor_003E5__4;

		[Token(Token = "0x4001950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private BaseTransitionEffect _003CcustomTransitionEffect_003E5__5;

		[Token(Token = "0x4001951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool _003CleavingLevel_003E5__6;

		[Token(Token = "0x4001952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool _003CdoReload_003E5__7;

		[Token(Token = "0x4001953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool _003CshowTransition_003E5__8;

		[Token(Token = "0x1700026D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600163F")]
			[Address(RVA = "0x17E8134", Offset = "0x17E8134", VA = "0x17E8134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700026E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001641")]
			[Address(RVA = "0x17E817C", Offset = "0x17E817C", VA = "0x17E817C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x17E6E3C", Offset = "0x17E6E3C", VA = "0x17E6E3C")]
		[DebuggerHidden]
		public _003CPlay_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x17E6E68", Offset = "0x17E6E68", VA = "0x17E6E68", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600163E")]
		[Address(RVA = "0x17E6E6C", Offset = "0x17E6E6C", VA = "0x17E6E6C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600163F")]
		[Address(RVA = "0x17E8134", Offset = "0x17E8134", VA = "0x17E8134", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x17E813C", Offset = "0x17E813C", VA = "0x17E813C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x17E817C", Offset = "0x17E817C", VA = "0x17E817C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE94", Offset = "0x3FE94")]
	private sealed class _003CLoadLevel_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelData levelData;

		[Token(Token = "0x4001957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x4001958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool discardLoadedScenes;

		[Token(Token = "0x4001959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<Level> onComplete;

		[Token(Token = "0x1700026F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x17E6DEC", Offset = "0x17E6DEC", VA = "0x17E6DEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000270")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001647")]
			[Address(RVA = "0x17E6E34", Offset = "0x17E6E34", VA = "0x17E6E34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x17E69B4", Offset = "0x17E69B4", VA = "0x17E69B4")]
		[DebuggerHidden]
		public _003CLoadLevel_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001643")]
		[Address(RVA = "0x17E69E0", Offset = "0x17E69E0", VA = "0x17E69E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001644")]
		[Address(RVA = "0x17E69E4", Offset = "0x17E69E4", VA = "0x17E69E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001645")]
		[Address(RVA = "0x17E6DEC", Offset = "0x17E6DEC", VA = "0x17E6DEC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x17E6DF4", Offset = "0x17E6DF4", VA = "0x17E6DF4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x17E6E34", Offset = "0x17E6E34", VA = "0x17E6E34", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FEA4", Offset = "0x3FEA4")]
	private sealed class _003CUnloadLevel_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400195A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400195B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400195C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x17000271")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x17E8728", Offset = "0x17E8728", VA = "0x17E8728", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000272")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600164D")]
			[Address(RVA = "0x17E8770", Offset = "0x17E8770", VA = "0x17E8770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x17E8534", Offset = "0x17E8534", VA = "0x17E8534")]
		[DebuggerHidden]
		public _003CUnloadLevel_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x17E8560", Offset = "0x17E8560", VA = "0x17E8560", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x17E8564", Offset = "0x17E8564", VA = "0x17E8564", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600164B")]
		[Address(RVA = "0x17E8728", Offset = "0x17E8728", VA = "0x17E8728", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x17E8730", Offset = "0x17E8730", VA = "0x17E8730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x17E8770", Offset = "0x17E8770", VA = "0x17E8770", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FEB4", Offset = "0x3FEB4")]
	private sealed class _003CSwapTranstion_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400195D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400195E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400195F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x4001960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transition.TransitionEffect customTransitionEffectIndex;

		[Token(Token = "0x4001961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color? color;

		[Token(Token = "0x4001962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string textId;

		[Token(Token = "0x4001963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool showWaitAnimation;

		[Token(Token = "0x4001964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool isAsync;

		[Token(Token = "0x4001965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool showWaitingText;

		[Token(Token = "0x17000273")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001651")]
			[Address(RVA = "0x17E84E4", Offset = "0x17E84E4", VA = "0x17E84E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000274")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001653")]
			[Address(RVA = "0x17E852C", Offset = "0x17E852C", VA = "0x17E852C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600164E")]
		[Address(RVA = "0x17E8380", Offset = "0x17E8380", VA = "0x17E8380")]
		[DebuggerHidden]
		public _003CSwapTranstion_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600164F")]
		[Address(RVA = "0x17E83AC", Offset = "0x17E83AC", VA = "0x17E83AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001650")]
		[Address(RVA = "0x17E83B0", Offset = "0x17E83B0", VA = "0x17E83B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x17E84E4", Offset = "0x17E84E4", VA = "0x17E84E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x17E84EC", Offset = "0x17E84EC", VA = "0x17E84EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001653")]
		[Address(RVA = "0x17E852C", Offset = "0x17E852C", VA = "0x17E852C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FEC4", Offset = "0x3FEC4")]
	private sealed class _003CStartTransition_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BaseTransitionEffect customTransitionEffect;

		[Token(Token = "0x4001969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x400196A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transition.TransitionEffect customTransitionEffectIndex;

		[Token(Token = "0x400196B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color? color;

		[Token(Token = "0x400196C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textId;

		[Token(Token = "0x400196D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool showWaitAnimation;

		[Token(Token = "0x400196E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isAsync;

		[Token(Token = "0x400196F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool showWaitingText;

		[Token(Token = "0x17000275")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x17E8330", Offset = "0x17E8330", VA = "0x17E8330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000276")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001659")]
			[Address(RVA = "0x17E8378", Offset = "0x17E8378", VA = "0x17E8378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001654")]
		[Address(RVA = "0x17E8184", Offset = "0x17E8184", VA = "0x17E8184")]
		[DebuggerHidden]
		public _003CStartTransition_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001655")]
		[Address(RVA = "0x17E81B0", Offset = "0x17E81B0", VA = "0x17E81B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001656")]
		[Address(RVA = "0x17E81B4", Offset = "0x17E81B4", VA = "0x17E81B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001657")]
		[Address(RVA = "0x17E8330", Offset = "0x17E8330", VA = "0x17E8330", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0x17E8338", Offset = "0x17E8338", VA = "0x17E8338", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001659")]
		[Address(RVA = "0x17E8378", Offset = "0x17E8378", VA = "0x17E8378", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FED4", Offset = "0x3FED4")]
	private sealed class _003CEndTransition_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelManager _003C_003E4__this;

		[Token(Token = "0x4001973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool force;

		[Token(Token = "0x4001974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float overrideTransitionDuration;

		[Token(Token = "0x17000277")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x17E6964", Offset = "0x17E6964", VA = "0x17E6964", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000278")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600165F")]
			[Address(RVA = "0x17E69AC", Offset = "0x17E69AC", VA = "0x17E69AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600165A")]
		[Address(RVA = "0x17E689C", Offset = "0x17E689C", VA = "0x17E689C")]
		[DebuggerHidden]
		public _003CEndTransition_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600165B")]
		[Address(RVA = "0x17E68C8", Offset = "0x17E68C8", VA = "0x17E68C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600165C")]
		[Address(RVA = "0x17E68CC", Offset = "0x17E68CC", VA = "0x17E68CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600165D")]
		[Address(RVA = "0x17E6964", Offset = "0x17E6964", VA = "0x17E6964", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600165E")]
		[Address(RVA = "0x17E696C", Offset = "0x17E696C", VA = "0x17E696C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600165F")]
		[Address(RVA = "0x17E69AC", Offset = "0x17E69AC", VA = "0x17E69AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400190D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InGameMenu inGameMenu;

	[Token(Token = "0x400190E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transition transition;

	[Token(Token = "0x400190F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LevelData missingLevel;

	[Token(Token = "0x4001910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AntialisingQualityAdjuster antialisingQualityAdjuster;

	[Token(Token = "0x4001911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public SwitchUndockMessage undocking;

	[Token(Token = "0x4001912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action ReturnToOverworld;

	[Token(Token = "0x4001913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D888", Offset = "0x4D888")]
	private Action m_OnLevelWillUnload;

	[Token(Token = "0x4001914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D898", Offset = "0x4D898")]
	private Action<LevelData> m_OnLevelLoaded;

	[Token(Token = "0x4001915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D8A8", Offset = "0x4D8A8")]
	private Action m_OnLevelComplete;

	[Token(Token = "0x4001916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D8B8", Offset = "0x4D8B8")]
	private Action<string> m_ChallengeSelected;

	[Token(Token = "0x4001917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool hasLoadedAnyLevel;

	[Token(Token = "0x4001918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GarbageCollectorManager garbageManager;

	[Token(Token = "0x4001919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool wasLastPlayedLevelOnTheSide;

	[Token(Token = "0x400191A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private LevelData currentLevel;

	[Token(Token = "0x400191B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isReallyInLevel;

	[Token(Token = "0x400191C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static object _lock;

	[Token(Token = "0x400191D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool applicationIsQuitting;

	[Token(Token = "0x400191E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool goToLevelOnLoad;

	[Token(Token = "0x400191F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int textIndex;

	[Token(Token = "0x4001920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string[] texts;

	[Token(Token = "0x4001921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float time;

	[Token(Token = "0x4001922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AsyncOperationHandle<SceneInstance> addressableLoadHandle;

	[Token(Token = "0x17000269")]
	public bool getIsReallyInLevel
	{
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x152E184", Offset = "0x152E184", VA = "0x152E184")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700026A")]
	public bool HasLoadedAnyLevel
	{
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x152F200", Offset = "0x152F200", VA = "0x152F200")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700026B")]
	public InGameMenu InGameMenu
	{
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x152F208", Offset = "0x152F208", VA = "0x152F208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026C")]
	public TransitionTextEffects TransitionTextEffects
	{
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x152542C", Offset = "0x152542C", VA = "0x152542C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400001C")]
	public event Action OnLevelWillUnload
	{
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x152DDAC", Offset = "0x152DDAC", VA = "0x152DDAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6257C", Offset = "0x6257C")]
		add
		{
		}
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x152DE50", Offset = "0x152DE50", VA = "0x152DE50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6258C", Offset = "0x6258C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event Action<LevelData> OnLevelLoaded
	{
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x152DEF4", Offset = "0x152DEF4", VA = "0x152DEF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6259C", Offset = "0x6259C")]
		add
		{
		}
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x152DF98", Offset = "0x152DF98", VA = "0x152DF98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625AC", Offset = "0x625AC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public event Action OnLevelComplete
	{
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x152E03C", Offset = "0x152E03C", VA = "0x152E03C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625BC", Offset = "0x625BC")]
		add
		{
		}
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x152E0E0", Offset = "0x152E0E0", VA = "0x152E0E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625CC", Offset = "0x625CC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001F")]
	public event Action<string> ChallengeSelected
	{
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x15257E8", Offset = "0x15257E8", VA = "0x15257E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625DC", Offset = "0x625DC")]
		add
		{
		}
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x1525A10", Offset = "0x1525A10", VA = "0x1525A10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625EC", Offset = "0x625EC")]
		remove
		{
		}
	}

	[Token(Token = "0x600161A")]
	[Address(RVA = "0x152E18C", Offset = "0x152E18C", VA = "0x152E18C", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600161B")]
	[Address(RVA = "0x152E2F0", Offset = "0x152E2F0", VA = "0x152E2F0")]
	private void HandleSteamOverlayActivated(bool active)
	{
	}

	[Token(Token = "0x600161C")]
	[Address(RVA = "0x152E62C", Offset = "0x152E62C", VA = "0x152E62C")]
	public IEnumerator Play(LevelData levelData, [Optional] Action onTransitionCoverBefore, [Optional] IEnumerator onTransitionBeforeCoroutine, [Optional] IEnumerator onTransitionAfterCoroutineIfComplete, [Optional] Action<LevelData> onLevelLoaded, [Optional] Action<Level.CompletedState> onComplete, [Optional] Action<Level.FailState> onFail, [Optional] Action<Level.RestartState> onRestart, [Optional] Action onAbort, [Optional] Action<bool> onTransitionCoverAfter, [Optional][DefaultParameterValue(false)] bool discardLoadedScenes, [Optional][DefaultParameterValue(true)] bool countStrokesAndTime, [Optional][DefaultParameterValue(false)] bool skipTransitionIn, [Optional][DefaultParameterValue(false)] bool skipTransitionOut, [Optional][DefaultParameterValue(0)] int strokesFromPreviousLevels, [Optional][DefaultParameterValue(true)] bool resetStrokesWhenFinished, [Optional][DefaultParameterValue(false)] bool disableRestartButton, [Optional][DefaultParameterValue(false)] bool disableExitButton, [Optional][DefaultParameterValue(false)] bool showStrokeCounter, [Optional] string challengeID, [Optional][DefaultParameterValue(false)] bool alwaysReloadOnFail, [Optional] Func<bool> addStrokesOnFailToStrokesFromPreviousLevels, [Optional][DefaultParameterValue(false)] bool hideLevelCompletionText, [Optional] MultiplayerConfiguration multiplayerConfiguration, StrokeCounter.CounterTypes StrokeCounterType = StrokeCounter.CounterTypes.CardsAppearing)
	{
		return null;
	}

	[Token(Token = "0x600161D")]
	[Address(RVA = "0x152E768", Offset = "0x152E768", VA = "0x152E768")]
	internal void SetDailyTransitionEffect(TransitionColorDefinition transitionColors)
	{
	}

	[Token(Token = "0x600161E")]
	[Address(RVA = "0x152E80C", Offset = "0x152E80C", VA = "0x152E80C")]
	internal void SetSpecialDayTransitionEffect(DailyChallengeLevelDataContainer pack, out BaseTransitionEffect customTransitionEffect)
	{
	}

	[Token(Token = "0x600161F")]
	[Address(RVA = "0x152EAB4", Offset = "0x152EAB4", VA = "0x152EAB4")]
	private void OnAbandon(Level level)
	{
	}

	[Token(Token = "0x6001620")]
	[Address(RVA = "0x152EB4C", Offset = "0x152EB4C", VA = "0x152EB4C")]
	private void OnRestart(Level level)
	{
	}

	[Token(Token = "0x6001621")]
	[Address(RVA = "0x152EBE4", Offset = "0x152EBE4", VA = "0x152EBE4")]
	public bool IsInLevel()
	{
		return default;
	}

	[Token(Token = "0x6001622")]
	[Address(RVA = "0x152EC60", Offset = "0x152EC60", VA = "0x152EC60")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6001623")]
	[Address(RVA = "0x152EC68", Offset = "0x152EC68", VA = "0x152EC68")]
	private IEnumerator LoadLevel(LevelData levelData, bool discardLoadedScenes, Action<Level> onComplete, [Optional] MultiplayerConfiguration config)
	{
		return null;
	}

	[Token(Token = "0x6001624")]
	[Address(RVA = "0x152ECF8", Offset = "0x152ECF8", VA = "0x152ECF8")]
	public void UnloadLevelEvent()
	{
	}

	[Token(Token = "0x6001625")]
	[Address(RVA = "0x152EDF4", Offset = "0x152EDF4", VA = "0x152EDF4")]
	private IEnumerator UnloadLevel(LevelData levelData)
	{
		return null;
	}

	[Token(Token = "0x6001626")]
	[Address(RVA = "0x152EE68", Offset = "0x152EE68", VA = "0x152EE68")]
	private void SceneManagerOnSceneLoaded(Scene newScene, LoadSceneMode loadSceneMode)
	{
	}

	[Token(Token = "0x6001627")]
	[Address(RVA = "0x152EF14", Offset = "0x152EF14", VA = "0x152EF14")]
	public IEnumerator SwapTranstion([Optional] Color? color, [Optional] string textId, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, Transition.TransitionEffect customTransitionEffectIndex = Transition.TransitionEffect.Default)
	{
		return null;
	}

	[Token(Token = "0x6001628")]
	[Address(RVA = "0x152EFDC", Offset = "0x152EFDC", VA = "0x152EFDC")]
	public IEnumerator StartTransition([Optional] Color? color, [Optional] string textId, [Optional][DefaultParameterValue(false)] bool showWaitAnimation, [Optional][DefaultParameterValue(false)] bool isAsync, [Optional][DefaultParameterValue(false)] bool showWaitingText, [Optional][DefaultParameterValue(0)] Transition.TransitionEffect customTransitionEffectIndex, [Optional] BaseTransitionEffect customTransitionEffect)
	{
		return null;
	}

	[Token(Token = "0x6001629")]
	[Address(RVA = "0x152F0AC", Offset = "0x152F0AC", VA = "0x152F0AC")]
	public void InstantTransitionCover([Optional] Color? color)
	{
	}

	[Token(Token = "0x600162A")]
	[Address(RVA = "0x152F0F0", Offset = "0x152F0F0", VA = "0x152F0F0")]
	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x600162B")]
	[Address(RVA = "0x152F17C", Offset = "0x152F17C", VA = "0x152F17C")]
	public void ToggleTransitions()
	{
	}

	[Token(Token = "0x600162C")]
	[Address(RVA = "0x152F1DC", Offset = "0x152F1DC", VA = "0x152F1DC")]
	public bool IsTransitionActive()
	{
		return default;
	}

	[Token(Token = "0x600162D")]
	[Address(RVA = "0x152F1F8", Offset = "0x152F1F8", VA = "0x152F1F8")]
	public LevelData GetCurrentLevelData()
	{
		return null;
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0x152F210", Offset = "0x152F210", VA = "0x152F210")]
	public void OverwriteNextTransitionColor(Color color)
	{
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0x152F2C4", Offset = "0x152F2C4", VA = "0x152F2C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001633")]
	[Address(RVA = "0x152F32C", Offset = "0x152F32C", VA = "0x152F32C")]
	public LevelManager()
	{
	}
}
