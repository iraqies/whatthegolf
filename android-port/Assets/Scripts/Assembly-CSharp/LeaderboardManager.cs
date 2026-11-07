using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour, ILeaderboard
{
	private static LeaderboardManager _instance;

	private LeaderboardEntry player;

	public static readonly int lowestPossibleScore;

	public string playerName;

	public string playerId;

	public ILeaderboard platformLeaderboard;

	private bool didInit;

	public static LeaderboardManager Instance => null;

	private void Start()
	{
	}

	private void Init()
	{
	}

	private void PostInit()
	{
	}

	public void ShowLeaderBoard(LeaderboardBoard board)
	{
	}

	private IEnumerator TryLoginBeforeCall(Action<bool> OnResult)
	{
		return null;
	}

	public string GetPlayerId()
	{
		return null;
	}

	public void SubmitScoreAsync(LeaderboardBoard board, int playerScore, Action<bool, int> didSuccedCallback, int retries = 5)
	{
	}

	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback)
	{
	}

	public void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback)
	{
	}

	public bool CanRequestServerTime()
	{
		return false;
	}

	public void RequestServerTime(Action<bool, DateTime> serverTimeCallback)
	{
	}

	public bool IsConnected()
	{
		return false;
	}

	public bool IsLoggedIn()
	{
		return false;
	}

	private void PrintLeaderboard(bool succes, List<LeaderboardEntry> leaderboard)
	{
	}

	private void OnDisable()
	{
	}
}
