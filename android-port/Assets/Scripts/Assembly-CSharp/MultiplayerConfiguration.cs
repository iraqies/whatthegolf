using System;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000133")]
public class MultiplayerConfiguration
{
	[Token(Token = "0x2000134")]
	public class PlayerInfo
	{
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x10")]
		public int InputIndex;

		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x18")]
		public CameraManager Cam;

		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x20")]
		public List<GolfBallController> Controllers;

		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x28")]
		public List<GameObject> ControllerContainer;

		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x30")]
		public int Strokes;

		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x34")]
		public int Points;

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BallToSpawn;

		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x40")]
		public Stopwatch TimeSpent;

		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x48")]
		public PlayerColors.AvatarData Avatar;

		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x50")]
		public LobbySpawnPoint.SpawnPointPositions Side;

		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x58")]
		public Action<PlayerInfo> OnPlayerFinishedLevel;

		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x60")]
		public bool FinishedCurrentLevel;

		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x61")]
		public bool ArenaLooser;

		[Token(Token = "0x170000B2")]
		public string DisplayName
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x17FC0E8", Offset = "0x17FC0E8", VA = "0x17FC0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x17FC174", Offset = "0x17FC174", VA = "0x17FC174")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x17FC1D8", Offset = "0x17FC1D8", VA = "0x17FC1D8")]
		public PlayerInfo()
		{
		}
	}

	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DBD0", Offset = "0x3DBD0")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x17FC0BC", Offset = "0x17FC0BC", VA = "0x17FC0BC")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x17FC0C4", Offset = "0x17FC0C4", VA = "0x17FC0C4")]
		internal bool _003CGetPlayerWithIndex_003Eb__0(PlayerInfo p)
		{
			return default;
		}
	}

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x10")]
	public List<PlayerInfo> Players;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x18")]
	public int LevelsLeft;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x1C")]
	public MultiplayerPlayList.MatchTypes MatchType;

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x157AABC", Offset = "0x157AABC", VA = "0x157AABC")]
	public MultiplayerConfiguration()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x157AB40", Offset = "0x157AB40", VA = "0x157AB40")]
	public PlayerInfo AddPlayer(MultiplayerLobby.LobbyPlayer player)
	{
		return null;
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x157ACAC", Offset = "0x157ACAC", VA = "0x157ACAC")]
	public PlayerInfo GetPlayerWithIndex(int index)
	{
		return null;
	}
}
