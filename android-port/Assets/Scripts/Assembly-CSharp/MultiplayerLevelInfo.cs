using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F3")]
public class MultiplayerLevelInfo : MonoBehaviour
{
	[Token(Token = "0x20004F4")]
	public enum ListDistributionMethodEnum
	{
		[Token(Token = "0x40019D2")]
		EveryoneUsesTheSame = 0,
		[Token(Token = "0x40019D3")]
		OneListForEachPlayer = 1,
		[Token(Token = "0x40019D4")]
		OneListForEachPlayerOrdered = 2
	}

	[Serializable]
	[Token(Token = "0x20004F5")]
	public class ControllerSetup
	{
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> Controllers;

		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x18")]
		public CameraManager Camera;

		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x20")]
		public PlayerColors.AvatarIDs AvailableFor;

		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x17FF180", Offset = "0x17FF180", VA = "0x17FF180")]
		public ControllerSetup()
		{
		}
	}

	[Token(Token = "0x20004F6")]
	public enum PlayerDistributionTypeEnum
	{
		[Token(Token = "0x40019D9")]
		Identical = 0,
		[Token(Token = "0x40019DA")]
		Different = 1
	}

	[Token(Token = "0x20004F7")]
	public enum SpawnTypes
	{
		[Token(Token = "0x40019DC")]
		SpawnNewControllers = 0,
		[Token(Token = "0x40019DD")]
		UseCurrentControllers = 1
	}

	[Token(Token = "0x20004F8")]
	public enum GameTypes
	{
		[Token(Token = "0x40019DF")]
		Strokes = 0,
		[Token(Token = "0x40019E0")]
		Time = 1
	}

	[Token(Token = "0x20004F9")]
	public enum SplitScreenTypeEnum
	{
		[Token(Token = "0x40019E2")]
		VerticalSplit = 0,
		[Token(Token = "0x40019E3")]
		HorizontalSplit = 1
	}

	[Token(Token = "0x20004FA")]
	public enum WinConditions
	{
		[Token(Token = "0x40019E5")]
		AllPlayersHitGoal = 0,
		[Token(Token = "0x40019E6")]
		OnePlayerHitsGoal = 1
	}

	[Token(Token = "0x20004FB")]
	public enum ResetEvents
	{
		[Token(Token = "0x40019E8")]
		Reset = 0,
		[Token(Token = "0x40019E9")]
		Respawn = 1
	}

