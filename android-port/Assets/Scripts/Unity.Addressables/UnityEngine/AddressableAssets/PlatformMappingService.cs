using System;
using System.Collections.Generic;

namespace UnityEngine.AddressableAssets
{
	public class PlatformMappingService
	{
		internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping;

		internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform)
		{
			return AddressablesPlatform.Unknown;
		}

		internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform)
		{
			return null;
		}

		[Obsolete]
		public static AddressablesPlatform GetPlatform()
		{
			return AddressablesPlatform.Unknown;
		}

		public static string GetPlatformPathSubFolder()
		{
			return null;
		}
	}
}
