using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Core;
using UnityEngine;

public class DailyChallenges : AddressableSingleton<DailyChallenges>
{
	internal bool NewPackWasCompletedToday;
	internal DailyChallengeLevelDataContainer lastPackPlayed;
	internal bool isDailyPlaying;
	private static readonly TimeSpan EndOfDay = new TimeSpan(23, 59, 59);

	public static bool WasLastPlayedToday()
	{
		string lastDay = SaveGame.LastDayPlayed;
		string todayStr = DateToString(GetToday());
		return lastDay == todayStr;
	}

	public static string DateToString(DateTime dateValue)
	{
		return dateValue.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
	}

	private static DateTime GetAndAdjustTime(DateTime dt)
	{
		return dt;
	}

	public static DateTime GetToday()
	{
		return GetAndAdjustTime(DateTime.Now);
	}

	public static TimeSpan GetRemainingDayTime()
	{
		return EndOfDay - GetToday().TimeOfDay;
	}

	public static int GetWeekNumber(DateTime time)
	{
		DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
		if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
		{
			time = time.AddDays(3.0);
		}
		return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
	}

	public static void SetIsDailyPackPlayed(DailyChallengeLevelDataContainer pack)
	{
		if (pack == null) return;
		string dateStr = DateToString(GetToday());
		string packName = pack.PackName;
		if (pack.IsSpecial)
		{
			var played = SaveGame.DailyPacksPlayed;
			if (played == null || !played.Select(x => x != null && x.Contains("_") ? x.Substring(0, x.LastIndexOf('_')) : x).Contains(packName))
			{
				string entry = packName + "_" + dateStr;
				Debug.Log("DailyChallenge: Setting special pack played: " + entry);
				SaveGame.AddPlayedDailyPack(entry);
			}
		}
		else
		{
			var played = SaveGame.DailyPacksPlayed;
			if (played != null)
			{
				var toRemove = played.Where(x => x != null && x.StartsWith(packName)).ToList();
				foreach (var item in toRemove)
				{
					SaveGame.RemovePlayedDailyPack(item);
				}
			}
			string entry = packName + "_" + dateStr;
			SaveGame.AddPlayedDailyPack(entry);
		}
	}

	public static bool GetPacksForDate(DateTime d, out DailyChallengeLevelDataContainer special, out DailyChallengeLevelDataContainer normal)
	{
		normal = null;
		special = null;
		if (Instance == null) return false;

		var sp = GetSpecialPack(d);
		if (!IsPlayed(sp))
			special = sp;
		if (special != null)
			return true;

		var nm = GetNormalPack(d);
		if (!IsPlayed(nm))
			normal = nm;
		return normal != null;
	}

	private static bool IsPlayed(DailyChallengeLevelDataContainer pack)
	{
		if (pack == null) return true;
		var played = SaveGame.DailyPacksPlayed;
		if (played == null) return false;
		return played.Any(x => x != null && x.StartsWith(pack.PackName));
	}

	public static DailyChallengeLevelDataContainer GetPack()
	{
		return GetPack(GetToday());
	}

	public static DailyChallengeLevelDataContainer GetNormalPack()
	{
		return GetNormalPack(GetToday());
	}

	public static DailyChallengeLevelDataContainer GetSpecialPack()
	{
		return GetSpecialPack(GetToday());
	}

	public static bool HasSpecialBeenPlayedBefore()
	{
		var sp = GetSpecialPack(GetToday());
		if (sp != null)
			return HasSpecialBeenPlayedBefore(sp.PackName);
		return false;
	}

	public static bool HasSpecialBeenPlayedBefore(string specialId)
	{
		if (string.IsNullOrEmpty(specialId)) return false;
		var played = SaveGame.DailyPacksPlayed;
		if (played == null) return false;
		return played.Any(x => x != null && x.StartsWith(specialId));
	}

	public static DailyChallengeLevelDataContainer GetPack(DateTime day)
	{
		var sp = GetSpecialPack(day);
		if (sp != null) return sp;
		return GetNormalPack(day);
	}

	public static DailyChallengeLevelDataContainer GetNormalPack(DateTime day)
	{
		int weekNum = GetWeekNumber(day);
		int dayIdx = day.DayOfWeek == DayOfWeek.Sunday ? 6 : ((int)day.DayOfWeek - 1);
		var dailies = RuntimeStoreData.Dailies;
		if (dailies == null || dayIdx < 0 || dayIdx >= dailies.Count)
			return null;
		var arr = dailies[dayIdx];
		if (arr == null || arr.Length == 0)
			return null;
		int idx = Mathf.Abs(weekNum) % arr.Length;
		return arr[idx];
	}

	public DailyChallengeLevelDataContainer GetSpecialEventByPrizeID(string s)
	{
		var spContainer = RuntimeStoreData.SpecialPackContainer;
		if (spContainer == null || spContainer.GetContainers() == null)
			return null;
		return spContainer.GetContainers().FirstOrDefault(c => c != null && c.mountain_prize_prefab != null && c.mountain_prize_prefab.ID == s);
	}

	public static DailyChallengeLevelDataContainer GetSpecialPack(DateTime day)
	{
		var spContainer = RuntimeStoreData.SpecialPackContainer;
		if (spContainer == null || spContainer.GetContainers() == null)
			return null;
		return spContainer.GetContainers().FirstOrDefault(c => c != null && c.IsActive(day));
	}
}
