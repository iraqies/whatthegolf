using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

[Serializable]
public struct WTGNotification
{
	[Serializable]
	public class LevelDataList
	{
		public List<LevelData> levels;
	}

	private const string TYPE_PACK = "pack";

	private const string TYPE_CONTENTPACK = "contentPack";

	private const string TYPE_OTHER = "other";

	[SerializeField]
	private string id;

	[SerializeField]
	private string localizationId;

	[SerializeField]
	private string localizationIdTitle;

	[SerializeField]
	private string gameboyDescription;

	[SerializeField]
	public string gameboyTitle;

	[SerializeField]
	private Sprite image;

	[SerializeField]
	private ENotificationType type;

	[SerializeField]
	private string packId;

	[SerializeField]
	private LevelDataList levels;

	[SerializeField]
	private List<UserCriteria> criteria;

	public bool skipGameboyPopup;

	[NonSerialized]
	public bool NotRecognized;

	public Func<bool> ShouldSend { get; set; }

	public string Id
	{
		get
		{
			return id;
		}
		set
		{
			id = value;
		}
	}

	public ENotificationType Type => type;

	public string LocalizationId => localizationId;

	public string LocalizationIdTitle => localizationIdTitle;

	public string GameboyDescription => gameboyDescription;

	public string GameboyTitle => gameboyTitle;

	public Sprite Image => image;

	public List<UserCriteria> Criteria => criteria;

	public List<LevelData> Levels => (type == ENotificationType.Campaign && levels != null) ? levels.levels : null;

	public bool IsValid => !string.IsNullOrEmpty(id);

	public string Text
	{
		get
		{
			if (string.IsNullOrEmpty(localizationId) && WTGSingleton<WTGNotificationsManager>.Instance != null)
			{
				string notId = id;
				List<WTGNotification> all = WTGSingleton<WTGNotificationsManager>.Instance.AllNotifications;
				if (all != null)
				{
					WTGNotification found = all.FirstOrDefault((WTGNotification x) => x.Id == notId);
					localizationId = found.localizationId;
				}
			}
			if (Localization.Instance != null && !string.IsNullOrEmpty(localizationId))
			{
				return Localization.Instance.GetString(localizationId, logFallback: false, null) ?? "";
			}
			return "";
		}
	}

	public string Title
	{
		get
		{
			if (string.IsNullOrEmpty(localizationIdTitle) && WTGSingleton<WTGNotificationsManager>.Instance != null)
			{
				string notId = id;
				List<WTGNotification> all = WTGSingleton<WTGNotificationsManager>.Instance.AllNotifications;
				if (all != null)
				{
					WTGNotification found = all.FirstOrDefault((WTGNotification x) => x.Id == notId);
					localizationIdTitle = found.localizationIdTitle;
				}
			}
			if (Localization.Instance != null && !string.IsNullOrEmpty(localizationIdTitle))
			{
				return Localization.Instance.GetString(localizationIdTitle, logFallback: false, null) ?? "";
			}
			return "";
		}
	}

	public ContentPackDef Pack
	{
		get
		{
			if (!string.IsNullOrEmpty(packId) && RuntimeStoreData.instance != null)
			{
				return RuntimeStoreData.instance.TryGetContent(packId);
			}
			return null;
		}
	}

	public IPackWithData ChallengePack
	{
		get
		{
			if (!string.IsNullOrEmpty(packId) && RuntimeStoreData.instance != null)
			{
				ContentPackDef def = RuntimeStoreData.instance.TryGetContent(packId);
				if (def != null)
				{
					string id1 = id;
					ContentPack pack = def.GetPack();
					if (pack != null && pack.levelContainer is DailyChallengeLevelDataContainerContainer container)
					{
						var containers = container.GetContainers();
						if (containers != null)
						{
							return containers.FirstOrDefault((DailyChallengeLevelDataContainer x) => x != null && x.NotificationID == id1);
						}
					}
				}
			}
			return null;
		}
	}

	public WTGNotification(string url)
	{
		id = url;
		localizationId = null;
		localizationIdTitle = null;
		gameboyDescription = null;
		gameboyTitle = null;
		image = null;
		type = ENotificationType.Simple;
		packId = null;
		levels = null;
		criteria = null;
		skipGameboyPopup = false;
		ShouldSend = null;
		NotRecognized = false;
		if (!string.IsNullOrEmpty(url))
		{
			bool isDaily = url.StartsWith("daily_");
			bool isSpecial = url.StartsWith("special_event_");
			bool isChallenge = url.StartsWith("challenge_");
			bool isLevel = url.StartsWith("level_");
			if (isLevel)
			{
				type = ENotificationType.Campaign;
				packId = "CP_MAIN_CAMPAIGN";
			}
			else if (isDaily || isSpecial || isChallenge)
			{
				type = ENotificationType.Event;
				if (isChallenge)
				{
					packId = "CP_IMPOSSIBLE_LIVING_ROOM";
				}
				else if (isSpecial)
				{
					packId = "CP_SPECIAL_EVENT";
				}
				else if (isDaily)
				{
					string[] parts = url.Split(':');
					packId = (parts.Length == 2) ? parts[1] : "CP_DAILY_CHALLENGE";
				}
			}
		}
	}

	private WTGNotification(WTGNotification other)
	{
		id = other.id;
		localizationId = other.localizationId;
		localizationIdTitle = other.localizationIdTitle;
		type = other.type;
		packId = other.packId;
		levels = other.levels;
		criteria = other.criteria;
		ShouldSend = other.ShouldSend;
		NotRecognized = other.NotRecognized;
		gameboyDescription = other.gameboyDescription;
		gameboyTitle = other.gameboyTitle;
		image = other.image;
		skipGameboyPopup = other.skipGameboyPopup;
	}

	public ScheduledNotification ToScheduled(DateTimeOffset time)
	{
		return new ScheduledNotification(this, time);
	}

	public bool ValidateCriteria(int fails = -1, string levelID = "", string packName = "", DateTime? day = null)
	{
		if (criteria != null)
		{
			return criteria.All((UserCriteria x) => x == null || x.DoesUserFit(fails, levelID, packName, day));
		}
		return true;
	}

	public override string ToString()
	{
		return id;
	}

	public override bool Equals(object other)
	{
		if (other is WTGNotification wTGNotification)
		{
			return GetHashCode() == wTGNotification.GetHashCode();
		}
		return false;
	}

	public bool Equals(WTGNotification other)
	{
		return GetHashCode() == other.GetHashCode();
	}

	public static bool operator ==(WTGNotification lhs, WTGNotification rhs)
	{
		return lhs.GetHashCode() == rhs.GetHashCode();
	}

	public static bool operator !=(WTGNotification lhs, WTGNotification rhs)
	{
		return !(lhs == rhs);
	}

	public override int GetHashCode()
	{
		int hash = ((int)type).GetHashCode();
		if (id != null)
		{
			hash = (hash * 16777619) ^ id.GetHashCode();
		}
		if (localizationId != null)
		{
			hash = (hash * 16777619) ^ localizationId.GetHashCode();
		}
		if (localizationIdTitle != null)
		{
			hash = (hash * 16777619) ^ localizationIdTitle.GetHashCode();
		}
		if (type != ENotificationType.Simple && packId != null)
		{
			hash = (hash * 16777619) ^ packId.GetHashCode();
		}
		return hash;
	}
}
