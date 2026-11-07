using System;
using BetaAnalytics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000374")]
public class GameAnalytics
{
	[Serializable]
	[Token(Token = "0x2000375")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F39C", Offset = "0x3F39C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40012FC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40012FD")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AnalyticsTotalsData> _003C_003E9__108_0;

		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x10")]
		public static Action<AnalyticsTotalsData> _003C_003E9__109_0;

		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x18")]
		public static Action<AnalyticsTotalsData> _003C_003E9__111_0;

		[Token(Token = "0x4001300")]
		[FieldOffset(Offset = "0x20")]
		public static Action<AnalyticsTotalsData> _003C_003E9__112_0;

		[Token(Token = "0x4001301")]
		[FieldOffset(Offset = "0x28")]
		public static Action<AnalyticsTotalsData> _003C_003E9__112_1;

		[Token(Token = "0x4001302")]
		[FieldOffset(Offset = "0x30")]
		public static Action<AnalyticsTotalsData> _003C_003E9__117_1;

		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x38")]
		public static Action<AnalyticsTotalsData> _003C_003E9__118_0;

		[Token(Token = "0x6001057")]
		[Address(RVA = "0x17AC4CC", Offset = "0x17AC4CC", VA = "0x17AC4CC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001058")]
		[Address(RVA = "0x17AC4D4", Offset = "0x17AC4D4", VA = "0x17AC4D4")]
		internal void _003COnHitFlagInOverworld_003Eb__108_0(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x6001059")]
		[Address(RVA = "0x17AC4F4", Offset = "0x17AC4F4", VA = "0x17AC4F4")]
		internal void _003COnHitFlagDialogCanceled_003Eb__109_0(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x600105A")]
		[Address(RVA = "0x17AC514", Offset = "0x17AC514", VA = "0x17AC514")]
		internal void _003COnLevelComplete_003Eb__111_0(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x17AC550", Offset = "0x17AC550", VA = "0x17AC550")]
		internal void _003COnLevelStroke_003Eb__112_0(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x600105C")]
		[Address(RVA = "0x17AC570", Offset = "0x17AC570", VA = "0x17AC570")]
		internal void _003COnLevelStroke_003Eb__112_1(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x17AC590", Offset = "0x17AC590", VA = "0x17AC590")]
		internal void _003COnOverworldStroke_003Eb__117_1(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x600105E")]
		[Address(RVA = "0x17AC5B0", Offset = "0x17AC5B0", VA = "0x17AC5B0")]
		internal void _003COnHitTalkingThingInOverworld_003Eb__118_0(AnalyticsTotalsData totals)
		{
		}
	}

	[Token(Token = "0x2000376")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F3AC", Offset = "0x3F3AC")]
	private sealed class _003C_003Ec__DisplayClass115_0
	{
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x10")]
		public float totalLevelDuration;

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x17AC5D0", Offset = "0x17AC5D0", VA = "0x17AC5D0")]
		public _003C_003Ec__DisplayClass115_0()
		{
		}

		[Token(Token = "0x6001060")]
		[Address(RVA = "0x17AC5D8", Offset = "0x17AC5D8", VA = "0x17AC5D8")]
		internal void _003CAddTimeAfterLevelExit_003Eb__0(AnalyticsTotalsData totals)
		{
		}

		[Token(Token = "0x6001061")]
		[Address(RVA = "0x17AC5FC", Offset = "0x17AC5FC", VA = "0x17AC5FC")]
		internal void _003CAddTimeAfterLevelExit_003Eb__1(AnalyticsTotalsData totals)
		{
		}
	}

	[Token(Token = "0x2000377")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F3BC", Offset = "0x3F3BC")]
	private sealed class _003C_003Ec__DisplayClass117_0
	{
		[Token(Token = "0x4001305")]
		[FieldOffset(Offset = "0x10")]
		public float overworldDuration;

		[Token(Token = "0x6001062")]
		[Address(RVA = "0x17AC620", Offset = "0x17AC620", VA = "0x17AC620")]
		public _003C_003Ec__DisplayClass117_0()
		{
		}

		[Token(Token = "0x6001063")]
		[Address(RVA = "0x17AC628", Offset = "0x17AC628", VA = "0x17AC628")]
		internal void _003COnOverworldStroke_003Eb__0(AnalyticsTotalsData totals)
		{
		}
	}

	[Token(Token = "0x2000378")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F3CC", Offset = "0x3F3CC")]
	private sealed class _003C_003Ec__DisplayClass121_0
	{
		[Token(Token = "0x4001306")]
		[FieldOffset(Offset = "0x10")]
		public float overworldDuration;

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x17AC64C", Offset = "0x17AC64C", VA = "0x17AC64C")]
		public _003C_003Ec__DisplayClass121_0()
		{
		}

		[Token(Token = "0x6001065")]
		[Address(RVA = "0x17AC654", Offset = "0x17AC654", VA = "0x17AC654")]
		internal void _003COnOverworldHide_003Eb__0(AnalyticsTotalsData totals)
		{
		}
	}

	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC34", Offset = "0x4CC34")]
	private static bool IsInitialized__BackingField;

	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x8")]
	public static AnalyticsData data;

	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x10")]
	public static AnalyticsLevelData currentLevelData;

	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x18")]
	private static int totalSecondsPlayedAtInitialize;

	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x1C")]
	private static float levelStartTime;

	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x20")]
	private static float overworldStartTime;

	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x24")]
	private static bool isOnboarding;

	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x28")]
	private static float lastStrokeCountTime;

	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x2C")]
	private static float lastPauseTime;

	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x30")]
	private static OverworldGoal lastOverworldGoal;

	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x38")]
	private static HubSection lastOverworldHubSection;

	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x40")]
	private static AnalyticsUnityHelper unityHelper;

	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x48")]
	public static float sessionLength;

	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC44", Offset = "0x4CC44")]
	private static Vector3 OverworldBallPosition__BackingField;

	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC54", Offset = "0x4CC54")]
	private static string GameVersion__BackingField;

	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC64", Offset = "0x4CC64")]
	private static bool UsingController__BackingField;

	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC74", Offset = "0x4CC74")]
	private static int SessionCount__BackingField;

	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC84", Offset = "0x4CC84")]
	private static string CurrentCampaignID__BackingField;

	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CC94", Offset = "0x4CC94")]
	private static Action<string> OnCampaignStart;

	[Token(Token = "0x40012F5")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CCA4", Offset = "0x4CCA4")]
	private static Action<string> OnCampaignEnd;

	[Token(Token = "0x40012F6")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CCB4", Offset = "0x4CCB4")]
	private static string Guid__BackingField;

	[Token(Token = "0x40012F7")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CCC4", Offset = "0x4CCC4")]
	private static bool AgreedToAnalytics__BackingField;

	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x89")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CCD4", Offset = "0x4CCD4")]
	private static bool WasAskedAboutAnalytics__BackingField;

	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x8C")]
	private static float _campaignTimer;

	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x90")]
	private static float musicVolumeOnSettingsMenuOpen;

	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x94")]
	private static float sfxVolumeOnSettingsMenuOpen;

	[Token(Token = "0x170001E3")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x1477664", Offset = "0x1477664", VA = "0x1477664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6150C", Offset = "0x6150C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x14776B0", Offset = "0x14776B0", VA = "0x14776B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6151C", Offset = "0x6151C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001E4")]
	private static float currentTotalTime
	{
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x1477708", Offset = "0x1477708", VA = "0x1477708")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001E5")]
	public static Vector3 OverworldBallPosition
	{
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x1477774", Offset = "0x1477774", VA = "0x1477774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6152C", Offset = "0x6152C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x14777C4", Offset = "0x14777C4", VA = "0x14777C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153C", Offset = "0x6153C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001E6")]
	public static string GameVersion
	{
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x1477830", Offset = "0x1477830", VA = "0x1477830")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6154C", Offset = "0x6154C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x147787C", Offset = "0x147787C", VA = "0x147787C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6155C", Offset = "0x6155C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001E7")]
	public static string Platform
	{
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x14778D4", Offset = "0x14778D4", VA = "0x14778D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E8")]
	public static string Store
	{
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x1477998", Offset = "0x1477998", VA = "0x1477998")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E9")]
	public static bool UsingController
	{
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x1477A2C", Offset = "0x1477A2C", VA = "0x1477A2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6156C", Offset = "0x6156C")]
		get
		{
			return default;
		}
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x1477A78", Offset = "0x1477A78", VA = "0x1477A78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6157C", Offset = "0x6157C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001EA")]
	public static int SessionCount
	{
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x1477AD0", Offset = "0x1477AD0", VA = "0x1477AD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6158C", Offset = "0x6158C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x1477B1C", Offset = "0x1477B1C", VA = "0x1477B1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159C", Offset = "0x6159C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001EB")]
	public static int Day
	{
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x1477B74", Offset = "0x1477B74", VA = "0x1477B74")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001EC")]
	public static string CurrentCampaignID
	{
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x1477C90", Offset = "0x1477C90", VA = "0x1477C90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615AC", Offset = "0x615AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x1477CDC", Offset = "0x1477CDC", VA = "0x1477CDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615BC", Offset = "0x615BC")]
		private set
		{
		}
	}

	[Token(Token = "0x170001ED")]
	private static string Guid
	{
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x1477D34", Offset = "0x1477D34", VA = "0x1477D34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615CC", Offset = "0x615CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x1477D80", Offset = "0x1477D80", VA = "0x1477D80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615DC", Offset = "0x615DC")]
		set
		{
		}
	}

	[Token(Token = "0x170001EE")]
	public static bool AgreedToAnalytics
	{
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x1477DD8", Offset = "0x1477DD8", VA = "0x1477DD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615EC", Offset = "0x615EC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x1477E24", Offset = "0x1477E24", VA = "0x1477E24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FC", Offset = "0x615FC")]
		private set
		{
		}
	}

	[Token(Token = "0x170001EF")]
	public static bool WasAskedAboutAnalytics
	{
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x1477E7C", Offset = "0x1477E7C", VA = "0x1477E7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6160C", Offset = "0x6160C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x1477EC8", Offset = "0x1477EC8", VA = "0x1477EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6161C", Offset = "0x6161C")]
		private set
		{
		}
	}

	[Token(Token = "0x170001F0")]
	public static bool CanUploadData
	{
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x1477F20", Offset = "0x1477F20", VA = "0x1477F20")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001F1")]
	public static bool CanCacheDataLocally
	{
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x1478000", Offset = "0x1478000", VA = "0x1478000")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001F2")]
	public static bool IsUnderage
	{
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x1477FD8", Offset = "0x1477FD8", VA = "0x1477FD8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001F3")]
	public static bool IsReady
	{
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x14780D4", Offset = "0x14780D4", VA = "0x14780D4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600101E")]
	[Address(RVA = "0x1478148", Offset = "0x1478148", VA = "0x1478148")]
	public static bool IsCompileFlagValid()
	{
		return default;
	}

	[Token(Token = "0x600101F")]
	[Address(RVA = "0x1478150", Offset = "0x1478150", VA = "0x1478150")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x1478A54", Offset = "0x1478A54", VA = "0x1478A54")]
	private static void OnUpdate()
	{
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x147864C", Offset = "0x147864C", VA = "0x147864C")]
	private static void LoadIds(bool create)
	{
	}

	[Token(Token = "0x6001022")]
	[Address(RVA = "0x1478B58", Offset = "0x1478B58", VA = "0x1478B58")]
	public static void OnAskedForAnalytics(bool didAsk = true)
	{
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x1478CA8", Offset = "0x1478CA8", VA = "0x1478CA8")]
	public static void SetAgreeAnalytics(bool agree)
	{
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x1478E38", Offset = "0x1478E38", VA = "0x1478E38")]
	private static void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x14791E4", Offset = "0x14791E4", VA = "0x14791E4")]
	private static void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x1478F1C", Offset = "0x1478F1C", VA = "0x1478F1C")]
	private static void SaveMainOverworldBallPosition()
	{
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x147909C", Offset = "0x147909C", VA = "0x147909C")]
	private static void OnSessionStop()
	{
	}

	[Token(Token = "0x6001028")]
	[Address(RVA = "0x14788E4", Offset = "0x14788E4", VA = "0x14788E4")]
	private static void OnNewSession(bool startupFromApplicationFocus)
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x1479828", Offset = "0x1479828", VA = "0x1479828")]
	private static void Reset()
	{
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x14794C8", Offset = "0x14794C8", VA = "0x14794C8")]
	private static void HandleEvent(AnalyticDefinitions.Event e)
	{
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x14798D8", Offset = "0x14798D8", VA = "0x14798D8")]
	private static bool ValidateForCurrentStore(AnalyticDefinitions.Event e)
	{
		return default;
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0x1479A44", Offset = "0x1479A44", VA = "0x1479A44")]
	public static void OnCampaignStarted(ContentPack contentPack, bool _isOnboarding = false)
	{
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0x1479604", Offset = "0x1479604", VA = "0x1479604")]
	public static void OnCampaignStarted(string campaignId, bool _isOnboarding = false)
	{
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0x1479244", Offset = "0x1479244", VA = "0x1479244")]
	public static void OnCampaignEnded(bool completed = false)
	{
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x1479A5C", Offset = "0x1479A5C", VA = "0x1479A5C")]
	public static void OnPrizeSceneLeave(double timeSpent, bool DidUnpackPrize, string LastPrizeReceived)
	{
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x1479B10", Offset = "0x1479B10", VA = "0x1479B10")]
	public static void OnDailyChallengeEnded(string campaignId, bool completed, bool isReplay, int exitLevel, string packID, int strokeCount)
	{
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0x1479C40", Offset = "0x1479C40", VA = "0x1479C40")]
	public static void OnNotificationReceived(string id, bool opened)
	{
	}

	[Token(Token = "0x6001032")]
	[Address(RVA = "0x1479CE4", Offset = "0x1479CE4", VA = "0x1479CE4")]
	public static void NotificationCancelled(string id)
	{
	}

	[Token(Token = "0x6001033")]
	[Address(RVA = "0x1479D80", Offset = "0x1479D80", VA = "0x1479D80")]
	public static void OnNotificationScheduled(string id)
	{
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x1479E1C", Offset = "0x1479E1C", VA = "0x1479E1C")]
	public static void OnFinalBossCompleted(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0x1479EE8", Offset = "0x1479EE8", VA = "0x1479EE8")]
	public static void OnDoorOpen(string overworldID, bool isCrownDoor, string hubsectionId)
	{
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0x147A008", Offset = "0x147A008", VA = "0x147A008")]
	public static void OnOverworldMainDoorPlateActivated(OverworldMainDoorRobot robot, OverworldMainDoorPlate plate)
	{
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0x147A124", Offset = "0x147A124", VA = "0x147A124")]
	public static void OnHitFlagInOverworld(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6001038")]
	[Address(RVA = "0x147A320", Offset = "0x147A320", VA = "0x147A320")]
	public static void OnHitFlagDialogCanceled(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0x147A4B4", Offset = "0x147A4B4", VA = "0x147A4B4")]
	public static void OnLevelBegin(LevelData level, string challengeID)
	{
	}

	[Token(Token = "0x600103A")]
	[Address(RVA = "0x147A7A0", Offset = "0x147A7A0", VA = "0x147A7A0")]
	public static void OnLevelComplete(LevelData level)
	{
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x147AC70", Offset = "0x147AC70", VA = "0x147AC70")]
	public static void OnLevelStroke()
	{
	}

	[Token(Token = "0x600103C")]
	[Address(RVA = "0x147AF08", Offset = "0x147AF08", VA = "0x147AF08")]
	public static void OnLevelReset()
	{
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x147AFAC", Offset = "0x147AFAC", VA = "0x147AFAC")]
	public static void OnLevelAbort()
	{
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0x147AA9C", Offset = "0x147AA9C", VA = "0x147AA9C")]
	private static void AddTimeAfterLevelExit(bool inChallenge)
	{
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0x147B138", Offset = "0x147B138", VA = "0x147B138")]
	public static void OnLevelManualReset()
	{
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0x147B1DC", Offset = "0x147B1DC", VA = "0x147B1DC")]
	public static void OnOverworldStroke()
	{
	}

	[Token(Token = "0x6001041")]
	[Address(RVA = "0x147B468", Offset = "0x147B468", VA = "0x147B468")]
	public static void OnHitTalkingThingInOverworld(ShowSpeechbubbleOnHit thing)
	{
	}

	[Token(Token = "0x6001042")]
	[Address(RVA = "0x147B658", Offset = "0x147B658", VA = "0x147B658")]
	public static void OnExitOverworld()
	{
	}

	[Token(Token = "0x6001043")]
	[Address(RVA = "0x147B760", Offset = "0x147B760", VA = "0x147B760")]
	public static void OnOverworldEnter(OverworldBall2D ball)
	{
	}

	[Token(Token = "0x6001044")]
	[Address(RVA = "0x147B844", Offset = "0x147B844", VA = "0x147B844")]
	public static void OnOverworldHide(OverworldBall2D ball)
	{
	}

	[Token(Token = "0x6001045")]
	[Address(RVA = "0x147B9F4", Offset = "0x147B9F4", VA = "0x147B9F4")]
	public static void OnControllerConnectionChanged(bool connected)
	{
	}

	[Token(Token = "0x6001046")]
	[Address(RVA = "0x147BAB4", Offset = "0x147BAB4", VA = "0x147BAB4")]
	public static void OnLanguageChangedByUser(string langauge)
	{
	}

	[Token(Token = "0x6001047")]
	[Address(RVA = "0x147BB50", Offset = "0x147BB50", VA = "0x147BB50")]
	public static void OnNotificationsAsked(bool agreed)
	{
	}

	[Token(Token = "0x6001048")]
	[Address(RVA = "0x147BBEC", Offset = "0x147BBEC", VA = "0x147BBEC")]
	public static void OnReviewAsked(bool agreed)
	{
	}

	[Token(Token = "0x6001049")]
	[Address(RVA = "0x147BC88", Offset = "0x147BC88", VA = "0x147BC88")]
	public static void OnFlagFinderUsed()
	{
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0x147BD40", Offset = "0x147BD40", VA = "0x147BD40")]
	public static void OnSaveSlotCleared()
	{
	}

	[Token(Token = "0x600104B")]
	[Address(RVA = "0x147BDCC", Offset = "0x147BDCC", VA = "0x147BDCC")]
	public static void OnMenuButtonPressed(string buttonId)
	{
	}

	[Token(Token = "0x600104C")]
	[Address(RVA = "0x147BE68", Offset = "0x147BE68", VA = "0x147BE68")]
	public static void OnSettingsMenuOpen()
	{
	}

	[Token(Token = "0x600104D")]
	[Address(RVA = "0x147BF4C", Offset = "0x147BF4C", VA = "0x147BF4C")]
	public static void OnCampaignShortcutUsed(HubSection hubSection)
	{
	}

	[Token(Token = "0x600104E")]
	[Address(RVA = "0x147C048", Offset = "0x147C048", VA = "0x147C048")]
	public static void OnNewLevelCreated()
	{
	}

	[Token(Token = "0x600104F")]
	[Address(RVA = "0x147C0D4", Offset = "0x147C0D4", VA = "0x147C0D4")]
	public static void OnLevelCloned()
	{
	}

	[Token(Token = "0x6001050")]
	[Address(RVA = "0x147C160", Offset = "0x147C160", VA = "0x147C160")]
	public static void OnLevelDeleted()
	{
	}

	[Token(Token = "0x6001051")]
	[Address(RVA = "0x147C1EC", Offset = "0x147C1EC", VA = "0x147C1EC")]
	public static void OnFirstTimeLevelSaved()
	{
	}

	[Token(Token = "0x6001052")]
	[Address(RVA = "0x147C278", Offset = "0x147C278", VA = "0x147C278")]
	public static void OnFirstTimeLevelTested()
	{
	}

	[Token(Token = "0x6001053")]
	[Address(RVA = "0x147C304", Offset = "0x147C304", VA = "0x147C304")]
	public static void OnLevelDesignerClosed(float sessionLengthMinutes)
	{
	}

	[Token(Token = "0x6001054")]
	[Address(RVA = "0x147C3A0", Offset = "0x147C3A0", VA = "0x147C3A0")]
	public static void GameboyPopupClosed(bool confirmed, GameboyPopup.Type type)
	{
	}

	[Token(Token = "0x6001055")]
	[Address(RVA = "0x147C444", Offset = "0x147C444", VA = "0x147C444")]
	public static void ErrorReceived(string condition, string stacktrace, string sceneName, Vector2? ballPosition)
	{
	}
}
