using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001416")]
	public class PlatformSettings : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2001417")]
		public class PlatformConfiguration
		{
			[Token(Token = "0x4006BCD")]
			[FieldOffset(Offset = "0x10")]
			public ScreenModes defaultScreenMode;

			[Token(Token = "0x4006BCE")]
			[FieldOffset(Offset = "0x14")]
			public bool isMobile;

			[Token(Token = "0x4006BCF")]
			[FieldOffset(Offset = "0x15")]
			public bool useRotatedOverworldAndCameraInLevels;

			[Token(Token = "0x4006BD0")]
			[FieldOffset(Offset = "0x18")]
			public EPlatformType platformType;

			[Token(Token = "0x4006BD1")]
			[FieldOffset(Offset = "0x1C")]
			public bool useFileSave;

			[Token(Token = "0x4006BD2")]
			[FieldOffset(Offset = "0x1D")]
			public bool useSaveThrobber;

			[Token(Token = "0x4006BD3")]
			[FieldOffset(Offset = "0x1E")]
			public bool longSaveAnimation;

			[Token(Token = "0x4006BD4")]
			[FieldOffset(Offset = "0x20")]
			public MainMenuData menu;

			[Token(Token = "0x4006BD5")]
			[FieldOffset(Offset = "0x28")]
			public bool playAgainSelectionAlwaysVisible;

			[Token(Token = "0x4006BD6")]
			[FieldOffset(Offset = "0x29")]
			public bool useQuickmenuInOnboarding;

			[Token(Token = "0x4006BD7")]
			[FieldOffset(Offset = "0x2A")]
			public bool useBackButtonInMenus;

			[Token(Token = "0x4006BD8")]
			[FieldOffset(Offset = "0x2B")]
			public bool useGifs;

			[Token(Token = "0x4006BD9")]
			[FieldOffset(Offset = "0x2C")]
			public bool useMegacoolGifRecorder;

			[Token(Token = "0x4006BDA")]
			[FieldOffset(Offset = "0x2D")]
			public bool useUnityGifRecorder;

			[Token(Token = "0x4006BDB")]
			[FieldOffset(Offset = "0x2E")]
			public bool canShareGif;

			[Token(Token = "0x4006BDC")]
			[FieldOffset(Offset = "0x2F")]
			public bool useGyro;

			[Token(Token = "0x4006BDD")]
			[FieldOffset(Offset = "0x30")]
			public bool simulateGyroWithTouchOrMouse;

			[Token(Token = "0x4006BDE")]
			[FieldOffset(Offset = "0x31")]
			public bool flipGyroInput;

			[Token(Token = "0x4006BDF")]
			[FieldOffset(Offset = "0x34")]
			public int SleepTimeout;

			[Token(Token = "0x4006BE0")]
			[FieldOffset(Offset = "0x38")]
			public int FPSOnBattery;

			[Token(Token = "0x4006BE1")]
			[FieldOffset(Offset = "0x3C")]
			public int FPSOnPower;

			[Token(Token = "0x4006BE2")]
			[FieldOffset(Offset = "0x40")]
			public bool usesKeyboardAndControllerInput;

			[Token(Token = "0x4006BE3")]
			[FieldOffset(Offset = "0x44")]
			public float maxDragLength;

			[Token(Token = "0x4006BE4")]
			[FieldOffset(Offset = "0x48")]
			public bool UseControllerDisconnectedPopup;

			[Token(Token = "0x4006BE5")]
			[FieldOffset(Offset = "0x49")]
			public bool CanChangeGyroControlsInLevel;

			[Token(Token = "0x4006BE6")]
			[FieldOffset(Offset = "0x4A")]
			public bool isMultiplayerSupported;

			[Token(Token = "0x4006BE7")]
			[FieldOffset(Offset = "0x4B")]
			public bool UseAimMarker;

			[Token(Token = "0x4006BE8")]
			[FieldOffset(Offset = "0x4C")]
			public bool useChallengeIconDescriptions;

			[Token(Token = "0x4006BE9")]
			[FieldOffset(Offset = "0x50")]
			public float ChallengeWindowScale;

			[Token(Token = "0x4006BEA")]
			[FieldOffset(Offset = "0x54")]
			public bool UseLoadingAnimation;

			[Token(Token = "0x4006BEB")]
			[FieldOffset(Offset = "0x58")]
			public float QuickMenuScale;

			[Token(Token = "0x4006BEC")]
			[FieldOffset(Offset = "0x5C")]
			public bool enlargeSpeechBubbles;

			[Token(Token = "0x4006BED")]
			[FieldOffset(Offset = "0x5D")]
			public bool enlargeOnlySpeechBubblesOnSmallScreen;

			[Token(Token = "0x4006BEE")]
			[FieldOffset(Offset = "0x60")]
			public float preloadAudioTimeOnLoading;

			[Token(Token = "0x4006BEF")]
			[FieldOffset(Offset = "0x64")]
			public int maxAudioTransitionsInMemory;

			[Token(Token = "0x4006BF0")]
			[FieldOffset(Offset = "0x68")]
			public int maxAudioStatesInMemory;

			[Token(Token = "0x4006BF1")]
			[FieldOffset(Offset = "0x6C")]
			public bool useRumble;

			[Token(Token = "0x4006BF2")]
			[FieldOffset(Offset = "0x6D")]
			public bool useUnloadUnusedAssetsOnLevelUnload;

			[Token(Token = "0x4006BF3")]
			[FieldOffset(Offset = "0x70")]
			public string overwriteId;

			[Token(Token = "0x4006BF4")]
			[FieldOffset(Offset = "0x78")]
			public float AdjustOrthoSizeForFourByThree;

			[Token(Token = "0x4006BF5")]
			[FieldOffset(Offset = "0x7C")]
			public bool useAirPlay;

			[Token(Token = "0x4006BF6")]
			[FieldOffset(Offset = "0x80")]
			public float challengeTimeExtraPct;

			[Token(Token = "0x4006BF7")]
			[FieldOffset(Offset = "0x84")]
			public float aimTimeScaleModifier;

			[Token(Token = "0x4006BF8")]
			[FieldOffset(Offset = "0x88")]
			public int defaultAntiAliasing;

			[Token(Token = "0x4006BF9")]
			[FieldOffset(Offset = "0x8C")]
			public bool UseRoom8ObjectCulling;

			[Token(Token = "0x4006BFA")]
			[FieldOffset(Offset = "0x8D")]
			public bool usePhysicsOptimizationsInOverworld;

			[Token(Token = "0x4006BFB")]
			[FieldOffset(Offset = "0x8E")]
			public bool useNativeNotifications;

			[Token(Token = "0x4006BFC")]
			[FieldOffset(Offset = "0x8F")]
			public bool useDeepLinks;

			[Token(Token = "0x17000A9E")]
			public IPlatform Platform
			{
				[Token(Token = "0x6005D73")]
				[Address(RVA = "0x1827680", Offset = "0x1827680", VA = "0x1827680")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6005D71")]
			[Address(RVA = "0x18275B8", Offset = "0x18275B8", VA = "0x18275B8")]
			public bool ShouldEnlargeSpeechBubble()
			{
				return default;
			}

			[Token(Token = "0x6005D72")]
			[Address(RVA = "0x1827678", Offset = "0x1827678", VA = "0x1827678")]
			public bool IsPlayingUndocked()
			{
				return default;
			}

			[Token(Token = "0x6005D74")]
			[Address(RVA = "0x18276D4", Offset = "0x18276D4", VA = "0x18276D4")]
			public PlatformConfiguration()
			{
			}
		}

		[Token(Token = "0x2001418")]
		public enum OnlineLeaderboardType
		{
			[Token(Token = "0x4006BFE")]
			None = 0,
			[Token(Token = "0x4006BFF")]
			PlayFab = 1,
			[Token(Token = "0x4006C00")]
			GameCenter = 2,
			[Token(Token = "0x4006C01")]
			Steam = 3,
			[Token(Token = "0x4006C02")]
			Playstation = 4
		}

		[Token(Token = "0x2001419")]
		public enum ScreenModes
		{
			[Token(Token = "0x4006C04")]
			Landscape = 0,
			[Token(Token = "0x4006C05")]
			Portrait = 1
		}

		[Token(Token = "0x200141A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4902C", Offset = "0x4902C")]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			[Token(Token = "0x4006C06")]
			[FieldOffset(Offset = "0x10")]
			public EPlatformType runtimePlatform;

			[Token(Token = "0x6005D75")]
			[Address(RVA = "0x182758C", Offset = "0x182758C", VA = "0x182758C")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6005D76")]
			[Address(RVA = "0x1827594", Offset = "0x1827594", VA = "0x1827594")]
			internal bool _003CGetCurrentNonCached_003Eb__0(PlatformConfiguration c)
			{
				return default;
			}
		}

		[Token(Token = "0x4006BBF")]
		[FieldOffset(Offset = "0x18")]
		public PlatformConfiguration iPhone;

		[Token(Token = "0x4006BC0")]
		[FieldOffset(Offset = "0x20")]
		public PlatformConfiguration iPad;

		[Token(Token = "0x4006BC1")]
		[FieldOffset(Offset = "0x28")]
		public PlatformConfiguration airplay;

		[Token(Token = "0x4006BC2")]
		[FieldOffset(Offset = "0x30")]
		public PlatformConfiguration android;

		[Token(Token = "0x4006BC3")]
		[FieldOffset(Offset = "0x38")]
		public PlatformConfiguration windows;

		[Token(Token = "0x4006BC4")]
		[FieldOffset(Offset = "0x40")]
		public PlatformConfiguration mac;

		[Token(Token = "0x4006BC5")]
		[FieldOffset(Offset = "0x48")]
		public PlatformConfiguration appleTV;

		[Token(Token = "0x4006BC6")]
		[FieldOffset(Offset = "0x50")]
		public PlatformConfiguration nintendoSwitch;

		[Token(Token = "0x4006BC7")]
		[FieldOffset(Offset = "0x58")]
		public PlatformConfiguration linux;

		[Token(Token = "0x4006BC8")]
		[FieldOffset(Offset = "0x60")]
		public PlatformConfiguration ps4;

		[Token(Token = "0x4006BC9")]
		[FieldOffset(Offset = "0x68")]
		public PlatformConfiguration ps5;

		[Token(Token = "0x4006BCA")]
		[FieldOffset(Offset = "0x70")]
		public PlatformConfiguration xboxOne;

		[Token(Token = "0x4006BCB")]
		[FieldOffset(Offset = "0x78")]
		private PlatformConfiguration cachedCurrent;

		[Token(Token = "0x4006BCC")]
		[FieldOffset(Offset = "0x0")]
		private static PlatformSettings instance;

		[Token(Token = "0x17000A90")]
		public static PlatformSettings Instance
		{
			[Token(Token = "0x6005D5E")]
			[Address(RVA = "0x15E7028", Offset = "0x15E7028", VA = "0x15E7028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A91")]
		public PlatformConfiguration[] Configurations
		{
			[Token(Token = "0x6005D5F")]
			[Address(RVA = "0x15E7830", Offset = "0x15E7830", VA = "0x15E7830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A92")]
		public static bool IsMobile
		{
			[Token(Token = "0x6005D63")]
			[Address(RVA = "0x15E7BD8", Offset = "0x15E7BD8", VA = "0x15E7BD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A93")]
		public static bool IsStandalone
		{
			[Token(Token = "0x6005D64")]
			[Address(RVA = "0x15E7C48", Offset = "0x15E7C48", VA = "0x15E7C48")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A94")]
		public static bool IsIOS
		{
			[Token(Token = "0x6005D65")]
			[Address(RVA = "0x15E7D30", Offset = "0x15E7D30", VA = "0x15E7D30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A95")]
		public static bool IsAppleTV
		{
			[Token(Token = "0x6005D66")]
			[Address(RVA = "0x15E7DE4", Offset = "0x15E7DE4", VA = "0x15E7DE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A96")]
		public static bool IsSwitch
		{
			[Token(Token = "0x6005D67")]
			[Address(RVA = "0x15E7E5C", Offset = "0x15E7E5C", VA = "0x15E7E5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A97")]
		public static bool IsPS4
		{
			[Token(Token = "0x6005D68")]
			[Address(RVA = "0x15E7ED4", Offset = "0x15E7ED4", VA = "0x15E7ED4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A98")]
		public static bool IsPS5
		{
			[Token(Token = "0x6005D69")]
			[Address(RVA = "0x15E7F4C", Offset = "0x15E7F4C", VA = "0x15E7F4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A99")]
		public static bool IsXboxOne
		{
			[Token(Token = "0x6005D6A")]
			[Address(RVA = "0x15E7FC4", Offset = "0x15E7FC4", VA = "0x15E7FC4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A9A")]
		public static bool IsConsole
		{
			[Token(Token = "0x6005D6B")]
			[Address(RVA = "0x15E803C", Offset = "0x15E803C", VA = "0x15E803C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A9B")]
		public static bool IsPortraitByDefault
		{
			[Token(Token = "0x6005D6C")]
			[Address(RVA = "0x15E8238", Offset = "0x15E8238", VA = "0x15E8238")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A9C")]
		public static bool UseNativeNotifications
		{
			[Token(Token = "0x6005D6D")]
			[Address(RVA = "0x15E82A8", Offset = "0x15E82A8", VA = "0x15E82A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A9D")]
		public static bool UseDeepLinks
		{
			[Token(Token = "0x6005D6E")]
			[Address(RVA = "0x15E833C", Offset = "0x15E833C", VA = "0x15E833C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x15E77A4", Offset = "0x15E77A4", VA = "0x15E77A4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72960", Offset = "0x72960")]
		private static void Init()
		{
		}

		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x15E7ABC", Offset = "0x15E7ABC", VA = "0x15E7ABC")]
		public PlatformConfiguration GetCurrent()
		{
			return null;
		}

		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x15E7AC4", Offset = "0x15E7AC4", VA = "0x15E7AC4")]
		public PlatformConfiguration GetCurrentNonCached(bool isBuilding = false)
		{
			return null;
		}

		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x15E7808", Offset = "0x15E7808", VA = "0x15E7808")]
		private void InitCached()
		{
		}

		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x15E83AC", Offset = "0x15E83AC", VA = "0x15E83AC")]
		public PlatformSettings()
		{
		}
	}
}
