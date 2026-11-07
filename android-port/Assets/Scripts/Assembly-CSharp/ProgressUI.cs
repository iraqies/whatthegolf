using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000158")]
public class ProgressUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000159")]
	public class PlayerPointsContainer
	{
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x10")]
		public LobbySpawnPoint.SpawnPointPositions Side;

		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x18")]
		public ProgressUIPlayerPoints PlayerPoints;

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x182E05C", Offset = "0x182E05C", VA = "0x182E05C")]
		public PlayerPointsContainer()
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCB0", Offset = "0x3DCB0")]
	private sealed class _003CWinningRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x20")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x28")]
		public List<MultiplayerConfiguration.PlayerInfo> players;

		[Token(Token = "0x170000BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x182E00C", Offset = "0x182E00C", VA = "0x182E00C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x182E054", Offset = "0x182E054", VA = "0x182E054", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x182DED8", Offset = "0x182DED8", VA = "0x182DED8")]
		[DebuggerHidden]
		public _003CWinningRoutine_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x182DF04", Offset = "0x182DF04", VA = "0x182DF04", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x182DF08", Offset = "0x182DF08", VA = "0x182DF08", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x182E00C", Offset = "0x182E00C", VA = "0x182E00C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x182E014", Offset = "0x182E014", VA = "0x182E014", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x182E054", Offset = "0x182E054", VA = "0x182E054", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCC0", Offset = "0x3DCC0")]
	private sealed class _003CPlayerWonArenaRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x20")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x170000C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x182DC3C", Offset = "0x182DC3C", VA = "0x182DC3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x182DC84", Offset = "0x182DC84", VA = "0x182DC84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x182DBA0", Offset = "0x182DBA0", VA = "0x182DBA0")]
		[DebuggerHidden]
		public _003CPlayerWonArenaRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x182DBCC", Offset = "0x182DBCC", VA = "0x182DBCC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x182DBD0", Offset = "0x182DBD0", VA = "0x182DBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x182DC3C", Offset = "0x182DC3C", VA = "0x182DC3C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x182DC44", Offset = "0x182DC44", VA = "0x182DC44", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x182DC84", Offset = "0x182DC84", VA = "0x182DC84", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCD0", Offset = "0x3DCD0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x8")]
		public static Action<ProgressUICrown> _003C_003E9__29_0;

		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x10")]
		public static Action<ProgressUICrown> _003C_003E9__36_0;

		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x18")]
		public static Func<ProgressUICrown, bool> _003C_003E9__37_0;

		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ProgressUICrown, bool> _003C_003E9__40_1;

		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x28")]
		public static Func<ProgressUICrown, bool> _003C_003E9__43_1;

		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x30")]
		public static Func<ProgressUICrown, bool> _003C_003E9__43_2;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x182CBD4", Offset = "0x182CBD4", VA = "0x182CBD4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x182CBDC", Offset = "0x182CBDC", VA = "0x182CBDC")]
		internal void _003CSetupBeforeRoutine_003Eb__29_0(ProgressUICrown c)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x182CBF8", Offset = "0x182CBF8", VA = "0x182CBF8")]
		internal void _003CHideAndReset_003Eb__36_0(ProgressUICrown c)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x182CC14", Offset = "0x182CC14", VA = "0x182CC14")]
		internal bool _003CFinalLevelLoaded_003Eb__37_0(ProgressUICrown c)
		{
			return default;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x182CC30", Offset = "0x182CC30", VA = "0x182CC30")]
		internal bool _003CPlayerHealthChanged_003Eb__40_1(ProgressUICrown l)
		{
			return default;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x182CC4C", Offset = "0x182CC4C", VA = "0x182CC4C")]
		internal bool _003CConvertStrokesToPoints_003Eb__43_1(ProgressUICrown c)
		{
			return default;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x182CC68", Offset = "0x182CC68", VA = "0x182CC68")]
		internal bool _003CConvertStrokesToPoints_003Eb__43_2(ProgressUICrown c)
		{
			return default;
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCE0", Offset = "0x3DCE0")]
	private sealed class _003CDelayedMaximize_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x28")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x30")]
		public bool value;

		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x38")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x170000C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x182D6F0", Offset = "0x182D6F0", VA = "0x182D6F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x182D738", Offset = "0x182D738", VA = "0x182D738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x182D5FC", Offset = "0x182D5FC", VA = "0x182D5FC")]
		[DebuggerHidden]
		public _003CDelayedMaximize_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x182D628", Offset = "0x182D628", VA = "0x182D628", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x182D62C", Offset = "0x182D62C", VA = "0x182D62C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x182D6F0", Offset = "0x182D6F0", VA = "0x182D6F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x182D6F8", Offset = "0x182D6F8", VA = "0x182D6F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x182D738", Offset = "0x182D738", VA = "0x182D738", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DCF0", Offset = "0x3DCF0")]
	private sealed class _003CShowPoints_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x20")]
		public float initialDelay;

		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x28")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x30")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170000C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x182DE88", Offset = "0x182DE88", VA = "0x182DE88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x182DED0", Offset = "0x182DED0", VA = "0x182DED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x182DC8C", Offset = "0x182DC8C", VA = "0x182DC8C")]
		[DebuggerHidden]
		public _003CShowPoints_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x182DCB8", Offset = "0x182DCB8", VA = "0x182DCB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x182DCBC", Offset = "0x182DCBC", VA = "0x182DCBC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x182DE88", Offset = "0x182DE88", VA = "0x182DE88", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x182DE90", Offset = "0x182DE90", VA = "0x182DE90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x182DED0", Offset = "0x182DED0", VA = "0x182DED0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD00", Offset = "0x3DD00")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x2000160")]
		private sealed class _003C_003CPlayerHealthChanged_003Eg__DelayedLostHealthRoutine_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400063F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000640")]
			[FieldOffset(Offset = "0x20")]
			public _003C_003Ec__DisplayClass40_0 _003C_003E4__this;

			[Token(Token = "0x170000C7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1882A0C", Offset = "0x1882A0C", VA = "0x1882A0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x1882A54", Offset = "0x1882A54", VA = "0x1882A54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x188270C", Offset = "0x188270C", VA = "0x188270C")]
			[DebuggerHidden]
			public _003C_003CPlayerHealthChanged_003Eg__DelayedLostHealthRoutine_007C0_003Ed(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1882738", Offset = "0x1882738", VA = "0x1882738", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x188273C", Offset = "0x188273C", VA = "0x188273C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1882A0C", Offset = "0x1882A0C", VA = "0x1882A0C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1882A14", Offset = "0x1882A14", VA = "0x1882A14", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1882A54", Offset = "0x1882A54", VA = "0x1882A54", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x10")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x18")]
		public MultiplayerConfiguration.PlayerInfo playerHit;

		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x20")]
		public int health;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x182CC90", Offset = "0x182CC90", VA = "0x182CC90")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x182CC98", Offset = "0x182CC98", VA = "0x182CC98")]
		internal IEnumerator _003CPlayerHealthChanged_003Eg__DelayedLostHealthRoutine_007C0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD10", Offset = "0x3DD10")]
	private sealed class _003COnProgress_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x28")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x30")]
		public MultiplayerConfiguration.PlayerInfo lastWinner;

		[Token(Token = "0x170000C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x182DB50", Offset = "0x182DB50", VA = "0x182DB50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x182DB98", Offset = "0x182DB98", VA = "0x182DB98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x182D740", Offset = "0x182D740", VA = "0x182D740")]
		[DebuggerHidden]
		public _003COnProgress_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x182D76C", Offset = "0x182D76C", VA = "0x182D76C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x182D770", Offset = "0x182D770", VA = "0x182D770", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x182DB50", Offset = "0x182DB50", VA = "0x182DB50", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x182DB58", Offset = "0x182DB58", VA = "0x182DB58", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x182DB98", Offset = "0x182DB98", VA = "0x182DB98", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD20", Offset = "0x3DD20")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x10")]
		public int done;

		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__3;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x182CD0C", Offset = "0x182CD0C", VA = "0x182CD0C")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x182CD14", Offset = "0x182CD14", VA = "0x182CD14")]
		internal void _003CConvertStrokesToPoints_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD30", Offset = "0x3DD30")]
	private sealed class _003CConvertStrokesToPoints_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerPlayList.MatchTypes matchType;

		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x28")]
		public List<MultiplayerConfiguration.PlayerInfo> players;

		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x30")]
		public ProgressUI _003C_003E4__this;

		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass43_0 _003C_003E8__1;

		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x40")]
		public bool instant;

		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x48")]
		public MultiplayerConfiguration.PlayerInfo winner;

		[Token(Token = "0x170000CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x182D5AC", Offset = "0x182D5AC", VA = "0x182D5AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x182D5F4", Offset = "0x182D5F4", VA = "0x182D5F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x182CD24", Offset = "0x182CD24", VA = "0x182CD24")]
		[DebuggerHidden]
		public _003CConvertStrokesToPoints_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x182CD50", Offset = "0x182CD50", VA = "0x182CD50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x182CD54", Offset = "0x182CD54", VA = "0x182CD54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x182D5AC", Offset = "0x182D5AC", VA = "0x182D5AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x182D5B4", Offset = "0x182D5B4", VA = "0x182D5B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x182D5F4", Offset = "0x182D5F4", VA = "0x182D5F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DD40", Offset = "0x3DD40")]
	private sealed class _003C_003CConvertStrokesToPoints_003Eg__localCountdown_007C43_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController controller;

		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x28")]
		public int strokes;

		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x30")]
		public Action onDone;

		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170000CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x182CB24", Offset = "0x182CB24", VA = "0x182CB24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x182CB6C", Offset = "0x182CB6C", VA = "0x182CB6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x182C9EC", Offset = "0x182C9EC", VA = "0x182C9EC")]
		[DebuggerHidden]
		public _003C_003CConvertStrokesToPoints_003Eg__localCountdown_007C43_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x182CA18", Offset = "0x182CA18", VA = "0x182CA18", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x182CA1C", Offset = "0x182CA1C", VA = "0x182CA1C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x182CB24", Offset = "0x182CB24", VA = "0x182CB24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x182CB2C", Offset = "0x182CB2C", VA = "0x182CB2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x182CB6C", Offset = "0x182CB6C", VA = "0x182CB6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x28")]
	public ProgressUICharacters Characters;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x30")]
	public List<ProgressUIMap> Maps;

	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MapContainer;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x40")]
	public List<PlayerPointsContainer> PlayerPoints;

	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x48")]
	public Camera UICamera;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x50")]
	public Canvas CrownCanvas;

	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection CrownClaimedClip;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 from;

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x70")]
	private Transform target;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x78")]
	private float moveTimer;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 refVel;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x88")]
	private float waitTime;

	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x90")]
	private ProgressUIMap selectedMap;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x98")]
	private int lastFlag;

	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x9C")]
	private bool moveCharacters;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0xA0")]
	private MultiplayerConfiguration.PlayerInfo winner;

	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<LobbySpawnPoint.SpawnPointPositions, ProgressUIPlayerPoints> playerPoints;

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x1623284", Offset = "0x1623284", VA = "0x1623284")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x16232B4", Offset = "0x16232B4", VA = "0x16232B4")]
	private void SetCrownCanvasEnabled(bool value)
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x1623364", Offset = "0x1623364", VA = "0x1623364")]
	private void SetMapContainerActive(bool value)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x16232E8", Offset = "0x16232E8", VA = "0x16232E8")]
	private void UpdateCamera()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x1623398", Offset = "0x1623398", VA = "0x1623398")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x16238D4", Offset = "0x16238D4", VA = "0x16238D4")]
	private void OnLevelWinnerFound(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x16238DC", Offset = "0x16238DC", VA = "0x16238DC")]
	public IEnumerator WinningRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		return null;
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x1623954", Offset = "0x1623954", VA = "0x1623954")]
	public IEnumerator PlayerWonArenaRoutine(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner)
	{
		return null;
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x16239C8", Offset = "0x16239C8", VA = "0x16239C8")]
	private void OnLevelAboutToLoad()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x1623BB8", Offset = "0x1623BB8", VA = "0x1623BB8")]
	public void SetupBeforeRoutine(int index, List<LevelData> levels, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerPlayList.MatchTypes matchType)
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x1625278", Offset = "0x1625278", VA = "0x1625278")]
	public void HideBehindArenaSequence()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x1625298", Offset = "0x1625298", VA = "0x1625298")]
	public void InitiateVista(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x16252C0", Offset = "0x16252C0", VA = "0x16252C0")]
	public void StartVistaSequence()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x16252E8", Offset = "0x16252E8", VA = "0x16252E8")]
	public void DisableVista()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x1625360", Offset = "0x1625360", VA = "0x1625360")]
	public void InitForArena()
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1625380", Offset = "0x1625380", VA = "0x1625380")]
	public void HideBehindTransition()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x16253A0", Offset = "0x16253A0", VA = "0x16253A0")]
	public void HideAndReset()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x1625690", Offset = "0x1625690", VA = "0x1625690")]
	public void FinalLevelLoaded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x1625F38", Offset = "0x1625F38", VA = "0x1625F38")]
	private IEnumerator DelayedMaximize(float delay, bool value, MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x1625FD4", Offset = "0x1625FD4", VA = "0x1625FD4")]
	private IEnumerator ShowPoints(MultiplayerConfiguration.PlayerInfo player, float initialDelay)
	{
		return null;
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x162605C", Offset = "0x162605C", VA = "0x162605C")]
	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo playerHit, int health)
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x16260F4", Offset = "0x16260F4", VA = "0x16260F4")]
	public IEnumerator OnProgress(int index, List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo lastWinner, MultiplayerPlayList.MatchTypes matchType)
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x162617C", Offset = "0x162617C", VA = "0x162617C")]
	public void ToggleMaximize(bool value, MultiplayerConfiguration.PlayerInfo player)
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x1625E30", Offset = "0x1625E30", VA = "0x1625E30")]
	public IEnumerator ConvertStrokesToPoints(List<MultiplayerConfiguration.PlayerInfo> players, MultiplayerConfiguration.PlayerInfo winner, MultiplayerPlayList.MatchTypes matchType, bool instant = false)
	{
		return null;
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x1626218", Offset = "0x1626218", VA = "0x1626218")]
	public ProgressUI()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x1626220", Offset = "0x1626220", VA = "0x1626220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E8E8", Offset = "0x5E8E8")]
	internal static IEnumerator _003CConvertStrokesToPoints_003Eg__localCountdown_007C43_0(GolfBallController controller, int strokes, Action onDone)
	{
		return null;
	}
}
