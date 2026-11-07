using System;
using System.Runtime.CompilerServices;
using BetaAnalytics;
using Core;
using UnityEngine;

public class GameAnalytics
{
	public static AnalyticsData data;

	public static AnalyticsLevelData currentLevelData;

	private static int totalSecondsPlayedAtInitialize;

	private static float levelStartTime;

	private static float overworldStartTime;

	private static bool isOnboarding;

	private static float lastStrokeCountTime;

	private static float lastPauseTime;

	private static OverworldGoal lastOverworldGoal;

	private static HubSection lastOverworldHubSection;

	private static AnalyticsUnityHelper unityHelper;

	public static float sessionLength;

	[CompilerGenerated]
	private static Action<string> OnCampaignStart;

	[CompilerGenerated]
	private static Action<string> OnCampaignEnd;

	private static float _campaignTimer;

	private static float musicVolumeOnSettingsMenuOpen;

	private static float sfxVolumeOnSettingsMenuOpen;

	public static bool IsInitialized { get; private set; }

	private static float currentTotalTime => 0f;

	public static Vector3 OverworldBallPosition { get; private set; }

	public static string GameVersion { get; private set; }

	public static string Platform => null;

	public static string Store => null;

	public static bool UsingController { get; private set; }

	public static int SessionCount { get; private set; }

	public static int Day => 0;

	public static string CurrentCampaignID { get; private set; }

	private static string Guid { get; set; }

	public static bool AgreedToAnalytics { get; private set; }

	public static bool WasAskedAboutAnalytics { get; private set; }

	public static bool CanUploadData => false;

	public static bool CanCacheDataLocally => false;

	public static bool IsUnderage => false;

	public static bool IsReady => false;

	public static bool IsCompileFlagValid()
	{
		return false;
	}

	public static void Initialize()
	{
	}

	private static void OnUpdate()
	{
	}

	private static void LoadIds(bool create)
	{
	}

	public static void OnAskedForAnalytics(bool didAsk = true)
	{
	}

	public static void SetAgreeAnalytics(bool agree)
	{
	}

	private static void OnApplicationFocus(bool focus)
	{
	}

	private static void OnApplicationQuit()
	{
	}

	private static void SaveMainOverworldBallPosition()
	{
	}

	private static void OnSessionStop()
	{
	}

	private static void OnNewSession(bool startupFromApplicationFocus)
	{
	}

	private static void Reset()
	{
	}

	private static void HandleEvent(AnalyticDefinitions.Event e)
	{
	}

	private static bool ValidateForCurrentStore(AnalyticDefinitions.Event e)
	{
		return false;
	}

	public static void OnCampaignStarted(ContentPack contentPack, bool _isOnboarding = false)
	{
	}

	public static void OnCampaignStarted(string campaignId, bool _isOnboarding = false)
	{
	}

	public static void OnCampaignEnded(bool completed = false)
	{
	}

	public static void OnPrizeSceneLeave(double timeSpent, bool DidUnpackPrize, string LastPrizeReceived)
	{
	}

	public static void OnDailyChallengeEnded(string campaignId, bool completed, bool isReplay, int exitLevel, string packID, int strokeCount)
	{
	}

	public static void OnNotificationReceived(string id, bool opened)
	{
	}

	public static void NotificationCancelled(string id)
	{
	}

	public static void OnNotificationScheduled(string id)
	{
	}

	public static void OnFinalBossCompleted(OverworldGoal goal)
	{
	}

	public static void OnDoorOpen(string overworldID, bool isCrownDoor, string hubsectionId)
	{
	}

	public static void OnOverworldMainDoorPlateActivated(OverworldMainDoorRobot robot, OverworldMainDoorPlate plate)
	{
	}

	public static void OnHitFlagInOverworld(OverworldGoal goal)
	{
	}

	public static void OnHitFlagDialogCanceled(OverworldGoal goal)
	{
	}

	public static void OnLevelBegin(LevelData level, string challengeID)
	{
	}

	public static void OnLevelComplete(LevelData level)
	{
	}

	public static void OnLevelStroke()
	{
	}

	public static void OnLevelReset()
	{
	}

	public static void OnLevelAbort()
	{
	}

	private static void AddTimeAfterLevelExit(bool inChallenge)
	{
	}

	public static void OnLevelManualReset()
	{
	}

	public static void OnOverworldStroke()
	{
	}

	public static void OnHitTalkingThingInOverworld(ShowSpeechbubbleOnHit thing)
	{
	}

	public static void OnExitOverworld()
	{
	}

	public static void OnOverworldEnter(OverworldBall2D ball)
	{
	}

	public static void OnOverworldHide(OverworldBall2D ball)
	{
	}

	public static void OnControllerConnectionChanged(bool connected)
	{
	}

	public static void OnLanguageChangedByUser(string langauge)
	{
	}

	public static void OnNotificationsAsked(bool agreed)
	{
	}

	public static void OnReviewAsked(bool agreed)
	{
	}

	public static void OnFlagFinderUsed()
	{
	}

	public static void OnSaveSlotCleared()
	{
	}

	public static void OnMenuButtonPressed(string buttonId)
	{
	}

	public static void OnSettingsMenuOpen()
	{
	}

	public static void OnCampaignShortcutUsed(HubSection hubSection)
	{
	}

	public static void OnNewLevelCreated()
	{
	}

	public static void OnLevelCloned()
	{
	}

	public static void OnLevelDeleted()
	{
	}

	public static void OnFirstTimeLevelSaved()
	{
	}

	public static void OnFirstTimeLevelTested()
	{
	}

	public static void OnLevelDesignerClosed(float sessionLengthMinutes)
	{
	}

	public static void GameboyPopupClosed(bool confirmed, GameboyPopup.Type type)
	{
	}

	public static void ErrorReceived(string condition, string stacktrace, string sceneName, Vector2? ballPosition)
	{
	}
}
