using System;
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

			public bool isMobile;

			public bool useRotatedOverworldAndCameraInLevels;

			public EPlatformType platformType;

			public bool useFileSave;

			public bool useSaveThrobber;

			public bool longSaveAnimation;

			public MainMenuData menu;

			public bool playAgainSelectionAlwaysVisible;

			public bool useQuickmenuInOnboarding;

			public bool useBackButtonInMenus;

			public bool useGifs;

			public bool useMegacoolGifRecorder;

			public bool useUnityGifRecorder;

			public bool canShareGif;

			public bool useGyro;

			public bool simulateGyroWithTouchOrMouse;

			public bool flipGyroInput;

			public int SleepTimeout;

			public int FPSOnBattery;

			public int FPSOnPower;

			public bool usesKeyboardAndControllerInput;

			public float maxDragLength;

			public bool UseControllerDisconnectedPopup;

			public bool CanChangeGyroControlsInLevel;

			public bool isMultiplayerSupported;

			public bool UseAimMarker;

			public bool useChallengeIconDescriptions;

			public float ChallengeWindowScale;

			public bool UseLoadingAnimation;

			public float QuickMenuScale;

			public bool enlargeSpeechBubbles;

			public bool enlargeOnlySpeechBubblesOnSmallScreen;

			public float preloadAudioTimeOnLoading;

			public int maxAudioTransitionsInMemory;

			public int maxAudioStatesInMemory;

			public bool useRumble;

			public bool useUnloadUnusedAssetsOnLevelUnload;

			public string overwriteId;

			public float AdjustOrthoSizeForFourByThree;

			public bool useAirPlay;

			public float challengeTimeExtraPct;

			public float aimTimeScaleModifier;

			public int defaultAntiAliasing;

			public bool UseRoom8ObjectCulling;

			public bool usePhysicsOptimizationsInOverworld;

			public bool useNativeNotifications;

			public bool useDeepLinks;

			public IPlatform Platform => null;

			public bool ShouldEnlargeSpeechBubble()
			{
				return false;
			}

			public bool IsPlayingUndocked()
			{
				return false;
			}
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

		public static PlatformSettings Instance => null;

		public PlatformConfiguration[] Configurations => null;

		public static bool IsMobile => false;

		public static bool IsStandalone => false;

		public static bool IsIOS => false;

		public static bool IsAppleTV => false;

		public static bool IsSwitch => false;

		public static bool IsPS4 => false;

		public static bool IsPS5 => false;

		public static bool IsXboxOne => false;

		public static bool IsConsole => false;

		public static bool IsPortraitByDefault => false;

		public static bool UseNativeNotifications => false;

		public static bool UseDeepLinks => false;

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		public PlatformConfiguration GetCurrent()
		{
			return null;
		}

		public PlatformConfiguration GetCurrentNonCached(bool isBuilding = false)
		{
			return null;
		}

		private void InitCached()
		{
		}
	}
}
