using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20008C6")]
public interface ILeaderboard
{
	[Token(Token = "0x6002879")]
	bool IsConnected();

	[Token(Token = "0x600287A")]
	bool IsLoggedIn();

	[Token(Token = "0x600287B")]
	void Login(string id, string name, Action<bool> didSuccedCallback);

	[Token(Token = "0x600287C")]
	bool CanRequestServerTime();

	[Token(Token = "0x600287D")]
	void RequestServerTime(Action<bool, DateTime> serverTimeCallback);

	[Token(Token = "0x600287E")]
	void SubmitScoreAsync(LeaderboardBoard board, int score, Action<bool, int> didSuccedCallback, int retries = 5);

	[Token(Token = "0x600287F")]
	void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback);

	[Token(Token = "0x6002880")]
	void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback);

	[Token(Token = "0x6002881")]
	void ShowLeaderBoard(LeaderboardBoard board);
}
