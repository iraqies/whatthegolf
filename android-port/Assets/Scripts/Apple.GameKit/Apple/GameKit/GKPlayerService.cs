using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;
using Apple.GameKit.Players;

namespace Apple.GameKit
{
	public static class GKPlayerService
	{
		private static TaskCompletionSource<GKAuthenticateResponse> _authenticateTCS;

		[PreserveSig]
		private static extern void GameKitWrapper_Authenticate(SuccessCallback<GKAuthenticateResponse> callback, ErrorCallback errorCallback);

		public static Task<GKAuthenticateResponse> Authenticate()
		{
			return null;
		}

		private static void OnAuthenticateError(InteropError error)
		{
		}

		private static void OnAuthenticate(GKAuthenticateResponse response)
		{
		}

		[PreserveSig]
		private static extern GKLocalPlayer GameKitWrapper_FetchLocalPlayer();

		public static GKLocalPlayer FetchLocalPlayer()
		{
			return default;
		}
	}
}
