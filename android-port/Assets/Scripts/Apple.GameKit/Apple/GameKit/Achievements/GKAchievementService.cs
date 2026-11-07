using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;
using Il2CppDummyDll;

namespace Apple.GameKit.Achievements
{
	[Token(Token = "0x2000011")]
	public static class GKAchievementService
	{
		[PreserveSig]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x12E7EA4", Offset = "0x12E7EA4", VA = "0x12E7EA4")]
		private static extern void GameKitWrapper_ReportAchievement(string identifier, double percentage, bool showCompletionBanner, string taskId, SuccessCallback<string> onSuccess, ErrorCallback onError);

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12E7F38", Offset = "0x12E7F38", VA = "0x12E7F38")]
		public static Task ReportAchievementProgress(string identifier, double percentage, bool showCompletionBanner)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x12E8104", Offset = "0x12E8104", VA = "0x12E8104")]
		private static extern void GameKitWrapper_ResetAllAchievements(string taskId, SuccessCallback<string> onSuccess, ErrorCallback onError);

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x12E815C", Offset = "0x12E815C", VA = "0x12E815C")]
		public static Task ResetAllAchievements()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x12E7C88", Offset = "0x12E7C88", VA = "0x12E7C88")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32E5C", Offset = "0x32E5C")]
		private static void OnSuccess(string taskId)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x12E7D44", Offset = "0x12E7D44", VA = "0x12E7D44")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32EC4", Offset = "0x32EC4")]
		private static void OnBoolError(InteropError error)
		{
		}
	}
}
