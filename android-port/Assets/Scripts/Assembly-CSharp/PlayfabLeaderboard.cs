using System;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;

public class PlayfabLeaderboard : ILeaderboard
{
	private Action<bool, List<LeaderboardEntry>> leaderboardCallback;

	private Action<bool> loginSuccedCallback;

	private string playerName;

	private string playerPlayfabId;

	private bool didReachServer;

	private string GetStatName(LeaderboardBoard board)
	{
		return null;
	}

	private void HandlePlayFabError(PlayFabError error)
	{
	}

	public void SubmitScoreAsync(LeaderboardBoard board, int playerScore, Action<bool, int> didSuccedCallback, int retries)
	{
	}

	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> _leaderboardCallback)
	{
	}

	private void GetLeaderboard(GetLeaderboardResult result)
	{
	}

	private void RequestLeaderboardFailure(PlayFabError error)
	{
	}

	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	private void OnLoginSuccess(LoginResult result)
	{
	}

	private void OnLoginFailure(PlayFabError error)
	{
	}

	private void SetDisplayName()
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

	public void ShowLeaderBoard(LeaderboardBoard board)
	{
	}
}
