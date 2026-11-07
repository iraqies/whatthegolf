using System;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime
{
	[Obsolete]
	public class ProfileAWSEndpointDiscoveryEnabled
	{
		public bool Enabled { get; private set; }

		public ProfileAWSEndpointDiscoveryEnabled(ICredentialProfileSource source)
		{
		}

		public ProfileAWSEndpointDiscoveryEnabled(ICredentialProfileSource source, string profileName)
		{
		}

		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
