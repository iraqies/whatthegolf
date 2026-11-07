using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime
{
	[Obsolete]
	public static class FallbackEndpointDiscoveryEnabledFactory
	{
		private delegate bool ConfigGenerator();

		private static CredentialProfileStoreChain credentialProfileChain;

		private static object _lock;

		private static bool? endpointDiscoveryEnabled;

		private static List<ConfigGenerator> EnabledGenerators { get; set; }

		static FallbackEndpointDiscoveryEnabledFactory()
		{
		}

		public static void Reset()
		{
		}

		public static bool? GetEnabled()
		{
			return null;
		}
	}
}
