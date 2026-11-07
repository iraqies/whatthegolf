using System;
using System.Collections.Generic;
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

	public DateTime StartDate => default;

	public DateTime EndDate => default;

	public Sprite MenuIcon => null;

	public string TitleID => null;

	public string ContentID => null;

	public string PackID => null;

	public string PackName => null;

	public string NotificationID => null;

	public bool IsSpecial => false;

	public List<UserCriteria> Criteria => null;

	public bool HasCustomTransition => false;

	public List<PunData> SetPuns()
	{
		return null;
	}

	public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
	{
		return default;
	}

	private string ToLevelName(LevelData l)
	{
		return null;
	}

	public string PunCompletionID(LevelData level)
	{
		return null;
	}

	private string DefaultDailyIDLocalized(string id)
	{
		return null;
	}

	private string Formatted(string s)
	{
		return null;
	}

	internal string GetMenuID()
	{
		return null;
	}

	public string GetStringID()
	{
		return null;
	}

	internal int GetID()
	{
		return 0;
	}

	public bool IsActive(DateTime now)
	{
		return false;
	}
}
