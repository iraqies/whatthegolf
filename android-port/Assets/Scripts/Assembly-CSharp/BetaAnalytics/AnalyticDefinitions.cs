using System.Collections.Generic;
using Core;
using UnityEngine;

namespace BetaAnalytics
{
	public static class AnalyticDefinitions
	{
		public struct Event
		{
			public string eventName;

			public Dictionary<string, object> eventData;

			public HashSet<Store> exludedStores;

			public Event(string eventName)
			{
				this.eventName = null;
				eventData = null;
				exludedStores = null;
			}

			public void AddParameter(string parameterName, object parameterValue)
			{
			}

			public void RemoveParameter(string parameterName)
			{
			}

			public void CleanUpSectionId()
			{
			}
		}

		public static class Names
		{
			public static class Parameters
			{
				internal static string DC_EXIT_LEVEL_INDEX;

				internal static string DC_PACK_ID;

				internal static string DC_DAY_OF_WEEK;

				internal static string DC_NUM_TIMES_PLAYED;

				internal static string DC_IS_REPLAY;

				internal static string DC_STROKE_COUNT;

				internal static string DID_UNPACKPRIZE;

				internal static string LAST_PRIZE_RECEIVED;

				public static string APP_INSTALL_YEAR;

				public static string APP_INSTALL_MONTH;

				public static string APP_INSTALL_DAY;

				public static string FIRST_SESSION_EVER;

				public static string FIRST_SESSION_DAY;

				public static string FIRST_SESSION_WEEK;

				public static string FIRST_SESSION_MONTH;

				public static string PLAYER_SCORE;

				public static string GAMEBOY_CONFIRMED;

				public static string GAMEBOY_TYPE;

				public static string ERROR_CONDITION;

				public static string ERROR_STACKTRACE;

				public static string ERROR_SCENE;

				public static string ERROR_POSITION;
			}
		}

		public static Event OnNotificationReceived(string id, bool opened)
		{
			return default;
		}

		public static Event NotificationCancelled(string id)
		{
			return default;
		}

		public static Event NotificationsAsked(bool result)
		{
			return default;
		}

		public static Event NotificationsScheduled(string id)
		{
			return default;
		}

		public static Event SessionStart(bool startFromApplicationFocus, string lastLevelId)
		{
			return default;
		}

		private static void AddRetentionParameters(Event e)
		{
		}

		public static Event SessionStop(string lastLevelId, float sessionLength, string currentCampaignId)
		{
			return default;
		}

		public static Event MenuButtonPressed(string buttonID)
		{
			return default;
		}

		public static Event LanguageChanged(string newLang)
		{
			return default;
		}

		public static Event SaveSlotCleared()
		{
			return default;
		}

		public static Event ReviewAsked(bool result)
		{
			return default;
		}

		public static Event CampaignShortcutUsed(string sectionName)
		{
			return default;
		}

		public static Event CrownDoorOpen(string overworldID, string campaignID, string sectionId)
		{
			return default;
		}

		public static Event OverworldDoorOpen(string overworldID, string campaignID, string sectionId)
		{
			return default;
		}

		public static Event FinalLevelCompleted(OverworldGoal goal, string campaignId)
		{
			return default;
		}

		public static Event DoorPlateActivated(string overworldID, string campaignID)
		{
			return default;
		}

		public static Event LevelStarted(AnalyticsLevelData aLevelData, bool isOnboarding)
		{
			return default;
		}

		public static Event LevelComplete(AnalyticsLevelData aLevelData, bool isOnboarding, string levelId)
		{
			return default;
		}

		public static Event LevelAbort(AnalyticsLevelData aLevelData, bool isOnboarding)
		{
			return default;
		}

		public static Event ChallengeStart(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		public static Event ChallengeComplete(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		public static Event ChallengeAbort(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		public static Event FirstFlagCrowned(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		public static Event CampaignStarted(string campaignId, bool isOnboarding)
		{
			return default;
		}

		public static Event DailyCampaignEnded(string campaignId, bool completed, bool isReplay, int exitLevel, string packID, int strokeCount, float timeSpentInCampaignSeconds)
		{
			return default;
		}

		public static Event CampaignEnded(string campaignId, bool isOnboarding, bool completed, float timeSpentOverworld, float timeSpentLevels, float timeSpentChallenges, Vector3 ballPosition, string sectionId)
		{
			return default;
		}

		internal static Event OnPrizeSceneLeave(double timeSpent, bool DidUnpackPrize, string LastPrizeReceived)
		{
			return default;
		}

		public static Event FlagFinderUsed(string campaignId)
		{
			return default;
		}

		public static Event HitTalkingThing(string campaignId, ShowSpeechbubbleOnHit bubble)
		{
			return default;
		}

		public static Event GameboyPopup(bool confirmed, GameboyPopup.Type type)
		{
			return default;
		}

		public static Event ErrorReceived(string condition, string stacktrace, string sceneName, Vector2? ballPosition)
		{
			return default;
		}

		public static Event NewLevelCreated()
		{
			return default;
		}

		public static Event LevelCloned()
		{
			return default;
		}

		public static Event LevelDeleted()
		{
			return default;
		}

		public static Event FirstTimeLevelSaved()
		{
			return default;
		}

		public static Event FirstTimeLevelTested()
		{
			return default;
		}

		public static Event LevelDesignerClosed(float sessionLengthMinutes)
		{
			return default;
		}

		public static Event AddPlayerScore(this Event e)
		{
			return default;
		}
	}
}
