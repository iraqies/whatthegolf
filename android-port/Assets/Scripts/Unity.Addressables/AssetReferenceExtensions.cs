using UnityEngine.AddressableAssets;

public static class AssetReferenceExtensions
{
	public static bool IsNull(this AssetReference assetReference)
	{
		if (assetReference == null)
			return true;
		if (assetReference is AssetReferenceScene sceneRef && !string.IsNullOrEmpty(sceneRef.SceneName))
			return false;
		return string.IsNullOrEmpty(assetReference.AssetGUID);
	}
}
