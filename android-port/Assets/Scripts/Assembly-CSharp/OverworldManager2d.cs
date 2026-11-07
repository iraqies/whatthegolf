using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using Audio.Rumble;
using CameraStack;
using Core;
using Hub;
using Il2CppDummyDll;
using Puzzle;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000A10")]
public class OverworldManager2d : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A11")]
	public class SpecialCollectableDoor
	{
		[Token(Token = "0x40037C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Collectable Collectable;

		[Token(Token = "0x40037C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldButton2D Door;

		[Token(Token = "0x6003001")]
		[Address(RVA = "0x181ACD4", Offset = "0x181ACD4", VA = "0x181ACD4")]
		public SpecialCollectableDoor()
		{
		}
	}

	[Token(Token = "0x2000A12")]
	public enum STATES
	{
		[Token(Token = "0x40037C9")]
		active = 0,
		[Token(Token = "0x40037CA")]
		inlevel = 1,
		[Token(Token = "0x40037CB")]
		inDialog = 2,
		[Token(Token = "0x40037CC")]
		inAnimation = 3,
		[Token(Token = "0x40037CD")]
		inOnboarding = 4
	}

	[Serializable]
	[Token(Token = "0x2000A13")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42958", Offset = "0x42958")]
	private sealed class _003C_003Ec__82<T>
	{
		[Token(Token = "0x40037CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec__82<T> _003C_003E9;

		[Token(Token = "0x40037CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<T, bool> _003C_003E9__82_0;

		[Token(Token = "0x6003003")]
		public _003C_003Ec__82()
		{
		}

		[Token(Token = "0x6003004")]
		internal bool _003CRemoveNullsFromList_003Eb__82_0(T l)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42968", Offset = "0x42968")]
	private sealed class _003CStart_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x170004EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003008")]
			[Address(RVA = "0x1819C64", Offset = "0x1819C64", VA = "0x1819C64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600300A")]
			[Address(RVA = "0x1819CAC", Offset = "0x1819CAC", VA = "0x1819CAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003005")]
		[Address(RVA = "0x18185C0", Offset = "0x18185C0", VA = "0x18185C0")]
		[DebuggerHidden]
		public _003CStart_003Ed__84(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003006")]
		[Address(RVA = "0x18185EC", Offset = "0x18185EC", VA = "0x18185EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003007")]
		[Address(RVA = "0x18185F0", Offset = "0x18185F0", VA = "0x18185F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003008")]
		[Address(RVA = "0x1819C64", Offset = "0x1819C64", VA = "0x1819C64", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003009")]
		[Address(RVA = "0x1819C6C", Offset = "0x1819C6C", VA = "0x1819C6C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600300A")]
		[Address(RVA = "0x1819CAC", Offset = "0x1819CAC", VA = "0x1819CAC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42978", Offset = "0x42978")]
	private sealed class _003CDeathRoutine_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x170004F0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600300E")]
			[Address(RVA = "0x1817594", Offset = "0x1817594", VA = "0x1817594", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004F1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003010")]
			[Address(RVA = "0x18175DC", Offset = "0x18175DC", VA = "0x18175DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600300B")]
		[Address(RVA = "0x18173B0", Offset = "0x18173B0", VA = "0x18173B0")]
		[DebuggerHidden]
		public _003CDeathRoutine_003Ed__89(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600300C")]
		[Address(RVA = "0x18173DC", Offset = "0x18173DC", VA = "0x18173DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600300D")]
		[Address(RVA = "0x18173E0", Offset = "0x18173E0", VA = "0x18173E0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600300E")]
		[Address(RVA = "0x1817594", Offset = "0x1817594", VA = "0x1817594", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600300F")]
		[Address(RVA = "0x181759C", Offset = "0x181759C", VA = "0x181759C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003010")]
		[Address(RVA = "0x18175DC", Offset = "0x18175DC", VA = "0x18175DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42988", Offset = "0x42988")]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		[Token(Token = "0x40037D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 currentCablePosition;

		[Token(Token = "0x40037D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldBall2D overworldBall;

		[Token(Token = "0x6003011")]
		[Address(RVA = "0x1816B64", Offset = "0x1816B64", VA = "0x1816B64")]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[Token(Token = "0x6003012")]
		[Address(RVA = "0x1816B6C", Offset = "0x1816B6C", VA = "0x1816B6C")]
		internal void _003CMainButtonPressRoutine_003Eb__0(Vector3 p)
		{
		}

		[Token(Token = "0x6003013")]
		[Address(RVA = "0x1816BBC", Offset = "0x1816BBC", VA = "0x1816BBC")]
		internal void _003CMainButtonPressRoutine_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000A17")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42998", Offset = "0x42998")]
	private sealed class _003CMainButtonPressRoutine_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldMainButton button;

		[Token(Token = "0x40037DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass93_0 _003C_003E8__1;

		[Token(Token = "0x170004F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003017")]
			[Address(RVA = "0x1817908", Offset = "0x1817908", VA = "0x1817908", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003019")]
			[Address(RVA = "0x1817950", Offset = "0x1817950", VA = "0x1817950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003014")]
		[Address(RVA = "0x18175E4", Offset = "0x18175E4", VA = "0x18175E4")]
		[DebuggerHidden]
		public _003CMainButtonPressRoutine_003Ed__93(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003015")]
		[Address(RVA = "0x1817610", Offset = "0x1817610", VA = "0x1817610", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003016")]
		[Address(RVA = "0x1817614", Offset = "0x1817614", VA = "0x1817614", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003017")]
		[Address(RVA = "0x1817908", Offset = "0x1817908", VA = "0x1817908", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003018")]
		[Address(RVA = "0x1817910", Offset = "0x1817910", VA = "0x1817910", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003019")]
		[Address(RVA = "0x1817950", Offset = "0x1817950", VA = "0x1817950", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429A8", Offset = "0x429A8")]
	private sealed class _003CStartOverworldMusicDelayed_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40037E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x170004F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600301D")]
			[Address(RVA = "0x181AC84", Offset = "0x181AC84", VA = "0x181AC84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600301F")]
			[Address(RVA = "0x181ACCC", Offset = "0x181ACCC", VA = "0x181ACCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600301A")]
		[Address(RVA = "0x181AB38", Offset = "0x181AB38", VA = "0x181AB38")]
		[DebuggerHidden]
		public _003CStartOverworldMusicDelayed_003Ed__94(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600301B")]
		[Address(RVA = "0x181AB64", Offset = "0x181AB64", VA = "0x181AB64", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600301C")]
		[Address(RVA = "0x181AB68", Offset = "0x181AB68", VA = "0x181AB68", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600301D")]
		[Address(RVA = "0x181AC84", Offset = "0x181AC84", VA = "0x181AC84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600301E")]
		[Address(RVA = "0x181AC8C", Offset = "0x181AC8C", VA = "0x181AC8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600301F")]
		[Address(RVA = "0x181ACCC", Offset = "0x181ACCC", VA = "0x181ACCC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A19")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429B8", Offset = "0x429B8")]
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		[Token(Token = "0x40037E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool didPlayTunnelAnimation;

		[Token(Token = "0x6003020")]
		[Address(RVA = "0x1816C24", Offset = "0x1816C24", VA = "0x1816C24")]
		public _003C_003Ec__DisplayClass99_0()
		{
		}

		[Token(Token = "0x6003021")]
		[Address(RVA = "0x1816C2C", Offset = "0x1816C2C", VA = "0x1816C2C")]
		internal void _003CPlayIntroAnimation_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A1A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429C8", Offset = "0x429C8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40037E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40037E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__99_0;

		[Token(Token = "0x40037E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<bool> _003C_003E9__99_2;

		[Token(Token = "0x40037E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<bool> _003C_003E9__99_3;

		[Token(Token = "0x40037E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action _003C_003E9__99_4;

		[Token(Token = "0x40037E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<LevelData, bool> _003C_003E9__103_0;

		[Token(Token = "0x40037E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<LevelData> _003C_003E9__115_9;

		[Token(Token = "0x6003023")]
		[Address(RVA = "0x1815DE8", Offset = "0x1815DE8", VA = "0x1815DE8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003024")]
		[Address(RVA = "0x1815DF0", Offset = "0x1815DF0", VA = "0x1815DF0")]
		internal void _003CPlayIntroAnimation_003Eb__99_0()
		{
		}

		[Token(Token = "0x6003025")]
		[Address(RVA = "0x1815E1C", Offset = "0x1815E1C", VA = "0x1815E1C")]
		internal bool _003CPlayIntroAnimation_003Eb__99_2()
		{
			return default;
		}

		[Token(Token = "0x6003026")]
		[Address(RVA = "0x1815E24", Offset = "0x1815E24", VA = "0x1815E24")]
		internal bool _003CPlayIntroAnimation_003Eb__99_3()
		{
			return default;
		}

		[Token(Token = "0x6003027")]
		[Address(RVA = "0x1815E2C", Offset = "0x1815E2C", VA = "0x1815E2C")]
		internal void _003CPlayIntroAnimation_003Eb__99_4()
		{
		}

		[Token(Token = "0x6003028")]
		[Address(RVA = "0x1815E30", Offset = "0x1815E30", VA = "0x1815E30")]
		internal bool _003CReturnToOverworld_003Eb__103_0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6003029")]
		[Address(RVA = "0x1815E4C", Offset = "0x1815E4C", VA = "0x1815E4C")]
		internal void _003CStartGoalLevel_003Eb__115_9(LevelData l)
		{
		}
	}

	[Token(Token = "0x2000A1B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429D8", Offset = "0x429D8")]
	private sealed class _003CPlayIntroAnimation_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass99_0 _003C_003E8__1;

		[Token(Token = "0x170004F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600302D")]
			[Address(RVA = "0x1818074", Offset = "0x1818074", VA = "0x1818074", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x18180BC", Offset = "0x18180BC", VA = "0x18180BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600302A")]
		[Address(RVA = "0x1817958", Offset = "0x1817958", VA = "0x1817958")]
		[DebuggerHidden]
		public _003CPlayIntroAnimation_003Ed__99(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600302B")]
		[Address(RVA = "0x1817984", Offset = "0x1817984", VA = "0x1817984", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600302C")]
		[Address(RVA = "0x1817988", Offset = "0x1817988", VA = "0x1817988", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600302D")]
		[Address(RVA = "0x1818074", Offset = "0x1818074", VA = "0x1818074", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600302E")]
		[Address(RVA = "0x181807C", Offset = "0x181807C", VA = "0x181807C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600302F")]
		[Address(RVA = "0x18180BC", Offset = "0x18180BC", VA = "0x18180BC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429E8", Offset = "0x429E8")]
	private sealed class _003CShowBallDelayed_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40037EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40037F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldGoal goalHit;

		[Token(Token = "0x170004F8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003033")]
			[Address(RVA = "0x1818570", Offset = "0x1818570", VA = "0x1818570", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004F9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003035")]
			[Address(RVA = "0x18185B8", Offset = "0x18185B8", VA = "0x18185B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003030")]
		[Address(RVA = "0x1818414", Offset = "0x1818414", VA = "0x1818414")]
		[DebuggerHidden]
		public _003CShowBallDelayed_003Ed__101(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003031")]
		[Address(RVA = "0x1818440", Offset = "0x1818440", VA = "0x1818440", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003032")]
		[Address(RVA = "0x1818444", Offset = "0x1818444", VA = "0x1818444", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003033")]
		[Address(RVA = "0x1818570", Offset = "0x1818570", VA = "0x1818570", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003034")]
		[Address(RVA = "0x1818578", Offset = "0x1818578", VA = "0x1818578", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003035")]
		[Address(RVA = "0x18185B8", Offset = "0x18185B8", VA = "0x18185B8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000A1D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x429F8", Offset = "0x429F8")]
	private struct _003CAskAboutReviewAndNotifications_003Ed__107 : IAsyncStateMachine
	{
		[Token(Token = "0x40037F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40037F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40037F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int numFails;

		[Token(Token = "0x40037F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OverworldGoal goal;

		[Token(Token = "0x6003036")]
		[Address(RVA = "0x1816C38", Offset = "0x1816C38", VA = "0x1816C38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003037")]
		[Address(RVA = "0x1816EBC", Offset = "0x1816EBC", VA = "0x1816EBC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000A1E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A08", Offset = "0x42A08")]
	private sealed class _003C_003Ec__DisplayClass108_0
	{
		[Token(Token = "0x40037F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x40037F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldGoal goal;

		[Token(Token = "0x40037F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldBall2D ballHit;

		[Token(Token = "0x40037FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool forceBallOn;

		[Token(Token = "0x40037FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityAction<bool> _003C_003E9__3;

		[Token(Token = "0x6003038")]
		[Address(RVA = "0x1815E6C", Offset = "0x1815E6C", VA = "0x1815E6C")]
		public _003C_003Ec__DisplayClass108_0()
		{
		}

		[Token(Token = "0x6003039")]
		[Address(RVA = "0x1815E74", Offset = "0x1815E74", VA = "0x1815E74")]
		internal void _003CGoal_OnHit_003Eb__1(string challengeID)
		{
		}

		[Token(Token = "0x600303A")]
		[Address(RVA = "0x1815F74", Offset = "0x1815F74", VA = "0x1815F74")]
		internal void _003CGoal_OnHit_003Eb__3(bool success)
		{
		}

		[Token(Token = "0x600303B")]
		[Address(RVA = "0x1815F9C", Offset = "0x1815F9C", VA = "0x1815F9C")]
		internal void _003CGoal_OnHit_003Eb__0(bool s)
		{
		}
	}

	[Token(Token = "0x2000A1F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A18", Offset = "0x42A18")]
	private sealed class _003C_003Ec__DisplayClass108_1
	{
		[Token(Token = "0x40037FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool previousBallState;

		[Token(Token = "0x40037FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass108_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600303C")]
		[Address(RVA = "0x1815FC4", Offset = "0x1815FC4", VA = "0x1815FC4")]
		public _003C_003Ec__DisplayClass108_1()
		{
		}

		[Token(Token = "0x600303D")]
		[Address(RVA = "0x1815FCC", Offset = "0x1815FCC", VA = "0x1815FCC")]
		internal void _003CGoal_OnHit_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000A20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A28", Offset = "0x42A28")]
	private sealed class _003C_003Ec__DisplayClass111_0
	{
		[Token(Token = "0x40037FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isWaitingForLoad;

		[Token(Token = "0x600303E")]
		[Address(RVA = "0x18160F4", Offset = "0x18160F4", VA = "0x18160F4")]
		public _003C_003Ec__DisplayClass111_0()
		{
		}

		[Token(Token = "0x600303F")]
		[Address(RVA = "0x18160FC", Offset = "0x18160FC", VA = "0x18160FC")]
		internal void _003CSetLevelMusicRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000A21")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A38", Offset = "0x42A38")]
	private sealed class _003CSetLevelMusicRoutine_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40037FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelMusicSettings music;

		[Token(Token = "0x4003802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onLoaded;

		[Token(Token = "0x4003803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass111_0 _003C_003E8__1;

		[Token(Token = "0x4003805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _003CignoreTransition_003E5__2;

		[Token(Token = "0x4003806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _003CloadStartTime_003E5__3;

		[Token(Token = "0x170004FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003043")]
			[Address(RVA = "0x18183C4", Offset = "0x18183C4", VA = "0x18183C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003045")]
			[Address(RVA = "0x181840C", Offset = "0x181840C", VA = "0x181840C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003040")]
		[Address(RVA = "0x18180C4", Offset = "0x18180C4", VA = "0x18180C4")]
		[DebuggerHidden]
		public _003CSetLevelMusicRoutine_003Ed__111(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003041")]
		[Address(RVA = "0x18180F0", Offset = "0x18180F0", VA = "0x18180F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003042")]
		[Address(RVA = "0x18180F4", Offset = "0x18180F4", VA = "0x18180F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003043")]
		[Address(RVA = "0x18183C4", Offset = "0x18183C4", VA = "0x18183C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003044")]
		[Address(RVA = "0x18183CC", Offset = "0x18183CC", VA = "0x18183CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003045")]
		[Address(RVA = "0x181840C", Offset = "0x181840C", VA = "0x181840C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A22")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A48", Offset = "0x42A48")]
	private sealed class _003C_003Ec__DisplayClass113_0
	{
		[Token(Token = "0x4003807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool didLoadMusic;

		[Token(Token = "0x4003808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Level.CompletedState> completeStates;

		[Token(Token = "0x400380A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelData level;

		[Token(Token = "0x400380B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool> callback;

		[Token(Token = "0x6003046")]
		[Address(RVA = "0x1816104", Offset = "0x1816104", VA = "0x1816104")]
		public _003C_003Ec__DisplayClass113_0()
		{
		}

		[Token(Token = "0x6003047")]
		[Address(RVA = "0x181610C", Offset = "0x181610C", VA = "0x181610C")]
		internal void _003CStartBossLevel_003Eb__0()
		{
		}

		[Token(Token = "0x6003048")]
		[Address(RVA = "0x1816118", Offset = "0x1816118", VA = "0x1816118")]
		internal void _003CStartBossLevel_003Eb__1()
		{
		}

		[Token(Token = "0x6003049")]
		[Address(RVA = "0x1816138", Offset = "0x1816138", VA = "0x1816138")]
		internal bool _003CStartBossLevel_003Eb__2()
		{
			return default;
		}

		[Token(Token = "0x600304A")]
		[Address(RVA = "0x1816140", Offset = "0x1816140", VA = "0x1816140")]
		internal void _003CStartBossLevel_003Eb__3(Level.CompletedState s)
		{
		}

		[Token(Token = "0x600304B")]
		[Address(RVA = "0x18161BC", Offset = "0x18161BC", VA = "0x18161BC")]
		internal void _003CStartBossLevel_003Eb__4(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x2000A23")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A58", Offset = "0x42A58")]
	private sealed class _003CStartBossLevel_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400380C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400380D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400380E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x400380F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelData level;

		[Token(Token = "0x4003810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool> callback;

		[Token(Token = "0x170004FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600304F")]
			[Address(RVA = "0x181A048", Offset = "0x181A048", VA = "0x181A048", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003051")]
			[Address(RVA = "0x181A090", Offset = "0x181A090", VA = "0x181A090", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600304C")]
		[Address(RVA = "0x1819CB4", Offset = "0x1819CB4", VA = "0x1819CB4")]
		[DebuggerHidden]
		public _003CStartBossLevel_003Ed__113(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600304D")]
		[Address(RVA = "0x1819CE0", Offset = "0x1819CE0", VA = "0x1819CE0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600304E")]
		[Address(RVA = "0x1819CE4", Offset = "0x1819CE4", VA = "0x1819CE4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600304F")]
		[Address(RVA = "0x181A048", Offset = "0x181A048", VA = "0x181A048", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003050")]
		[Address(RVA = "0x181A050", Offset = "0x181A050", VA = "0x181A050", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003051")]
		[Address(RVA = "0x181A090", Offset = "0x181A090", VA = "0x181A090", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A68", Offset = "0x42A68")]
	private sealed class _003C_003Ec__DisplayClass115_0
	{
		[Token(Token = "0x4003811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string challengeID;

		[Token(Token = "0x4003812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Level.CompletedState> completeStates;

		[Token(Token = "0x4003814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<LevelData> levelsToPlay;

		[Token(Token = "0x4003815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Level.FailState> failedStates;

		[Token(Token = "0x4003816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OverworldGoal goal;

		[Token(Token = "0x4003817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OverworldBall2D ballHit;

		[Token(Token = "0x4003818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool challengeAlreadyCompleted;

		[Token(Token = "0x4003819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityAction<bool> afterLevelCallback;

		[Token(Token = "0x400381A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Func<LevelData.ChallengeData, bool> _003C_003E9__1;

		[Token(Token = "0x400381B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action _003C_003E9__3;

		[Token(Token = "0x400381C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action<Level.FailState> _003C_003E9__6;

		[Token(Token = "0x6003052")]
		[Address(RVA = "0x18162DC", Offset = "0x18162DC", VA = "0x18162DC")]
		public _003C_003Ec__DisplayClass115_0()
		{
		}

		[Token(Token = "0x6003053")]
		[Address(RVA = "0x18162E4", Offset = "0x18162E4", VA = "0x18162E4")]
		internal bool _003CStartGoalLevel_003Eb__0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6003054")]
		[Address(RVA = "0x18163B8", Offset = "0x18163B8", VA = "0x18163B8")]
		internal bool _003CStartGoalLevel_003Eb__1(LevelData.ChallengeData c)
		{
			return default;
		}

		[Token(Token = "0x6003055")]
		[Address(RVA = "0x18163DC", Offset = "0x18163DC", VA = "0x18163DC")]
		internal void _003CStartGoalLevel_003Eb__3()
		{
		}

		[Token(Token = "0x6003056")]
		[Address(RVA = "0x18163FC", Offset = "0x18163FC", VA = "0x18163FC")]
		internal void _003CStartGoalLevel_003Eb__6(Level.FailState fail)
		{
		}
	}

	[Token(Token = "0x2000A25")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A78", Offset = "0x42A78")]
	private sealed class _003C_003Ec__DisplayClass115_1
	{
		[Token(Token = "0x400381D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x400381E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass115_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6003057")]
		[Address(RVA = "0x1816460", Offset = "0x1816460", VA = "0x1816460")]
		public _003C_003Ec__DisplayClass115_1()
		{
		}
	}

	[Token(Token = "0x2000A26")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A88", Offset = "0x42A88")]
	private sealed class _003C_003Ec__DisplayClass115_2
	{
		[Token(Token = "0x400381F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool didLoadMusic;

		[Token(Token = "0x4003820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool isLastLevel;

		[Token(Token = "0x4003821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass115_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6003058")]
		[Address(RVA = "0x1816468", Offset = "0x1816468", VA = "0x1816468")]
		public _003C_003Ec__DisplayClass115_2()
		{
		}

		[Token(Token = "0x6003059")]
		[Address(RVA = "0x1816470", Offset = "0x1816470", VA = "0x1816470")]
		internal void _003CStartGoalLevel_003Eb__2()
		{
		}

		[Token(Token = "0x600305A")]
		[Address(RVA = "0x181647C", Offset = "0x181647C", VA = "0x181647C")]
		internal bool _003CStartGoalLevel_003Eb__4()
		{
			return default;
		}

		[Token(Token = "0x600305B")]
		[Address(RVA = "0x1816484", Offset = "0x1816484", VA = "0x1816484")]
		internal void _003CStartGoalLevel_003Eb__5(Level.CompletedState s)
		{
		}

		[Token(Token = "0x600305C")]
		[Address(RVA = "0x18166CC", Offset = "0x18166CC", VA = "0x18166CC")]
		internal void _003CStartGoalLevel_003Eb__7()
		{
		}

		[Token(Token = "0x600305D")]
		[Address(RVA = "0x1816734", Offset = "0x1816734", VA = "0x1816734")]
		internal void _003CStartGoalLevel_003Eb__8(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x2000A27")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42A98", Offset = "0x42A98")]
	private sealed class _003CStartGoalLevel_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string challengeID;

		[Token(Token = "0x4003825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OverworldGoal goal;

		[Token(Token = "0x4003827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OverworldBall2D ballHit;

		[Token(Token = "0x4003828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityAction<bool> afterLevelCallback;

		[Token(Token = "0x4003829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private _003C_003Ec__DisplayClass115_1 _003C_003E8__1;

		[Token(Token = "0x170004FE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003061")]
			[Address(RVA = "0x181AAE8", Offset = "0x181AAE8", VA = "0x181AAE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004FF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003063")]
			[Address(RVA = "0x181AB30", Offset = "0x181AB30", VA = "0x181AB30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600305E")]
		[Address(RVA = "0x181A098", Offset = "0x181A098", VA = "0x181A098")]
		[DebuggerHidden]
		public _003CStartGoalLevel_003Ed__115(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600305F")]
		[Address(RVA = "0x181A0C4", Offset = "0x181A0C4", VA = "0x181A0C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003060")]
		[Address(RVA = "0x181A0C8", Offset = "0x181A0C8", VA = "0x181A0C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003061")]
		[Address(RVA = "0x181AAE8", Offset = "0x181AAE8", VA = "0x181AAE8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003062")]
		[Address(RVA = "0x181AAF0", Offset = "0x181AAF0", VA = "0x181AAF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003063")]
		[Address(RVA = "0x181AB30", Offset = "0x181AB30", VA = "0x181AB30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AA8", Offset = "0x42AA8")]
	private sealed class _003C_003Ec__DisplayClass118_0
	{
		[Token(Token = "0x400382A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x400382B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x400382C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 end;

		[Token(Token = "0x6003064")]
		[Address(RVA = "0x18169E4", Offset = "0x18169E4", VA = "0x18169E4")]
		public _003C_003Ec__DisplayClass118_0()
		{
		}

		[Token(Token = "0x6003065")]
		[Address(RVA = "0x18169EC", Offset = "0x18169EC", VA = "0x18169EC")]
		internal void _003CCameraMoveCenter_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000A29")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AB8", Offset = "0x42AB8")]
	private sealed class _003CCameraMoveCenter_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400382D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400382E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400382F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4003831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float time;

		[Token(Token = "0x17000500")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003069")]
			[Address(RVA = "0x1817104", Offset = "0x1817104", VA = "0x1817104", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000501")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600306B")]
			[Address(RVA = "0x181714C", Offset = "0x181714C", VA = "0x181714C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003066")]
		[Address(RVA = "0x1816EC8", Offset = "0x1816EC8", VA = "0x1816EC8")]
		[DebuggerHidden]
		public _003CCameraMoveCenter_003Ed__118(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003067")]
		[Address(RVA = "0x1816EF4", Offset = "0x1816EF4", VA = "0x1816EF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003068")]
		[Address(RVA = "0x1816EF8", Offset = "0x1816EF8", VA = "0x1816EF8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003069")]
		[Address(RVA = "0x1817104", Offset = "0x1817104", VA = "0x1817104", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600306A")]
		[Address(RVA = "0x181710C", Offset = "0x181710C", VA = "0x181710C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600306B")]
		[Address(RVA = "0x181714C", Offset = "0x181714C", VA = "0x181714C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A2A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AC8", Offset = "0x42AC8")]
	private sealed class _003C_003Ec__DisplayClass119_0
	{
		[Token(Token = "0x4003832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool zoomIn;

		[Token(Token = "0x4003833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x4003834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sizeStart;

		[Token(Token = "0x4003835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeEnd;

		[Token(Token = "0x600306C")]
		[Address(RVA = "0x1816AA4", Offset = "0x1816AA4", VA = "0x1816AA4")]
		public _003C_003Ec__DisplayClass119_0()
		{
		}

		[Token(Token = "0x600306D")]
		[Address(RVA = "0x1816AAC", Offset = "0x1816AAC", VA = "0x1816AAC")]
		internal void _003CCameraMoveDuringTransition_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000A2B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AD8", Offset = "0x42AD8")]
	private sealed class _003CCameraMoveDuringTransition_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool zoomIn;

		[Token(Token = "0x4003839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldManager2d _003C_003E4__this;

		[Token(Token = "0x400383A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass119_0 _003C_003E8__1;

		[Token(Token = "0x17000502")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003071")]
			[Address(RVA = "0x1817360", Offset = "0x1817360", VA = "0x1817360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000503")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003073")]
			[Address(RVA = "0x18173A8", Offset = "0x18173A8", VA = "0x18173A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600306E")]
		[Address(RVA = "0x1817154", Offset = "0x1817154", VA = "0x1817154")]
		[DebuggerHidden]
		public _003CCameraMoveDuringTransition_003Ed__119(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600306F")]
		[Address(RVA = "0x1817180", Offset = "0x1817180", VA = "0x1817180", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003070")]
		[Address(RVA = "0x1817184", Offset = "0x1817184", VA = "0x1817184", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003071")]
		[Address(RVA = "0x1817360", Offset = "0x1817360", VA = "0x1817360", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003072")]
		[Address(RVA = "0x1817368", Offset = "0x1817368", VA = "0x1817368", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003073")]
		[Address(RVA = "0x18173A8", Offset = "0x18173A8", VA = "0x18173A8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50234", Offset = "0x50234")]
	private Action<bool> m_OnToggleOverworld;

	[Token(Token = "0x4003785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50244", Offset = "0x50244")]
	private Action<LevelData> m_OnLastFlagExit;

	[Token(Token = "0x4003786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool isHub;

	[Token(Token = "0x4003787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SectionManager sectionManager;

	[Token(Token = "0x4003788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OverworldLevelData overworldLevelData;

	[Token(Token = "0x4003789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ECampaignType overworldType;

	[Token(Token = "0x400378A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SectionCulling culling;

	[Token(Token = "0x400378B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public OverworldUI ui;

	[Token(Token = "0x400378C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public OverworldBall2D ball;

	[Token(Token = "0x400378D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public OverworldGoal lastFlag;

	[Token(Token = "0x400378E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform cameraTarget;

	[Token(Token = "0x400378F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<GameObject> disableWhilePlaying;

	[Token(Token = "0x4003790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GridFiller gridfiller;

	[Token(Token = "0x4003791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Rigidbody2D gridRigid;

	[Token(Token = "0x4003792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float delayAfterHidingTransitionOnStartinInTunnel;

	[Token(Token = "0x4003793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool debugTestLastOnboardingLevel;

	[Token(Token = "0x4003794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool debugWithoutDoors;

	[Token(Token = "0x4003795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool debugWithoutComputersAndBigButtons;

	[Token(Token = "0x4003796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LevelDataContainer onboardingLevels;

	[Token(Token = "0x4003797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public OverworldCamera Camera;

	[Token(Token = "0x4003798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public IntroTunnelInOverworld introTunnel;

	[Token(Token = "0x4003799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<OverworldGoal, bool> OnlevelCompleted;

	[Token(Token = "0x400379A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action<OverworldGoal> OnlevelAbandoned;

	[Token(Token = "0x400379B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Action<List<LevelData>> OnLevelStarting;

	[Token(Token = "0x400379C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<SpecialCollectableDoor> CollectableDoors;

	[Token(Token = "0x400379D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Transition deathTransition;

	[Token(Token = "0x400379E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50274", Offset = "0x50274")]
	private Action m_OnShoot;

	[Token(Token = "0x400379F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public WinCrownEffect CrownWonEffect;

	[Token(Token = "0x40037A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public UncompletedFlagScanner FlagScanner;

	[Token(Token = "0x40037A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public List<OverworldGoal> goals;

	[Token(Token = "0x40037A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 ballStartPosition;

	[Token(Token = "0x40037A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private OverworldGoal currentGoal;

	[Token(Token = "0x40037A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private OverworldArea currentArea;

	[Token(Token = "0x40037A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private List<OverworldButton2D> allButtons;

	[Token(Token = "0x40037A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private List<OverworldOLButton2D> OLButtons;

	[Token(Token = "0x40037A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	private List<OverworldSecretWall> allSecrets;

	[Token(Token = "0x40037A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	private List<OverworldMainButton> allOverworldMainButton;

	[Token(Token = "0x40037A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	private List<SimplePortal> allOverworldPortals;

	[Token(Token = "0x40037AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private List<OverworldMainDoorRobot> allOverworldRobots;

	[Token(Token = "0x40037AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private List<PuzzleCompletedGate> allPuzzleDoors;

	[Token(Token = "0x40037AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private List<ResetOnInvisible> allResetProps;

	[Token(Token = "0x40037AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private STATES state;

	[Token(Token = "0x40037AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public bool isComingFromLoaderScene;

	[Token(Token = "0x40037AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private float overworldActiveTime;

	[Token(Token = "0x40037B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float onboardingActiveTime;

	[Token(Token = "0x40037B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Dictionary<string, float> levelActiveTime;

	[Token(Token = "0x40037B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public OverworldMusic overworldMusic;

	[Token(Token = "0x40037B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private OverworldMusicData musicOverworldStart;

	[Token(Token = "0x40037B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public bool canStartAtLogoWhenStartingOverworld;

	[Token(Token = "0x40037B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50324", Offset = "0x50324")]
	private OverworldMusicData m_music__BackingField;

	[Token(Token = "0x40037B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private RandomAudioClips clearLevelClips;

	[Token(Token = "0x40037B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private RandomAudioClips clearLevelCrownClips;

	[Token(Token = "0x40037B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private RandomAudioClips flagHitFirstPlayClips;

	[Token(Token = "0x40037B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private RandomAudioClips flagHitClips;

	[Token(Token = "0x40037BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private RumbleEventAsset rumbleEventAssetFlagCompleted;

	[Token(Token = "0x40037BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private RumbleEventAsset rumbleEventAssetFlagNotCompleted;

	[Token(Token = "0x40037BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private LevelManager levelManager;

	[Token(Token = "0x40037BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private AudioManager audioManager;

	[Token(Token = "0x40037BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float timeForLastTransitionJingle;

	[Token(Token = "0x40037BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private GarbageCollectorManager GarbageCollector;

	[Token(Token = "0x40037C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private int mainCameraCullingMask;

	[Token(Token = "0x40037C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private QuickMenu quickMenu;

	[Token(Token = "0x40037C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50394", Offset = "0x50394")]
	private bool IsIntroAnimationComplete__BackingField;

	[Token(Token = "0x40037C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	public int NumFailsInLastLevel;

	[Token(Token = "0x40037C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503A4", Offset = "0x503A4")]
	private bool IsInteractionDisabled__BackingField;

	[Token(Token = "0x40037C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OverworldManager2d instance;

	[Token(Token = "0x170004E6")]
	public STATES State
	{
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x15C027C", Offset = "0x15C027C", VA = "0x15C027C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170004E7")]
	public OverworldMusicData m_music
	{
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x15C0284", Offset = "0x15C0284", VA = "0x15C0284")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69048", Offset = "0x69048")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x15C028C", Offset = "0x15C028C", VA = "0x15C028C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69058", Offset = "0x69058")]
		set
		{
		}
	}

	[Token(Token = "0x170004E8")]
	public bool IsIntroAnimationComplete
	{
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x15C22A4", Offset = "0x15C22A4", VA = "0x15C22A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6907C", Offset = "0x6907C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x15C22AC", Offset = "0x15C22AC", VA = "0x15C22AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6908C", Offset = "0x6908C")]
		private set
		{
		}
	}

	[Token(Token = "0x170004E9")]
	public bool IsOverworldPlaying
	{
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x15C4C40", Offset = "0x15C4C40", VA = "0x15C4C40")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170004EA")]
	public bool IsInteractionDisabled
	{
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x15C4C50", Offset = "0x15C4C50", VA = "0x15C4C50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6909C", Offset = "0x6909C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x15C4C58", Offset = "0x15C4C58", VA = "0x15C4C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x690AC", Offset = "0x690AC")]
		private set
		{
		}
	}

	[Token(Token = "0x170004EB")]
	private OverworldBall2D BallOrIslandBall
	{
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x15C4C60", Offset = "0x15C4C60", VA = "0x15C4C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EC")]
	public static OverworldManager2d Instance
	{
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x15C503C", Offset = "0x15C503C", VA = "0x15C503C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004ED")]
	public static bool HasInstance
	{
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x15C5124", Offset = "0x15C5124", VA = "0x15C5124")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000061")]
	public event Action<bool> OnToggleOverworld
	{
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x15BFEA4", Offset = "0x15BFEA4", VA = "0x15BFEA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FE8", Offset = "0x68FE8")]
		add
		{
		}
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x15BFF48", Offset = "0x15BFF48", VA = "0x15BFF48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FF8", Offset = "0x68FF8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000062")]
	public event Action<LevelData> OnLastFlagExit
	{
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x15BFFEC", Offset = "0x15BFFEC", VA = "0x15BFFEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69008", Offset = "0x69008")]
		add
		{
		}
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x15C0090", Offset = "0x15C0090", VA = "0x15C0090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69018", Offset = "0x69018")]
		remove
		{
		}
	}

	[Token(Token = "0x14000063")]
	public event Action OnShoot
	{
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x15C0134", Offset = "0x15C0134", VA = "0x15C0134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69028", Offset = "0x69028")]
		add
		{
		}
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x15C01D8", Offset = "0x15C01D8", VA = "0x15C01D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69038", Offset = "0x69038")]
		remove
		{
		}
	}

	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x15C0294", Offset = "0x15C0294", VA = "0x15C0294")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x69068", Offset = "0x69068")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x15C02E0", Offset = "0x15C02E0", VA = "0x15C02E0")]
	public bool CanLoadLevel()
	{
		return default;
	}

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x15C02F0", Offset = "0x15C02F0", VA = "0x15C02F0", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x15C05AC", Offset = "0x15C05AC", VA = "0x15C05AC")]
	public void PostPrcompile()
	{
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x15C05EC", Offset = "0x15C05EC", VA = "0x15C05EC")]
	public void PrePrcompile()
	{
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x15C0608", Offset = "0x15C0608", VA = "0x15C0608")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x15C0EE8", Offset = "0x15C0EE8", VA = "0x15C0EE8")]
	private void Undocking_OnDockingStateChanged(bool isDocked)
	{
	}

	[Token(Token = "0x6002FCD")]
	private void RemoveNullsFromList<T>(List<T> list)
	{
	}

	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x15C124C", Offset = "0x15C124C", VA = "0x15C124C")]
	private bool IsPrecompiledListsOk()
	{
		return default;
	}

	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x15C1480", Offset = "0x15C1480", VA = "0x15C1480")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x15C0FA4", Offset = "0x15C0FA4", VA = "0x15C0FA4")]
	public void RefreshDoorsAndGoals()
	{
	}

	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x15C14F4", Offset = "0x15C14F4", VA = "0x15C14F4")]
	public static void ActivateParticleSystems(Transform root)
	{
	}

	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x15C1B94", Offset = "0x15C1B94", VA = "0x15C1B94")]
	private void RestOverworldProps()
	{
	}

	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x15C1D28", Offset = "0x15C1D28", VA = "0x15C1D28")]
	private void BallMananger_OnDeath(OverworldBall2D ball)
	{
	}

	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x15C1DA4", Offset = "0x15C1DA4", VA = "0x15C1DA4")]
	private IEnumerator DeathRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x15C1E18", Offset = "0x15C1E18", VA = "0x15C1E18")]
	public void RegisterBall(OverworldBall2D _ball, Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x15C20EC", Offset = "0x15C20EC", VA = "0x15C20EC")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x15C2128", Offset = "0x15C2128", VA = "0x15C2128")]
	private void Mainbutton_OnPressed(OverworldMainButton button)
	{
	}

	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x15C21A8", Offset = "0x15C21A8", VA = "0x15C21A8")]
	private IEnumerator MainButtonPressRoutine(OverworldMainButton button)
	{
		return null;
	}

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x15C2220", Offset = "0x15C2220", VA = "0x15C2220")]
	private IEnumerator StartOverworldMusicDelayed(float delay)
	{
		return null;
	}

	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x15C22B4", Offset = "0x15C22B4", VA = "0x15C22B4")]
	private IEnumerator PlayIntroAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x15C2328", Offset = "0x15C2328", VA = "0x15C2328")]
	private void Update()
	{
	}

	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x15C2470", Offset = "0x15C2470", VA = "0x15C2470")]
	private IEnumerator ShowBallDelayed(OverworldGoal goalHit)
	{
		return null;
	}

	[Token(Token = "0x6002FDF")]
	[Address(RVA = "0x15C24E8", Offset = "0x15C24E8", VA = "0x15C24E8")]
	public void StartMusicWithoutTransition()
	{
	}

	[Token(Token = "0x6002FE0")]
	[Address(RVA = "0x15C25C8", Offset = "0x15C25C8", VA = "0x15C25C8")]
	private void ReturnToOverworld(List<LevelData> levelData, bool isCompleted, List<Level.CompletedState> completeState, OverworldGoal goalHit, [Optional][DefaultParameterValue(true)] bool clearPlayAgainDialog, [Optional] OverworldBall2D ballThatHit, [Optional] List<Level.FailState> failStates)
	{
	}

	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x15C3170", Offset = "0x15C3170", VA = "0x15C3170")]
	private void Maindoor_OnEnter(OverworldMainDoorRobot door, Vector3 pos, Action<bool> shouldPlayLevel)
	{
	}

	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x15C3354", Offset = "0x15C3354", VA = "0x15C3354")]
	private void Goal_CrownWon(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x15C3044", Offset = "0x15C3044", VA = "0x15C3044")]
	private void AskAboutReviewAndNotifications(OverworldGoal goal, int numFails = 0)
	{
	}

	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x15C33F0", Offset = "0x15C33F0", VA = "0x15C33F0")]
	public void Goal_OnHit(OverworldGoal goal, Vector3 hitPos, OverworldBall2D ballHit, bool forceBallOn = false)
	{
	}

	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x15C4108", Offset = "0x15C4108", VA = "0x15C4108")]
	private Vector3 GetSafeBallPosition(OverworldGoal goal, Vector3 hitPos)
	{
		return default;
	}

	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x15C39E8", Offset = "0x15C39E8", VA = "0x15C39E8")]
	private void StopBallNextToFlag(OverworldGoal goal, Vector3 hitPos)
	{
	}

	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x15C4788", Offset = "0x15C4788", VA = "0x15C4788")]
	private IEnumerator SetLevelMusicRoutine(LevelMusicSettings music, Action onLoaded)
	{
		return null;
	}

	[Token(Token = "0x6002FE8")]
	[Address(RVA = "0x15C4810", Offset = "0x15C4810", VA = "0x15C4810")]
	public void ChangeStateToInLevel()
	{
	}

	[Token(Token = "0x6002FE9")]
	[Address(RVA = "0x15C481C", Offset = "0x15C481C", VA = "0x15C481C")]
	public IEnumerator StartBossLevel(LevelData level, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x15C2CA4", Offset = "0x15C2CA4", VA = "0x15C2CA4")]
	public void ToggleOverworld(bool isOverworldActive)
	{
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x15C406C", Offset = "0x15C406C", VA = "0x15C406C")]
	private IEnumerator StartGoalLevel(OverworldGoal goal, string challengeID, [Optional] OverworldBall2D ballHit, [Optional] UnityAction<bool> afterLevelCallback)
	{
		return null;
	}

	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x15C48A4", Offset = "0x15C48A4", VA = "0x15C48A4")]
	public void DisplayCampaignHub(bool display)
	{
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x15C4970", Offset = "0x15C4970", VA = "0x15C4970")]
	public void ResetBallPositionToLastSave()
	{
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x15C32CC", Offset = "0x15C32CC", VA = "0x15C32CC")]
	private IEnumerator CameraMoveCenter(Transform target, float time)
	{
		return null;
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x15C30F4", Offset = "0x15C30F4", VA = "0x15C30F4")]
	private IEnumerator CameraMoveDuringTransition(bool zoomIn, [Optional] Transform target)
	{
		return null;
	}

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x15C49F4", Offset = "0x15C49F4", VA = "0x15C49F4")]
	public void SaveBallStartPosition(Vector3 position)
	{
	}

	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x15C4A00", Offset = "0x15C4A00", VA = "0x15C4A00")]
	private void NotifyOnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x15C4A14", Offset = "0x15C4A14", VA = "0x15C4A14")]
	public HubSection FindCurrentHubSection()
	{
		return null;
	}

	[Token(Token = "0x6002FF7")]
	[Address(RVA = "0x15C4DE4", Offset = "0x15C4DE4", VA = "0x15C4DE4")]
	public void DisableInteraction(bool hide = true)
	{
	}

	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x15C4F00", Offset = "0x15C4F00", VA = "0x15C4F00")]
	public void EnableInteraction()
	{
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x15C51B8", Offset = "0x15C51B8", VA = "0x15C51B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x15C5204", Offset = "0x15C5204", VA = "0x15C5204")]
	public OverworldManager2d()
	{
	}

	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x15C528C", Offset = "0x15C528C", VA = "0x15C528C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x690BC", Offset = "0x690BC")]
	private void _003CStart_003Eb__84_0(OverworldGoal g, Vector3 v, OverworldBall2D b)
	{
	}

	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x15C5294", Offset = "0x15C5294", VA = "0x15C5294")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x690CC", Offset = "0x690CC")]
	private void _003CDeathRoutine_003Eb__89_0()
	{
	}

	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x15C52B8", Offset = "0x15C52B8", VA = "0x15C52B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x690DC", Offset = "0x690DC")]
	private void _003CStartOverworldMusicDelayed_003Eb__94_0()
	{
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x15C5300", Offset = "0x15C5300", VA = "0x15C5300")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x690EC", Offset = "0x690EC")]
	private void _003CAskAboutReviewAndNotifications_003Eb__107_0()
	{
	}
}
