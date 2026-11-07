using Il2CppDummyDll;

[Token(Token = "0x20003AD")]
public class ODRVersionManager
{
	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x10")]
	private ODRVersionDictionary _cachedOdrVersionDictionary;

	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x18")]
	private string _buildVersion;

	[Token(Token = "0x1700020D")]
	private static string CachedVersionPath
	{
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x15913F4", Offset = "0x15913F4", VA = "0x15913F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020E")]
	private ODRVersionDictionary CachedOdrVersionDictionary
	{
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x1591514", Offset = "0x1591514", VA = "0x1591514")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020F")]
	private string BuildVersion
	{
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x15916E0", Offset = "0x15916E0", VA = "0x15916E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600116B")]
	[Address(RVA = "0x1591770", Offset = "0x1591770", VA = "0x1591770")]
	private bool TryGetItem(string resourceName, out ODRVersion odrVersion)
	{
		return default;
	}

	[Token(Token = "0x600116C")]
	[Address(RVA = "0x1590484", Offset = "0x1590484", VA = "0x1590484")]
	public bool IsSameVersion(string resourceName)
	{
		return default;
	}

	[Token(Token = "0x600116D")]
	[Address(RVA = "0x15917B0", Offset = "0x15917B0", VA = "0x15917B0")]
	public void RemoveVersion(string resourceName)
	{
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0x1590B10", Offset = "0x1590B10", VA = "0x1590B10")]
	public void UpdateVersion(string resourceName)
	{
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0x1591870", Offset = "0x1591870", VA = "0x1591870")]
	private void Save()
	{
	}

	[Token(Token = "0x6001170")]
	[Address(RVA = "0x1590260", Offset = "0x1590260", VA = "0x1590260")]
	public ODRVersionManager()
	{
	}
}
