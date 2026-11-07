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

		public List<GolfBallController> Controllers;

		public List<GameObject> ControllerContainer;

		public int Strokes;

		public int Points;

		public GameObject BallToSpawn;

		public Stopwatch TimeSpent;

		public PlayerColors.AvatarData Avatar;

		public LobbySpawnPoint.SpawnPointPositions Side;

		public Action<PlayerInfo> OnPlayerFinishedLevel;

		public bool FinishedCurrentLevel;

		public bool ArenaLooser;

		public string DisplayName => null;

		public void Reset()
		{
		}
	}

	public List<PlayerInfo> Players;

	public int LevelsLeft;

	public MultiplayerPlayList.MatchTypes MatchType;

	public PlayerInfo AddPlayer(MultiplayerLobby.LobbyPlayer player)
	{
		return null;
	}

	public PlayerInfo GetPlayerWithIndex(int index)
	{
		return null;
	}
}
