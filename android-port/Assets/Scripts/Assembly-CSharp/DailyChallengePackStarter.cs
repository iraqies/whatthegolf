using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000EDA")]
public class DailyChallengePackStarter : BasePackStarter
{
	[Token(Token = "0x2000EDB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45470", Offset = "0x45470")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4005044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x4005045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DailyChallengeLevelDataContainer pack;

		[Token(Token = "0x4005046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<LevelData> levelsToPlay;

		[Token(Token = "0x4005047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int strokes;

		[Token(Token = "0x4005048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool completedAllLevels;

		[Token(Token = "0x4005049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool aborted;

		[Token(Token = "0x400504A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool finishedOnSameDay;

		[Token(Token = "0x400504B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int dayStarted;

		[Token(Token = "0x400504C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<Level.RestartState> _003C_003E9__2;

		[Token(Token = "0x400504D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action _003C_003E9__3;

		[Token(Token = "0x6004567")]
		[Address(RVA = "0x1794E5C", Offset = "0x1794E5C", VA = "0x1794E5C")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6004568")]
		[Address(RVA = "0x1794E64", Offset = "0x1794E64", VA = "0x1794E64")]
		internal void _003CPlayRoutine_003Eb__2(Level.RestartState s)
		{
		}

		[Token(Token = "0x6004569")]
		[Address(RVA = "0x1794E80", Offset = "0x1794E80", VA = "0x1794E80")]
		internal void _003CPlayRoutine_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000EDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45480", Offset = "0x45480")]
	private sealed class _003C_003Ec__DisplayClass27_1
	{
		[Token(Token = "0x400504E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x400504F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600456A")]
		[Address(RVA = "0x1794E8C", Offset = "0x1794E8C", VA = "0x1794E8C")]
		public _003C_003Ec__DisplayClass27_1()
		{
		}

		[Token(Token = "0x600456B")]
		[Address(RVA = "0x1794E94", Offset = "0x1794E94", VA = "0x1794E94")]
		internal void _003CPlayRoutine_003Eb__4(bool s)
		{
		}
	}

	[Token(Token = "0x2000EDD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45490", Offset = "0x45490")]
	private sealed class _003C_003Ec__DisplayClass27_2
	{
		[Token(Token = "0x4005050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LevelData level;

		[Token(Token = "0x4005051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelData newLevelData;

		[Token(Token = "0x4005052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass27_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x600456C")]
		[Address(RVA = "0x1794F64", Offset = "0x1794F64", VA = "0x1794F64")]
		public _003C_003Ec__DisplayClass27_2()
		{
		}

		[Token(Token = "0x600456D")]
		[Address(RVA = "0x1794F6C", Offset = "0x1794F6C", VA = "0x1794F6C")]
		internal void _003CPlayRoutine_003Eb__0(LevelData l)
		{
		}

		[Token(Token = "0x600456E")]
		[Address(RVA = "0x1795164", Offset = "0x1795164", VA = "0x1795164")]
		internal void _003CPlayRoutine_003Eb__1(Level.CompletedState s)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000EDE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454A0", Offset = "0x454A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__27_5;

		[Token(Token = "0x6004570")]
		[Address(RVA = "0x1794E4C", Offset = "0x1794E4C", VA = "0x1794E4C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004571")]
		[Address(RVA = "0x1794E54", Offset = "0x1794E54", VA = "0x1794E54")]
		internal bool _003CPlayRoutine_003Eb__27_5()
		{
			return default;
		}
	}

	[Token(Token = "0x2000EDF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454B0", Offset = "0x454B0")]
	private sealed class _003CPlayRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x4005058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x4005059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass27_1 _003C_003E8__2;

		[Token(Token = "0x400505A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass27_2 _003C_003E8__3;

		[Token(Token = "0x400505B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTime _003Ctoday_003E5__2;

		[Token(Token = "0x400505C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _003CexitLevelIndex_003E5__3;

		[Token(Token = "0x17000734")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004575")]
			[Address(RVA = "0x1796AD8", Offset = "0x1796AD8", VA = "0x1796AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000735")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004577")]
			[Address(RVA = "0x1796B20", Offset = "0x1796B20", VA = "0x1796B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004572")]
		[Address(RVA = "0x1795C60", Offset = "0x1795C60", VA = "0x1795C60")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004573")]
		[Address(RVA = "0x1795C8C", Offset = "0x1795C8C", VA = "0x1795C8C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004574")]
		[Address(RVA = "0x1795C90", Offset = "0x1795C90", VA = "0x1795C90", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004575")]
		[Address(RVA = "0x1796AD8", Offset = "0x1796AD8", VA = "0x1796AD8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004576")]
		[Address(RVA = "0x1796AE0", Offset = "0x1796AE0", VA = "0x1796AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004577")]
		[Address(RVA = "0x1796B20", Offset = "0x1796B20", VA = "0x1796B20", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454C0", Offset = "0x454C0")]
	private sealed class _003CStartTransition_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400505D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400505E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400505F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x4005060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DailyChallengeLevelDataContainer pack;

		[Token(Token = "0x17000736")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600457B")]
			[Address(RVA = "0x1796D28", Offset = "0x1796D28", VA = "0x1796D28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000737")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600457D")]
			[Address(RVA = "0x1796D70", Offset = "0x1796D70", VA = "0x1796D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004578")]
		[Address(RVA = "0x1796B28", Offset = "0x1796B28", VA = "0x1796B28")]
		[DebuggerHidden]
		public _003CStartTransition_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004579")]
		[Address(RVA = "0x1796B54", Offset = "0x1796B54", VA = "0x1796B54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600457A")]
		[Address(RVA = "0x1796B58", Offset = "0x1796B58", VA = "0x1796B58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600457B")]
		[Address(RVA = "0x1796D28", Offset = "0x1796D28", VA = "0x1796D28", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600457C")]
		[Address(RVA = "0x1796D30", Offset = "0x1796D30", VA = "0x1796D30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600457D")]
		[Address(RVA = "0x1796D70", Offset = "0x1796D70", VA = "0x1796D70", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EE1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454D0", Offset = "0x454D0")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4005061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DailyChallengeLevelDataContainer pack;

		[Token(Token = "0x600457E")]
		[Address(RVA = "0x1795284", Offset = "0x1795284", VA = "0x1795284")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x600457F")]
		[Address(RVA = "0x179528C", Offset = "0x179528C", VA = "0x179528C")]
		internal bool _003CPackIsNotYetPlayedToday_003Eb__0(string s)
		{
			return default;
		}
	}

	[Token(Token = "0x2000EE2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454E0", Offset = "0x454E0")]
	private sealed class _003CLoadMuseumScene_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x4005065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSpecial;

		[Token(Token = "0x4005066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperationHandle<SceneInstance> _003CloadHandle_003E5__2;

		[Token(Token = "0x17000738")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004583")]
			[Address(RVA = "0x1795C10", Offset = "0x1795C10", VA = "0x1795C10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000739")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004585")]
			[Address(RVA = "0x1795C58", Offset = "0x1795C58", VA = "0x1795C58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004580")]
		[Address(RVA = "0x1795920", Offset = "0x1795920", VA = "0x1795920")]
		[DebuggerHidden]
		public _003CLoadMuseumScene_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004581")]
		[Address(RVA = "0x179594C", Offset = "0x179594C", VA = "0x179594C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004582")]
		[Address(RVA = "0x1795950", Offset = "0x1795950", VA = "0x1795950", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004583")]
		[Address(RVA = "0x1795C10", Offset = "0x1795C10", VA = "0x1795C10", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004584")]
		[Address(RVA = "0x1795C18", Offset = "0x1795C18", VA = "0x1795C18", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004585")]
		[Address(RVA = "0x1795C58", Offset = "0x1795C58", VA = "0x1795C58", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EE3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x454F0", Offset = "0x454F0")]
	private sealed class _003CWaitForTransitionIfNeeded_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x1700073A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004589")]
			[Address(RVA = "0x17970A0", Offset = "0x17970A0", VA = "0x17970A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700073B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600458B")]
			[Address(RVA = "0x17970E8", Offset = "0x17970E8", VA = "0x17970E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004586")]
		[Address(RVA = "0x1796FAC", Offset = "0x1796FAC", VA = "0x1796FAC")]
		[DebuggerHidden]
		public _003CWaitForTransitionIfNeeded_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004587")]
		[Address(RVA = "0x1796FD8", Offset = "0x1796FD8", VA = "0x1796FD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004588")]
		[Address(RVA = "0x1796FDC", Offset = "0x1796FDC", VA = "0x1796FDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004589")]
		[Address(RVA = "0x17970A0", Offset = "0x17970A0", VA = "0x17970A0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600458A")]
		[Address(RVA = "0x17970A8", Offset = "0x17970A8", VA = "0x17970A8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600458B")]
		[Address(RVA = "0x17970E8", Offset = "0x17970E8", VA = "0x17970E8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000EE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45500", Offset = "0x45500")]
	private struct _003CClose_003Ed__38 : IAsyncStateMachine
	{
		[Token(Token = "0x4005069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400506A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400506B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x400506C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isAborted;

		[Token(Token = "0x400506D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x400506E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x600458C")]
		[Address(RVA = "0x17952CC", Offset = "0x17952CC", VA = "0x17952CC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600458D")]
		[Address(RVA = "0x1795914", Offset = "0x1795914", VA = "0x1795914", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000EE5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45510", Offset = "0x45510")]
	private sealed class _003CSubmitScore_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400506F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyChallengePackStarter _003C_003E4__this;

		[Token(Token = "0x4005072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int strokes;

		[Token(Token = "0x4005073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float pause;

		[Token(Token = "0x4005074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retries;

		[Token(Token = "0x1700073C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004591")]
			[Address(RVA = "0x1796F5C", Offset = "0x1796F5C", VA = "0x1796F5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700073D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004593")]
			[Address(RVA = "0x1796FA4", Offset = "0x1796FA4", VA = "0x1796FA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600458E")]
		[Address(RVA = "0x1796D78", Offset = "0x1796D78", VA = "0x1796D78")]
		[DebuggerHidden]
		public _003CSubmitScore_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600458F")]
		[Address(RVA = "0x1796DA4", Offset = "0x1796DA4", VA = "0x1796DA4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004590")]
		[Address(RVA = "0x1796DA8", Offset = "0x1796DA8", VA = "0x1796DA8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004591")]
		[Address(RVA = "0x1796F5C", Offset = "0x1796F5C", VA = "0x1796F5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004592")]
		[Address(RVA = "0x1796F64", Offset = "0x1796F64", VA = "0x1796F64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004593")]
		[Address(RVA = "0x1796FA4", Offset = "0x1796FA4", VA = "0x1796FA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4005034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int numLevelsToPlay;

	[Token(Token = "0x4005035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TransitionColorDefinition defaultColors;

	[Token(Token = "0x4005036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool endTransition;

	[Token(Token = "0x4005037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool isSpecialPackStarterHack;

	[Token(Token = "0x4005038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LevelMusicSettings winMusic;

	[Token(Token = "0x4005039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;

	[Token(Token = "0x400503A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<LevelData> BlacklistMusicLevels;

	[Token(Token = "0x400503B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private LevelMusicSettings dailyChallengeMusic;

	[Token(Token = "0x400503C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool ShouldSubmitScore;

	[Token(Token = "0x400503D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected readonly string bestScoreKey;

	[Token(Token = "0x400503E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected bool inTransition;

	[Token(Token = "0x400503F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ContentPack _pack;

	[Token(Token = "0x4005040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int levelIndexForPaginator;

	[Token(Token = "0x4005041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected int strokesToSubmit;

	[Token(Token = "0x4005042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Coroutine submitScoreRoutine;

	[Token(Token = "0x4005043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SceneInstance winSceneInstance;

	[Token(Token = "0x17000732")]
	public bool isDailyPlaying
	{
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x18CB290", Offset = "0x18CB290", VA = "0x18CB290")]
		get
		{
			return default;
		}
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x18CB2E4", Offset = "0x18CB2E4", VA = "0x18CB2E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000733")]
	private DailyChallengePagination Paginator
	{
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x18CB34C", Offset = "0x18CB34C", VA = "0x18CB34C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004552")]
	[Address(RVA = "0x18CB3A8", Offset = "0x18CB3A8", VA = "0x18CB3A8")]
	private void ShowDailyPagination(int levelCount)
	{
	}

	[Token(Token = "0x6004553")]
	[Address(RVA = "0x18CB790", Offset = "0x18CB790", VA = "0x18CB790")]
	private void HideDailyPagination()
	{
	}

	[Token(Token = "0x6004554")]
	[Address(RVA = "0x18CB818", Offset = "0x18CB818", VA = "0x18CB818")]
	private void CompleteIcon()
	{
	}

	[Token(Token = "0x6004555")]
	[Address(RVA = "0x18CB960", Offset = "0x18CB960", VA = "0x18CB960")]
	private void ActivateIcon()
	{
	}

	[Token(Token = "0x6004556")]
	[Address(RVA = "0x18CBAE4", Offset = "0x18CBAE4", VA = "0x18CBAE4")]
	public void PlayLevels(bool isDailyPlayed, int lastScore = -1)
	{
	}

	[Token(Token = "0x6004557")]
	[Address(RVA = "0x18CBBD4", Offset = "0x18CBBD4", VA = "0x18CBBD4")]
	public void AllowEndTransition()
	{
	}

	[Token(Token = "0x6004558")]
	[Address(RVA = "0x18CBB60", Offset = "0x18CBB60", VA = "0x18CBB60")]
	private IEnumerator PlayRoutine(bool isDailyPlayed = false, int lastScore = -1)
	{
		return null;
	}

	[Token(Token = "0x6004559")]
	[Address(RVA = "0x18CBBE0", Offset = "0x18CBBE0", VA = "0x18CBBE0")]
	private IEnumerator StartTransition(DailyChallengeLevelDataContainer pack)
	{
		return null;
	}

	[Token(Token = "0x600455A")]
	[Address(RVA = "0x18CBC58", Offset = "0x18CBC58", VA = "0x18CBC58")]
	private bool PackIsNotYetPlayedToday(DailyChallengeLevelDataContainer pack)
	{
		return default;
	}

	[Token(Token = "0x600455B")]
	[Address(RVA = "0x18CBE3C", Offset = "0x18CBE3C", VA = "0x18CBE3C")]
	private void OnPlayerAbort(bool s)
	{
	}

	[Token(Token = "0x600455C")]
	[Address(RVA = "0x18CC19C", Offset = "0x18CC19C", VA = "0x18CC19C")]
	public int GetDayAsInt()
	{
		return default;
	}

	[Token(Token = "0x600455D")]
	[Address(RVA = "0x18CC22C", Offset = "0x18CC22C", VA = "0x18CC22C", Slot = "5")]
	public virtual DailyChallengeLevelDataContainer GetLevelPack()
	{
		return null;
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0x18CC3E8", Offset = "0x18CC3E8", VA = "0x18CC3E8", Slot = "4")]
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0x18CC070", Offset = "0x18CC070", VA = "0x18CC070")]
	private void OnAllLevelsComplete()
	{
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0x18CC598", Offset = "0x18CC598", VA = "0x18CC598")]
	private void OpenMuseumScene(bool isSpecial)
	{
	}

	[Token(Token = "0x6004561")]
	[Address(RVA = "0x18CC61C", Offset = "0x18CC61C", VA = "0x18CC61C")]
	private IEnumerator LoadMuseumScene(bool isSpecial)
	{
		return null;
	}

	[Token(Token = "0x6004562")]
	[Address(RVA = "0x18CC698", Offset = "0x18CC698", VA = "0x18CC698")]
	private IEnumerator WaitForTransitionIfNeeded()
	{
		return null;
	}

	[Token(Token = "0x6004563")]
	[Address(RVA = "0x18CC0F8", Offset = "0x18CC0F8", VA = "0x18CC0F8")]
	public void Close(bool isAborted)
	{
	}

	[Token(Token = "0x6004564")]
	[Address(RVA = "0x18CC6F4", Offset = "0x18CC6F4", VA = "0x18CC6F4", Slot = "6")]
	protected virtual IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		return null;
	}

	[Token(Token = "0x6004565")]
	[Address(RVA = "0x18CC790", Offset = "0x18CC790", VA = "0x18CC790")]
	protected void SubmitScoreCallback(bool succes, int retries)
	{
	}

	[Token(Token = "0x6004566")]
	[Address(RVA = "0x18CC848", Offset = "0x18CC848", VA = "0x18CC848")]
	public DailyChallengePackStarter()
	{
	}
}
