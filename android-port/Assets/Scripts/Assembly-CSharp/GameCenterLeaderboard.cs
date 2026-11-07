using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apple.GameKit.Leaderboards;

public class GameCenterLeaderboard : ILeaderboard
{
	private class LeaderboardRequest
	{
		public LeaderboardBoard board;

		public int entries;

		public Action<bool, List<LeaderboardEntry>> callback;
	}

	private class PostScoreRequest
	{
		public LeaderboardBoard board;

		public int score;

		public Action<bool, int> callback;

		public int retries;
	}

	private enum Reason
	{
		NOT_SUPPORTED = 0,
		OTHER = 1,
		IS_EXPIRED = 2,
		SUCCESS = 3,
		NOT_AUTHENTICATED = 4
	}

	private static Dictionary<string, LeaderboardEntry> m_cachedPlayerScoresByLeaderboard;

	private static RequestQueue<LeaderboardRequest> m_leaderboardRequestQueue;

	private static RequestQueue<PostScoreRequest> m_postScoreRequestQueue;

	private static void OnRetrieveScores_Failed(string error)
	{
	}

	private static void OnRetrieveScores_Loaded(GKLoadLeaderboardScoresResponse result, string leaderboard)
	{
	}

	private static void OnSubmitScore_Failed(string error)
	{
	}

	private static void OnSubitScore_Success(string message)
	{
	}

	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	private static void ProcessLeaderboardRequestQueue(bool firstFinished)
	{
	}

	private static Task<bool> ShowLeaderboardErrorsIfAny(LeaderboardBoard b)
	{
		return null;
	}

	private static Task<Reason> CheckLeaderboardActive(string id)
	{
		return null;
	}

	private static LeaderboardEntry FromScore(GKLeaderboardScore s, bool isPlayer)
	{
		return null;
	}

	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback)
	{
	}

	private static void ProcessSubmitScoreRequestQueue(bool firstFinished)
	{
	}

	public static bool isRecurringLeaderboardsSupported()
	{
		return false;
	}

	private static int getMajor(string s)
	{
		return 0;
	}

	public static void ShowDialogUpdateSystem()
	{
	}

	private static void ShowDialog(Reason r, bool force = false)
	{
	}

	public void SubmitScoreAsync(LeaderboardBoard board, int score, Action<bool, int> didSuccedCallback, int retries = 5)
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
