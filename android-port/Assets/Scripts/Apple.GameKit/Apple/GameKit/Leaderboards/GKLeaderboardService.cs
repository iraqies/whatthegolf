using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;
using Il2CppDummyDll;

namespace Apple.GameKit.Leaderboards
{
	[Token(Token = "0x200000A")]
	public static class GKLeaderboardService
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TaskCompletionSource<bool> _submitScoreTCS;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TaskCompletionSource<bool> _showLeaderboardTCS;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static TaskCompletionSource<IEnumerable<GKLeaderboard>> _loadLeaderboardsTCS;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static TaskCompletionSource<GKLoadLeaderboardScoresResponse> _loadScoresTCS;

		[PreserveSig]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x12E894C", Offset = "0x12E894C", VA = "0x12E894C")]
		private static extern void GameKitWrapper_SubmitLeaderboardScore(string leaderboardId, long score, long context, SuccessCallback onSuccess, ErrorCallback onError);

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x12E89BC", Offset = "0x12E89BC", VA = "0x12E89BC")]
		public static Task SubmitScore(string leaderboardId, long score, long context)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x12E83FC", Offset = "0x12E83FC", VA = "0x12E83FC")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32B84", Offset = "0x32B84")]
		private static void OnSubmitScoreSuccess()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x12E8474", Offset = "0x12E8474", VA = "0x12E8474")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32BEC", Offset = "0x32BEC")]
		private static void OnSubmitScoreFailed(InteropError error)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12E8BC8", Offset = "0x12E8BC8", VA = "0x12E8BC8")]
		private static extern void GameKitWrapper_ShowLeaderboardDialog(string leaderboardId, GKLeaderboardTimeScope timeScope, SuccessCallback onClosedSuccess);

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x12E8C14", Offset = "0x12E8C14", VA = "0x12E8C14")]
		public static Task ShowLeaderboardDialog(string leaderboardId, GKLeaderboardTimeScope timeScope = GKLeaderboardTimeScope.AllTime)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x12E8588", Offset = "0x12E8588", VA = "0x12E8588")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32C54", Offset = "0x32C54")]
		private static void OnShowLeaderboardDialogClosed()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12E8DBC", Offset = "0x12E8DBC", VA = "0x12E8DBC")]
		private static extern void GameKitWrapper_LoadLeaderboards(SuccessCallback<GKLoadLeaderboardsResponse> onLoaded, ErrorCallback onError);

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x12E8DF0", Offset = "0x12E8DF0", VA = "0x12E8DF0")]
		public static Task<IEnumerable<GKLeaderboard>> LoadLeaderboards()
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x12E8600", Offset = "0x12E8600", VA = "0x12E8600")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32CBC", Offset = "0x32CBC")]
		private static void OnLoadLeaderboardData(GKLoadLeaderboardsResponse response)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x12E8688", Offset = "0x12E8688", VA = "0x12E8688")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32D24", Offset = "0x32D24")]
		private static void OnLoadLeaderboardsFailed(InteropError error)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x12E919C", Offset = "0x12E919C", VA = "0x12E919C")]
		private static extern void GameKitWrapper_LoadLeaderboardScores(string leaderboardIdentifier, GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope, int rankMin, int rankMax, bool previousOccurrence, SuccessCallback<GKLoadLeaderboardScoresResponse> onLoaded, ErrorCallback onError);

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x12E922C", Offset = "0x12E922C", VA = "0x12E922C")]
		public static Task<GKLoadLeaderboardScoresResponse> LoadScores(string leaderboardIdentifier, GKLeaderboardPlayerScope playerScope = GKLeaderboardPlayerScope.Global, GKLeaderboardTimeScope timeScope = GKLeaderboardTimeScope.AllTime, int rankMin = 1, int rankMax = 100, bool previousOccurrence = false)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x12E879C", Offset = "0x12E879C", VA = "0x12E879C")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32D8C", Offset = "0x32D8C")]
		private static void OnLoadScoresData(GKLoadLeaderboardScoresResponse response)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x12E8838", Offset = "0x12E8838", VA = "0x12E8838")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32DF4", Offset = "0x32DF4")]
		private static void OnLoadScoresError(InteropError error)
		{
		}
	}
}
