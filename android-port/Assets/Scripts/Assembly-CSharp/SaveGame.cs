using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Core;
using System.Runtime.Serialization.Formatters.Binary;
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
			get => GetValue(SAVE_POSITION, string.Empty);
			set => SetValue(SAVE_POSITION, value, true);
		}

		public string SavePositionShape
		{
			get => GetValue(SAVE_POSITION_SHAPE, Transmogrif.BALLSHAPES.ball.ToString());
			set => SetValue(SAVE_POSITION_SHAPE, value, true);
		}

		public int TimePlayed
		{
			get => GetValue(TIME_PLAYED, 0);
			set => SetValue(TIME_PLAYED, value, false);
		}

		public int TimePlayed0Pct { get => GetValue(TIME_PLAYED_0_PCT, 0); set => SetValue(TIME_PLAYED_0_PCT, value); }
		public int TimePlayed50Pct { get => GetValue(TIME_PLAYED_50_PCT, 0); set => SetValue(TIME_PLAYED_50_PCT, value); }
		public int TimePlayed75Pct { get => GetValue(TIME_PLAYED_75_PCT, 0); set => SetValue(TIME_PLAYED_75_PCT, value); }
		public int TimePlayed100Pct { get => GetValue(TIME_PLAYED_100_PCT, 0); set => SetValue(TIME_PLAYED_100_PCT, value); }

		public int OverworldStrokes { get => GetValue(OVERWORLD_STROKES, 0); set => SetValue(OVERWORLD_STROKES, value); }
		public int OverworldStrokes0Pct { get => GetValue(OVERWORLD_STROKES_0_PCT, 0); set => SetValue(OVERWORLD_STROKES_0_PCT, value); }
		public int OverworldStrokes50Pct { get => GetValue(OVERWORLD_STROKES_50_PCT, 0); set => SetValue(OVERWORLD_STROKES_50_PCT, value); }
		public int OverworldStrokes75Pct { get => GetValue(OVERWORLD_STROKES_75_PCT, 0); set => SetValue(OVERWORLD_STROKES_75_PCT, value); }
		public int OverworldStrokes100Pct { get => GetValue(OVERWORLD_STROKES_100_PCT, 0); set => SetValue(OVERWORLD_STROKES_100_PCT, value); }

		public OverWorldData(string prefix)
		{
			this.prefix = prefix ?? string.Empty;
			string p = string.IsNullOrEmpty(this.prefix) ? string.Empty : this.prefix + "_";
			ONBOARDING_COMPLETED = p + "ONBOARDING_COMPLETED";
			INTRO_ANIMATION_COMPLETED = p + "INTRO_ANIMATION_COMPLETED";
			OPEN_DOORS = p + "OPEN_DOORS";
			CONSOLES_HIT = p + "CONSOLES_HIT";
			OPEN_MAIN_DOORS = p + "OPEN_MAIN_DOORS";
			COMPLETED_LEVELS = p + "COMPLETED_LEVELS";
			ACCESSIBLE_LEVELS = p + "ACCESSIBLE_LEVELS";
			LEVEL_NOTIFICATIONS = p + "LEVEL_NOTIFICATIONS";
			COMPLETED_CHALLENGES = p + "COMPLETED_CHALLENGES";
			UNLOCKED_CHESTS = p + "UNLOCKED_CHESTS";
			CROWN_AWARENESS_MODE = p + "CROWN_AWARENESS_MODE";
			SAVE_POSITION = p + "SAVE_POSITION";
			SAVE_POSITION_SHAPE = p + "SAVE_POSITION_SHAPE";
			TIME_PLAYED = p + "TIME_PLAYED";
			TIME_PLAYED_0_PCT = p + "TIME_PLAYED_0_PCT";
			TIME_PLAYED_50_PCT = p + "TIME_PLAYED_50_PCT";
			TIME_PLAYED_75_PCT = p + "TIME_PLAYED_75_PCT";
			TIME_PLAYED_100_PCT = p + "TIME_PLAYED_100_PCT";
			OVERWORLD_STROKES = p + "OVERWORLD_STROKES";
			OVERWORLD_STROKES_0_PCT = p + "OVERWORLD_STROKES_0_PCT";
			OVERWORLD_STROKES_50_PCT = p + "OVERWORLD_STROKES_50_PCT";
			OVERWORLD_STROKES_75_PCT = p + "OVERWORLD_STROKES_75_PCT";
			OVERWORLD_STROKES_100_PCT = p + "OVERWORLD_STROKES_100_PCT";
		}
	}

	[Serializable]
	public class SaveSlot : Dictionary<string, object>
	{
	}

	[Serializable]
	public class SaveData : Dictionary<int, SaveSlot>
	{
		public DateTime created = DateTime.UtcNow;
		private Guid _uuid = Guid.NewGuid();

		public Guid UUID => _uuid;
		public long CloudMegaMergeTimestamp { get; set; }
		public string DeviceName { get; set; } = "Android";
		public string DeviceModel { get; set; } = "Android";
		public DateTime SaveTime { get; set; } = DateTime.UtcNow;

		public void UpdateUUID() => _uuid = Guid.NewGuid();
		public bool HasValidSave() => Count > 0;
		public bool IsFirstTime()
		{
			if (TryGetValue(0, out var slot) && slot != null && slot.TryGetValue(IS_FIRST_TIME, out var v))
				return Convert.ToBoolean(v);
			return true;
		}
		public int GetPartyWeight(string id, int fallback = int.MinValue) => fallback;
		public void DeletePartyWeight(string id) { }
		public void SetPartyWeight(string id, int weight) { }

		public byte[] ToBytes(bool compress = true)
		{
			string json = MegacoolThirdParty_MiniJSON.Json.Serialize(this) ?? "{}";
			byte[] raw = Encoding.UTF8.GetBytes(json);
			return compress ? Compress(raw) : raw;
		}

		public static SaveData FromBytes(byte[] bytes, out bool success)
		{
			success = false;
			if (bytes == null || bytes.Length == 0) return new SaveData();
			try
			{
				byte[] raw = bytes;
				if (bytes.Length > 2 && bytes[0] == 0x1F && bytes[1] == 0x8B)
					raw = Decompress(bytes);
				string json = Encoding.UTF8.GetString(raw);
				var dict = MegacoolThirdParty_MiniJSON.Json.Deserialize(json) as Dictionary<string, object>;
				var data = new SaveData();
				if (dict != null)
				{
					foreach (var kv in dict)
					{
						if (int.TryParse(kv.Key, out int slotIdx) && kv.Value is Dictionary<string, object> slotDict)
						{
							var slot = new SaveSlot();
							foreach (var skv in slotDict) slot[skv.Key] = skv.Value;
							data[slotIdx] = slot;
						}
					}
					success = true;
					return data;
				}
			}
			catch (Exception)
			{
			}
			return new SaveData();
		}

		public static byte[] Compress(byte[] data)
		{
			if (data == null) return new byte[0];
			using (var ms = new MemoryStream())
			{
				using (var gz = new GZipStream(ms, CompressionMode.Compress, true))
					gz.Write(data, 0, data.Length);
				return ms.ToArray();
			}
		}

		public static byte[] Decompress(byte[] data)
		{
			if (data == null) return new byte[0];
			using (var input = new MemoryStream(data))
			using (var gz = new GZipStream(input, CompressionMode.Decompress))
			using (var output = new MemoryStream())
			{
				gz.CopyTo(output);
				return output.ToArray();
			}
		}
	}

	public static Action<SaveSlot> OnSave;
	public static Action<SaveSlot> OnLoad;
	public static Action OnDataChanged;
	private static SaveData savedFields = new SaveData();
	private static DateTime lastBackup;
	public const string FILE_EXTENSION = ".golf";
	public const string FILE_NAME = "GolfSave";
	public static string FILE_NAME_WITH_EXTENSION = "GolfSave.golf";
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
	[CompilerGenerated] private static Action<int> m_OnStrokesUpdated;
	private static string _consentRequestCooldown;

	public static string Path => System.IO.Path.Combine(Application.persistentDataPath, FILE_NAME_WITH_EXTENSION);
	public static string PathBackupFolder => System.IO.Path.Combine(Application.persistentDataPath, "Backups");
	public static SaveData CurrentSave => savedFields ?? (savedFields = new SaveData());
	public static OverWorldData currentOverworld
	{
		get
		{
			EnsureCampaignDatas();
			var t = currentCampaignDef != null ? currentCampaignDef.type : ECampaignType.Main;
			if (!campaignDatas.TryGetValue(t, out var ow))
			{
				ow = new OverWorldData(t.ToString());
				campaignDatas[t] = ow;
			}
			return ow;
		}
	}

	private static PlatformSettings.PlatformConfiguration platformSettings => PlatformSettings.Instance.GetCurrent();
	public static bool loaded { get; private set; }
	public static int _activeSaveSlot => activeSaveSlot;

	public static bool IsSavedOnline { get; set; }
	public static string RemoteNotificationAppUpdatePrompt { get; set; }

	public static bool IsFirstTime
	{
		get => GetValue(IS_FIRST_TIME, true);
		set => SetValue(IS_FIRST_TIME, value, true);
	}

	public static bool HasSeenLogo
	{
		get => GetValue(HAS_SEEN_LOGO, true, SETTINGS_SAVESLOT);
		set => SetValue(HAS_SEEN_LOGO, value, true, SETTINGS_SAVESLOT);
	}

	public static int NumTimeDailyPlayed
	{
		get => GetValue(NUMBER_OF_DAILYS_PLAYED, 0);
		set => SetValue(NUMBER_OF_DAILYS_PLAYED, value, true);
	}

	public static int LastScore
	{
		get => GetValue(LAST_DAILY_SCORE, 0);
		set => SetValue(LAST_DAILY_SCORE, value, true);
	}

	public static string LastDayPlayed
	{
		get => GetValue(LAST_PLAYED_DAY, string.Empty);
		set => SetValue(LAST_PLAYED_DAY, value, true);
	}

	public static List<string> RemoteNotificationTokens => new List<string>();
	public static List<string> DailyPrizes => GetStringList(DAILYS_ANIMAL_ID);
	public static List<string> DailyPacksPlayed => GetStringList(DAILY_PACKS_PLAYED);

	public static int SecondOnboardingIndex
	{
		get => GetValue(SECOND_ONBOARDING_INDEX, 0);
		set => SetValue(SECOND_ONBOARDING_INDEX, value, true);
	}

	public static DateTime CreatedTime => CurrentSave.created;
	public static int LastDaySeenTiktok { get; set; }
	public static int TiktokIndex { get; set; }

	public static bool IsOnboardingComplete
	{
		get => GetValue(currentOverworld.ONBOARDING_COMPLETED, false);
		set => SetValue(currentOverworld.ONBOARDING_COMPLETED, value, true);
	}

	public static string Language
	{
		get => GetValue(LANGUAGE, "English", SETTINGS_SAVESLOT);
		set => SetValue(LANGUAGE, value, true, SETTINGS_SAVESLOT);
	}

	public static bool CrownAwarenessMode
	{
		get => GetValue(currentOverworld.CROWN_AWARENESS_MODE, false);
		set => SetValue(currentOverworld.CROWN_AWARENESS_MODE, value, true);
	}

	public static int TotalTimePlayed => TimePlayed;
	public static int TotalNumberOfStrokes => OverworldStrokes;

	public static int TimePlayed
	{
		get => currentOverworld.TimePlayed;
		set => currentOverworld.TimePlayed = value;
	}

	public static int SessionCount
	{
		get => GetValue(SESSION_COUNT, 0, SETTINGS_SAVESLOT);
		set
		{
			SetValue(SESSION_COUNT, value, true, SETTINGS_SAVESLOT);
			SessionCountIncremented?.Invoke();
		}
	}

	public static string SavePosition
	{
		get => currentOverworld.SavePosition;
		set => currentOverworld.SavePosition = value;
	}

	public static bool SwitchUseGyro
	{
		get => GetValue(SWITCH_USE_GYRO, false, SETTINGS_SAVESLOT);
		set => SetValue(SWITCH_USE_GYRO, value, true, SETTINGS_SAVESLOT);
	}

	public static Transmogrif.BALLSHAPES SavePositionShape
	{
		get
		{
			if (Enum.TryParse<Transmogrif.BALLSHAPES>(currentOverworld.SavePositionShape, out var shape))
				return shape;
			return Transmogrif.BALLSHAPES.ball;
		}
		set => currentOverworld.SavePositionShape = value.ToString();
	}

	public static bool IsIntroAnimationComplete
	{
		get => GetValue(currentOverworld.INTRO_ANIMATION_COMPLETED, false);
		set => SetValue(currentOverworld.INTRO_ANIMATION_COMPLETED, value, true);
	}

	public static int OverworldStrokes
	{
		get => currentOverworld.OverworldStrokes;
		set
		{
			currentOverworld.OverworldStrokes = value;
			m_OnStrokesUpdated?.Invoke(value);
		}
	}

	public static int OverworldStrokes0Pct { get => currentOverworld.OverworldStrokes0Pct; set => currentOverworld.OverworldStrokes0Pct = value; }
	public static int OverworldStrokes50Pct { get => currentOverworld.OverworldStrokes50Pct; set => currentOverworld.OverworldStrokes50Pct = value; }
	public static int OverworldStrokes75Pct { get => currentOverworld.OverworldStrokes75Pct; set => currentOverworld.OverworldStrokes75Pct = value; }
	public static int OverworldStrokes100Pct { get => currentOverworld.OverworldStrokes100Pct; set => currentOverworld.OverworldStrokes100Pct = value; }

	public static int TimePlayed0Pct { get => currentOverworld.TimePlayed0Pct; set => currentOverworld.TimePlayed0Pct = value; }
	public static int TimePlayed50Pct { get => currentOverworld.TimePlayed50Pct; set => currentOverworld.TimePlayed50Pct = value; }
	public static int TimePlayed75Pct { get => currentOverworld.TimePlayed75Pct; set => currentOverworld.TimePlayed75Pct = value; }
	public static int TimePlayed100Pct { get => currentOverworld.TimePlayed100Pct; set => currentOverworld.TimePlayed100Pct = value; }

	public static ECampaignType LastPlayedCampaignType
	{
		get => (ECampaignType)GetValue("LAST_PLAYED_CAMPAIGN_TYPE", (int)ECampaignType.Main);
		set => SetValue("LAST_PLAYED_CAMPAIGN_TYPE", (int)value, true);
	}

	public static Guid DeviceUUID => CurrentSave.UUID;

	public static event Action<int> OnStrokesUpdated
	{
		add => m_OnStrokesUpdated = (Action<int>)Delegate.Combine(m_OnStrokesUpdated, value);
		remove => m_OnStrokesUpdated = (Action<int>)Delegate.Remove(m_OnStrokesUpdated, value);
	}

	private static void EnsureCampaignDatas()
	{
		if (campaignDatas == null)
		{
			campaignDatas = new Dictionary<ECampaignType, OverWorldData>();
			foreach (ECampaignType t in Enum.GetValues(typeof(ECampaignType)))
			{
				string prefix = t == ECampaignType.Main ? string.Empty : t.ToString();
				campaignDatas[t] = new OverWorldData(prefix);
			}
		}
		if (currentCampaignDef == null)
			currentCampaignDef = new CampaignDef { type = ECampaignType.Main };
	}

	public static string GetLocalSaveFilePath(string saveFilename)
	{
		return System.IO.Path.Combine(Application.persistentDataPath, saveFilename ?? FILE_NAME_WITH_EXTENSION);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		EnsureCampaignDatas();
		if (!loaded) Load(0);
	}

	static SaveGame()
	{
		EnsureCampaignDatas();
	}

	private static void SetContentPackReleaseVersions() { }
	public static void SetContentPackReleaseVersion(string contentPackId, string bundleVersion) { }
	public static string GetContentPackReleaseVersion(string contentPackId) => Application.version;

	public static void SetOverworld(ECampaignType type)
	{
		EnsureCampaignDatas();
		currentCampaignDef = new CampaignDef { type = type };
		LastPlayedCampaignType = type;
	}

	public static int GetCompletedPercentage(ECampaignType campaignType, int? saveSlot = null, bool includeChallenges = true)
	{
		var ow = GetOverworldData(campaignType);
		if (ow == null) return 0;
		var completed = GetStringList(ow.COMPLETED_LEVELS, saveSlot);
		return Mathf.Clamp(completed.Count * 2, 0, 100);
	}

	public static OverWorldData GetOverworldData(ECampaignType type)
	{
		EnsureCampaignDatas();
		if (!campaignDatas.TryGetValue(type, out var ow))
		{
			ow = new OverWorldData(type == ECampaignType.Main ? string.Empty : type.ToString());
			campaignDatas[type] = ow;
		}
		return ow;
	}

	public static void UpdateLastSaveTime() => CurrentSave.SaveTime = DateTime.UtcNow;
	public static void UpdateDeviceName() => CurrentSave.DeviceName = SystemInfo.deviceName;
	public static void UpdateDeviceModel() => CurrentSave.DeviceModel = SystemInfo.deviceModel;
	public static void UpdateUUID() => CurrentSave.UpdateUUID();
	public static void AddOrReplaceRemoteNotificationToken(string pushNotificationToken, string deviceId) { }
	public static string GetRemoteNotificationToken(string deviceUniqueIdentifier) => string.Empty;
	public static List<string> GetDeviceIds() => new List<string>();
	public static void AddAnimal(string s) => AddToSet(DAILYS_ANIMAL_ID, s);
	public static bool GetIsSpecialPlayed(string specialId) => IsElementInList("SPECIAL_PLAYED", specialId);
	public static void SetIsSpecialPlayed(string specialId) => AddToSet("SPECIAL_PLAYED", specialId);
	public static void AddPlayedDailyPack(string s) => AddToSet(DAILY_PACKS_PLAYED, s);
	public static void RemovePlayedDailyPack(string s) => RemoveFromSet(DAILY_PACKS_PLAYED, s);
	public static DateTime GetLastTimePlayed(int saveSlot) => DateTime.UtcNow;
	public static void UpdateLastPlayedTime() => SetValue(LAST_PLAYED_TIME, DateTime.UtcNow.ToBinary(), false);
	public static void SetContentPackComplete(string contentPackId) => AddToSet("COMPLETED_PACKS", contentPackId);
	public static bool IsContentPackComplete(string contentPackId) => IsElementInList("COMPLETED_PACKS", contentPackId);
	public static bool GetIsOnboardingComplete(int saveSlot) => GetValue(GetOverworldData(ECampaignType.Main).ONBOARDING_COMPLETED, false, saveSlot);
	public static bool GetIsOnboardingComplete(int saveSlot, ECampaignType campaign) => GetValue(GetOverworldData(campaign).ONBOARDING_COMPLETED, false, saveSlot);
	public static bool GetIsLevelCompleted(string id, int? saveSlot = null) => IsElementInList(currentOverworld.COMPLETED_LEVELS, id, saveSlot);
	public static bool GetIsLevelCompleted(string id, OverWorldData data, int? saveSlot = null) => IsElementInList((data ?? currentOverworld).COMPLETED_LEVELS, id, saveSlot);
	public static List<string> CompletedLevelsInOverworld(OverWorldData data, int? saveSlot = null) => GetStringList((data ?? currentOverworld).COMPLETED_LEVELS, saveSlot);
	public static List<string> GetLevelNotifications() => GetStringList(currentOverworld.LEVEL_NOTIFICATIONS);
	public static void AddLevelNotification(string notificationId) => AddToSet(currentOverworld.LEVEL_NOTIFICATIONS, notificationId);
	public static void RemoveLevelNotification(string notificationId) => RemoveFromSet(currentOverworld.LEVEL_NOTIFICATIONS, notificationId);
	public static List<ConsentRequestTypes> ConsentedPopupRequests() => new List<ConsentRequestTypes>();
	public static void DisablePopupRequest(ConsentRequestTypes requestType) { }

	public static void SetLevelCompleted(string id)
	{
		if (!string.IsNullOrEmpty(id))
		{
			AddToSet(currentOverworld.COMPLETED_LEVELS, id);
			IsFirstTime = false;
			Save();
		}
	}

	public static bool GetIsDoorOpen(string id) => IsElementInList(currentOverworld.OPEN_DOORS, id);
	public static void SetDoorOpen(string id) => AddToSet(currentOverworld.OPEN_DOORS, id);
	public static List<string> GetConsolesHit() => GetStringList(currentOverworld.CONSOLES_HIT);
	public static void SetConsoleHit(string id) => AddToSet(currentOverworld.CONSOLES_HIT, id);
	public static bool GetIsMainDoorOpen(string id) => IsElementInList(currentOverworld.OPEN_MAIN_DOORS, id);
	public static void SetMainDoorOpen(string id) => AddToSet(currentOverworld.OPEN_MAIN_DOORS, id);

	public static List<string> GetCompletedChallenges(List<string> challengeIds, OverWorldData data = null, int? saveSlot = null)
	{
		var all = GetStringList((data ?? currentOverworld).COMPLETED_CHALLENGES, saveSlot);
		if (challengeIds == null) return all;
		return all.Where(challengeIds.Contains).ToList();
	}

	public static void AddCompletedChallenges(List<string> challengeIds)
	{
		if (challengeIds != null)
		{
			AddToSet(currentOverworld.COMPLETED_CHALLENGES, challengeIds);
			Save();
		}
	}

	public static bool GetIsChestUnlocked(string id) => IsElementInList(currentOverworld.UNLOCKED_CHESTS, id);
	public static void SetChestUnlocked(string id) => AddToSet(currentOverworld.UNLOCKED_CHESTS, id);
	public static int GetTotalPlayTime(int saveSlot) => GetValue(GetOverworldData(ECampaignType.Main).TIME_PLAYED, 0, saveSlot);
	public static void ResetSaveLoadCheck() { }
	private static void LoadCheck() { if (!loaded) Load(); }

	public static void SetSaveSlot(int saveSlot)
	{
		activeSaveSlot = saveSlot;
		EnsureSlotExists(activeSaveSlot);
		OnSaveSlotChanged?.Invoke(activeSaveSlot);
	}

	public static int GetSaveSlot() => activeSaveSlot;
	public static int GetSaveSlotOrNothing() => activeSaveSlot;
	public static int GetSaveSlotCount() => 3;
	public static void ReplaceSaveSlots(int lowestProgressionSaveslot, int fifthSaveSlot) { }

	private static SaveSlot EnsureSlotExists(int slot)
	{
		var save = CurrentSave;
		if (!save.TryGetValue(slot, out var s) || s == null)
		{
			s = new SaveSlot();
			save[slot] = s;
		}
		return s;
	}

	public static void SetValue<T>(string key, T value, bool autoSave = false, int? saveSlot = null)
	{
		if (string.IsNullOrEmpty(key)) return;
		int slotIdx = saveSlot ?? activeSaveSlot;
		var slot = EnsureSlotExists(slotIdx);
		slot[key] = value;
		OnDataChanged?.Invoke();
		if (autoSave) Save();
	}

	public static void SaveBackup() { }

	public static bool Save(bool isIcloud = false) => Save(isIcloud, null);

	private static bool Save(bool isIcloud, Action done)
	{
		try
		{
			UpdateLastSaveTime();
			var slot = EnsureSlotExists(activeSaveSlot);
			OnSave?.Invoke(slot);
			byte[] bytes = CurrentSave.ToBytes(true);
			string dir = System.IO.Path.GetDirectoryName(Path);
			if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
			string tmp = Path + ".tmp";
			File.WriteAllBytes(tmp, bytes);
			if (File.Exists(Path)) File.Delete(Path);
			File.Move(tmp, Path);
			done?.Invoke();
			return true;
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[SaveGame] Save failed: " + ex.Message);
			done?.Invoke();
			return false;
		}
	}

	public static void ConvertToJSON() { }

	public static void Load(int retries = 0)
	{
		EnsureCampaignDatas();
		try
		{
			if (File.Exists(Path))
			{
				byte[] bytes = File.ReadAllBytes(Path);
				var loadedData = SaveData.FromBytes(bytes, out bool ok);
				if (ok && loadedData != null)
					savedFields = loadedData;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[SaveGame] Load failed: " + ex.Message);
		}
		if (savedFields == null)
			savedFields = new SaveData();
		EnsureSlotExists(SETTINGS_SAVESLOT);
		EnsureSlotExists(ACHIEVEMENTS_SAVESLOT);
		EnsureSlotExists(0);
		loaded = true;
		OnLoadDone();
	}

	private static void OnLoadDone()
	{
		var slot = EnsureSlotExists(activeSaveSlot);
		OnLoad?.Invoke(slot);
	}

	public static void CreateNewCleanSave()
	{
		savedFields = new SaveData();
		EnsureSlotExists(SETTINGS_SAVESLOT);
		EnsureSlotExists(ACHIEVEMENTS_SAVESLOT);
		EnsureSlotExists(0);
		loaded = true;
		Save();
	}

	public static bool TryGetValue<T>(string key, out T value, int? saveSlot = null)
	{
		return TryGetValue(key, out value, default(T), saveSlot);
	}

	public static bool TryGetValue<T>(string key, out T value, T defaultValue, int? saveSlot = null)
	{
		value = defaultValue;
		if (string.IsNullOrEmpty(key)) return false;
		int slotIdx = saveSlot ?? activeSaveSlot;
		var slot = EnsureSlotExists(slotIdx);
		if (!slot.TryGetValue(key, out var raw) || raw == null)
			return false;
		try
		{
			if (raw is T tVal)
			{
				value = tVal;
				return true;
			}
			if (typeof(T).IsEnum)
			{
				value = (T)Enum.ToObject(typeof(T), Convert.ToInt32(raw));
				return true;
			}
			value = (T)Convert.ChangeType(raw, typeof(T));
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static T GetValue<T>(string key, T defaultValue, int? saveSlot = null)
	{
		return TryGetValue(key, out T val, defaultValue, saveSlot) ? val : defaultValue;
	}

	private static string GetSaveKeyForContentPack(string packId) => CONTENT_PACK_PLAY_COUNT_PREFIX + (packId ?? string.Empty);

	public static long GetContentPackPlayCount(string packId) => GetValue(GetSaveKeyForContentPack(packId), 0L);

	public static void IncrementContentPackPlayCount(string packId)
	{
		long cur = GetContentPackPlayCount(packId);
		SetValue(GetSaveKeyForContentPack(packId), cur + 1L, true);
	}

	public static void ResetContentPackPlayCount(string packId) => SetValue(GetSaveKeyForContentPack(packId), 0L, true);

	public static bool ContainsKey(string key, int? saveSlot = null)
	{
		int slotIdx = saveSlot ?? activeSaveSlot;
		return EnsureSlotExists(slotIdx).ContainsKey(key);
	}

	public static void ClearValue(string key, bool autoSave = true, int? saveSlot = null)
	{
		int slotIdx = saveSlot ?? activeSaveSlot;
		EnsureSlotExists(slotIdx).Remove(key);
		if (autoSave) Save();
	}

	public static void ClearSave() => CreateNewCleanSave();

	public static void ClearSaveSlot()
	{
		EnsureSlotExists(activeSaveSlot).Clear();
		OnSaveSlotDeleted?.Invoke();
		Save();
	}

	private static List<string> GetList(string key, int? saveSlot = null) => GetStringList(key, saveSlot);

	public static List<string> GetStringList(string key, int? saveSlot = null)
	{
		int slotIdx = saveSlot ?? activeSaveSlot;
		var dict = EnsureSlotExists(slotIdx);
		if (dict != null && dict.TryGetValue(key, out var raw) && raw != null)
		{
			if (raw is List<string> sList)
				return sList;
			if (raw is System.Collections.IList rawList)
			{
				var converted = new List<string>(rawList.Count);
				for (int i = 0; i < rawList.Count; i++)
				{
					if (rawList[i] != null)
						converted.Add(rawList[i].ToString());
				}
				dict[key] = converted;
				return converted;
			}
		}
		var empty = new List<string>();
		SetValue(key, empty, false, saveSlot);
		return empty;
	}

	public static void AddToSet(string key, string element, int? saveSlot = null)
	{
		if (string.IsNullOrEmpty(element)) return;
		var list = GetStringList(key, saveSlot);
		if (!list.Contains(element))
		{
			list.Add(element);
			SetValue(key, list, false, saveSlot);
		}
	}

	public static void RemoveFromSet(string key, string element, int? saveSlot = null)
	{
		var list = GetStringList(key, saveSlot);
		if (list.Remove(element))
			SetValue(key, list, false, saveSlot);
	}

	public static void AddToSet(string key, List<string> elements, int? saveSlot = null)
	{
		if (elements == null) return;
		var list = GetStringList(key, saveSlot);
		foreach (var e in elements)
		{
			if (!string.IsNullOrEmpty(e) && !list.Contains(e))
				list.Add(e);
		}
		SetValue(key, list, false, saveSlot);
	}

	public static void ClearSet(string key, int? saveSlot = null) => SetValue(key, new List<string>(), false, saveSlot);

	public static bool IsElementInList(string key, string element, int? saveSlot = null) => GetStringList(key, saveSlot).Contains(element);

	public static int GetListCount(string key, int? saveSlot = null) => GetStringList(key, saveSlot).Count;

	public static int GetListIntersectionCount(string key1, List<string> list2, int? saveSlot = null)
	{
		if (list2 == null) return 0;
		var l1 = GetStringList(key1, saveSlot);
		return l1.Count(list2.Contains);
	}

	private static bool CheckListForElement(List<string> list, string element) => list != null && list.Contains(element);

	public static bool OverWrite(SaveData newSaveData, bool isIcloud = false)
	{
		if (newSaveData != null) savedFields = newSaveData;
		return Save(isIcloud);
	}

	public static void IncrementConsentRequestCooldown() { }
	public static SnoozeData GetConsentRequestCooldown() => new SnoozeData(0, DateTime.UtcNow);
}
