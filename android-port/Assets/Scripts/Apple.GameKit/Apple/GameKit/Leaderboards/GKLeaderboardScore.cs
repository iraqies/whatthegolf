using Apple.GameKit.Players;

namespace Apple.GameKit.Leaderboards
{
	public struct GKLeaderboardScore
	{
		public long Rank;

		public long Value;

		public long Context;

		public double UnixSeconds;

		public GKPlayer Player;
	}
}
