using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	public class LegacyResourcesLocator : IResourceLocator
	{
		public IEnumerable<object> Keys => null;

		public string LocatorId => null;

		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			locations = null;
			return false;
		}
	}
}
