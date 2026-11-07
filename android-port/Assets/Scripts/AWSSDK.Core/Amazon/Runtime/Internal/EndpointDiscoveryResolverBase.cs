using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public abstract class EndpointDiscoveryResolverBase
	{
		private IClientConfig _config;

		private Logger _logger;

		private LruCache<string, IList<DiscoveryEndpointBase>> _cache;

		private object objectCacheLock;

		public virtual int CacheCount => 0;

		protected EndpointDiscoveryResolverBase(IClientConfig config, Logger logger)
		{
		}

		public virtual IEnumerable<DiscoveryEndpointBase> ResolveEndpoints(EndpointOperationContextBase context, Func<IList<DiscoveryEndpointBase>> InvokeEndpointOperation)
		{
			return null;
		}

		private IEnumerable<DiscoveryEndpointBase> ProcessInvokeEndpointOperation(string cacheKey, Func<IList<DiscoveryEndpointBase>> InvokeEndpointOperation, bool endpointRequired)
		{
			return null;
		}

		public virtual IList<DiscoveryEndpointBase> GetDiscoveryEndpointsFromCache(string cacheKey)
		{
			return null;
		}

		private IEnumerable<DiscoveryEndpointBase> ProcessEndpointCache(string cacheKey, bool evictCacheKey, Uri evictUri, out bool refreshCache)
		{
			refreshCache = default;
			return null;
		}

		private static string BuildEndpointDiscoveryCacheKey(EndpointOperationContextBase context)
		{
			return null;
		}
	}
}
