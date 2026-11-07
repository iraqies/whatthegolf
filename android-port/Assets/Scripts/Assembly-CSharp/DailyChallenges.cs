using System;
using Core;

public class DailyChallenges : AddressableSingleton<DailyChallenges>
{
	internal bool NewPackWasCompletedToday;

	internal DailyChallengeLevelDataContainer lastPackPlayed;

	internal bool isDailyPlaying;

	private static readonly TimeSpan EndOfDay;

	public static bool WasLastPlayedToday()
	{
		return false;
	}

	public static string DateToString(DateTime dateValue)
	{
		return null;
	}

	private static DateTime GetAndAdjustTime(DateTime dt)
	{
		return default;
	}

	public static DateTime GetToday()
	{
		return default;
	}

	public static TimeSpan GetRemainingDayTime()
	{
		return default;
	}

	public static int GetWeekNumber(DateTime time)
	{
		return 0;
	}

	public static void SetIsDailyPackPlayed(DailyChallengeLevelDataContainer pack)
	{
	}

	public static bool GetPacksForDate(DateTime d, out DailyChallengeLevelDataContainer special, out DailyChallengeLevelDataContainer normal)
	{
		special = null;
		normal = null;
		return false;
	}

	public static DailyChallengeLevelDataContainer GetPack()
	{
		return null;
	}

	public static DailyChallengeLevelDataContainer GetNormalPack()
	{
		return null;
	}

	public static DailyChallengeLevelDataContainer GetSpecialPack()
	{
		return null;
	}

	public static bool HasSpecialBeenPlayedBefore()
	{
		return false;
	}

	public static bool HasSpecialBeenPlayedBefore(string specialId)
	{
		return false;
	}

	public static DailyChallengeLevelDataContainer GetPack(DateTime day)
	{
		return null;
	}

	public static DailyChallengeLevelDataContainer GetNormalPack(DateTime day)
	{
		return null;
	}

	public DailyChallengeLevelDataContainer GetSpecialEventByPrizeID(string s)
	{
		return null;
	}

	public static DailyChallengeLevelDataContainer GetSpecialPack(DateTime day)
	{
		return null;
	}
}
