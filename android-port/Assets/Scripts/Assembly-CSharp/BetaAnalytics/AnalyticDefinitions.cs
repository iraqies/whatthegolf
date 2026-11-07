using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace BetaAnalytics
{
	[Token(Token = "0x200111E")]
	public static class AnalyticDefinitions
	{
		[Token(Token = "0x200111F")]
		public struct Event
		{
			[Token(Token = "0x4005AA8")]
			[FieldOffset(Offset = "0x0")]
			public string eventName;

			[Token(Token = "0x4005AA9")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, object> eventData;

			[Token(Token = "0x4005AAA")]
			[FieldOffset(Offset = "0x10")]
			public HashSet<Store> exludedStores;

			[Token(Token = "0x6004D3A")]
			[Address(RVA = "0x176A264", Offset = "0x176A264", VA = "0x176A264")]
			public Event(string eventName)
			{
			}

			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0x176A3F8", Offset = "0x176A3F8", VA = "0x176A3F8")]
			public void AddParameter(string parameterName, object parameterValue)
			{
			}

			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0x176A590", Offset = "0x176A590", VA = "0x176A590")]
			public void RemoveParameter(string parameterName)
			{
			}

			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x176A630", Offset = "0x176A630", VA = "0x176A630")]
			public void CleanUpSectionId()
			{
			}
		}

		[Token(Token = "0x2001120")]
		public static class Names
		{
			[Token(Token = "0x2001121")]
			public static class Parameters
			{
				[Token(Token = "0x4005AAB")]
				[FieldOffset(Offset = "0x0")]
				internal static string DC_EXIT_LEVEL_INDEX;

				[Token(Token = "0x4005AAC")]
				[FieldOffset(Offset = "0x8")]
				internal static string DC_PACK_ID;

				[Token(Token = "0x4005AAD")]
				[FieldOffset(Offset = "0x10")]
				internal static string DC_DAY_OF_WEEK;

				[Token(Token = "0x4005AAE")]
				[FieldOffset(Offset = "0x18")]
				internal static string DC_NUM_TIMES_PLAYED;

				[Token(Token = "0x4005AAF")]
				[FieldOffset(Offset = "0x20")]
				internal static string DC_IS_REPLAY;

				[Token(Token = "0x4005AB0")]
				[FieldOffset(Offset = "0x28")]
				internal static string DC_STROKE_COUNT;

				[Token(Token = "0x4005AB1")]
				[FieldOffset(Offset = "0x30")]
				internal static string DID_UNPACKPRIZE;

				[Token(Token = "0x4005AB2")]
				[FieldOffset(Offset = "0x38")]
				internal static string LAST_PRIZE_RECEIVED;

				[Token(Token = "0x4005AB3")]
				[FieldOffset(Offset = "0x40")]
				public static string APP_INSTALL_YEAR;

				[Token(Token = "0x4005AB4")]
				[FieldOffset(Offset = "0x48")]
				public static string APP_INSTALL_MONTH;

				[Token(Token = "0x4005AB5")]
				[FieldOffset(Offset = "0x50")]
				public static string APP_INSTALL_DAY;

				[Token(Token = "0x4005AB6")]
				[FieldOffset(Offset = "0x58")]
				public static string FIRST_SESSION_EVER;

				[Token(Token = "0x4005AB7")]
				[FieldOffset(Offset = "0x60")]
				public static string FIRST_SESSION_DAY;

				[Token(Token = "0x4005AB8")]
				[FieldOffset(Offset = "0x68")]
				public static string FIRST_SESSION_WEEK;

				[Token(Token = "0x4005AB9")]
				[FieldOffset(Offset = "0x70")]
				public static string FIRST_SESSION_MONTH;

				[Token(Token = "0x4005ABA")]
				[FieldOffset(Offset = "0x78")]
				public static string PLAYER_SCORE;

				[Token(Token = "0x4005ABB")]
				[FieldOffset(Offset = "0x80")]
				public static string GAMEBOY_CONFIRMED;

				[Token(Token = "0x4005ABC")]
				[FieldOffset(Offset = "0x88")]
				public static string GAMEBOY_TYPE;

				[Token(Token = "0x4005ABD")]
				[FieldOffset(Offset = "0x90")]
				public static string ERROR_CONDITION;

				[Token(Token = "0x4005ABE")]
				[FieldOffset(Offset = "0x98")]
				public static string ERROR_STACKTRACE;

				[Token(Token = "0x4005ABF")]
				[FieldOffset(Offset = "0xA0")]
				public static string ERROR_SCENE;

				[Token(Token = "0x4005AC0")]
				[FieldOffset(Offset = "0xA8")]
				public static string ERROR_POSITION;
			}
		}

		[Serializable]
		[Token(Token = "0x2001122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47C44", Offset = "0x47C44")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005AC1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005AC2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ECampaignType, bool> _003C_003E9__28_0;

			[Token(Token = "0x6004D40")]
			[Address(RVA = "0x176A1DC", Offset = "0x176A1DC", VA = "0x176A1DC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004D41")]
			[Address(RVA = "0x176A1E4", Offset = "0x176A1E4", VA = "0x176A1E4")]
			internal bool _003CCampaignEnded_003Eb__28_0(ECampaignType ck)
			{
				return default;
			}
		}

		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x14101A8", Offset = "0x14101A8", VA = "0x14101A8")]
		public static Event OnNotificationReceived(string id, bool opened)
		{
			return default;
		}

		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x14105E8", Offset = "0x14105E8", VA = "0x14105E8")]
		public static Event NotificationCancelled(string id)
		{
			return default;
		}

		[Token(Token = "0x6004D16")]
		[Address(RVA = "0x1410698", Offset = "0x1410698", VA = "0x1410698")]
		public static Event NotificationsAsked(bool result)
		{
			return default;
		}

		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x1410834", Offset = "0x1410834", VA = "0x1410834")]
		public static Event NotificationsScheduled(string id)
		{
			return default;
		}

		[Token(Token = "0x6004D18")]
		[Address(RVA = "0x14108E4", Offset = "0x14108E4", VA = "0x14108E4")]
		public static Event SessionStart(bool startFromApplicationFocus, string lastLevelId)
		{
			return default;
		}

		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x14102C8", Offset = "0x14102C8", VA = "0x14102C8")]
		private static void AddRetentionParameters(Event e)
		{
		}

		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x1410EE0", Offset = "0x1410EE0", VA = "0x1410EE0")]
		public static Event SessionStop(string lastLevelId, float sessionLength, string currentCampaignId)
		{
			return default;
		}

		[Token(Token = "0x6004D1B")]
		[Address(RVA = "0x1411100", Offset = "0x1411100", VA = "0x1411100")]
		public static Event MenuButtonPressed(string buttonID)
		{
			return default;
		}

		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x1411278", Offset = "0x1411278", VA = "0x1411278")]
		public static Event LanguageChanged(string newLang)
		{
			return default;
		}

		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x14113F0", Offset = "0x14113F0", VA = "0x14113F0")]
		public static Event SaveSlotCleared()
		{
			return default;
		}

		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0x1411534", Offset = "0x1411534", VA = "0x1411534")]
		public static Event ReviewAsked(bool result)
		{
			return default;
		}

		[Token(Token = "0x6004D1F")]
		[Address(RVA = "0x14116D0", Offset = "0x14116D0", VA = "0x14116D0")]
		public static Event CampaignShortcutUsed(string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6004D20")]
		[Address(RVA = "0x1411848", Offset = "0x1411848", VA = "0x1411848")]
		public static Event CrownDoorOpen(string overworldID, string campaignID, string sectionId)
		{
			return default;
		}

		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x1411A20", Offset = "0x1411A20", VA = "0x1411A20")]
		public static Event OverworldDoorOpen(string overworldID, string campaignID, string sectionId)
		{
			return default;
		}

		[Token(Token = "0x6004D22")]
		[Address(RVA = "0x1411BF8", Offset = "0x1411BF8", VA = "0x1411BF8")]
		public static Event FinalLevelCompleted(OverworldGoal goal, string campaignId)
		{
			return default;
		}

		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x1411E14", Offset = "0x1411E14", VA = "0x1411E14")]
		public static Event DoorPlateActivated(string overworldID, string campaignID)
		{
			return default;
		}

		[Token(Token = "0x6004D24")]
		[Address(RVA = "0x1412068", Offset = "0x1412068", VA = "0x1412068")]
		public static Event LevelStarted(AnalyticsLevelData aLevelData, bool isOnboarding)
		{
			return default;
		}

		[Token(Token = "0x6004D25")]
		[Address(RVA = "0x14122B8", Offset = "0x14122B8", VA = "0x14122B8")]
		public static Event LevelComplete(AnalyticsLevelData aLevelData, bool isOnboarding, string levelId)
		{
			return default;
		}

		[Token(Token = "0x6004D26")]
		[Address(RVA = "0x1412684", Offset = "0x1412684", VA = "0x1412684")]
		public static Event LevelAbort(AnalyticsLevelData aLevelData, bool isOnboarding)
		{
			return default;
		}

		[Token(Token = "0x6004D27")]
		[Address(RVA = "0x14129D8", Offset = "0x14129D8", VA = "0x14129D8")]
		public static Event ChallengeStart(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		[Token(Token = "0x6004D28")]
		[Address(RVA = "0x1412BD0", Offset = "0x1412BD0", VA = "0x1412BD0")]
		public static Event ChallengeComplete(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		[Token(Token = "0x6004D29")]
		[Address(RVA = "0x1412EFC", Offset = "0x1412EFC", VA = "0x1412EFC")]
		public static Event ChallengeAbort(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		[Token(Token = "0x6004D2A")]
		[Address(RVA = "0x1413228", Offset = "0x1413228", VA = "0x1413228")]
		public static Event FirstFlagCrowned(AnalyticsLevelData aLevelData)
		{
			return default;
		}

		[Token(Token = "0x6004D2B")]
		[Address(RVA = "0x14133C8", Offset = "0x14133C8", VA = "0x14133C8")]
		public static Event CampaignStarted(string campaignId, bool isOnboarding)
		{
			return default;
		}

		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0x14135CC", Offset = "0x14135CC", VA = "0x14135CC")]
		public static Event DailyCampaignEnded(string campaignId, bool completed, bool isReplay, int exitLevel, string packID, int strokeCount, float timeSpentInCampaignSeconds)
		{
			return default;
		}

		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x1413A18", Offset = "0x1413A18", VA = "0x1413A18")]
		public static Event CampaignEnded(string campaignId, bool isOnboarding, bool completed, float timeSpentOverworld, float timeSpentLevels, float timeSpentChallenges, Vector3 ballPosition, string sectionId)
		{
			return default;
		}

		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x1413FDC", Offset = "0x1413FDC", VA = "0x1413FDC")]
		internal static Event OnPrizeSceneLeave(double timeSpent, bool DidUnpackPrize, string LastPrizeReceived)
		{
			return default;
		}

		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x141421C", Offset = "0x141421C", VA = "0x141421C")]
		public static Event FlagFinderUsed(string campaignId)
		{
			return default;
		}

		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x1414394", Offset = "0x1414394", VA = "0x1414394")]
		public static Event HitTalkingThing(string campaignId, ShowSpeechbubbleOnHit bubble)
		{
			return default;
		}

		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x1414754", Offset = "0x1414754", VA = "0x1414754")]
		public static Event GameboyPopup(bool confirmed, GameboyPopup.Type type)
		{
			return default;
		}

		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x14148B4", Offset = "0x14148B4", VA = "0x14148B4")]
		public static Event ErrorReceived(string condition, string stacktrace, string sceneName, Vector2? ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x1414A24", Offset = "0x1414A24", VA = "0x1414A24")]
		public static Event NewLevelCreated()
		{
			return default;
		}

		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x1414B68", Offset = "0x1414B68", VA = "0x1414B68")]
		public static Event LevelCloned()
		{
			return default;
		}

		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x1414CAC", Offset = "0x1414CAC", VA = "0x1414CAC")]
		public static Event LevelDeleted()
		{
			return default;
		}

		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x1414DF0", Offset = "0x1414DF0", VA = "0x1414DF0")]
		public static Event FirstTimeLevelSaved()
		{
			return default;
		}

		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x1414F34", Offset = "0x1414F34", VA = "0x1414F34")]
		public static Event FirstTimeLevelTested()
		{
			return default;
		}

		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x1415078", Offset = "0x1415078", VA = "0x1415078")]
		public static Event LevelDesignerClosed(float sessionLengthMinutes)
		{
			return default;
		}

		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x1410CA4", Offset = "0x1410CA4", VA = "0x1410CA4")]
		public static Event AddPlayerScore(this Event e)
		{
			return default;
		}
	}
}
