using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Audio;
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

	private Dictionary<int, LobbySpawnPoint> playersJoining = new Dictionary<int, LobbySpawnPoint>();

	private IPlayerConnector playerConnector;

	private Dictionary<MultiplayerPlayList, List<int>> readyPlayers = new Dictionary<MultiplayerPlayList, List<int>>();

	private List<Player> disconnectedPlayers = new List<Player>();

	private MultiplayerConfiguration currentConfig;

	private List<LobbyPlayer> lobbyPlayers = new List<LobbyPlayer>();

	private const int MAX_PLAYERS = 2;

	private MatchStateEnum MatchState;

	private bool matchStarting;

	private MultiplayerPlayList lastPlayList;

	private Controller controllerToAddBack;

	private bool isQuitting;

	private Dictionary<int, LobbySpawnPoint> occupiedSpawnpoints = new Dictionary<int, LobbySpawnPoint>();

	private MultiplayerPlayList overridePlayList;

	private QuickMenu quickMenu;

	internal bool ShouldDebug;

	public List<MultiplayerPlayList> PlayLists => _playLists;

	private void Awake()
	{
		quickMenu = UnityEngine.Object.FindObjectOfType<QuickMenu>();
		if (ReadyTrigger != null && _playLists != null && _playLists.Count > 0)
		{
			ReadyTrigger.Configure(_playLists[0], PlayerReady, PlayerUnready);
		}
		allLobbySpawnPoints = LobbySpawnPositions != null ? new List<LobbySpawnPoint>(LobbySpawnPositions) : new List<LobbySpawnPoint>();
		occupiedSpawnpoints = new Dictionary<int, LobbySpawnPoint>();
		disconnectedPlayers = new List<Player>();
		playerConnector = new PlayerConnectorLocal();
		playerConnector.OnPlayerConnected += PlayerConnected;
		playerConnector.OnPlayerConnecting += PlayerConnecting;
		playerConnector.OnPlayerStoppedConnecting += PlayerStoppedConnecting;
		playerConnector.OnPlayerDisconnected += PlayerDisconnected;
		MatchState = MatchStateEnum.WaitingForPlayers;
		ReInput.ControllerConnectedEvent += OnControllerConnectedEvent;
		ReInput.ControllerPreDisconnectEvent += OnControllerPreDisconnectEvent;
		lobbyPlayers = new List<LobbyPlayer>();
		if (ProgressUI != null)
		{
			ProgressUI.Initialize();
		}
	}

	private void OnApplicationQuit()
	{
		isQuitting = true;
	}

	private void OnDestroy()
	{
		ReInput.ControllerConnectedEvent -= OnControllerConnectedEvent;
		ReInput.ControllerPreDisconnectEvent -= OnControllerPreDisconnectEvent;
	}

	private void Start()
	{
		if (LevelManager.Instance != null)
		{
			StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}
		MainMenu2Music music = GetComponent<MainMenu2Music>();
		if (music != null)
		{
			music.Play();
		}
	}

	private void PlayerDisconnected(int id)
	{
		if (lobbyPlayers == null)
		{
			return;
		}
		LobbyPlayer lp = lobbyPlayers.FirstOrDefault(p => p != null && p.PlayerIndex == id);
		if (lp == null)
		{
			return;
		}
		if (lp.ControllerRoot != null)
		{
			UnityEngine.Object.Destroy(lp.ControllerRoot);
		}
		if (occupiedSpawnpoints != null && occupiedSpawnpoints.TryGetValue(id, out LobbySpawnPoint sp) && sp != null)
		{
			sp.SpawnpointDeactivated();
		}
		OnPlayerDisconnected?.Invoke(lp);
		if (lp.Controller != null && AudioManager.Instance != null && AudioManager.Instance.golfAudioManager != null)
		{
			AudioManager.Instance.golfAudioManager.RemoveMultiplayerPull(lp.Controller);
		}
		lobbyPlayers.Remove(lp);
		if (lobbyPlayers.Count == 0)
		{
			OnAllPlayerDisconnected?.Invoke();
			MatchState = MatchStateEnum.WaitingForPlayers;
		}
	}

	private void Update()
	{
		if (MatchState == MatchStateEnum.WaitingForPlayers || MatchState == MatchStateEnum.Lobby)
		{
			playerConnector?.CheckForConnectingPlayers();
		}
	}

	private PlayerColors.AvatarData GetRandomAvatar()
	{
		if (AvatarData == null || AvatarData.Colors == null || AvatarData.Colors.Count == 0)
		{
			return null;
		}
		List<PlayerColors.AvatarData> available = AvatarData.Colors.Where(a => a != null && a.AvailableByDefault).ToList();
		if (available.Count == 0)
		{
			available = new List<PlayerColors.AvatarData>(AvatarData.Colors);
		}
		return available[UnityEngine.Random.Range(0, available.Count)];
	}

	private void PlayerStoppedConnecting(int id)
	{
		if (playersJoining != null && playersJoining.TryGetValue(id, out LobbySpawnPoint sp))
		{
			if (sp != null)
			{
				sp.SpawnpointDeactivated();
			}
			playersJoining.Remove(id);
		}
	}

	private void PlayerConnecting(int id, float normalizedTime)
	{
		if (lobbyPlayers != null && lobbyPlayers.Any(p => p != null && p.PlayerIndex == id))
		{
			return;
		}
		if (!playersJoining.TryGetValue(id, out LobbySpawnPoint sp))
		{
			if (LobbySpawnPositions != null && LobbySpawnPositions.Count > 0)
			{
				sp = LobbySpawnPositions[0];
				LobbySpawnPositions.RemoveAt(0);
				occupiedSpawnpoints[id] = sp;
				playersJoining[id] = sp;
			}
		}
		if (sp != null)
		{
			sp.SpawnpointGettingActivated(Mathf.Max(normalizedTime, 0.1f));
		}
	}

	private void PlayerConnected(int id)
	{
		if (lobbyPlayers != null && lobbyPlayers.Any(p => p != null && p.PlayerIndex == id))
		{
			return;
		}
		if (lobbyPlayers.Count == 0)
		{
			readyPlayers.Clear();
		}
		playersJoining.TryGetValue(id, out LobbySpawnPoint sp);
		playersJoining.Remove(id);
		PlayerColors.AvatarData avatar = GetRandomAvatar();
		if (sp != null)
		{
			sp.SpawnpointPickedBy(avatar);
		}
		LobbyAvatarPrefab prefabInfo = AvatarPrefabs != null && avatar != null ? AvatarPrefabs.FirstOrDefault(p => p != null && p.ID == avatar.AvatarID) : null;
		GameObject prefab = prefabInfo != null && prefabInfo.Prefab != null ? prefabInfo.Prefab : LobbyPlayerPrefab;
		if (prefab == null)
		{
			return;
		}
		Vector3 spawnPos = sp != null && sp.PlayerSpawnPosition != null ? sp.PlayerSpawnPosition.position : transform.position;
		Transform parent = LobbyObjects != null ? LobbyObjects.transform : transform;
		GameObject root = UnityEngine.Object.Instantiate(prefab, spawnPos, Quaternion.identity, parent);
		root.SetActive(true);
		Vector3 targetScale = root.transform.localScale;
		StartCoroutine(pTween.To(0.2f, 0f, 1f, t =>
		{
			if (root != null)
			{
				root.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, t);
			}
		}));
		GolfBallController ctrl = root.GetComponentInChildren<GolfBallController>();
		if (ctrl != null)
		{
			if (AudioManager.Instance != null && AudioManager.Instance.golfAudioManager != null)
			{
				AudioManager.Instance.golfAudioManager.AddMultiplayerPull(ctrl);
			}
			ctrl.SetPlayer(id);
			ctrl.gameObject.SetActive(true);
			SetMaterialColorToPlayerColor[] colorSetters = ctrl.gameObject.GetComponentsInChildren<SetMaterialColorToPlayerColor>();
			if (colorSetters != null)
			{
				for (int i = 0; i < colorSetters.Length; i++)
				{
					if (colorSetters[i] != null)
					{
						colorSetters[i].UpdateMaterials(avatar);
					}
				}
			}
		}
		LobbyPlayer lp = new LobbyPlayer
		{
			ControllerRoot = root,
			Controller = ctrl,
			Avatar = avatar,
			PlayerIndex = id,
			AvatarIndex = AvatarData != null && AvatarData.Colors != null ? AvatarData.Colors.IndexOf(avatar) : 0,
			SpawnPointUsed = sp
		};
		lobbyPlayers.Add(lp);
		OnPlayerJoined?.Invoke(lp);
		if (lobbyPlayers.Count >= 1)
		{
			MatchState = MatchStateEnum.Lobby;
		}
	}

	public LobbyPlayer GetLobbyPlayerForPlayer(MultiplayerConfiguration.PlayerInfo player)
	{
		if (player == null || lobbyPlayers == null)
		{
			return null;
		}
		return lobbyPlayers.FirstOrDefault(lp => lp != null && lp.PlayerIndex == player.InputIndex);
	}

	public void PlayerReady(MultiplayerPlayList playList, int id)
	{
		if (MatchState != MatchStateEnum.Lobby || playList == null || _playLists == null || !_playLists.Contains(playList))
		{
			return;
		}
		if (!readyPlayers.ContainsKey(playList))
		{
			readyPlayers[playList] = new List<int>();
		}
		if (!readyPlayers[playList].Contains(id))
		{
			readyPlayers[playList].Add(id);
			LobbyPlayer lp = lobbyPlayers.FirstOrDefault(p => p != null && p.PlayerIndex == id);
			OnPlayerIsReady?.Invoke(lp);
			if (lobbyPlayers.Count >= 2 && readyPlayers[playList].Count >= lobbyPlayers.Count)
			{
				OnAllPlayersReady?.Invoke();
			}
		}
	}

	public void StartMatch()
	{
		if (MatchState != MatchStateEnum.Lobby || _playLists == null || _playLists.Count == 0)
		{
			return;
		}
		MatchState = MatchStateEnum.StartingMatch;
		StartCoroutine(CountdownRoutine(_playLists[0]));
	}

	private IEnumerator CountdownRoutine(MultiplayerPlayList playList)
	{
		OnMatchStarting?.Invoke(lobbyPlayers);
		yield return new WaitForSeconds(0.5f);
		yield return StartCoroutine(PlayLevels(playList));
	}

	public void PlayerUnready(MultiplayerPlayList playList, int id)
	{
		if (MatchState != MatchStateEnum.Lobby || playList == null || !readyPlayers.TryGetValue(playList, out List<int> list))
		{
			return;
		}
		if (list.Remove(id))
		{
			LobbyPlayer lp = lobbyPlayers.FirstOrDefault(p => p != null && p.PlayerIndex == id);
			OnPlayerIsUnready?.Invoke(lp);
		}
	}

	private IEnumerator PlayLevels(MultiplayerPlayList playList)
	{
		MatchState = MatchStateEnum.Playing;
		lastPlayList = playList;
		currentConfig = new MultiplayerConfiguration();
		for (int i = 0; i < lobbyPlayers.Count; i++)
		{
			if (lobbyPlayers[i] != null)
			{
				currentConfig.AddPlayer(lobbyPlayers[i]);
			}
		}
		if (LobbyObjects != null)
		{
			LobbyObjects.SetActive(false);
		}
		if (playList != null && playList.Levels != null)
		{
			for (int i = 0; i < playList.Levels.Count; i++)
			{
				LevelData ld = playList.Levels[i];
				if (ld == null)
				{
					continue;
				}
				OnLevelAboutToLoad?.Invoke();
				if (LevelManager.Instance != null)
				{
					yield return StartCoroutine(LevelManager.Instance.Play(ld, multiplayerConfiguration: currentConfig));
				}
				OnLevelFinished?.Invoke();
			}
		}
		MatchState = MatchStateEnum.Results;
		OnMatchEnded?.Invoke(currentConfig.Players);
	}

	private LevelData SelectedRandomWeightedLevelData(List<LevelData> levels)
	{
		if (levels == null || levels.Count == 0)
		{
			return null;
		}
		return levels[UnityEngine.Random.Range(0, levels.Count)];
	}

	private int GetRandomWeightedIndex(int[] weights)
	{
		if (weights == null || weights.Length == 0)
		{
			return 0;
		}
		int total = 0;
		for (int i = 0; i < weights.Length; i++)
		{
			total += Mathf.Max(0, weights[i]);
		}
		if (total <= 0)
		{
			return 0;
		}
		float r = UnityEngine.Random.value * total;
		float acc = 0f;
		for (int i = 0; i < weights.Length; i++)
		{
			acc += Mathf.Max(0, weights[i]);
			if (r <= acc)
			{
				return i;
			}
		}
		return 0;
	}

	private void PlayerFinishedLevel(MultiplayerConfiguration.PlayerInfo player)
	{
		if (currentConfig != null)
		{
			OnPlayerFinished?.Invoke(player, currentConfig.Players);
		}
	}

	public void WinSequenceFinished()
	{
		if (LobbyObjects != null)
		{
			LobbyObjects.SetActive(true);
		}
		if (currentConfig != null)
		{
			OnWinSequenceFinished?.Invoke(currentConfig.Players);
		}
	}

	private void LoadDemoScreen()
	{
		if (quickMenu != null)
		{
			quickMenu.RemoveBlocker(this);
		}
		DemoEndLoader loader = GetComponent<DemoEndLoader>();
		if (loader != null)
		{
			loader.LoadEnd();
		}
	}

	public void ReturnToLobby()
	{
		MatchState = MatchStateEnum.WaitingForPlayers;
		if (LobbyObjects != null)
		{
			LobbyObjects.SetActive(true);
		}
		if (lobbyPlayers != null)
		{
			for (int i = lobbyPlayers.Count - 1; i >= 0; i--)
			{
				if (lobbyPlayers[i] != null)
				{
					OnPlayerIsUnready?.Invoke(lobbyPlayers[i]);
					PlayerDisconnected(lobbyPlayers[i].PlayerIndex);
				}
			}
		}
		readyPlayers?.Clear();
		if (quickMenu != null)
		{
			quickMenu.RemoveBlocker(this);
		}
		MainMenu2Music music = GetComponent<MainMenu2Music>();
		if (music != null)
		{
			music.Play();
		}
	}

	public void PlayAgainFromResultsScreen()
	{
		if (lastPlayList != null)
		{
			StartCoroutine(PlayLevels(lastPlayList));
		}
	}

	public void ReturnToMainMenu()
	{
		StartCoroutine(CloseLobbyRoutine());
	}

	private void OnControllerPreDisconnectEvent(ControllerStatusChangedEventArgs args)
	{
	}

	private void OnControllerConnectedEvent(ControllerStatusChangedEventArgs args)
	{
		if (args != null)
		{
			ControllerReconnected(args.controllerId);
		}
	}

	private void ControllerReconnected(int id)
	{
		if (disconnectedPlayers == null || ReInput.players == null)
		{
			return;
		}
		Player p = ReInput.players.GetPlayer(id);
		if (p != null && disconnectedPlayers.Remove(p) && disconnectedPlayers.Count == 0)
		{
			TimeControl tc = UnityEngine.Object.FindObjectOfType<TimeControl>();
			if (tc != null)
			{
				tc.TogglePause(false);
			}
		}
	}

	public IEnumerator CloseLobbyRoutine()
	{
		if (LevelManager.Instance != null)
		{
			LevelManager.Instance.ReturnToOverworld?.Invoke();
		}
		yield break;
	}
}
