using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class SaveGame
{
	public class OverWorldData
	{
		public string prefix;

		public string ONBOARDING_COMPLETED;

		public string INTRO_ANIMATION_COMPLETED;

		public string OPEN_DOORS;

		public string CONSOLES_HIT;

		public string OPEN_MAIN_DOORS;

		public string COMPLETED_LEVELS;

		public string ACCESSIBLE_LEVELS;

		public string LEVEL_NOTIFICATIONS;

		public string COMPLETED_CHALLENGES;

		public string UNLOCKED_CHESTS;

		public string CROWN_AWARENESS_MODE;

		public string SAVE_POSITION;

		public string SAVE_POSITION_SHAPE;

		public string TIME_PLAYED;

		public string TIME_PLAYED_0_PCT;

		public string TIME_PLAYED_50_PCT;

		public string TIME_PLAYED_75_PCT;

		public string TIME_PLAYED_100_PCT;

		public string OVERWORLD_STROKES;

		public string OVERWORLD_STROKES_0_PCT;

		public string OVERWORLD_STROKES_50_PCT;

		public string OVERWORLD_STROKES_75_PCT;

		public string OVERWORLD_STROKES_100_PCT;

		public string SavePosition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SavePositionShape
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int TimePlayed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TimePlayed0Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TimePlayed50Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TimePlayed75Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TimePlayed100Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int OverworldStrokes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int OverworldStrokes0Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int OverworldStrokes50Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int OverworldStrokes75Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int OverworldStrokes100Pct
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public OverWorldData(string prefix)
		{
		}
	}

	[Serializable]
	public class SaveSlot : Dictionary<string, object>
	{
	}

	[Serializable]
	public class SaveData : Dictionary<int, SaveSlot>
	{
		public DateTime created;

		public Guid UUID => default;

		public long CloudMegaMergeTimestamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string DeviceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeviceModel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime SaveTime
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public void UpdateUUID()
		{
		}

		public bool HasValidSave()
		{
			return false;
		}

		public bool IsFirstTime()
		{
			return false;
		}

		public int GetPartyWeight(string id, int fallback = int.MinValue)
		{
			return 0;
		}

		public void DeletePartyWeight(string id)
		{
		}

		public void SetPartyWeight(string id, int weight)
		{
		}

		public byte[] ToBytes(bool compress = true)
		{
			return null;
		}

		public static SaveData FromBytes(byte[] bytes, out bool success)
		{
			success = default;
			return null;
		}

		public static byte[] Compress(byte[] data)
		{
			return null;
		}

		public static byte[] Decompress(byte[] data)
		{
			return null;
		}
	}

	public static Action<SaveSlot> OnSave;

	public static Action<SaveSlot> OnLoad;

	public static Action OnDataChanged;

	private static SaveData savedFields;

	private static DateTime lastBackup;

	public const string FILE_EXTENSION = ".golf";

	public const string FILE_NAME = "GolfSave";

	public static string FILE_NAME_WITH_EXTENSION;

	public static Action<int> OnSaveSlotChanged;

	public static Action OnSaveSlotDeleted;

	private const string VERSION = "VERSION";

	public const int SETTINGS_SAVESLOT = -1;

	public const int ACHIEVEMENTS_SAVESLOT = -2;

	public const string ACTIVE_SAVESLOT = "ACTIVE_SAVESLOT";

	public const string IS_FIRST_TIME = "IS_FIRST_TIME";

	public const string SECOND_ONBOARDING_INDEX = "SECOND_ONBOARDING_INDEX";

	public const string HAS_SEEN_LOGO = "HAS_SEEN_LOGO";

	public const string CREATED_TIME = "CREATED_TIME";

	private const string LANGUAGE = "LANGUAGE";

	private const string LAST_SAVE_TIME = "LAST_SAVE_TIME";

	private const string DEVICE_UUID = "DEVICE_UUID";

	private const string DEVICE_NAME = "DEVICE_NAME";

	private const string CLOUD_MEGA_MERGE_TIMESTAMP = "CLOUD_MEGA_MERGE_TIMESTAMP";

	private const string DEVICE_MODEL = "DEVICE_MODEL";

	public const string SESSION_COUNT = "SESSION_COUNT";

	public const string APPLE_SESSION_COUNT = "APPLE_SESSION_COUNT";

	private const string SWITCH_USE_GYRO = "SWITCH_USE_GYRO";

	public const string SAVESLOT_ID = "SAVESLOT_ID";

	public const string LAST_UPDATE_DISPLAY_TIME = "LAST_UPDATE_DISPLAY_TIME_UTC";

	public const string CONTENT_PACK_PLAY_COUNT_PREFIX = "CONTENT_PACK_PLAY_COUNT_";

	public const string UPDATE_SEEN_DATE_PREFIX = "UPDATE_SEEN_DATE_";

	public const string ASKED_ABOUT_REVIEW = "ASKED_ABOUT_REVIEW";

	public const string ASKED_ABOUT_EMAIL = "ASKED_ABOUT_EMAIL";

	public const string SHOWN_MULTIPLE_SAVES_WARNING = "SHOWN_MULTIPLE_SAVES_WARNING";

	private const string LOCAL_UUID = "LOCAL_UUID";

	private const string PARTY_WEIGHTS = "PARTY_WEIGHTS_";

	public const string LAST_PLAYED_TIME = "LAST_PLAYED_TIME";

	public const string NUMBER_OF_DAILYS_PLAYED = "NUMBER_OF_DAILYS_PLAYED";

	public const string DAILY_PACKS_PLAYED = "DAILY_PACKS_PLAYED";

	public const string DAILYS_ANIMAL_ID = "DAILYS_ANIMAL_ID";

	public const string LAST_PLAYED_DAY = "LAST_PLAYED_DAY";

	public const string LAST_DAILY_SCORE = "LAST_DAILY_SCORE";

	public const string REMOTE_NOTIFICATION_TOKENS = "REMOTE_NOTIFICATION_TOKENS";

	public const string REMOTE_NOTIFICATION_DEVICE_IDS = "REMOTE_NOTIFICATION_DEVICE_IDS";

	public static Dictionary<ECampaignType, OverWorldData> campaignDatas;

	public static CampaignDef currentCampaignDef;

	private static int activeSaveSlot;

	private const int buildVersion = 1;

	private const string TAG = "SaveGame";

	private static readonly pLogger dbg;

	private static readonly pLogger dbg_detail;

	private const string IS_SAVED_ONLINE = "IS_SAVED_ONLINE_{0}";

	public static Action SessionCountIncremented;

	[CompilerGenerated]
	private static Action<int> m_OnStrokesUpdated;

	private static string _consentRequestCooldown;

	public static string Path => null;

	public static string PathBackupFolder => null;

	public static SaveData CurrentSave => null;

	public static OverWorldData currentOverworld => null;

	private static PlatformSettings.PlatformConfiguration platformSettings => null;

	public static bool loaded { get; private set; }

	public static int _activeSaveSlot => 0;

	public static bool IsSavedOnline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string RemoteNotificationAppUpdatePrompt
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool IsFirstTime
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HasSeenLogo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int NumTimeDailyPlayed
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LastScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static string LastDayPlayed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static List<string> RemoteNotificationTokens => null;

	public static List<string> DailyPrizes => null;

	public static List<string> DailyPacksPlayed => null;

	public static int SecondOnboardingIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static DateTime CreatedTime => default;

	public static int LastDaySeenTiktok
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TiktokIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool IsOnboardingComplete
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string Language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool CrownAwarenessMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int TotalTimePlayed => 0;

	public static int TotalNumberOfStrokes => 0;

	public static int TimePlayed
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int SessionCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static string SavePosition
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool SwitchUseGyro
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Transmogrif.BALLSHAPES SavePositionShape
	{
		get
		{
			return Transmogrif.BALLSHAPES.ball;
		}
		set
		{
		}
	}

	public static bool IsIntroAnimationComplete
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int OverworldStrokes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int OverworldStrokes0Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int OverworldStrokes50Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int OverworldStrokes75Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int OverworldStrokes100Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TimePlayed0Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TimePlayed50Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TimePlayed75Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TimePlayed100Pct
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ECampaignType LastPlayedCampaignType
	{
		get
		{
			return ECampaignType.None;
		}
		set
		{
		}
	}

	public static Guid DeviceUUID => default;

	public static event Action<int> OnStrokesUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static string GetLocalSaveFilePath(string saveFilename)
	{
		return null;
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private static void SetContentPackReleaseVersions()
	{
	}

	public static void SetContentPackReleaseVersion(string contentPackId, string bundleVersion)
	{
	}

	public static string GetContentPackReleaseVersion(string contentPackId)
	{
		return null;
	}

	public static void SetOverworld(ECampaignType type)
	{
	}

	public static int GetCompletedPercentage(ECampaignType campaignType, int? saveSlot = null, bool includeChallenges = true)
	{
		return 0;
	}

	public static OverWorldData GetOverworldData(ECampaignType type)
	{
		return null;
	}

	static SaveGame()
	{
	}

	public static void UpdateLastSaveTime()
	{
	}

	public static void UpdateDeviceName()
	{
	}

	public static void UpdateDeviceModel()
	{
	}

	public static void UpdateUUID()
	{
	}

	public static void AddOrReplaceRemoteNotificationToken(string pushNotificationToken, string deviceId)
	{
	}

	public static string GetRemoteNotificationToken(string deviceUniqueIdentifier)
	{
		return null;
	}

	public static List<string> GetDeviceIds()
	{
		return null;
	}

	public static void AddAnimal(string s)
	{
	}

	public static bool GetIsSpecialPlayed(string specialId)
	{
		return false;
	}

	public static void SetIsSpecialPlayed(string specialId)
	{
	}

	public static void AddPlayedDailyPack(string s)
	{
	}

	public static void RemovePlayedDailyPack(string s)
	{
	}

	public static DateTime GetLastTimePlayed(int saveSlot)
	{
		return default;
	}

	public static void UpdateLastPlayedTime()
	{
	}

	public static void SetContentPackComplete(string contentPackId)
	{
	}

	public static bool IsContentPackComplete(string contentPackId)
	{
		return false;
	}

	public static bool GetIsOnboardingComplete(int saveSlot)
	{
		return false;
	}

	public static bool GetIsOnboardingComplete(int saveSlot, ECampaignType campaign)
	{
		return false;
	}

	public static bool GetIsLevelCompleted(string id, int? saveSlot = null)
	{
		return false;
	}

	public static bool GetIsLevelCompleted(string id, OverWorldData data, int? saveSlot = null)
	{
		return false;
	}

	public static List<string> CompletedLevelsInOverworld(OverWorldData data, int? saveSlot = null)
	{
		return null;
	}

	public static List<string> GetLevelNotifications()
	{
		return null;
	}

	public static void AddLevelNotification(string notificationId)
	{
	}

	public static void RemoveLevelNotification(string notificationId)
	{
	}

	public static List<ConsentRequestTypes> ConsentedPopupRequests()
	{
		return null;
	}

	public static void DisablePopupRequest(ConsentRequestTypes requestType)
	{
	}

	public static void SetLevelCompleted(string id)
	{
	}

	public static bool GetIsDoorOpen(string id)
	{
		return false;
	}

	public static void SetDoorOpen(string id)
	{
	}

	public static List<string> GetConsolesHit()
	{
		return null;
	}

	public static void SetConsoleHit(string id)
	{
	}

	public static bool GetIsMainDoorOpen(string id)
	{
		return false;
	}

	public static void SetMainDoorOpen(string id)
	{
	}

	public static List<string> GetCompletedChallenges(List<string> challengeIds, OverWorldData data = null, int? saveSlot = null)
	{
		return null;
	}

	public static void AddCompletedChallenges(List<string> challengeIds)
	{
	}

	public static bool GetIsChestUnlocked(string id)
	{
		return false;
	}

	public static void SetChestUnlocked(string id)
	{
	}

	public static int GetTotalPlayTime(int saveSlot)
	{
		return 0;
	}

	public static void ResetSaveLoadCheck()
	{
	}

	private static void LoadCheck()
	{
	}

	public static void SetSaveSlot(int saveSlot)
	{
	}

	public static int GetSaveSlot()
	{
		return 0;
	}

	public static int GetSaveSlotOrNothing()
	{
		return 0;
	}

	public static int GetSaveSlotCount()
	{
		return 0;
	}

	public static void ReplaceSaveSlots(int lowestProgressionSaveslot, int fifthSaveSlot)
	{
	}

	public static void SetValue<T>(string key, T value, bool autoSave = false, int? saveSlot = null)
	{
	}

	public static void SaveBackup()
	{
	}

	public static bool Save(bool isIcloud = false)
	{
		return false;
	}

	private static bool Save(bool isIcloud, Action done)
	{
		return false;
	}

	public static void ConvertToJSON()
	{
	}

	public static void Load(int retries = 0)
	{
	}

	private static void OnLoadDone()
	{
	}

	public static void CreateNewCleanSave()
	{
	}

	public static bool TryGetValue<T>(string key, out T value, int? saveSlot = null)
	{
		value = default;
		return false;
	}

	public static bool TryGetValue<T>(string key, out T value, T defaultValue, int? saveSlot = null)
	{
		value = default;
		return false;
	}

	public static T GetValue<T>(string key, T defaultValue, int? saveSlot = null)
	{
		return default;
	}

	private static string GetSaveKeyForContentPack(string packId)
	{
		return null;
	}

	public static long GetContentPackPlayCount(string packId)
	{
		return 0L;
	}

	public static void IncrementContentPackPlayCount(string packId)
	{
	}

	public static void ResetContentPackPlayCount(string packId)
	{
	}

	public static bool ContainsKey(string key, int? saveSlot = null)
	{
		return false;
	}

	public static void ClearValue(string key, bool autoSave = true, int? saveSlot = null)
	{
	}

	public static void ClearSave()
	{
	}

	public static void ClearSaveSlot()
	{
	}

	private static List<string> GetList(string key, int? saveSlot = null)
	{
		return null;
	}

	public static List<string> GetStringList(string key, int? saveSlot = null)
	{
		return null;
	}

	public static void AddToSet(string key, string element, int? saveSlot = null)
	{
	}

	public static void RemoveFromSet(string key, string element, int? saveSlot = null)
	{
	}

	public static void AddToSet(string key, List<string> elements, int? saveSlot = null)
	{
	}

	public static void ClearSet(string key, int? saveSlot = null)
	{
	}

	public static bool IsElementInList(string key, string element, int? saveSlot = null)
	{
		return false;
	}

	public static int GetListCount(string key, int? saveSlot = null)
	{
		return 0;
	}

	public static int GetListIntersectionCount(string key1, List<string> list2, int? saveSlot = null)
	{
		return 0;
	}

	private static bool CheckListForElement(List<string> list, string element)
	{
		return false;
	}

	public static bool OverWrite(SaveData newSaveData, bool isIcloud = false)
	{
		return false;
	}

	public static void IncrementConsentRequestCooldown()
	{
	}

	public static SnoozeData GetConsentRequestCooldown()
	{
		return null;
	}
}