	[Token(Token = "0x20004FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4001C", Offset = "0x4001C")]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x17FCEB4", Offset = "0x17FCEB4", VA = "0x17FCEB4")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x17FCEBC", Offset = "0x17FCEBC", VA = "0x17FCEBC")]
		internal void _003CRequestNewBallForPlayer_003Eb__0(ShootArrow arrow)
		{
		}
	}

	[Token(Token = "0x20004FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4002C", Offset = "0x4002C")]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x10")]
		public bool complete;

		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x17FCEF4", Offset = "0x17FCEF4", VA = "0x17FCEF4")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x17FCEFC", Offset = "0x17FCEFC", VA = "0x17FCEFC")]
		internal void _003CTimeCounter_003Eb__0(Level.CompletedState s)
		{
		}
	}

	[Token(Token = "0x20004FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4003C", Offset = "0x4003C")]
	private sealed class _003CTimeCounter_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40019EE")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerLevelInfo _003C_003E4__this;

		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		[Token(Token = "0x17000281")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x17FF130", Offset = "0x17FF130", VA = "0x17FF130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000282")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x17FF178", Offset = "0x17FF178", VA = "0x17FF178", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x17FECF0", Offset = "0x17FECF0", VA = "0x17FECF0")]
		[DebuggerHidden]
		public _003CTimeCounter_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x17FED1C", Offset = "0x17FED1C", VA = "0x17FED1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x17FED20", Offset = "0x17FED20", VA = "0x17FED20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x17FF130", Offset = "0x17FF130", VA = "0x17FF130", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x17FF138", Offset = "0x17FF138", VA = "0x17FF138", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x17FF178", Offset = "0x17FF178", VA = "0x17FF178", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4004C", Offset = "0x4004C")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerLevelInfo _003C_003E4__this;

		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0x18")]
		public int i;

		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x20")]
		public Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__1;

		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x17FCF08", Offset = "0x17FCF08", VA = "0x17FCF08")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x17FCF10", Offset = "0x17FCF10", VA = "0x17FCF10")]
		internal bool _003CSetupUsingExisting_003Eb__1(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000500")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4005C", Offset = "0x4005C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MultiplayerConfiguration.PlayerInfo, int> _003C_003E9__38_0;

		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__41_1;

		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x18")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__41_2;

		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x20")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__41_3;

		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x28")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__41_4;

		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x17FCE14", Offset = "0x17FCE14", VA = "0x17FCE14")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x17FCE1C", Offset = "0x17FCE1C", VA = "0x17FCE1C")]
		internal int _003CSetupUsingExisting_003Eb__38_0(MultiplayerConfiguration.PlayerInfo a)
		{
			return default;
		}

		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x17FCE34", Offset = "0x17FCE34", VA = "0x17FCE34")]
		internal bool _003CLateInit_003Eb__41_1(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}

		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x17FCE54", Offset = "0x17FCE54", VA = "0x17FCE54")]
		internal bool _003CLateInit_003Eb__41_2(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}

		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x17FCE74", Offset = "0x17FCE74", VA = "0x17FCE74")]
		internal bool _003CLateInit_003Eb__41_3(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}

		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x17FCE94", Offset = "0x17FCE94", VA = "0x17FCE94")]
		internal bool _003CLateInit_003Eb__41_4(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Token(Token = "0x2000501")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4006C", Offset = "0x4006C")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerLevelInfo _003C_003E4__this;

		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x18")]
		public string[] arrowLayers;

		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x17FCFB0", Offset = "0x17FCFB0", VA = "0x17FCFB0")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}
	}

	[Token(Token = "0x2000502")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4007C", Offset = "0x4007C")]
	private sealed class _003C_003Ec__DisplayClass41_1
	{
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x17FCFB8", Offset = "0x17FCFB8", VA = "0x17FCFB8")]
		public _003C_003Ec__DisplayClass41_1()
		{
		}
	}

	[Token(Token = "0x2000503")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4008C", Offset = "0x4008C")]
	private sealed class _003C_003Ec__DisplayClass41_2
	{
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController controller;

		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass41_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x17FCFC0", Offset = "0x17FCFC0", VA = "0x17FCFC0")]
		public _003C_003Ec__DisplayClass41_2()
		{
		}

		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x17FCFC8", Offset = "0x17FCFC8", VA = "0x17FCFC8")]
		internal void _003CLateInit_003Eb__0(ShootArrow arrow)
		{
		}
	}

	[Token(Token = "0x2000504")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4009C", Offset = "0x4009C")]
	private sealed class _003CLateInit_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerLevelInfo _003C_003E4__this;

		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		[Token(Token = "0x17000283")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60016F6")]
			[Address(RVA = "0x17FECA0", Offset = "0x17FECA0", VA = "0x17FECA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000284")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x17FECE8", Offset = "0x17FECE8", VA = "0x17FECE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x17FD3A0", Offset = "0x17FD3A0", VA = "0x17FD3A0")]
		[DebuggerHidden]
		public _003CLateInit_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x17FD3CC", Offset = "0x17FD3CC", VA = "0x17FD3CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x17FD3D0", Offset = "0x17FD3D0", VA = "0x17FD3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x17FECA0", Offset = "0x17FECA0", VA = "0x17FECA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x17FECA8", Offset = "0x17FECA8", VA = "0x17FECA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x17FECE8", Offset = "0x17FECE8", VA = "0x17FECE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000505")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400AC", Offset = "0x400AC")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x10")]
		public TimeControl time;

		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x17FD124", Offset = "0x17FD124", VA = "0x17FD124")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x17FD12C", Offset = "0x17FD12C", VA = "0x17FD12C")]
		internal void _003CCountdownRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000506")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400BC", Offset = "0x400BC")]
	private sealed class _003CCountdownRoutine_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerLevelInfo _003C_003E4__this;

		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x30")]
		private bool _003ColdBool_003E5__2;

		[Token(Token = "0x17000285")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x17FD350", Offset = "0x17FD350", VA = "0x17FD350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000286")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x17FD398", Offset = "0x17FD398", VA = "0x17FD398", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x17FD174", Offset = "0x17FD174", VA = "0x17FD174")]
		[DebuggerHidden]
		public _003CCountdownRoutine_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x17FD1A0", Offset = "0x17FD1A0", VA = "0x17FD1A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x17FD1A4", Offset = "0x17FD1A4", VA = "0x17FD1A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x17FD350", Offset = "0x17FD350", VA = "0x17FD350", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x17FD358", Offset = "0x17FD358", VA = "0x17FD358", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001700")]
		[Address(RVA = "0x17FD398", Offset = "0x17FD398", VA = "0x17FD398", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x18")]
	public ListDistributionMethodEnum ListDistributionMethod;

	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0x20")]
	public List<ControllerSetup> Setups;

	[Token(Token = "0x40019BC")]
	[FieldOffset(Offset = "0x28")]
	public int LoseStrokePenalty;

	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x2C")]
	public PlayerDistributionTypeEnum DistributionType;

	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0x30")]
	public SpawnTypes SpawnType;

	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0x34")]
	public bool HasSplitScreen;

	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0x38")]
	public List<GameObject> Controllers;

	[Token(Token = "0x40019C1")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> SinglePlayerControllers;

	[Token(Token = "0x40019C2")]
	[FieldOffset(Offset = "0x48")]
	public bool SpawnAtControllerPosition;

	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0x4C")]
	public SplitScreenTypeEnum SplitScreenType;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x50")]
	public List<Transform> SpawnPoints;

	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0x58")]
	public List<GameObject> ObjectsToDisable;

	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> ObjectsToEnable;

	[Token(Token = "0x40019C7")]
	[FieldOffset(Offset = "0x68")]
	public WinConditions WinCondition;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x6C")]
	public ResetEvents ResetEvent;

	[Token(Token = "0x40019C9")]
	[FieldOffset(Offset = "0x70")]
	public GameTypes GameType;

	[Token(Token = "0x40019CA")]
	[FieldOffset(Offset = "0x74")]
	public bool CullOpponentArrow;

	[Token(Token = "0x40019CB")]
	[FieldOffset(Offset = "0x78")]
	public CameraManager OverrideCamera;

	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x80")]
	public bool UseSpawnPointRotation;

	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x88")]
	private MultiplayerConfiguration config;

	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x90")]
	private StrokeCounter strokeCounter;

	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x98")]
	private bool firstPlayerFinished;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D9B4", Offset = "0x4D9B4")]
	private Action<GolfBallController> m_onPlayerSpawned;

	[Token(Token = "0x14000020")]
	public event Action<GolfBallController> onPlayerSpawned
	{
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x157BDCC", Offset = "0x157BDCC", VA = "0x157BDCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628F8", Offset = "0x628F8")]
		add
		{
		}
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x157BE70", Offset = "0x157BE70", VA = "0x157BE70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62908", Offset = "0x62908")]
		remove
		{
		}
	}

	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x157BF14", Offset = "0x157BF14", VA = "0x157BF14")]
	public void SetupLevel(MultiplayerConfiguration config)
	{
	}

	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x157DB2C", Offset = "0x157DB2C", VA = "0x157DB2C")]
	public void RequestNewBallForPlayer(int playerIndex, GolfBallController oldController)
	{
	}

	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x157E138", Offset = "0x157E138", VA = "0x157E138")]
	private IEnumerator TimeCounter()
	{
		return null;
	}

	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x157D304", Offset = "0x157D304", VA = "0x157D304")]
	private void SetupBaseMultiplayer()
	{
	}

	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x157D674", Offset = "0x157D674", VA = "0x157D674")]
	private void SetupAvatarAudio()
	{
	}

	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x157C0B4", Offset = "0x157C0B4", VA = "0x157C0B4")]
	private void SetupUsingExisting()
	{
	}

	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x157DEB8", Offset = "0x157DEB8", VA = "0x157DEB8")]
	private GolfBallController SetControllerForPlayer(MultiplayerConfiguration.PlayerInfo player, GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x157E220", Offset = "0x157E220", VA = "0x157E220")]
	private void OnGoalProgress(int playerIndex, string arg2)
	{
	}

	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x157E1AC", Offset = "0x157E1AC", VA = "0x157E1AC")]
	private IEnumerator LateInit()
	{
		return null;
	}

	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x157E30C", Offset = "0x157E30C", VA = "0x157E30C")]
	private IEnumerator CountdownRoutine()
	{
		return null;
	}

	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x157E380", Offset = "0x157E380", VA = "0x157E380")]
	public List<GolfBallController> GetAllControllers()
	{
		return null;
	}

	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x157E54C", Offset = "0x157E54C", VA = "0x157E54C")]
	public MultiplayerLevelInfo()
	{
	}
}
