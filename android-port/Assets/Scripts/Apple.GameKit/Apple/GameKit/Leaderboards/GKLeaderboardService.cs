using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;

namespace Apple.GameKit.Leaderboards
{
	public static class GKLeaderboardService
	{
		private static TaskCompletionSource<bool> _submitScoreTCS;

		private static TaskCompletionSource<bool> _showLeaderboardTCS;

		private static TaskCompletionSource<IEnumerable<GKLeaderboard>> _loadLeaderboardsTCS;

		private static TaskCompletionSource<GKLoadLeaderboardScoresResponse> _loadScoresTCS;

		[PreserveSig]
		private static extern void GameKitWrapper_SubmitLeaderboardScore(string leaderboardId, long score, long context, SuccessCallback onSuccess, ErrorCallback onError);

		public static Task SubmitScore(string leaderboardId, long score, long context)
		{
			return null;
		}

		private static void OnSubmitScoreSuccess()
		{
		}

		private static void OnSubmitScoreFailed(InteropError error)
		{
		}

		[PreserveSig]
		private static extern void GameKitWrapper_ShowLeaderboardDialog(string leaderboardId, GKLeaderboardTimeScope timeScope, SuccessCallback onClosedSuccess);

		public static Task ShowLeaderboardDialog(string leaderboardId, GKLeaderboardTimeScope timeScope = GKLeaderboardTimeScope.AllTime)
		{
			return null;
		}

		private static void OnShowLeaderboardDialogClosed()
		{
		}

		[PreserveSig]
		private static extern void GameKitWrapper_LoadLeaderboards(SuccessCallback<GKLoadLeaderboardsResponse> onLoaded, ErrorCallback onError);

		public static Task<IEnumerable<GKLeaderboard>> LoadLeaderboards()
		{
			return null;
		}

		private static void OnLoadLeaderboardData(GKLoadLeaderboardsResponse response)
		{
		}

		private static void OnLoadLeaderboardsFailed(InteropError error)
		{
		}

		[PreserveSig]
		private static extern void GameKitWrapper_LoadLeaderboardScores(string leaderboardIdentifier, GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope, int rankMin, int rankMax, bool previousOccurrence, SuccessCallback<GKLoadLeaderboardScoresResponse> onLoaded, ErrorCallback onError);

		public static Task<GKLoadLeaderboardScoresResponse> LoadScores(string leaderboardIdentifier, GKLeaderboardPlayerScope playerScope = GKLeaderboardPlayerScope.Global, GKLeaderboardTimeScope timeScope = GKLeaderboardTimeScope.AllTime, int rankMin = 1, int rankMax = 100, bool previousOccurrence = false)
		{
			return null;
		}

		private static void OnLoadScoresData(GKLoadLeaderboardScoresResponse response)
		{
		}

		private static void OnLoadScoresError(InteropError error)
		{
		}
	}
}
