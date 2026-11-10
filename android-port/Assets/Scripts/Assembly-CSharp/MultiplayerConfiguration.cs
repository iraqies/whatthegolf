using System;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using UnityEngine;

public class MultiplayerConfiguration
{
	public class PlayerInfo
	{
		public int InputIndex;

		public CameraManager Cam;

		public List<GolfBallController> Controllers = new List<GolfBallController>();

		public List<GameObject> ControllerContainer = new List<GameObject>();

		public int Strokes;

		public int Points;

		public GameObject BallToSpawn;

		public Stopwatch TimeSpent = new Stopwatch();

		public PlayerColors.AvatarData Avatar;

		public LobbySpawnPoint.SpawnPointPositions Side;

		public Action<PlayerInfo> OnPlayerFinishedLevel;

		public bool FinishedCurrentLevel;

		public bool ArenaLooser;

		public string DisplayName => Avatar != null && !string.IsNullOrEmpty(Avatar.NameID) ? Avatar.NameID : "Player " + (InputIndex + 1);

		public void Reset()
		{
			Strokes = 0;
			FinishedCurrentLevel = false;
			ArenaLooser = false;
			TimeSpent?.Reset();
			Controllers?.Clear();
			ControllerContainer?.Clear();
		}
	}

	public List<PlayerInfo> Players = new List<PlayerInfo>();

	public int LevelsLeft;

	public MultiplayerPlayList.MatchTypes MatchType;

	public PlayerInfo AddPlayer(MultiplayerLobby.LobbyPlayer player)
	{
		if (player == null)
		{
			return null;
		}
		if (Players == null)
		{
			Players = new List<PlayerInfo>();
		}
		PlayerInfo info = new PlayerInfo
		{
			InputIndex = player.PlayerIndex,
			Avatar = player.Avatar,
			Side = player.SpawnPointUsed != null ? player.SpawnPointUsed.Position : LobbySpawnPoint.SpawnPointPositions.Left
		};
		Players.Add(info);
		return info;
	}

	public PlayerInfo GetPlayerWithIndex(int index)
	{
		if (Players == null)
		{
			return null;
		}
		for (int i = 0; i < Players.Count; i++)
		{
			if (Players[i] != null && Players[i].InputIndex == index)
			{
				return Players[i];
			}
		}
		return null;
	}
}
