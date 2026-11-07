using System.Collections.Generic;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	public class RegionEndpointV3 : IRegionEndpoint
	{
		private class ServiceMap
		{
			private Dictionary<string, RegionEndpoint.Endpoint> _serviceMap;

			private Dictionary<string, RegionEndpoint.Endpoint> _dualServiceMap;

			private Dictionary<string, RegionEndpoint.Endpoint> GetMap(bool dualStack)
			{
				return null;
			}

			public bool ContainsKey(string servicName)
			{
				return false;
			}

			public void Add(string serviceName, bool dualStack, RegionEndpoint.Endpoint endpoint)
			{
			}

			public bool TryGetEndpoint(string serviceName, bool dualStack, out RegionEndpoint.Endpoint endpoint)
			{
				endpoint = null;
				return false;
			}
		}

		private ServiceMap _serviceMap;

		private JsonData _partitionJsonData;

		private JsonData _servicesJsonData;

		private bool _servicesLoaded;

		public string RegionName { get; private set; }

		public string DisplayName { get; private set; }

		public string PartitionName => null;

		public string PartitionDnsSuffix => null;

		public RegionEndpointV3(string regionName, string displayName, JsonData partition, JsonData services)
		{
		}

		public RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
		{
			return null;
		}

		private RegionEndpoint.Endpoint CreateUnknownEndpoint(string serviceName, bool dualStack)
		{
			return null;
		}

		private void ParseAllServices()
		{
		}

		private void AddServiceToMap(JsonData service, string serviceName)
		{
		}

		private static void MergeJsonData(JsonData target, JsonData source)
		{
		}

		private void CreateEndpointAndAddToServiceMap(JsonData result, string regionName, string serviceName)
		{
		}

		private void CreateEndpointAndAddToServiceMap(JsonData result, string regionName, string serviceName, bool dualStack)
		{
		}

		private static string DetermineSignatureOverride(JsonData defaults, string serviceName)
		{
			return null;
		}

		private static string DetermineAuthRegion(JsonData credentialScope)
		{
			return null;
		}
	}
}
