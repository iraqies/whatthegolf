using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	public static class SdkCache
	{
		internal class CacheKey
		{
			public ImmutableCredentials ImmutableCredentials { get; private set; }

			public RegionEndpoint RegionEndpoint { get; private set; }

			public string ServiceUrl { get; private set; }

			public object CacheType { get; private set; }

			private CacheKey()
			{
			}

			public static CacheKey Create(AmazonServiceClient client, object cacheType)
			{
				return null;
			}

			public static CacheKey Create(object cacheType)
			{
				return null;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}
		}

		private static object cacheLock;

		private static Cache<CacheKey, ICache> cache;

		public static void Clear()
		{
		}

		public static void Clear(object cacheType)
		{
		}

		public static ICache<TKey, TValue> GetCache<TKey, TValue>(object client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}

		public static ICache<TKey, TValue> GetCache<TKey, TValue>(AmazonServiceClient client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}
	}
}
