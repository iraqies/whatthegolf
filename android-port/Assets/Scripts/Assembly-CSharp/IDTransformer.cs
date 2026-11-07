using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

internal static class IDTransformer
{
	private static string ODRPathResolve(IResourceLocation location)
	{
		if (location == null) return null;
		string id = location.InternalId;
		if (string.IsNullOrEmpty(id)) return id;

		if (location.ResourceType == typeof(IAssetBundleResource) && id.StartsWith("ios:"))
		{
			string rel = id.Substring(4).TrimStart('/');
			string odrPath = Path.Combine(ODRDownloadManager.CachePath, rel);
			if (File.Exists(odrPath))
				return odrPath;
			string saPath = Path.Combine(Application.streamingAssetsPath, "aa", "iOS", rel);
			return saPath;
		}

		// On Android, Addressables.RuntimePath expands to StreamingAssets/aa, where the bundles live under /iOS/
		if (id.Contains("/Android/") && !id.Contains("/iOS/"))
		{
			id = id.Replace("/Android/", "/iOS/");
		}
		return id;
	}

	[RuntimeInitializeOnLoadMethod]
	private static void SetInternalIdTransform()
	{
		Addressables.InternalIdTransformFunc = ODRPathResolve;
	}
}
