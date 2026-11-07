using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime
{
	public class ProfileAWSRegion : AWSRegion
	{
		public ProfileAWSRegion(ICredentialProfileSource source)
		{
		}

		public ProfileAWSRegion(ICredentialProfileSource source, string profileName)
		{
		}

		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
