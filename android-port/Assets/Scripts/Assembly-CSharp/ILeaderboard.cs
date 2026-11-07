using System;
using System.Collections.Generic;

public interface ILeaderboard
{
	bool IsConnected();

	bool IsLoggedIn();

	void Login(string id, string name, Action<bool> didSuccedCallback);

	bool CanRequestServerTime();

	void RequestServerTime(Action<bool, DateTime> serverTimeCallback);

	void SubmitScoreAsync(LeaderboardBoard board, int score, Action<bool, int> didSuccedCallback, int retries = 5);

	void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback);

	void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback);

	void ShowLeaderBoard(LeaderboardBoard board);
}
