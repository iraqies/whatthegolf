using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour, ILeaderboard
{
	private static LeaderboardManager _instance;

	private LeaderboardEntry player = new LeaderboardEntry
	{
		isPlayer = true,
		name = "YOU",
		score = 999
	};

	public static readonly int lowestPossibleScore = 2;

	public string playerName;

	public string playerId;

	public ILeaderboard platformLeaderboard;

	private bool didInit;

	public static LeaderboardManager Instance
	{
		get
		{
			if (_instance == null)
			{
				GameObject go = new GameObject("LeaderboardManager");
				DontDestroyOnLoad(go);
				_instance = go.AddComponent<LeaderboardManager>();
				_instance.Init();
			}
			return _instance;
		}
	}

	private void Start()
	{
		if (!didInit)
		{
			Init();
		}
	}

	private void Init()
	{
		didInit = true;
		platformLeaderboard = null;
		if (RuntimeStoreData.instance != null)
		{
			Debug.Log("Leaderboard platform: " + RuntimeStoreData.instance.onlineLeaderboardType);
		}
		PostInit();
	}

	private void PostInit()
	{
		playerName = PlatformInfo.GetPlayerName();
		if (Application.platform != RuntimePlatform.Switch)
		{
			playerId = PlatformInfo.GetPlayerId();
		}
		if (string.IsNullOrEmpty(playerName))
		{
			playerName = "GolfBall";
		}
		if (string.IsNullOrEmpty(playerId))
		{
			playerId = SystemInfo.deviceUniqueIdentifier;
		}
		if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.leaderboardsAutologin)
		{
			Login(playerId, playerName, _ => { });
		}
	}

	public void ShowLeaderBoard(LeaderboardBoard board)
	{
		if (platformLeaderboard != null)
		{
			platformLeaderboard.ShowLeaderBoard(board);
		}
	}

	private IEnumerator TryLoginBeforeCall(Action<bool> OnResult)
	{
		if (IsLoggedIn())
		{
			OnResult?.Invoke(true);
			yield break;
		}
		bool done = false;
		bool result = false;
		Login(playerId, playerName, r =>
		{
			result = r;
			done = true;
		});
		while (!done)
		{
			yield return null;
		}
		OnResult?.Invoke(result);
	}

	public string GetPlayerId()
	{
		return playerId;
	}

	public void SubmitScoreAsync(LeaderboardBoard board, int playerScore, Action<bool, int> didSuccedCallback, int retries = 5)
	{
		if (playerScore < lowestPossibleScore)
		{
			Debug.LogWarning("Score too low to submit: " + playerScore);
			didSuccedCallback?.Invoke(true, retries);
			return;
		}
		if (platformLeaderboard != null)
		{
			StartCoroutine(TryLoginBeforeCall(loggedIn =>
			{
				if (loggedIn && platformLeaderboard != null)
				{
					platformLeaderboard.SubmitScoreAsync(board, playerScore, didSuccedCallback, retries);
				}
				else
				{
					didSuccedCallback?.Invoke(false, retries);
				}
			}));
			return;
		}
		if (player != null)
		{
			player.isPlayer = true;
			if (playerScore < player.score)
			{
				player.score = playerScore;
			}
		}
		didSuccedCallback?.Invoke(true, retries);
	}

	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
		if (platformLeaderboard != null)
		{
			if (platformLeaderboard.IsLoggedIn())
			{
				didSuccedCallback?.Invoke(true);
				return;
			}
			platformLeaderboard.Login(id, name, didSuccedCallback);
			return;
		}
		if (player != null && !string.IsNullOrEmpty(name))
		{
			player.name = name;
		}
		didSuccedCallback?.Invoke(true);
	}

	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback)
	{
		if (platformLeaderboard != null)
		{
			StartCoroutine(TryLoginBeforeCall(loggedIn =>
			{
				if (loggedIn && platformLeaderboard != null)
				{
					platformLeaderboard.RequestLeaderboard(board, entries, leaderboardCallback);
				}
				else
				{
					leaderboardCallback?.Invoke(false, null);
				}
			}));
			return;
		}
		if (leaderboardCallback != null)
		{
			var list = new List<LeaderboardEntry>();
			if (player != null)
			{
				list.Add(player);
			}
			leaderboardCallback(true, list);
		}
	}

	public void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback)
	{
		if (platformLeaderboard != null)
		{
			StartCoroutine(TryLoginBeforeCall(loggedIn =>
			{
				if (loggedIn && platformLeaderboard != null)
				{
					platformLeaderboard.RequestPlayerData(board, playerDataCallback);
				}
				else
				{
					playerDataCallback?.Invoke(false, null);
				}
			}));
			return;
		}
		playerDataCallback?.Invoke(true, player);
	}

	public bool CanRequestServerTime()
	{
		return platformLeaderboard != null && platformLeaderboard.CanRequestServerTime();
	}

	public void RequestServerTime(Action<bool, DateTime> serverTimeCallback)
	{
		if (CanRequestServerTime())
		{
			StartCoroutine(TryLoginBeforeCall(loggedIn =>
			{
				if (loggedIn && platformLeaderboard != null)
				{
					platformLeaderboard.RequestServerTime(serverTimeCallback);
				}
				else
				{
					serverTimeCallback?.Invoke(true, DateTime.UtcNow);
				}
			}));
			return;
		}
		serverTimeCallback?.Invoke(true, DateTime.UtcNow);
	}

	public bool IsConnected()
	{
		return platformLeaderboard == null || platformLeaderboard.IsConnected();
	}

	public bool IsLoggedIn()
	{
		return platformLeaderboard == null || platformLeaderboard.IsLoggedIn();
	}

	private void PrintLeaderboard(bool succes, List<LeaderboardEntry> leaderboard)
	{
		if (succes && leaderboard != null)
		{
			Debug.Log("Leaderboard count: " + leaderboard.Count);
		}
	}

	private void OnDisable()
	{
		if (SteamApi.Instance != null && SteamApi.Instance.IsValid)
		{
			SteamApi.Instance.Shutdown();
		}
	}
}
