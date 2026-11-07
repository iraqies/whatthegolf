using System;

internal static class GameCenter
{
	private class AchievementCompleteRequest
	{
		public string id;

		public string userId;

		public float progress;

		public Action<bool, float> onCompleted;
	}

	private static RequestQueue<AchievementCompleteRequest> _achivementCompleteRequestQueue;

	public static bool IsValidUserID(string userid)
	{
		return false;
	}

	private static void ProcessAchievementCompleteRequestQueue(bool firstFinished)
	{
	}

	private static void ReportAchievement_Failed(string error)
	{
	}

	private static void ReportAchievement_Finished(string s)
	{
	}

	public static void ResetAchievements()
	{
	}

	public static bool IsPlayerAuthenticated()
	{
		return false;
	}

	public static void UnlockAchievement(string id)
	{
	}

	public static void UpdateAchievement(string id, float progress = 100f, Action<bool, float> OnCompleted = null)
	{
	}
}
