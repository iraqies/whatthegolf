using System;
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
			public bool IsMobile => isMobile;
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
		public static bool IsPortraitByDefault => Instance != null && Instance.GetCurrent() != null && Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
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
				android.defaultScreenMode = ScreenModes.Portrait;
				android.useRotatedOverworldAndCameraInLevels = true;
				android.useFileSave = true;
				android.usesKeyboardAndControllerInput = true;
				android.UseAimMarker = true;
				return android;
			}
			if (iPhone != null)
				return iPhone;
			if (iPad != null)
			{
				iPad.isMobile = true;
				iPad.useFileSave = true;
				iPad.usesKeyboardAndControllerInput = true;
				iPad.UseAimMarker = true;
				return iPad;
			}
			return new PlatformConfiguration();
		}

		private void InitCached()
		{
			cachedCurrent = GetCurrentNonCached(false);
		}
	}
}
