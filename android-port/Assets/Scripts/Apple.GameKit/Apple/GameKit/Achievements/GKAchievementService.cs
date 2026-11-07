using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;

namespace Apple.GameKit.Achievements
{
	public static class GKAchievementService
	{
		[PreserveSig]
		private static extern void GameKitWrapper_ReportAchievement(string identifier, double percentage, bool showCompletionBanner, string taskId, SuccessCallback<string> onSuccess, ErrorCallback onError);

		public static Task ReportAchievementProgress(string identifier, double percentage, bool showCompletionBanner)
		{
			return null;
		}

		[PreserveSig]
		private static extern void GameKitWrapper_ResetAllAchievements(string taskId, SuccessCallback<string> onSuccess, ErrorCallback onError);

		public static Task ResetAllAchievements()
		{
			return null;
		}

		private static void OnSuccess(string taskId)
		{
		}

		private static void OnBoolError(InteropError error)
		{
		}
	}
}
