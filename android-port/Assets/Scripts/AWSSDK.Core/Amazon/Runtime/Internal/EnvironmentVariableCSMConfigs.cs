using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
	public class EnvironmentVariableCSMConfigs
	{
		private const string CSM_ENABLED = "AWS_CSM_ENABLED";

		private const string CSM_CLIENTID = "AWS_CSM_CLIENT_ID";

		private const string CSM_HOST = "AWS_CSM_HOST";

		private const string CSM_PORT = "AWS_CSM_PORT";

		private IEnvironmentVariableRetriever environmentRetriever { get; set; }

		public EnvironmentVariableCSMConfigs(IEnvironmentVariableRetriever environmentRetriever, CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		public EnvironmentVariableCSMConfigs(CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		private void SetupConfiguration(CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}
	}
}
