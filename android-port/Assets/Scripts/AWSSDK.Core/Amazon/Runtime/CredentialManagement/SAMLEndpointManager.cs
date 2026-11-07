using System.Collections.Generic;
using Amazon.Util.Internal;

namespace Amazon.Runtime.CredentialManagement
{
	public class SAMLEndpointManager
	{
		private NamedSettingsManager settingsManager;

		public static bool IsAvailable => false;

		public void RegisterEndpoint(SAMLEndpoint samlEndpoint)
		{
		}

		public bool TryGetEndpoint(string endpointName, out SAMLEndpoint samlEndpoint)
		{
			samlEndpoint = null;
			return false;
		}

		public SAMLEndpoint GetEndpoint(string endpointName)
		{
			return null;
		}

		public void UnregisterEndpoint(string endpointName)
		{
		}

		public List<string> ListEndpointNames()
		{
			return null;
		}

		public List<SAMLEndpoint> ListEndpoints()
		{
			return null;
		}
	}
}
