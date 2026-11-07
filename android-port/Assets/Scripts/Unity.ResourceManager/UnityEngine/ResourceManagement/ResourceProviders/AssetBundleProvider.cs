using System;
using System.ComponentModel;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName]
	public class AssetBundleProvider : ResourceProviderBase
	{
		internal static void WaitForAllUnloadingBundlesToComplete()
		{
		}

		public override void Provide(ProvideHandle providerInterface)
		{
		}

		public override Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		public override void Release(IResourceLocation location, object asset)
		{
		}

		internal virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType)
		{
			return null;
		}
	}
}
