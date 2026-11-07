public class ODRVersionManager
{
	private ODRVersionDictionary _cachedOdrVersionDictionary;

	private string _buildVersion;

	private static string CachedVersionPath => null;

	private ODRVersionDictionary CachedOdrVersionDictionary => null;

	private string BuildVersion => null;

	private bool TryGetItem(string resourceName, out ODRVersion odrVersion)
	{
		odrVersion = null;
		return false;
	}

	public bool IsSameVersion(string resourceName)
	{
		return false;
	}

	public void RemoveVersion(string resourceName)
	{
	}

	public void UpdateVersion(string resourceName)
	{
	}

	private void Save()
	{
	}
}
