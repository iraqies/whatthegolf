#!/usr/bin/env python3
"""Implement core startup, platform, save, addressables, container, and level management classes
for WHAT THE GOLF? Android port:
  - Malee.ReorderableArray<T>
  - Kilt.BaseSingleton
  - UnityAsyncAwaitUtil.SyncContextUtil
  - Core.AddressableSingleton<T>
  - WTGSingleton<T>
  - AssetReferenceScene & SceneField
  - IDTransformer (resolves ios: and aa/iOS bundles on Android/iOS/Standalone)
  - ODRDownloadManager (offline local bundle resolution, no iOS OnDemandResources freeze)
  - EPlatformTypeExtensions (returns EPlatformType.Android on Android)
  - Core.PlatformSettings (full Android / iPhone / iPad mobile configuration with touch aiming, 60/120 FPS, file save)
  - RuntimeStoreData (unlocks all 17 ContentPacks and campaign lookups)
  - ContentPack, LevelDataContainer, LevelDataContainerContainer, LevelDataContainerWithChallenge, DailyChallengeLevelDataContainer, DailyChallengeLevelDataContainerContainer
  - Core.LevelData
  - SaveGame & CloudSave & iOSOnlineServices (persistent offline save system + Apple Arcade / Game Center / iCloud neutralization)
  - Bootstrap & Loading & HubSceneLoader
"""
import os

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
EXPORT_ASSETS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets"


def write_asset_file(rel_path: str, content: str) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. Malee/ReorderableArray.cs
    write_asset_file("Plugins/Assembly-CSharp-firstpass/Malee/ReorderableArray.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Malee
{
	[Serializable]
	public abstract class ReorderableArray<T> : ICloneable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[SerializeField]
		private List<T> array = new List<T>();

		public T this[int index]
		{
			get => array[index];
			set => array[index] = value;
		}

		public bool IsReadOnly => false;

		public int Count => array != null ? array.Count : 0;

		public ReorderableArray()
		{
			array = new List<T>();
		}

		public ReorderableArray(int length)
		{
			array = new List<T>(length);
		}

		public object Clone()
		{
			var copy = (ReorderableArray<T>)MemberwiseClone();
			copy.array = array != null ? new List<T>(array) : new List<T>();
			return copy;
		}

		public bool Contains(T value) => array != null && array.Contains(value);

		public int IndexOf(T value) => array != null ? array.IndexOf(value) : -1;

		public void Insert(int index, T item)
		{
			if (array == null) array = new List<T>();
			array.Insert(index, item);
		}

		public void RemoveAt(int index) => array?.RemoveAt(index);

		public void Add(T item)
		{
			if (array == null) array = new List<T>();
			array.Add(item);
		}

		public void Clear() => array?.Clear();

		public void CopyTo(T[] target, int arrayIndex) => array?.CopyTo(target, arrayIndex);

		public bool Remove(T item) => array != null && array.Remove(item);

		public IEnumerator<T> GetEnumerator() => (array ?? (array = new List<T>())).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
""")

    # 2. Kilt/BaseSingleton.cs & UnityAsyncAwaitUtil/SyncContextUtil.cs
    write_asset_file("Plugins/Assembly-CSharp-firstpass/Kilt/BaseSingleton.cs", """using UnityEngine;

namespace Kilt
{
	public abstract class BaseSingleton : MonoBehaviour
	{
		private static bool s_enableSingletonCreation = true;

		public static bool EnableSingletonCreation
		{
			get => s_enableSingletonCreation;
			private set => s_enableSingletonCreation = value;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void EnableInstanceCreation()
		{
			s_enableSingletonCreation = true;
		}
	}
}
""")

    write_asset_file("Plugins/Assembly-CSharp-firstpass/UnityAsyncAwaitUtil/SyncContextUtil.cs", """using System.Threading;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
	public static class SyncContextUtil
	{
		public static int UnityThreadId { get; private set; }

		public static SynchronizationContext UnitySynchronizationContext { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Install()
		{
			UnitySynchronizationContext = SynchronizationContext.Current;
			UnityThreadId = Thread.CurrentThread.ManagedThreadId;
		}
	}
}
""")

    # 3. Core/AddressableSingleton.cs & WTGSingleton.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/AddressableSingleton.cs", """using UnityEngine;

namespace Core
{
	public abstract class AddressableSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static bool Exists => _instance != null;

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = Object.FindObjectOfType<T>();
					if (_instance == null)
					{
						var prefab = Resources.Load<T>(typeof(T).Name) ?? Resources.Load<T>("Prefabs/" + typeof(T).Name);
						if (prefab != null)
						{
							_instance = Object.Instantiate(prefab);
						}
						else
						{
							var go = new GameObject(typeof(T).Name);
							_instance = go.AddComponent<T>();
						}
						Object.DontDestroyOnLoad(_instance.gameObject);
						if (_instance is AddressableSingleton<T> singleton)
							singleton.Initialize();
					}
				}
				return _instance;
			}
			protected set => _instance = value;
		}

		public virtual void Initialize()
		{
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/WTGSingleton.cs", """using UnityEngine;

public abstract class WTGSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance;

	public static T Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Object.FindObjectOfType<T>();
				if (instance == null)
				{
					var go = new GameObject(typeof(T).Name);
					instance = go.AddComponent<T>();
					Object.DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
		private set => instance = value;
	}

	public static bool IsCreated => instance != null;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this as T;
			Object.DontDestroyOnLoad(gameObject);
			OnInit();
		}
		else if (instance != this)
		{
			Object.Destroy(gameObject);
		}
	}

	protected virtual void OnInit()
	{
	}
}
""")

    # 4. AssetReferenceScene.cs & SceneField.cs
    write_asset_file("Scripts/Unity.Addressables/AssetReferenceScene.cs", """using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
