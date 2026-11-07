using System;
using Core;

namespace BetaAnalytics
{
	public static class AnalyticsPlayerPrefs
	{
		public static void ResetPreviousSessionData()
		{
		}

		public static void SaveCurrentDateTime()
		{
		}

		public static TimeSpan GetTimeSpanSinceLastSession()
		{
			return default;
		}

		public static bool TryGetDateOfLastSession(out DateTime time)
		{
			time = default;
			return false;
		}

		public static void SetDidUseController(bool didUse)
		{
		}

		public static bool HasAnyCrownedFlag()
		{
			return false;
		}

		public static void SaveCrownedFlag(LevelData levelData)
		{
		}

		public static string GetLastLevelID()
		{
			return null;
		}

		public static void SaveLastLevelID(string levelId)
		{
		}

		public static void SetFirstPlayDay(string contentPackID)
		{
		}
	}
}
