using System;

namespace Apple.GameKit.Leaderboards
{
	public struct GKLoadLeaderboardScoresResponse
	{
		public GKLeaderboardScore LocalScore;

		public IntPtr ScoreEntriesData;

		public int ScoreEntriesLength;

		public GKLeaderboardScore[] GetScoreEntries()
		{
			return null;
		}
	}
}
