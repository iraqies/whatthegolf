using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Core;
using Hub;
using UnityEngine;

[Serializable]
public class DailyChallengeLevelDataContainer : LevelDataContainer, IPackWithData
{
	[Serializable]
	public struct PunData
	{
		public string LevelName;
		public string LocalizedCompletionID;
	}

	public Sprite menuIcon;
	public DayOfWeek dayOfWeek;
	public TransitionColorDefinition transitionColors;
	public BaseTransitionEffect TransitionPrefab;
	public Sprite TransitionSilhouette;
	public bool UseSpecificDate;

	[SerializeField]
	private string startDateString;

	[SerializeField]
	private string endDateString;

	private DateTime? _startDate;
	private DateTime? _endDate;

	[SerializeField]
	private bool isNewYears;

	[SerializeField]
	private List<UserCriteria> criteria;

	public DailyPrizeData.Prize mountain_prize_prefab;
	public LevelMusicSettings music;
	public List<PunData> puns;
	public SpecialDayRoomConfig RoomConfig;

	public DateTime StartDate
	{
		get
		{
			if (!_startDate.HasValue || isNewYears)
			{
				if (DateTime.TryParse(startDateString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var parsed))
				{
					int year = DailyChallenges.GetToday().Year;
					if (isNewYears && DailyChallenges.GetToday().Month == 1 && DailyChallenges.GetToday().Day <= EndDate.Day)
					{
						year--;
					}
					_startDate = new DateTime(year, parsed.Month, parsed.Day);
				}
				else
				{
					_startDate = DateTime.MinValue;
				}
			}
			return _startDate.Value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			if (!_endDate.HasValue || isNewYears)
			{
				if (DateTime.TryParse(endDateString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var parsed))
				{
					parsed = parsed.AddDays(1.0).Subtract(TimeSpan.FromSeconds(1.0));
					int year = DailyChallenges.GetToday().Year;
					if (isNewYears && DailyChallenges.GetToday().Month == 12)
					{
						year++;
					}
					_endDate = new DateTime(year, parsed.Month, parsed.Day, 23, 59, 59);
				}
				else
				{
					_endDate = DateTime.MaxValue;
				}
			}
			return _endDate.Value;
		}
	}

	public Sprite MenuIcon => menuIcon;
	public string TitleID => "ID_DAILY_CHALLENGE_TITLE_" + PackName;
	public string ContentID => UseSpecificDate ? "CP_SPECIAL_EVENT" : "CP_DAILY_CHALLENGE";
	public string PackID => UseSpecificDate ? "CP_SPECIAL_EVENT" : "CP_DAILY_CHALLENGE";
	public string PackName => Formatted(name);
	public string NotificationID => PackName.ToLowerInvariant();
	public bool IsSpecial => UseSpecificDate;
	public List<UserCriteria> Criteria => criteria;
	public bool HasCustomTransition => TransitionPrefab != null || TransitionSilhouette != null;

	public List<PunData> SetPuns()
	{
		var lvls = GetLevelDatas();
		var list = new List<PunData>();
		if (lvls != null)
		{
			for (int i = 0; i < lvls.Count; i++)
			{
				var l = lvls[i];
				if (l == null) continue;
				string lvlName = ToLevelName(l);
				list.Add(new PunData
				{
					LevelName = lvlName,
					LocalizedCompletionID = DefaultDailyIDLocalized(lvlName)
				});
			}
		}
		puns = list;
		return puns;
	}

	public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
	{
		DateTime jan1 = new DateTime(year, 1, 1);
		int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;
		DateTime firstThursday = jan1.AddDays(daysOffset);
		var cal = CultureInfo.CurrentCulture.Calendar;
		int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
		int weekNum = weekOfYear;
		if (firstWeek == 1)
			weekNum--;
		return firstThursday.AddDays(weekNum * 7).AddDays(-3.0);
	}

	private string ToLevelName(LevelData l)
	{
		if (l == null || string.IsNullOrEmpty(l.GetID())) return string.Empty;
		return l.GetID().Replace("ID_", "");
	}

	public string PunCompletionID(LevelData level)
	{
		if (puns == null || puns.Count == 0)
			SetPuns();
		string lvlName = ToLevelName(level);
		if (puns != null)
		{
			var found = puns.Where(p => p.LevelName == lvlName);
			if (found.Any())
				return found.First().LocalizedCompletionID;
		}
		return null;
	}

	private string DefaultDailyIDLocalized(string id)
	{
		return "ID_" + PackName + "_" + Formatted(id) + "_PUN";
	}

	private string Formatted(string s)
	{
		if (string.IsNullOrEmpty(s)) return string.Empty;
		return s.Replace(" ", "_").ToUpperInvariant();
	}

	internal string GetMenuID()
	{
		return "ID_DAILY_CHALLENGE_TITLE_" + PackName;
	}

	public string GetStringID()
	{
		return PackName;
	}

	internal int GetID()
	{
		return PackName.GetHashCode();
	}

	public bool IsActive(DateTime now)
	{
		return now >= StartDate && now <= EndDate;
	}
}
