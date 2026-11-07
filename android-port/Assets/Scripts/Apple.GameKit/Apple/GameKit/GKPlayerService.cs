using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.Core.Runtime;
using Apple.GameKit.Players;
using Il2CppDummyDll;

namespace Apple.GameKit
{
	[Token(Token = "0x2000003")]
	public static class GKPlayerService
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TaskCompletionSource<GKAuthenticateResponse> _authenticateTCS;

		[PreserveSig]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x12E9868", Offset = "0x12E9868", VA = "0x12E9868")]
		private static extern void GameKitWrapper_Authenticate(SuccessCallback<GKAuthenticateResponse> callback, ErrorCallback errorCallback);

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x12E989C", Offset = "0x12E989C", VA = "0x12E989C")]
		public static Task<GKAuthenticateResponse> Authenticate()
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x12E9658", Offset = "0x12E9658", VA = "0x12E9658")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32A4C", Offset = "0x32A4C")]
		private static void OnAuthenticateError(InteropError error)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x12E97A0", Offset = "0x12E97A0", VA = "0x12E97A0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x32AB4", Offset = "0x32AB4")]
		private static void OnAuthenticate(GKAuthenticateResponse response)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x12E9A88", Offset = "0x12E9A88", VA = "0x12E9A88")]
		private static extern GKLocalPlayer GameKitWrapper_FetchLocalPlayer();

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x12E9B5C", Offset = "0x12E9B5C", VA = "0x12E9B5C")]
		public static GKLocalPlayer FetchLocalPlayer()
		{
			return default;
		}
	}
}
