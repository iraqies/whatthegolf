using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Rewired;
using UnityEngine;

public class MultiplayerLobby : MonoBehaviour
{
	[Serializable]
	public class LobbyAvatarPrefab
	{
		public PlayerColors.AvatarIDs ID;

		public GameObject Prefab;

		public float SpawnForce;
	}

	public class LobbyPlayer
	{
		public GameObject ControllerRoot;

		public GolfBallController Controller;

		public int PlayerIndex;

		public int AvatarIndex;

		public PlayerColors.AvatarData Avatar;

		public LobbySpawnPoint SpawnPointUsed;
	}

	private enum MatchStateEnum
	{
		WaitingForPlayers = 0,
		Lobby = 1,
		StartingMatch = 2,
		Playing = 3,
		Results = 4
	}

	[SerializeField]
	private List<MultiplayerPlayList> _playLists;

	[SerializeField]
	private List<MultiplayerPlayList> _playListsDemo;

	public GameObject LobbyPlayerPrefab;

	public List<LobbySpawnPoint> LobbySpawnPositions;

	public GameObject LobbyObjects;

	public PlayerColors AvatarData;

	public List<LobbyAvatarPrefab> AvatarPrefabs;

	public ProgressUI ProgressUI;

	public PlayerReadyTrigger ReadyTrigger;

	public Action<LobbyPlayer> OnPlayerJoined;

	public Action<LobbyPlayer> OnPlayerDisconnected;

	public Action OnAllPlayerDisconnected;

	public Action<LobbyPlayer> OnPlayerIsReady;

	public Action<LobbyPlayer> OnPlayerIsUnready;

	public Action OnAllPlayersReady;

	public bool debugTestAllLevels;

	public bool debugTestNextBatchLevels;

	public int debugTestLevelStartIndexOffset;

	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnLevelStarted;

	public Action OnLevelFinished;

	public Action OnLevelAboutToLoad;

	public Action<MultiplayerConfiguration.PlayerInfo, List<MultiplayerConfiguration.PlayerInfo>> OnPlayerFinished;

	public Action<List<MultiplayerConfiguration.PlayerInfo>, MultiplayerConfiguration.PlayerInfo> OnLevelWinnerFound;

	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnMatchEnded;

	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnMatchAborted;

	public Action<List<MultiplayerConfiguration.PlayerInfo>> OnWinSequenceFinished;

	public Action<List<LobbyPlayer>> OnMatchStarting;

	public Action<int, List<LevelData>, List<MultiplayerConfiguration.PlayerInfo>, MultiplayerConfiguration.PlayerInfo> OnSessionProgress;

	public Action OnStartingEndSequence;

	public UnlockablesManager UnlockablesManager;

	public List<LobbySpawnPoint> allLobbySpawnPoints;

	private Dictionary<int, LobbySpawnPoint> playersJoining;

	private IPlayerConnector playerConnector;

	private Dictionary<MultiplayerPlayList, List<int>> readyPlayers;

	private List<Player> disconnectedPlayers;

	private MultiplayerConfiguration currentConfig;

	private List<LobbyPlayer> lobbyPlayers;

	private const int MAX_PLAYERS = 2;

	private MatchStateEnum MatchState;

	private bool matchStarting;

	private MultiplayerPlayList lastPlayList;

	private Controller controllerToAddBack;

	private bool isQuitting;

	private Dictionary<int, LobbySpawnPoint> occupiedSpawnpoints;

	private MultiplayerPlayList overridePlayList;

	private QuickMenu quickMenu;

	internal bool ShouldDebug;

	public List<MultiplayerPlayList> PlayLists => null;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void PlayerDisconnected(int id)
	{
	}

	private void Update()
	{
	}

	private PlayerColors.AvatarData GetRandomAvatar()
	{
		return null;
	}

	private void PlayerStoppedConnecting(int id)
	{
	}

	private void PlayerConnecting(int id, float normalizedTime)
	{
	}

	private void PlayerConnected(int id)
	{
	}

	public LobbyPlayer GetLobbyPlayerForPlayer(MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	public void PlayerReady(MultiplayerPlayList playList, int id)
	{
	}

	public void StartMatch()
	{
	}

	private IEnumerator CountdownRoutine(MultiplayerPlayList playList)
	{
		return null;
	}

	public void PlayerUnready(MultiplayerPlayList playList, int id)
	{
	}

	private IEnumerator PlayLevels(MultiplayerPlayList playList)
	{
		return null;
	}

	private LevelData SelectedRandomWeightedLevelData(List<LevelData> levels)
	{
		return null;
	}

	private int GetRandomWeightedIndex(int[] weights)
	{
		return 0;
	}

	private void PlayerFinishedLevel(MultiplayerConfiguration.PlayerInfo player)
	{
	}

	public void WinSequenceFinished()
	{
	}

	private void LoadDemoScreen()
	{
	}

	public void ReturnToLobby()
	{
	}

	public void PlayAgainFromResultsScreen()
	{
	}

	public void ReturnToMainMenu()
	{
	}

	private void OnControllerPreDisconnectEvent(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnControllerConnectedEvent(ControllerStatusChangedEventArgs args)
	{
	}

	private void ControllerReconnected(int id)
	{
	}

	public IEnumerator CloseLobbyRoutine()
	{
		return null;
	}
}
