using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

[Token(Token = "0x20000CD")]
public class MultiplayerLobby : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class LobbyAvatarPrefab
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs ID;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Prefab;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpawnForce;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x18033D4", Offset = "0x18033D4", VA = "0x18033D4")]
		public LobbyAvatarPrefab()
		{
		}
	}

	[Token(Token = "0x20000CF")]
	public class LobbyPlayer
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject ControllerRoot;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GolfBallController Controller;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int PlayerIndex;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int AvatarIndex;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayerColors.AvatarData Avatar;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LobbySpawnPoint SpawnPointUsed;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x18033DC", Offset = "0x18033DC", VA = "0x18033DC")]
		public LobbyPlayer()
		{
		}
	}

	[Token(Token = "0x20000D0")]
	private enum MatchStateEnum
	{
		[Token(Token = "0x4000380")]
		WaitingForPlayers = 0,
		[Token(Token = "0x4000381")]
		Lobby = 1,
		[Token(Token = "0x4000382")]
		StartingMatch = 2,
		[Token(Token = "0x4000383")]
		Playing = 3,
		[Token(Token = "0x4000384")]
		Results = 4
	}

	[Serializable]
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8C0", Offset = "0x3D8C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__52_0;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PlayerColors.AvatarData, bool> _003C_003E9__58_0;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<LevelData, bool> _003C_003E9__67_5;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<LevelDataContainer, int> _003C_003E9__67_2;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<LevelData, int> _003C_003E9__67_4;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<GolfBallController, int> _003C_003E9__67_11;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<IGrouping<int, GolfBallController>, GolfBallController> _003C_003E9__67_12;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__67_10;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<LevelData, int> _003C_003E9__68_0;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x17FF1E8", Offset = "0x17FF1E8", VA = "0x17FF1E8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x17FF1F0", Offset = "0x17FF1F0", VA = "0x17FF1F0")]
		internal void _003CAwake_003Eb__52_0()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x17FF21C", Offset = "0x17FF21C", VA = "0x17FF21C")]
		internal bool _003CGetRandomAvatar_003Eb__58_0(PlayerColors.AvatarData a)
		{
			return default;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17FF234", Offset = "0x17FF234", VA = "0x17FF234")]
		internal bool _003CPlayLevels_003Eb__67_5(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x17FF260", Offset = "0x17FF260", VA = "0x17FF260")]
		internal int _003CPlayLevels_003Eb__67_2(LevelDataContainer l)
		{
			return default;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x17FF27C", Offset = "0x17FF27C", VA = "0x17FF27C")]
		internal int _003CPlayLevels_003Eb__67_4(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x17FF298", Offset = "0x17FF298", VA = "0x17FF298")]
		internal int _003CPlayLevels_003Eb__67_11(GolfBallController c)
		{
			return default;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x17FF2B0", Offset = "0x17FF2B0", VA = "0x17FF2B0")]
		internal GolfBallController _003CPlayLevels_003Eb__67_12(IGrouping<int, GolfBallController> c)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17FF304", Offset = "0x17FF304", VA = "0x17FF304")]
		internal bool _003CPlayLevels_003Eb__67_10(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x17FF31C", Offset = "0x17FF31C", VA = "0x17FF31C")]
		internal int _003CSelectedRandomWeightedLevelData_003Eb__68_0(LevelData l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8D0", Offset = "0x3D8D0")]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x17FF338", Offset = "0x17FF338", VA = "0x17FF338")]
		public _003C_003Ec__DisplayClass56_0()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17FF340", Offset = "0x17FF340", VA = "0x17FF340")]
		internal bool _003CPlayerDisconnected_003Eb__0(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x17FF364", Offset = "0x17FF364", VA = "0x17FF364")]
		internal bool _003CPlayerDisconnected_003Eb__1(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x17FF388", Offset = "0x17FF388", VA = "0x17FF388")]
		internal bool _003CPlayerDisconnected_003Eb__2(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x17FF3AC", Offset = "0x17FF3AC", VA = "0x17FF3AC")]
		internal bool _003CPlayerDisconnected_003Eb__3(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x17FF3D0", Offset = "0x17FF3D0", VA = "0x17FF3D0")]
		internal bool _003CPlayerDisconnected_003Eb__4(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8E0", Offset = "0x3D8E0")]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarIDs id;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17FF3F4", Offset = "0x17FF3F4", VA = "0x17FF3F4")]
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x17FF3FC", Offset = "0x17FF3FC", VA = "0x17FF3FC")]
		internal bool _003CGetRandomAvatar_003Eb__1(PlayerColors.AvatarData a)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8F0", Offset = "0x3D8F0")]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17FF420", Offset = "0x17FF420", VA = "0x17FF420")]
		public _003C_003Ec__DisplayClass59_0()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x17FF428", Offset = "0x17FF428", VA = "0x17FF428")]
		internal bool _003CPlayerStoppedConnecting_003Eb__0(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D900", Offset = "0x3D900")]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x17FF44C", Offset = "0x17FF44C", VA = "0x17FF44C")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x17FF454", Offset = "0x17FF454", VA = "0x17FF454")]
		internal bool _003CPlayerConnecting_003Eb__0(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x17FF478", Offset = "0x17FF478", VA = "0x17FF478")]
		internal bool _003CPlayerConnecting_003Eb__1(LobbySpawnPoint s)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D910", Offset = "0x3D910")]
	private sealed class _003C_003Ec__DisplayClass60_1
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LobbySpawnPoint s;

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x17FF57C", Offset = "0x17FF57C", VA = "0x17FF57C")]
		public _003C_003Ec__DisplayClass60_1()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x17FF584", Offset = "0x17FF584", VA = "0x17FF584")]
		internal bool _003CPlayerConnecting_003Eb__2(KeyValuePair<int, LobbySpawnPoint> a)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D920", Offset = "0x3D920")]
	private sealed class _003C_003Ec__DisplayClass60_2
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LobbySpawnPoint takeoverSpawnpoint;

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x17FF5EC", Offset = "0x17FF5EC", VA = "0x17FF5EC")]
		public _003C_003Ec__DisplayClass60_2()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x17FF5F4", Offset = "0x17FF5F4", VA = "0x17FF5F4")]
		internal bool _003CPlayerConnecting_003Eb__3(KeyValuePair<int, LobbySpawnPoint> s)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D930", Offset = "0x3D930")]
	private sealed class _003C_003Ec__DisplayClass60_3
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<int, LobbySpawnPoint> lobbySpawnPoint;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x17FF67C", Offset = "0x17FF67C", VA = "0x17FF67C")]
		public _003C_003Ec__DisplayClass60_3()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x17FF684", Offset = "0x17FF684", VA = "0x17FF684")]
		internal bool _003CPlayerConnecting_003Eb__4(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D940", Offset = "0x3D940")]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x17FF6E4", Offset = "0x17FF6E4", VA = "0x17FF6E4")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x17FF6EC", Offset = "0x17FF6EC", VA = "0x17FF6EC")]
		internal bool _003CPlayerConnected_003Eb__0(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x17FF710", Offset = "0x17FF710", VA = "0x17FF710")]
		internal bool _003CPlayerConnected_003Eb__5(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D950", Offset = "0x3D950")]
	private sealed class _003C_003Ec__DisplayClass61_1
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerColors.AvatarData avatar;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject playerGO;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 startScale;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LobbySpawnPoint spawnPoint;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public _003C_003Ec__DisplayClass61_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Func<LobbyAvatarPrefab, bool> _003C_003E9__6;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x17FF734", Offset = "0x17FF734", VA = "0x17FF734")]
		public _003C_003Ec__DisplayClass61_1()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x17FF73C", Offset = "0x17FF73C", VA = "0x17FF73C")]
		internal bool _003CPlayerConnected_003Eb__1(LobbyAvatarPrefab a)
		{
			return default;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x17FF76C", Offset = "0x17FF76C", VA = "0x17FF76C")]
		internal void _003CPlayerConnected_003Eb__2(float t)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x17FF81C", Offset = "0x17FF81C", VA = "0x17FF81C")]
		internal void _003CPlayerConnected_003Eb__3(Rigidbody r)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x17FF97C", Offset = "0x17FF97C", VA = "0x17FF97C")]
		internal bool _003CPlayerConnected_003Eb__6(LobbyAvatarPrefab a)
		{
			return default;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x17FF9AC", Offset = "0x17FF9AC", VA = "0x17FF9AC")]
		internal void _003CPlayerConnected_003Eb__4(ShootArrow arrow)
		{
		}
	}

	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D960", Offset = "0x3D960")]
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17FF9DC", Offset = "0x17FF9DC", VA = "0x17FF9DC")]
		public _003C_003Ec__DisplayClass62_0()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x17FF9E4", Offset = "0x17FF9E4", VA = "0x17FF9E4")]
		internal bool _003CGetLobbyPlayerForPlayer_003Eb__0(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D970", Offset = "0x3D970")]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x17FFA14", Offset = "0x17FFA14", VA = "0x17FFA14")]
		public _003C_003Ec__DisplayClass63_0()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17FFA1C", Offset = "0x17FFA1C", VA = "0x17FFA1C")]
		internal bool _003CPlayerReady_003Eb__0(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D980", Offset = "0x3D980")]
	private sealed class _003CCountdownRoutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerPlayList playList;

		[Token(Token = "0x1700008C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1800D20", Offset = "0x1800D20", VA = "0x1800D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700008D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1800D68", Offset = "0x1800D68", VA = "0x1800D68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1800A24", Offset = "0x1800A24", VA = "0x1800A24")]
		[DebuggerHidden]
		public _003CCountdownRoutine_003Ed__65(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1800A50", Offset = "0x1800A50", VA = "0x1800A50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1800A54", Offset = "0x1800A54", VA = "0x1800A54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1800D20", Offset = "0x1800D20", VA = "0x1800D20", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1800D28", Offset = "0x1800D28", VA = "0x1800D28", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1800D68", Offset = "0x1800D68", VA = "0x1800D68", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D990", Offset = "0x3D990")]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x17FFA40", Offset = "0x17FFA40", VA = "0x17FFA40")]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x17FFA48", Offset = "0x17FFA48", VA = "0x17FFA48")]
		internal bool _003CPlayerUnready_003Eb__0(LobbyPlayer l)
		{
			return default;
		}
	}

	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9A0", Offset = "0x3D9A0")]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelData> allLevels;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<LevelData> levelsToPlay;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerConfiguration.PlayerInfo winningPlayer;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool aborted;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Func<LevelData, bool> _003C_003E9__0;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Func<LevelDataContainer, bool> _003C_003E9__1;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Func<LevelData, bool> _003C_003E9__3;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action _003C_003E9__6;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x17FFA6C", Offset = "0x17FFA6C", VA = "0x17FFA6C")]
		public _003C_003Ec__DisplayClass67_0()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x17FFA74", Offset = "0x17FFA74", VA = "0x17FFA74")]
		internal bool _003CPlayLevels_003Eb__0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x17FFAE0", Offset = "0x17FFAE0", VA = "0x17FFAE0")]
		internal bool _003CPlayLevels_003Eb__1(LevelDataContainer c)
		{
			return default;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x17FFC5C", Offset = "0x17FFC5C", VA = "0x17FFC5C")]
		internal bool _003CPlayLevels_003Eb__3(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x17FFCE8", Offset = "0x17FFCE8", VA = "0x17FFCE8")]
		internal void _003CPlayLevels_003Eb__6()
		{
		}
	}

	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9B0", Offset = "0x3D9B0")]
	private sealed class _003C_003Ec__DisplayClass67_1
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x17FFD60", Offset = "0x17FFD60", VA = "0x17FFD60")]
		public _003C_003Ec__DisplayClass67_1()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x17FFD68", Offset = "0x17FFD68", VA = "0x17FFD68")]
		internal void _003CPlayLevels_003Eb__7(LevelData l)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x17FFE38", Offset = "0x17FFE38", VA = "0x17FFE38")]
		internal void _003CPlayLevels_003Eb__8(Level.CompletedState s)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x18007E8", Offset = "0x18007E8", VA = "0x18007E8")]
		internal void _003CPlayLevels_003Eb__9()
		{
		}
	}

	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9C0", Offset = "0x3D9C0")]
	private sealed class _003CPlayLevels_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerPlayList playList;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass67_0 _003C_003E8__1;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass67_1 _003C_003E8__2;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GarbageCollectorManager _003Cgarbage_003E5__2;

		[Token(Token = "0x1700008E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x18031B4", Offset = "0x18031B4", VA = "0x18031B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700008F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x18031FC", Offset = "0x18031FC", VA = "0x18031FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1800D70", Offset = "0x1800D70", VA = "0x1800D70")]
		[DebuggerHidden]
		public _003CPlayLevels_003Ed__67(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1800D9C", Offset = "0x1800D9C", VA = "0x1800D9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1800DA0", Offset = "0x1800DA0", VA = "0x1800DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x18031B4", Offset = "0x18031B4", VA = "0x18031B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x18031BC", Offset = "0x18031BC", VA = "0x18031BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x18031FC", Offset = "0x18031FC", VA = "0x18031FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9D0", Offset = "0x3D9D0")]
	private struct _003CReturnToMainMenu_003Ed__75 : IAsyncStateMachine
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1803204", Offset = "0x1803204", VA = "0x1803204", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x18033C8", Offset = "0x18033C8", VA = "0x18033C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9E0", Offset = "0x3D9E0")]
	private sealed class _003C_003Ec__DisplayClass76_0
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ControllerStatusChangedEventArgs args;

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1800848", Offset = "0x1800848", VA = "0x1800848")]
		public _003C_003Ec__DisplayClass76_0()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1800850", Offset = "0x1800850", VA = "0x1800850")]
		internal bool _003COnControllerPreDisconnectEvent_003Eb__0(LobbyPlayer l)
		{
			return default;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1800880", Offset = "0x1800880", VA = "0x1800880")]
		internal bool _003COnControllerPreDisconnectEvent_003Eb__1(LobbyPlayer c)
		{
			return default;
		}
	}

	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D9F0", Offset = "0x3D9F0")]
	private sealed class _003CCloseLobbyRoutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerLobby _003C_003E4__this;

		[Token(Token = "0x17000090")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x18009D4", Offset = "0x18009D4", VA = "0x18009D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000091")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1800A1C", Offset = "0x1800A1C", VA = "0x1800A1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x18008B0", Offset = "0x18008B0", VA = "0x18008B0")]
		[DebuggerHidden]
		public _003CCloseLobbyRoutine_003Ed__79(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x18008DC", Offset = "0x18008DC", VA = "0x18008DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x18008E0", Offset = "0x18008E0", VA = "0x18008E0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x18009D4", Offset = "0x18009D4", VA = "0x18009D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x18009DC", Offset = "0x18009DC", VA = "0x18009DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1800A1C", Offset = "0x1800A1C", VA = "0x1800A1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<MultiplayerPlayList> _playLists;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<MultiplayerPlayList> _playListsDemo;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject LobbyPlayerPrefab;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<LobbySpawnPoint> LobbySpawnPositions;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject LobbyObjects;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PlayerColors AvatarData;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<LobbyAvatarPrefab> AvatarPrefabs;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ProgressUI ProgressUI;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public PlayerReadyTrigger ReadyTrigger;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<LobbyPlayer> OnPlayerJoined;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action<LobbyPlayer> OnPlayerDisconnected;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Action OnAllPlayerDisconnected;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Action<LobbyPlayer> OnPlayerIsReady;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Action<LobbyPlayer> OnPlayerIsUnready;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action OnAllPlayersReady;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool debugTestAllLevels;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool debugTestNextBatchLevels;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int debugTestLevelStartIndexOffset;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnLevelStarted;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action OnLevelFinished;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action OnLevelAboutToLoad;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<MultiplayerConfiguration.PlayerInfo, List<MultiplayerConfiguration.PlayerInfo>> OnPlayerFinished;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action<List<MultiplayerConfiguration.PlayerInfo>, MultiplayerConfiguration.PlayerInfo> OnLevelWinnerFound;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnMatchEnded;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnMatchAborted;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnWinSequenceFinished;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Action<List<LobbyPlayer>> OnMatchStarting;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Action<int, List<LevelData>, List<MultiplayerConfiguration.PlayerInfo>, MultiplayerConfiguration.PlayerInfo> OnSessionProgress;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Action OnStartingEndSequence;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public UnlockablesManager UnlockablesManager;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<LobbySpawnPoint> allLobbySpawnPoints;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<int, LobbySpawnPoint> playersJoining;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private IPlayerConnector playerConnector;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Dictionary<MultiplayerPlayList, List<int>> readyPlayers;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<Player> disconnectedPlayers;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private MultiplayerConfiguration currentConfig;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<LobbyPlayer> lobbyPlayers;

	[Token(Token = "0x400036C")]
	private const int MAX_PLAYERS = 2;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private MatchStateEnum MatchState;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool matchStarting;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private MultiplayerPlayList lastPlayList;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Controller controllerToAddBack;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private bool isQuitting;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Dictionary<int, LobbySpawnPoint> occupiedSpawnpoints;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private MultiplayerPlayList overridePlayList;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private QuickMenu quickMenu;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	internal bool ShouldDebug;

	[Token(Token = "0x1700008B")]
	public List<MultiplayerPlayList> PlayLists
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x157E55C", Offset = "0x157E55C", VA = "0x157E55C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x157E564", Offset = "0x157E564", VA = "0x157E564")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x157EF08", Offset = "0x157EF08", VA = "0x157EF08")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x157EF14", Offset = "0x157EF14", VA = "0x157EF14")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x157F318", Offset = "0x157F318", VA = "0x157F318")]
	private void Start()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x157F3BC", Offset = "0x157F3BC", VA = "0x157F3BC")]
	private void PlayerDisconnected(int id)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x157F760", Offset = "0x157F760", VA = "0x157F760")]
	private void Update()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x157F9B0", Offset = "0x157F9B0", VA = "0x157F9B0")]
	private PlayerColors.AvatarData GetRandomAvatar()
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x157FF18", Offset = "0x157FF18", VA = "0x157FF18")]
	private void PlayerStoppedConnecting(int id)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x15800B8", Offset = "0x15800B8", VA = "0x15800B8")]
	private void PlayerConnecting(int id, float normalizedTime)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x15807E0", Offset = "0x15807E0", VA = "0x15807E0")]
	private void PlayerConnected(int id)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1580F90", Offset = "0x1580F90", VA = "0x1580F90")]
	public LobbyPlayer GetLobbyPlayerForPlayer(MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1581084", Offset = "0x1581084", VA = "0x1581084")]
	public void PlayerReady(MultiplayerPlayList playList, int id)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x158138C", Offset = "0x158138C", VA = "0x158138C")]
	public void StartMatch()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x158146C", Offset = "0x158146C", VA = "0x158146C")]
	private IEnumerator CountdownRoutine(MultiplayerPlayList playList)
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x15814E4", Offset = "0x15814E4", VA = "0x15814E4")]
	public void PlayerUnready(MultiplayerPlayList playList, int id)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x15816A4", Offset = "0x15816A4", VA = "0x15816A4")]
	private IEnumerator PlayLevels(MultiplayerPlayList playList)
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x158171C", Offset = "0x158171C", VA = "0x158171C")]
	private LevelData SelectedRandomWeightedLevelData(List<LevelData> levels)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x15818C4", Offset = "0x15818C4", VA = "0x15818C4")]
	private int GetRandomWeightedIndex(int[] weights)
	{
		return default;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1581A10", Offset = "0x1581A10", VA = "0x1581A10")]
	private void PlayerFinishedLevel(MultiplayerConfiguration.PlayerInfo player)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1581A90", Offset = "0x1581A90", VA = "0x1581A90")]
	public void WinSequenceFinished()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1581CD4", Offset = "0x1581CD4", VA = "0x1581CD4")]
	private void LoadDemoScreen()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x1581B0C", Offset = "0x1581B0C", VA = "0x1581B0C")]
	public void ReturnToLobby()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1581D98", Offset = "0x1581D98", VA = "0x1581D98")]
	public void PlayAgainFromResultsScreen()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x1581E18", Offset = "0x1581E18", VA = "0x1581E18")]
	public void ReturnToMainMenu()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x1581EA0", Offset = "0x1581EA0", VA = "0x1581EA0")]
	private void OnControllerPreDisconnectEvent(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1582140", Offset = "0x1582140", VA = "0x1582140")]
	private void OnControllerConnectedEvent(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x1582158", Offset = "0x1582158", VA = "0x1582158")]
	private void ControllerReconnected(int id)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x15822A4", Offset = "0x15822A4", VA = "0x15822A4")]
	public IEnumerator CloseLobbyRoutine()
	{
		return null;
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1582318", Offset = "0x1582318", VA = "0x1582318")]
	public MultiplayerLobby()
	{
	}
}
