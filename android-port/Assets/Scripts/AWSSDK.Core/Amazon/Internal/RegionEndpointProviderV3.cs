using System.Collections.Generic;
using System.IO;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	public class RegionEndpointProviderV3 : IRegionEndpointProvider
	{
		private const string ENDPOINT_JSON_RESOURCE = "Core.endpoints.json";

		private const string ENDPOINT_JSON = "endpoints.json";

		private JsonData _root;

		private Dictionary<string, IRegionEndpoint> _regionEndpointMap;

		private object _regionEndpointMapLock;

		private object _allRegionEndpointsLock;

		private IEnumerable<IRegionEndpoint> _allRegionEndpoints;

		private static JsonData _emptyDictionaryJsonData;

		public IEnumerable<IRegionEndpoint> AllRegionEndpoints => null;

		public RegionEndpointProviderV3()
		{
		}

		public RegionEndpointProviderV3(JsonData root)
		{
		}

		private static Stream GetEndpointJsonSourceStream()
		{
			return null;
		}

		private static string GetUnknownRegionDescription(string regionName)
		{
			return null;
		}

		private static bool IsRegionInPartition(string regionName, JsonData partition, out string description)
		{
			description = null;
			return false;
		}

		public IRegionEndpoint GetRegionEndpoint(string regionName)
		{
			return null;
		}

		private IRegionEndpoint GetNonstandardRegionEndpoint(string regionName)
		{
			return null;
		}
	}
}
