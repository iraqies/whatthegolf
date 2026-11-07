using Il2CppDummyDll;

[Token(Token = "0x2000B7C")]
public class SteamApi
{
	[Token(Token = "0x400400C")]
	[FieldOffset(Offset = "0x0")]
	private static SteamApi steamApi;

	[Token(Token = "0x400400D")]
	[FieldOffset(Offset = "0x10")]
	private bool isValid;

	[Token(Token = "0x170005D2")]
	public static SteamApi Instance
	{
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x16DD344", Offset = "0x16DD344", VA = "0x16DD344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D3")]
	public bool IsValid
	{
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x16DDE50", Offset = "0x16DDE50", VA = "0x16DDE50")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005D4")]
	public bool IsLoggedOn
	{
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x16DDE58", Offset = "0x16DDE58", VA = "0x16DDE58")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005D5")]
	public ulong SteamId
	{
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x16DD3BC", Offset = "0x16DD3BC", VA = "0x16DD3BC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005D6")]
	public string Name
	{
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x16DDE60", Offset = "0x16DDE60", VA = "0x16DDE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600376A")]
	[Address(RVA = "0x16DDE3C", Offset = "0x16DDE3C", VA = "0x16DDE3C")]
	public SteamApi()
	{
	}

	[Token(Token = "0x600376B")]
	[Address(RVA = "0x16DDE44", Offset = "0x16DDE44", VA = "0x16DDE44")]
	public bool Login()
	{
		return default;
	}

	[Token(Token = "0x600376C")]
	[Address(RVA = "0x16DDE4C", Offset = "0x16DDE4C", VA = "0x16DDE4C")]
	public void Shutdown()
	{
	}
}
