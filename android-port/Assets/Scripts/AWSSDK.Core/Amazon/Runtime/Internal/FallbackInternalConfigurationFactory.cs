using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime.Internal
{
	public static class FallbackInternalConfigurationFactory
	{
		private delegate InternalConfiguration ConfigGenerator();

		private static CredentialProfileStoreChain _credentialProfileChain;

		private static InternalConfiguration _cachedConfiguration;

		public static bool? EndpointDiscoveryEnabled => null;

		public static RequestRetryMode? RetryMode => null;

		public static int? MaxAttempts => null;

		static FallbackInternalConfigurationFactory()
		{
		}

		public static void Reset()
		{
		}

		private static T? SeekValue<T>(List<ConfigGenerator> generators, Func<InternalConfiguration, T?> getValue) where T : struct
		{
			return null;
		}
	}
}
