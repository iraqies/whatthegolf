using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime
{
	public static class FallbackRegionFactory
	{
		private delegate AWSRegion RegionGenerator();

		private static CredentialProfileStoreChain credentialProfileChain;

		private static object _lock;

		private static AWSRegion cachedRegion;

		private static List<RegionGenerator> AllGenerators { get; set; }

		private static List<RegionGenerator> NonMetadataGenerators { get; set; }

		static FallbackRegionFactory()
		{
		}

		public static void Reset()
		{
		}

		public static RegionEndpoint GetRegionEndpoint()
		{
			return null;
		}

		public static RegionEndpoint GetRegionEndpoint(bool includeInstanceMetadata)
		{
			return null;
		}
	}
}
