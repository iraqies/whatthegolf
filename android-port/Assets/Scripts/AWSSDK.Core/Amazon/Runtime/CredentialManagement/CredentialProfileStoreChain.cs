using System.Collections.Generic;

namespace Amazon.Runtime.CredentialManagement
{
	public class CredentialProfileStoreChain : ICredentialProfileSource
	{
		public string ProfilesLocation { get; private set; }

		public CredentialProfileStoreChain()
		{
		}

		public CredentialProfileStoreChain(string profilesLocation)
		{
		}

		public bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
		{
			credentials = null;
			return false;
		}

		public bool TryGetProfile(string profileName, out CredentialProfile profile)
		{
			profile = null;
			return false;
		}

		public List<CredentialProfile> ListProfiles()
		{
			return null;
		}

		public void RegisterProfile(CredentialProfile profile)
		{
		}

		public void UnregisterProfile(string profileName)
		{
		}
	}
}
