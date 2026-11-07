using System;

namespace Apple.GameKit.Leaderboards
{
	public struct GKLeaderboard
	{
		public string Identifier;

		public string GroupIdentifier;

		public string Title;

		public GKLeaderboardType Type;

		public double StartTimeUnixSeconds;

		public double NextStartStartUnixSeconds;

		public double DurationSeconds;

		public GKLeaderboardScore LocalPlayerScore;

		public DateTimeOffset GetStartTime()
		{
			return default;
		}
	}
}
