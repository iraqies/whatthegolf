using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyChallengeAchievement : MonoBehaviour
{
	[Serializable]
	[SerializeField]
	private struct WeekdayAcheivements
	{
		public DayOfWeek day;

		public UnlockAchievement achievement;
	}

	[SerializeField]
	private List<WeekdayAcheivements> weekdayAcheivements;

	private const string PlayerPrefLastDailyChallengeDate = "LAST_DAILY";

	private const string PlayerPrefLastDailyChallengeDateCount = "LAST_DAILY_COUNT";

	public UnlockAchievement dailyFirst;

	public UnlockAchievement daily9;

	public UnlockAchievement daily18;

	public static DailyChallengeAchievement Instance;

	private void Awake()
	{
	}

	private static int DateToDay(DateTime date)
	{
		return 0;
	}

	public void UpdateDailyChallengeAchievements(DailyChallengePackStarter menu)
	{
	}

	public static int GetCurrentDailyChallengeCount()
	{
		return 0;
	}

	public static bool WasLastDailyChallengeDateToday()
	{
		return false;
	}

	public static int IncrementPlayedCount()
	{
		return 0;
	}
}