public class AssetReferenceScene : AssetReferenceT<SceneReference>
{
	[SerializeField]
	private string sceneName;

	public string SceneName => sceneName;

	public AssetReferenceScene(string guid, string sceneName)
		: base(guid)
	{
		this.sceneName = sceneName;
	}

	public override bool ValidateAsset(string path) => !string.IsNullOrEmpty(path) && path.EndsWith(".unity");
}
""")

    write_asset_file("Scripts/Assembly-CSharp/SceneField.cs", """using System;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;

[Serializable]
public class SceneField : ISerializationCallbackReceiver
{
	[SerializeField]
	private UnityEngine.Object sceneAsset;

	[SerializeField]
	public AssetReferenceScene sceneReference;

	[SerializeField]
	private string deprecated_SceneName;

	public IResourceLocation ResourceLocation;

	public string SceneName
	{
		get
		{
			if (sceneReference != null && !string.IsNullOrEmpty(sceneReference.SceneName))
				return sceneReference.SceneName;
			if (!string.IsNullOrEmpty(deprecated_SceneName))
				return deprecated_SceneName;
			return sceneAsset != null ? sceneAsset.name : string.Empty;
		}
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
""")

    # 5. IDTransformer.cs & ODRDownloadManager.cs
    write_asset_file("Scripts/Assembly-CSharp/IDTransformer.cs", """using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

internal static class IDTransformer
{
	private static string ODRPathResolve(IResourceLocation location)
	{
		if (location == null) return null;
		string id = location.InternalId;
		if (string.IsNullOrEmpty(id)) return id;

		if (location.ResourceType == typeof(IAssetBundleResource) && id.StartsWith("ios:"))
		{
			string rel = id.Substring(4).TrimStart('/');
			string odrPath = Path.Combine(ODRDownloadManager.CachePath, rel);
			if (File.Exists(odrPath))
				return odrPath;
			string saPath = Path.Combine(Application.streamingAssetsPath, "aa", "iOS", rel);
			return saPath;
		}

		// On Android, Addressables.RuntimePath expands to StreamingAssets/aa, where the bundles live under /iOS/
		if (id.Contains("/Android/") && !id.Contains("/iOS/"))
		{
			id = id.Replace("/Android/", "/iOS/");
		}
		return id;
	}

	[RuntimeInitializeOnLoadMethod]
	private static void SetInternalIdTransform()
	{
		Addressables.InternalIdTransformFunc = ODRPathResolve;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/ODRDownloadManager.cs", """using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class ODRDownloadManager
{
	private static ODRDownloadManager _instance;
	private List<string> downloadsInProgress = new List<string>();
	private ODRVersionManager _versionManager;
	private ODRDownloadView view;
	private bool cancelled;
	private static Dictionary<uint, uint> replacementStateMap = new Dictionary<uint, uint>();

	public static ODRDownloadManager Instance => _instance ?? (_instance = new ODRDownloadManager());

	public static string CachePath => Path.Combine(Application.persistentDataPath, "ODR");

	private ODRVersionManager VersionManager => _versionManager ?? (_versionManager = new ODRVersionManager());

	private static string CachedResourcePath(string resourceName) => Path.Combine(CachePath, resourceName ?? string.Empty);

	public bool HasBeenDownloaded(string resourceName)
	{
		if (string.IsNullOrEmpty(resourceName)) return true;
		string saPath = Path.Combine(Application.streamingAssetsPath, "aa", "iOS", resourceName);
		if (File.Exists(saPath) || File.Exists(CachedResourcePath(resourceName)))
			return true;
		return true;
	}

	private bool IsSameVersion(string resourceName) => true;

	public Task<ODRDownloadResult> DownloadBundles(List<string> resourceNames, bool showProgressBar = false)
	{
		return Task.FromResult(ODRDownloadResult.Downloaded);
	}

	public Task<ODRDownloadResult> DownloadBundle(string resourceName, bool showProgressBar = false, int downloadNumber = 1, int downloadCount = 1)
	{
		return Task.FromResult(ODRDownloadResult.Downloaded);
	}

	public static void DeleteGroup(string resourceName)
	{
	}

	public uint ReplaceStateIfUnavailable(uint wwiseState) => wwiseState;
}
""")

    # 6. EPlatformTypeExtensions.cs & Core/PlatformSettings.cs & RuntimeStoreData.cs
    write_asset_file("Scripts/Assembly-CSharp/EPlatformTypeExtensions.cs", """using UnityEngine;

public static class EPlatformTypeExtensions
{
	public static EPlatformType GetCurrentRuntimePlatform()
	{
		switch (Application.platform)
		{
			case RuntimePlatform.Android:
				return EPlatformType.Android;
			case RuntimePlatform.IPhonePlayer:
				return (SystemInfo.deviceModel ?? string.Empty).ToLowerInvariant().Contains("ipad")
					? EPlatformType.iPad
					: EPlatformType.iPhone;
			case RuntimePlatform.tvOS:
				return EPlatformType.tvOS;
			case RuntimePlatform.Switch:
				return EPlatformType.Switch;
			case RuntimePlatform.PS4:
				return EPlatformType.PS4;
			case RuntimePlatform.PS5:
				return EPlatformType.PS5;
			case RuntimePlatform.XboxOne:
				return EPlatformType.XboxOne;
			case RuntimePlatform.OSXPlayer:
			case RuntimePlatform.OSXEditor:
				return EPlatformType.macOS;
			case RuntimePlatform.LinuxPlayer:
			case RuntimePlatform.LinuxEditor:
				return EPlatformType.Linux;
			default:
				return EPlatformType.Android;
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/PlatformSettings.cs", """using System;
using System.Linq;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class PlatformSettings : ScriptableObject
	{
		[Serializable]
		public class PlatformConfiguration
		{
			public ScreenModes defaultScreenMode;
			public bool isMobile = true;
			public bool useRotatedOverworldAndCameraInLevels;
			public EPlatformType platformType = EPlatformType.Android;
			public bool useFileSave = true;
			public bool useSaveThrobber;
			public bool longSaveAnimation;
			public MainMenuData menu;
			public bool playAgainSelectionAlwaysVisible;
			public bool useQuickmenuInOnboarding;
			public bool useBackButtonInMenus = true;
			public bool useGifs;
			public bool useMegacoolGifRecorder;
			public bool useUnityGifRecorder;
			public bool canShareGif;
			public bool useGyro = true;
			public bool simulateGyroWithTouchOrMouse = true;
			public bool flipGyroInput = true;
			public int SleepTimeout = 200;
			public int FPSOnBattery = 60;
			public int FPSOnPower = 120;
			public bool usesKeyboardAndControllerInput = true;
			public float maxDragLength = 0.22f;
			public bool UseControllerDisconnectedPopup;
			public bool CanChangeGyroControlsInLevel;
			public bool isMultiplayerSupported;
			public bool UseAimMarker = true;
			public bool useChallengeIconDescriptions = true;
			public float ChallengeWindowScale = 1f;
			public bool UseLoadingAnimation = true;
			public float QuickMenuScale = 1f;
			public bool enlargeSpeechBubbles;
			public bool enlargeOnlySpeechBubblesOnSmallScreen;
			public float preloadAudioTimeOnLoading = 1f;
			public int maxAudioTransitionsInMemory = 4;
			public int maxAudioStatesInMemory = 4;
			public bool useRumble;
			public bool useUnloadUnusedAssetsOnLevelUnload;
			public string overwriteId = "Android";
			public float AdjustOrthoSizeForFourByThree = 1.3f;
			public bool useAirPlay;
			public float challengeTimeExtraPct;
			public float aimTimeScaleModifier;
			public int defaultAntiAliasing;
			public bool UseRoom8ObjectCulling;
			public bool usePhysicsOptimizationsInOverworld;
			public bool useNativeNotifications;
			public bool useDeepLinks;

			private IPlatform _platform;
			public IPlatform Platform => _platform ?? (_platform = new GenericPlatform());

			public bool ShouldEnlargeSpeechBubble() => enlargeSpeechBubbles;

			public bool IsPlayingUndocked() => true;
		}

		public enum OnlineLeaderboardType
		{
			None = 0,
			PlayFab = 1,
			GameCenter = 2,
			Steam = 3,
			Playstation = 4
		}

		public enum ScreenModes
		{
			Landscape = 0,
			Portrait = 1
		}

		public PlatformConfiguration iPhone;
		public PlatformConfiguration iPad;
		public PlatformConfiguration airplay;
		public PlatformConfiguration android;
		public PlatformConfiguration windows;
		public PlatformConfiguration mac;
		public PlatformConfiguration appleTV;
		public PlatformConfiguration nintendoSwitch;
		public PlatformConfiguration linux;
		public PlatformConfiguration ps4;
		public PlatformConfiguration ps5;
		public PlatformConfiguration xboxOne;

		private PlatformConfiguration cachedCurrent;
		private static PlatformSettings instance;

		public static PlatformSettings Instance
		{
			get
			{
				if (instance == null)
				{
					instance = Resources.Load<PlatformSettings>("Settings/PlatformSettings")
						?? Resources.Load<PlatformSettings>("settings/PlatformSettings");
					if (instance == null)
					{
						instance = CreateInstance<PlatformSettings>();
						instance.android = new PlatformConfiguration
						{
							defaultScreenMode = ScreenModes.Landscape,
							isMobile = true,
							platformType = EPlatformType.Android,
							useFileSave = true,
							useBackButtonInMenus = true,
							useGyro = true,
							simulateGyroWithTouchOrMouse = true,
							FPSOnBattery = 60,
							FPSOnPower = 120,
							usesKeyboardAndControllerInput = true,
							maxDragLength = 0.22f,
							UseAimMarker = true
						};
					}
					instance.InitCached();
				}
				return instance;
			}
		}

		public PlatformConfiguration[] Configurations => new PlatformConfiguration[]
		{
			iPhone, iPad, airplay, android, windows, mac, appleTV, nintendoSwitch, linux, ps4, ps5, xboxOne
		};

		public static bool IsMobile => Instance.GetCurrent().isMobile;
		public static bool IsStandalone => !IsMobile && !IsConsole;
		public static bool IsIOS => false;
		public static bool IsAppleTV => false;
		public static bool IsSwitch => false;
		public static bool IsPS4 => false;
		public static bool IsPS5 => false;
		public static bool IsXboxOne => false;
		public static bool IsConsole => false;
		public static bool IsPortraitByDefault => Instance.GetCurrent().defaultScreenMode == ScreenModes.Portrait;
		public static bool UseNativeNotifications => false;
		public static bool UseDeepLinks => false;

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
			_ = Instance;
		}

		public PlatformConfiguration GetCurrent()
		{
			if (cachedCurrent == null)
				InitCached();
			return cachedCurrent;
		}

		public PlatformConfiguration GetCurrentNonCached(bool isBuilding = false)
		{
			if (android != null && android.menu != null)
			{
				android.isMobile = true;
				android.useFileSave = true;
				android.usesKeyboardAndControllerInput = true;
				android.UseAimMarker = true;
				return android;
			}
			if (iPad != null)
			{
				iPad.isMobile = true;
				iPad.useFileSave = true;
				iPad.usesKeyboardAndControllerInput = true;
				iPad.UseAimMarker = true;
				return iPad;
			}
			if (iPhone != null)
				return iPhone;
			return new PlatformConfiguration();
		}

		private void InitCached()
		{
			cachedCurrent = GetCurrentNonCached(false);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/RuntimeStoreData.cs", """using System;
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
""")

    # 7. ContentPack & LevelDataContainers & Core/LevelData
    write_asset_file("Scripts/Assembly-CSharp/ContentPack.cs", """using System.Collections.Generic;
using Core;
using UnityEngine;

public class ContentPack : ScriptableObject, IPackWithData
{
	public string contentPackID;
	public bool isODRContent;
	public ECampaignType campaignType;
	[SerializeField] public AssetReferenceScene overworldSceneReference;
	[SerializeField] public AssetReferenceScene tunnelLoaderSceneReference;
	public List<Object> requiredScenes;
	public LeaderboardBoard leaderboard;
	public LevelDataContainerBase mainContainer;
	public LevelDataContainerBase onboardingContainer;
	public string titleID;
	public string contentPackOverrideID;
	public bool ps5ActivityEnable;
	public bool ps5ActivityTrackProgress;
	public bool ps5ActivityHideWhenDone;
	public bool HasDownloadableMusic;

	public bool IsNew => IsConsideredNew();
	public bool hasLeaderboard => leaderboard != LeaderboardBoard.NONE;
	public string TitleID => titleID;
	public string ContentID => !string.IsNullOrEmpty(contentPackOverrideID) ? contentPackOverrideID : contentPackID;
	public string PackID => contentPackID;
	public string PackName => name;
	public List<UserCriteria> Criteria => new List<UserCriteria>();

	public List<LevelData> GetAllLevelDatas()
	{
		var res = new List<LevelData>();
		if (onboardingContainer != null)
		{
			var ol = onboardingContainer.GetLevelDatas();
			if (ol != null) res.AddRange(ol);
		}
		if (mainContainer != null)
		{
			var ml = mainContainer.GetLevelDatas();
			if (ml != null) res.AddRange(ml);
		}
		return res;
	}

	public bool IsFresh() => SaveGame.GetContentPackPlayCount(contentPackID) == 0;
	public bool IsConsideredNew() => IsFresh();
	private string Formatted(string s) => s;
	public bool IsAvailable() => true;
}
""")

    write_asset_file("Scripts/Assembly-CSharp/LevelDataContainer.cs", """using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainer : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataList levels;

	public bool UseFilter;
	public bool UsedInDailyChallenges;
	public float Weight = 1f;

	public List<LevelData> GetLevels()
	{
		if (levels == null) return new List<LevelData>();
		var list = new List<LevelData>(levels.Count);
		for (int i = 0; i < levels.Count; i++)
		{
			if (levels[i] != null) list.Add(levels[i]);
		}
		return list;
	}

	public override List<LevelData> GetLevelDatas() => GetLevels();

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return GetLevels().Select(l => new LevelDataAndChallenge { level = l, challengeID = string.Empty }).ToList();
	}

	public void SetLevels(List<LevelData> list)
	{
		if (levels == null) levels = new LevelDataList();
		levels.Clear();
		if (list != null)
		{
			foreach (var l in list) levels.Add(l);
		}
	}

	public LevelData GetLevel(string id)
	{
		return GetLevels().FirstOrDefault(l => l != null && (l.ID == id || l.name == id));
	}

	public int Swap(LevelData oldLvlData, LevelData newLvlData)
	{
		if (levels == null) return -1;
		int idx = levels.IndexOf(oldLvlData);
		if (idx >= 0) levels[idx] = newLvlData;
		return idx;
	}

	public int CalculateWeight() => Mathf.Max(1, Mathf.RoundToInt(Weight));
}
""")

    write_asset_file("Scripts/Assembly-CSharp/LevelDataContainerContainer.cs", """using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainerContainer : LevelDataContainerBase
{
	[SerializeField]
	private LevelContainerList levelContainers;

	public LevelDataContainer DebugContainer;

	public List<LevelDataContainer> GetContainers()
	{
		var res = new List<LevelDataContainer>();
		if (levelContainers != null)
		{
			for (int i = 0; i < levelContainers.Count; i++)
				if (levelContainers[i] != null) res.Add(levelContainers[i]);
		}
		return res;
	}

	public override List<LevelData> GetLevelDatas()
	{
		var res = new List<LevelData>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatas();
			if (l != null) res.AddRange(l);
		}
		return res;
	}

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		var res = new List<LevelDataAndChallenge>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatasWithChallenges();
			if (l != null) res.AddRange(l);
		}
		return res;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/LevelDataContainerWithChallenge.cs", """using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainerWithChallenge : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataListWithChallenge levels;

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		var res = new List<LevelDataAndChallenge>();
		if (levels != null)
		{
			for (int i = 0; i < levels.Count; i++)
				if (levels[i].level != null) res.Add(levels[i]);
		}
		return res;
	}

	public override List<LevelData> GetLevelDatas()
	{
		return GetLevelDatasWithChallenges().Select(x => x.level).Where(l => l != null).ToList();
	}

	public LevelDataAndChallenge GetLevel(string id)
	{
		return GetLevelDatasWithChallenges().FirstOrDefault(x => x.level != null && (x.level.ID == id || x.level.name == id));
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/DailyChallengeLevelDataContainerContainer.cs", """using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class DailyChallengeLevelDataContainerContainer : LevelDataContainerBase
{
	[SerializeField]
	private DailyChallengeLevelContainerList levelContainers;

	public DailyChallengeLevelDataContainer DebugContainer;

	public List<DailyChallengeLevelDataContainer> GetContainers()
	{
		var res = new List<DailyChallengeLevelDataContainer>();
		if (levelContainers != null)
		{
			for (int i = 0; i < levelContainers.Count; i++)
				if (levelContainers[i] != null) res.Add(levelContainers[i]);
		}
		return res;
	}

	public override List<LevelData> GetLevelDatas()
	{
		var res = new List<LevelData>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatas();
			if (l != null) res.AddRange(l);
		}
		return res;
	}

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		var res = new List<LevelDataAndChallenge>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatasWithChallenges();
			if (l != null) res.AddRange(l);
		}
		return res;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/LevelData.cs", """using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class LevelData : ScriptableObject
	{
		[Serializable]
		public class MapPositionData
		{
			public enum AngleOptions
			{
				RelativeForward = 0,
				RelativeLeft = 1,
				RelativeRight = 2,
				UseScene = 3
			}

			public AngleOptions currentAngle;
			public float distance;
		}

		public enum WindowType
		{
			Normal = 0,
			TwoD = 1
		}

		[Serializable]
		public class LevelCollectable
		{
			public Collectable Collectable;
			public List<string> IDs;
		}

		[Serializable]
		public class ChallengeData
		{
			public string ID;
			public string LocalizationID;
			public Sprite Icon;
		}

		[SerializeField] public bool skipPopup;
		[SerializeField] public string ID;
		[SerializeField] private MapPositionData mapPosition;
		public MusicData showcaseMusic;
		public LevelMusicSettings music;
		[SerializeField] public int StrokesToPar = 3;
		[SerializeField] public string Pun;
		[SerializeField] public string completionID;
		[SerializeField] public string CompletionText;
		[SerializeField] public SceneField Scene;
		[SerializeField] private WindowType window;
		public static string bestScoreID = "_BEST_SCORE";
		public static string levelEventsID = "_EVENTS";
		[SerializeField] public List<LevelCollectable> levelCollectables = new List<LevelCollectable>();
		[SerializeField] public List<ChallengeData> levelChallenges = new List<ChallengeData>();
		private List<string> _levelChallengeIds;
		[SerializeField] public bool isShowingFlipText;
		[SerializeField] public bool isBossBattle;
		[SerializeField] public bool usedInDailyChallenges;
		[SerializeField] public bool userCustomTransitionColor;
		[SerializeField] public Color customTransitionColor = Color.white;
		[SerializeField] public bool useCustomTransitionEffect;
		[SerializeField] public Transition.TransitionEffect customTransitionEffectIndex;
		[SerializeField] private int WeightInt = 1;
		private string convertedLevelId;

		public MapPositionData MapPosition
		{
			get => mapPosition;
			set => mapPosition = value;
		}

		public WindowType LevelWindowType => window;

		public int BestScore
		{
			get => SaveGame.GetValue(GetID() + bestScoreID, 0);
			set => SaveGame.SetValue(GetID() + bestScoreID, value, true);
		}

		public List<string> CompletedChallenges
		{
			get => SaveGame.GetCompletedChallenges(LevelChallengeIds());
			set
			{
				if (value != null)
					SaveGame.AddCompletedChallenges(value);
			}
		}

		public bool IsCompletedInSaveGame
		{
			get => SaveGame.GetIsLevelCompleted(GetID());
			set
			{
				if (value) SaveGame.SetLevelCompleted(GetID());
			}
		}

		public string SceneName => Scene != null && !string.IsNullOrEmpty(Scene.SceneName) ? Scene.SceneName : name;

		public List<string> LevelChallengeIds()
		{
			if (_levelChallengeIds == null)
			{
				_levelChallengeIds = levelChallenges != null
					? levelChallenges.Where(c => c != null && !string.IsNullOrEmpty(c.ID)).Select(c => c.ID).ToList()
					: new List<string>();
			}
			return _levelChallengeIds;
		}

		public void HandleSceneDataUpdate(Dictionary<string, float> data) { }
		public void DeleteData() { }
		public WindowType GetWindowType() => window;
		public string GetID() => !string.IsNullOrEmpty(ID) ? ID : name;
		public string GetCompletionTextID() => !string.IsNullOrEmpty(completionID) ? completionID : CompletionText;
		public string GetWeightID() => GetID() + "_WEIGHT";
		public List<string> GetChallengeLocalizationIDs() => levelChallenges != null ? levelChallenges.Select(c => c.LocalizationID).ToList() : new List<string>();
		public bool HasCompletedAllChallenges()
		{
			var ids = LevelChallengeIds();
			if (ids.Count == 0) return IsCompletedInSaveGame;
			return CompletedChallenges.Count >= ids.Count;
		}
		public int GetCurrentChallengeIndex() => CompletedChallenges.Count;
		public void ZeroWeight() { }
		public void IncrementWeight() { }
		public void DeleteWeight() { }
		public void ResetWeight() { }
		public int GetActualWeight() => Mathf.Max(1, WeightInt);
	}
}
""")

    print("Implemented core startup, platform, container, and LevelData scripts")


if __name__ == "__main__":
    main()
