public class SteamApi
{
	private static SteamApi steamApi;

	private bool isValid;

	public static SteamApi Instance => null;

	public bool IsValid => false;

	public bool IsLoggedOn => false;

	public ulong SteamId => 0uL;

	public string Name => null;

	public bool Login()
	{
		return false;
	}

	public void Shutdown()
	{
	}
}
