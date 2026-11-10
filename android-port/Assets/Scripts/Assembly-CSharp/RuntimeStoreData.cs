using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class RuntimeStoreData : ScriptableObject
{
	private const string ASSET_PATH = "Assets/Resources/RuntimeStoreData.asset";

	public Store storeType;
	public EPlatformType editorOverridePlatformType;
	public List<ContentPackDef> contentPacksDefs = new List<ContentPackDef>();
	public List<UpdateInfo> updateInfos = new List<UpdateInfo>();
	public PlatformSettings.OnlineLeaderboardType onlineLeaderboardType;
	public bool leaderboardsAutologin;
	public bool supportsAchievements;
	public bool supportsAnalytics;
	public bool analyticsRequiresConsent;
	public int analyticsBatchSize = 80;
	public float analyticsCacheDurationHours = 24f;
	public bool allowCustomizedOutboundLinks;
	public bool notificationsEnabled;

	private static RuntimeStoreData _instance;
	private static Dictionary<string, ContentPackDef> _contentLookup;
	private static List<DailyChallengeLevelDataContainer[]> _dailyChallenges;

	private static Dictionary<string, ContentPackDef> ContentLookup
	{
		get
		{
			if (_contentLookup == null)
				_contentLookup = new Dictionary<string, ContentPackDef>();
			return _contentLookup;
		}
	}

	public static RuntimeStoreData instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = Resources.Load<RuntimeStoreData>("RuntimeStoreData");
				if (_instance == null)
					_instance = CreateInstance<RuntimeStoreData>();
			}
			return _instance;
		}
	}

	public ContentPackDef mainCampaignPackDef => TryGetContent("CP_MAIN_CAMPAIGN", ECampaignType.Main);
	public ContentPack mainCampaignPack => mainCampaignPackDef?.pack;
	public ContentPack secondOnboarding => TryGetContent("CP_SECOND_ONBOARDING")?.pack;
	public ContentPack mainOnboardingPack => TryGetContent("CP_MAIN_ONBOARDING")?.pack;
	public ContentPackDef dailyChallengePack => TryGetContent("CP_DAILY_CHALLENGE");
	public ContentPackDef specialEventsPack => TryGetContent("CP_SPECIAL_EVENT");

	public static DailyChallengeLevelDataContainerContainer DailyPackContainer =>
		instance.dailyChallengePack?.pack?.mainContainer as DailyChallengeLevelDataContainerContainer;

	public static DailyChallengeLevelDataContainerContainer SpecialPackContainer =>
		instance.specialEventsPack?.pack?.mainContainer as DailyChallengeLevelDataContainerContainer;

	public static List<DailyChallengeLevelDataContainer[]> Dailies
	{
		get
		{
			if (_dailyChallenges == null)
			{
				var dc = DailyPackContainer;
				if (dc != null && dc.GetContainers() != null)
				{
					_dailyChallenges = dc.GetContainers()
						.GroupBy(c => c.dayOfWeek)
						.Select(g => g.ToArray())
						.ToList();
				}
				else
				{
					_dailyChallenges = new List<DailyChallengeLevelDataContainer[]>();
				}
			}
			return _dailyChallenges;
		}
	}

	public EPlatformType GetPlatformType(bool isBuilding) => EPlatformTypeExtensions.GetCurrentRuntimePlatform();

	public ContentPackDef TryGetContent(string contentPackID)
	{
		if (string.IsNullOrEmpty(contentPackID)) return null;
		if (ContentLookup.TryGetValue(contentPackID, out var cached)) return cached;
		if (contentPacksDefs != null)
		{
			var found = contentPacksDefs.FirstOrDefault(d => d != null && d.pack != null && d.pack.contentPackID == contentPackID);
			if (found == null)
			{
				if (contentPackID == "CP_HUB")
					found = contentPacksDefs.FirstOrDefault(d => d != null && d.pack != null && (d.pack.contentPackID == "CP_EPISODESHUB" || d.pack.campaignType == ECampaignType.Hub));
				else if (contentPackID == "CP_EPISODESHUB")
					found = contentPacksDefs.FirstOrDefault(d => d != null && d.pack != null && (d.pack.contentPackID == "CP_HUB" || d.pack.campaignType == ECampaignType.Hub));
			}
			if (found != null)
			{
				ContentLookup[contentPackID] = found;
				return found;
			}
		}
		return null;
	}

	private ContentPackDef TryGetContent(string key, ECampaignType type)
	{
		var byId = TryGetContent(key);
		if (byId != null) return byId;
		if (contentPacksDefs != null)
			return contentPacksDefs.FirstOrDefault(d => d != null && d.pack != null && d.pack.campaignType == type);
		return null;
	}

	public List<ContentPackDef> GetCampaignPackDefs()
	{
		if (contentPacksDefs == null) return new List<ContentPackDef>();
		return contentPacksDefs.Where(d => d != null && d.pack != null && d.accessible).ToList();
	}
}
