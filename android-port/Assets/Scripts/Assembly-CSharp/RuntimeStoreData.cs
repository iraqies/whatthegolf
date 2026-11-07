using System.Collections.Generic;
using Core;
using UnityEngine;

public class RuntimeStoreData : ScriptableObject
{
	private const string ASSET_PATH = "Assets/Resources/RuntimeStoreData.asset";

	public Store storeType;

	public EPlatformType editorOverridePlatformType;

	public List<ContentPackDef> contentPacksDefs;

	public List<UpdateInfo> updateInfos;

	public PlatformSettings.OnlineLeaderboardType onlineLeaderboardType;

	public bool leaderboardsAutologin;

	public bool supportsAchievements;

	public bool supportsAnalytics;

	public bool analyticsRequiresConsent;

	public int analyticsBatchSize;

	public float analyticsCacheDurationHours;

	public bool allowCustomizedOutboundLinks;

	public bool notificationsEnabled;

	private static RuntimeStoreData _instance;

	private static Dictionary<string, ContentPackDef> _contentLookup;

	private static List<DailyChallengeLevelDataContainer[]> _dailyChallenges;

	private static Dictionary<string, ContentPackDef> ContentLookup => null;

	public static RuntimeStoreData instance => null;

	public ContentPackDef mainCampaignPackDef => null;

	public ContentPack mainCampaignPack => null;

	public ContentPack secondOnboarding => null;

	public ContentPack mainOnboardingPack => null;

	public ContentPackDef dailyChallengePack => null;

	public ContentPackDef specialEventsPack => null;

	public static DailyChallengeLevelDataContainerContainer DailyPackContainer => null;

	public static DailyChallengeLevelDataContainerContainer SpecialPackContainer => null;

	public static List<DailyChallengeLevelDataContainer[]> Dailies => null;

	public EPlatformType GetPlatformType(bool isBuilding)
	{
		return EPlatformType.Unknown;
	}

	public ContentPackDef TryGetContent(string contentPackID)
	{
		return null;
	}

	private ContentPackDef TryGetContent(string key, ECampaignType type)
	{
		return null;
	}

	public List<ContentPackDef> GetCampaignPackDefs()
	{
		return null;
	}
}
