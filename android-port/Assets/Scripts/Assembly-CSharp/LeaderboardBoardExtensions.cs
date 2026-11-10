using Core;

public static class LeaderboardBoardExtensions
{
	private static string DailyChallengeID => "daily_" + DailyChallenges.GetToday().DayOfWeek.ToString().ToLowerInvariant();

	public static bool IsRecurring(this LeaderboardBoard value, Store storeType)
	{
		if (storeType == Store.Arcade)
		{
			return value == LeaderboardBoard.DailyChallenge || value == LeaderboardBoard.SpecialEventLeaderboard;
		}
		return false;
	}

	public static string GetLeaderboardId(this LeaderboardBoard value, Store storeType)
	{
		string text = null;
		if (storeType == Store.Arcade && value == LeaderboardBoard.DailyChallenge)
		{
			text = DailyChallengeID;
		}
		if (string.IsNullOrEmpty(text))
		{
			text = value.ToString().ToLowerInvariant();
		}
		if (storeType == Store.Arcade)
		{
			return "com.thelabel.whatthegolf." + text + "1";
		}
		return text;
	}
}
