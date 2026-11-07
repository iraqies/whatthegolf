using System;
using System.ComponentModel;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName]
public class TribandAssetBundleProvider : AssetBundleProvider
{
	public override void Release(IResourceLocation location, object asset)
	{
	}

	public override AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
	{
		return default;
	}

	public override bool CanProvide(Type t, IResourceLocation location)
	{
		return false;
	}

	public override Type GetDefaultType(IResourceLocation location)
	{
		return null;
	}

	public override bool Initialize(string id, string data)
	{
		return false;
	}

	public override void Provide(ProvideHandle providerInterface)
	{
	}
}
