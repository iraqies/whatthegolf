using System;

namespace Amazon.Runtime.CredentialManagement
{
	public class SAMLEndpoint
	{
		private SAMLAuthenticationType DefaultAuthenticationType;

		public string Name { get; private set; }

		public Uri EndpointUri { get; private set; }

		public SAMLAuthenticationType AuthenticationType { get; private set; }

		internal SAMLEndpoint(string name, string endpointUri, string authenticationType)
		{
		}

		public SAMLEndpoint(string name, Uri endpointUri)
		{
		}

		public SAMLEndpoint(string name, Uri endpointUri, SAMLAuthenticationType authenticationType)
		{
		}

		private void SetProperties(string name, Uri endpointUri, SAMLAuthenticationType authenticationType)
		{
		}
	}
}
