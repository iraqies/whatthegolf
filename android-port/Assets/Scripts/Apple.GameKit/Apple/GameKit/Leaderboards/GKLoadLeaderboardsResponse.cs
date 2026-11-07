using System;

namespace Apple.GameKit.Leaderboards
{
	public struct GKLoadLeaderboardsResponse
	{
		public IntPtr Leaderboards;

		public int LeaderboardsLength;

		public GKLeaderboard[] GetLeaderboards()
		{
			return null;
		}
	}
}
