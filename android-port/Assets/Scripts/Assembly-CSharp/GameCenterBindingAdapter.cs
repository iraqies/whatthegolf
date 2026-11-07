using System.Threading.Tasks;
using Apple.GameKit.Players;
using Il2CppDummyDll;

[Token(Token = "0x2000C9F")]
public static class GameCenterBindingAdapter
{
	[Token(Token = "0x6003BB5")]
	[Address(RVA = "0x147CE54", Offset = "0x147CE54", VA = "0x147CE54")]
	public static Task<GKAuthenticateResponse> AuthenticateGCPlayer()
	{
		return null;
	}

	[Token(Token = "0x6003BB6")]
	[Address(RVA = "0x14780CC", Offset = "0x14780CC", VA = "0x14780CC")]
	public static GKLocalPlayer FetchLocalGCPlayer()
	{
		return default;
	}
}
