using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class CSMFallbackConfigChain
	{
		public delegate void ConfigurationSource();

		private readonly ILogger LOGGER;

		private static CredentialProfileStoreChain credentialProfileChain;

		public List<ConfigurationSource> AllGenerators { get; set; }

		internal bool IsConfigSet { get; set; }

		public string ConfigSource { get; set; }

		public CSMConfiguration CSMConfiguration { get; internal set; }

		public CSMConfiguration GetCSMConfig()
		{
			return null;
		}
	}
}
