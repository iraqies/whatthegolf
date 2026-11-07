using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime.Internal
{
	public class ProfileCSMConfigs
	{
		private const string CSM_ENABLED = "csm_enabled";

		private const string CSM_CLIENTID = "csm_clientid";

		private const string CSM_HOST = "csm_host";

		private const string CSM_PORT = "csm_port";

		private const string CSM_PROFILE_ERROR_MSG = "CSM configurations not found using profile store.";

		private string ProfileName { get; set; }

		public ProfileCSMConfigs(CSMFallbackConfigChain cSMFallbackConfigChain, string profileName, IDictionary<string, string> profileProperties)
		{
		}

		public ProfileCSMConfigs(ICredentialProfileSource source, CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		private void Setup(CSMFallbackConfigChain cSMFallbackConfigChain, IDictionary<string, string> profileProperties)
		{
		}
	}
}
