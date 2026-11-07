using Il2CppDummyDll;

[Token(Token = "0x2000C78")]
public class ArcadeIdentity
{
	[Token(Token = "0x400444D")]
	[FieldOffset(Offset = "0x0")]
	public static string gameCenterId;

	[Token(Token = "0x1700060E")]
	public static bool hasGameCenterUser
	{
		[Token(Token = "0x6003B26")]
		[Address(RVA = "0x141DE54", Offset = "0x141DE54", VA = "0x141DE54")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6003B27")]
	[Address(RVA = "0x141DEE4", Offset = "0x141DEE4", VA = "0x141DEE4")]
	public static void SetGameCenterUser(string id, string username)
	{
	}
}
