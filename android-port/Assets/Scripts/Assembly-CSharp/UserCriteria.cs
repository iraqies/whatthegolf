using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserCriteria : ScriptableObject
{
	[Serializable]
	[SerializeField]
	private class CampaignData
	{
		public ECampaignType pack;

		public bool useMinProgress;

		public int MinProgrees;

		public bool useMaxProgress;

		public int MaxProgrees;

		public bool useMinProgressExclusive;

		public int minProgressExclusive;

		public bool useMaxProgressExclusive;

		public int maxProgressExclusive;

		public bool includeChallengesInCalculation;

		public bool useMinTime;

		public int MinTimePlayed;

		public bool useMaxTime;

		public int MaxTimePlayed;
	}

	public string UserDescription;

	[SerializeField]
	private string requiredVersion;

	[SerializeField]
	private bool useLastPlayed;

	[SerializeField]
	private ECampaignType lastPlayedPack;

	[SerializeField]
	private bool useMinSessionCount;

	[SerializeField]
	private int minSessionCount;

	[SerializeField]
	private bool useMaxSessionCount;

	[SerializeField]
	private int maxSessionCount;

	[SerializeField]
	private List<ContentPack> NotPlayedPacks;

	[SerializeField]
	private List<ContentPack> PlayedPaks;

	[SerializeField]
	private List<string> NotPlayedSpecials;

	[SerializeField]
	private bool useMinNumDailysPlayed;

	[SerializeField]
	private int minNumDailysPlayed;

	[SerializeField]
	private bool useMaxNumDailysPlayed;

	[SerializeField]
	private int maxNumDailysPlayed;

	[SerializeField]
	private bool useIsImpossiblePlayed;

	[SerializeField]
	private bool isImpossiblePlayed;

	[SerializeField]
	private bool useMinPlayTime;

	[SerializeField]
	private int minPlayTime;

	[SerializeField]
	private bool useMaxPlayTime;

	[SerializeField]
	private int maxPlayTime;

	[SerializeField]
	private List<CampaignData> ProgressData;

	[SerializeField]
	private bool useMinSessionPlaytime;

	[SerializeField]
	private int minSessionPlaytime;

	[SerializeField]
	private bool useMaxFailsInLastLevel;

	[SerializeField]
	private int maxFailsInLastLevel;

	[SerializeField]
	private List<string> allowedLevelsToAskAfter;

	[SerializeField]
	private bool useChallengeChecks;

	[SerializeField]
	private bool requireChallengeNotPlayed;

	[SerializeField]
	private bool requireChallengePlayed;

	[SerializeField]
	private bool requireChallengeActiveToday;

	[SerializeField]
	private string requiredChallengeActiveToday;

	[SerializeField]
	private bool notPlayedTomorrowsDaily;

	[SerializeField]
	private bool useSupportedPlatforms;

	[SerializeField]
	private EPlatformType[] supportedPlatforms;

	private List<string> _reasons;

	public bool DoesUserFit(int fails = -1, string levelID = "", string packName = "", DateTime? day = null)
	{
		return false;
	}

	public bool DoesUserFit(out List<string> reasons, int fails = -1, string levelID = "", string packName = "", DateTime? day = null)
	{
		reasons = null;
		return false;
	}

	public static bool IsChallengeActiveToday(string packId, DateTime dt)
	{
		return false;
	}

	public static bool IsDailyChallengeActiveToday(string packId, DateTime dt)
	{
		return false;
	}

	public string GenerateDescription()
	{
		return null;
	}
}
