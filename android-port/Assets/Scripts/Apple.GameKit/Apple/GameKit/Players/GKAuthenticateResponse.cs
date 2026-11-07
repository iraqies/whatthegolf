using Il2CppDummyDll;

namespace Apple.GameKit.Players
{
	[Token(Token = "0x2000006")]
	public struct GKAuthenticateResponse
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		public bool IsAuthenticated;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		public GKLocalPlayer Player;
	}
}
