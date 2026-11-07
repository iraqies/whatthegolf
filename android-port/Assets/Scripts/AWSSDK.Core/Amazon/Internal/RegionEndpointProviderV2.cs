using System.Collections.Generic;
using System.IO;
using System.Net;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	public class RegionEndpointProviderV2 : IRegionEndpointProvider
	{
		public class RegionEndpoint : IRegionEndpoint
		{
			private const string REGIONS_FILE = "Core.endpoints.json";

			private const string REGIONS_CUSTOMIZATIONS_FILE = "Core.endpoints.customizations.json";

			private const string DEFAULT_RULE = "*/*";

			private static Dictionary<string, JsonData> _documentEndpoints;

			private const int MAX_DOWNLOAD_RETRIES = 3;

			private static bool loaded;

			private static readonly object LOCK_OBJECT;

			private static Dictionary<string, RegionEndpoint> hashBySystemName;

			public static IEnumerable<RegionEndpoint> EnumerableAllRegions => null;

			public string SystemName { get; private set; }

			public string DisplayName { get; private set; }

			public string RegionName => null;

			public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
			{
				return null;
			}

			private JsonData GetEndpointRule(string serviceName)
			{
				return null;
			}

			private static RegionEndpoint GetEndpoint(string systemName, string displayName)
			{
				return null;
			}

			public static RegionEndpoint GetBySystemName(string systemName)
			{
				return null;
			}

			private static void LoadEndpointDefinitions()
			{
			}

			public static void LoadEndpointDefinitions(string endpointsPath)
			{
			}

			private static void ReadEndpointFile(Stream stream)
			{
			}

			private static void LoadEndpointDefinitionsFromEmbeddedResource()
			{
			}

			private static bool TryLoadEndpointDefinitionsFromAssemblyDir()
			{
				return false;
			}

			private static void LoadEndpointDefinitionFromFilePath(string path)
			{
			}

			private static void LoadEndpointDefinitionFromWeb(string url)
			{
			}

			public static void UnloadEndpointDefinitions()
			{
			}

			private RegionEndpoint(string systemName, string displayName)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public static IWebProxy Proxy { get; set; }

		public IEnumerable<IRegionEndpoint> AllRegionEndpoints => null;

		public IRegionEndpoint GetRegionEndpoint(string regionName)
		{
			return null;
		}
	}
}
