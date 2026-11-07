using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class ProfileInternalConfiguration : InternalConfiguration
	{
		private Logger _logger;

		public ProfileInternalConfiguration(ICredentialProfileSource source)
		{
		}

		public ProfileInternalConfiguration(ICredentialProfileSource source, string profileName)
		{
		}

		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
