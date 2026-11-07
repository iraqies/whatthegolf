using System;
using System.Collections.Generic;
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
			return null;
		}
		set
		{
		}
	}

	public ENotificationType Type => ENotificationType.Simple;

	public string LocalizationId => null;

	public string LocalizationIdTitle => null;

	public string GameboyDescription => null;

	public string GameboyTitle => null;

	public Sprite Image => null;

	public List<UserCriteria> Criteria => null;

	public List<LevelData> Levels => null;

	public bool IsValid => false;

	public string Text => null;

	public string Title => null;

	public ContentPackDef Pack => null;

	public IPackWithData ChallengePack => null;

	public WTGNotification(string url)
	{
		id = null;
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
	}

	private WTGNotification(WTGNotification other)
	{
		id = null;
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
	}

	public ScheduledNotification ToScheduled(DateTimeOffset time)
	{
		return default;
	}

	public bool ValidateCriteria(int fails = -1, string levelID = "", string packName = "", DateTime? day = null)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(WTGNotification other)
	{
		return false;
	}

	public static bool operator ==(WTGNotification lhs, WTGNotification rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
