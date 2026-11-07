using System;
using Core;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Token(Token = "0x2001125")]
	public static class AnalyticsPlayerPrefs
	{
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x1415534", Offset = "0x1415534", VA = "0x1415534")]
		public static void ResetPreviousSessionData()
		{
		}

		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x14155A4", Offset = "0x14155A4", VA = "0x14155A4")]
		public static void SaveCurrentDateTime()
		{
		}

		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x1410B58", Offset = "0x1410B58", VA = "0x1410B58")]
		public static TimeSpan GetTimeSpanSinceLastSession()
		{
			return default;
		}

		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x1410DB0", Offset = "0x1410DB0", VA = "0x1410DB0")]
		public static bool TryGetDateOfLastSession(out DateTime time)
		{
			return default;
		}

		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x141568C", Offset = "0x141568C", VA = "0x141568C")]
		public static void SetDidUseController(bool didUse)
		{
		}

		[Token(Token = "0x6004D4C")]
		[Address(RVA = "0x14156E4", Offset = "0x14156E4", VA = "0x14156E4")]
		public static bool HasAnyCrownedFlag()
		{
			return default;
		}

		[Token(Token = "0x6004D4D")]
		[Address(RVA = "0x141572C", Offset = "0x141572C", VA = "0x141572C")]
		public static void SaveCrownedFlag(LevelData levelData)
		{
		}

		[Token(Token = "0x6004D4E")]
		[Address(RVA = "0x14157FC", Offset = "0x14157FC", VA = "0x14157FC")]
		public static string GetLastLevelID()
		{
			return null;
		}

		[Token(Token = "0x6004D4F")]
		[Address(RVA = "0x1415844", Offset = "0x1415844", VA = "0x1415844")]
		public static void SaveLastLevelID(string levelId)
		{
		}

		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x141589C", Offset = "0x141589C", VA = "0x141589C")]
		public static void SetFirstPlayDay(string contentPackID)
		{
		}
	}
}
