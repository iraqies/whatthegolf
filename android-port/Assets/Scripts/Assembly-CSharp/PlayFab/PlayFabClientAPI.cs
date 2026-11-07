using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using PlayFab.ClientModels;

namespace PlayFab
{
	[Token(Token = "0x2001180")]
	public static class PlayFabClientAPI
	{
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x15EA0C0", Offset = "0x15EA0C0", VA = "0x15EA0C0")]
		public static bool IsClientLoggedIn()
		{
			return default;
		}

		[Token(Token = "0x600500F")]
		[Address(RVA = "0x15EA13C", Offset = "0x15EA13C", VA = "0x15EA13C")]
		public static void GetLeaderboard(GetLeaderboardRequest request, Action<GetLeaderboardResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}

		[Token(Token = "0x6005010")]
		[Address(RVA = "0x15EA314", Offset = "0x15EA314", VA = "0x15EA314")]
		public static void GetLeaderboardAroundPlayer(GetLeaderboardAroundPlayerRequest request, Action<GetLeaderboardAroundPlayerResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}

		[Token(Token = "0x6005011")]
		[Address(RVA = "0x15EA4EC", Offset = "0x15EA4EC", VA = "0x15EA4EC")]
		public static void GetTime(GetTimeRequest request, Action<GetTimeResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}

		[Token(Token = "0x6005012")]
		[Address(RVA = "0x15EA6C4", Offset = "0x15EA6C4", VA = "0x15EA6C4")]
		public static void LoginWithCustomID(LoginWithCustomIDRequest request, Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}

		[Token(Token = "0x6005013")]
		[Address(RVA = "0x15EA844", Offset = "0x15EA844", VA = "0x15EA844")]
		public static void UpdatePlayerStatistics(UpdatePlayerStatisticsRequest request, Action<UpdatePlayerStatisticsResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}

		[Token(Token = "0x6005014")]
		[Address(RVA = "0x15EAA1C", Offset = "0x15EAA1C", VA = "0x15EAA1C")]
		public static void UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request, Action<UpdateUserTitleDisplayNameResult> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}
	}
}
