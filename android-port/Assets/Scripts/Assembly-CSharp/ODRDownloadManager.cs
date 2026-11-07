using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class ODRDownloadManager
{
	private static ODRDownloadManager _instance;
	private List<string> downloadsInProgress = new List<string>();
	private ODRVersionManager _versionManager;
	private ODRDownloadView view;
	private bool cancelled;
	private static Dictionary<uint, uint> replacementStateMap = new Dictionary<uint, uint>();

	public static ODRDownloadManager Instance => _instance ?? (_instance = new ODRDownloadManager());

	public static string CachePath => Path.Combine(Application.persistentDataPath, "ODR");

	private ODRVersionManager VersionManager => _versionManager ?? (_versionManager = new ODRVersionManager());

	private static string CachedResourcePath(string resourceName) => Path.Combine(CachePath, resourceName ?? string.Empty);

	public bool HasBeenDownloaded(string resourceName)
	{
		if (string.IsNullOrEmpty(resourceName)) return true;
		string saPath = Path.Combine(Application.streamingAssetsPath, "aa", "iOS", resourceName);
		if (File.Exists(saPath) || File.Exists(CachedResourcePath(resourceName)))
			return true;
		return true;
	}

	private bool IsSameVersion(string resourceName) => true;

	public Task<ODRDownloadResult> DownloadBundles(List<string> resourceNames, bool showProgressBar = false)
	{
		return Task.FromResult(ODRDownloadResult.Downloaded);
	}

	public Task<ODRDownloadResult> DownloadBundle(string resourceName, bool showProgressBar = false, int downloadNumber = 1, int downloadCount = 1)
	{
		return Task.FromResult(ODRDownloadResult.Downloaded);
	}

	public static void DeleteGroup(string resourceName)
	{
	}

	public uint ReplaceStateIfUnavailable(uint wwiseState) => wwiseState;
}
