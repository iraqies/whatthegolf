using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.iOS;

public class ODRDownloadManager
{
	private static ODRDownloadManager _instance;

	private List<string> downloadsInProgress;

	private ODRVersionManager _versionManager;

	private ODRDownloadView view;

	private bool cancelled;

	private static Dictionary<uint, uint> replacementStateMap;

	public static ODRDownloadManager Instance => null;

	public static string CachePath => null;

	private ODRVersionManager VersionManager => null;

	private static string CachedResourcePath(string resourceName)
	{
		return null;
	}

	public bool HasBeenDownloaded(string resourceName)
	{
		return false;
	}

	private bool IsSameVersion(string resourceName)
	{
		return false;
	}

	public Task<ODRDownloadResult> DownloadBundles(List<string> resourceNames, bool showProgressBar = false)
	{
		return null;
	}

	public Task<ODRDownloadResult> DownloadBundle(string resourceName, bool showProgressBar = false, int downloadNumber = 1, int downloadCount = 1)
	{
		return null;
	}

	public static void DeleteGroup(string resourceName)
	{
	}

	private Task AwaitDownload(OnDemandResourcesRequest onDemandResourcesRequest, bool showProgressBar, int downloadNumber, int downloadCount)
	{
		return null;
	}

	private void OnDownloadCancelled()
	{
	}

	private void CacheFile(string resourceName, string resourcePath, string buildVersionString, OnDemandResourcesRequest onDemandResourcesRequest)
	{
	}

	public uint ReplaceStateIfUnavailable(uint wwiseState)
	{
		return 0u;
	}
}
