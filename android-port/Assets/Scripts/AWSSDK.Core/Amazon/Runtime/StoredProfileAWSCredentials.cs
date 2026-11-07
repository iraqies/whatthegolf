using System;

namespace Amazon.Runtime
{
	[Obsolete]
	public class StoredProfileAWSCredentials : AWSCredentials
	{
		private AWSCredentials _wrappedCredentials;

		public AWSCredentials WrappedCredentials => null;

		public string ProfileName { get; private set; }

		public string ProfilesLocation { get; private set; }

		public StoredProfileAWSCredentials()
		{
		}

		public StoredProfileAWSCredentials(string profileName)
		{
		}

		public StoredProfileAWSCredentials(string profileName, string profilesLocation)
		{
		}

		public static bool IsProfileKnown(string profileName, string profilesLocation)
		{
			return false;
		}

		public static bool CanCreateFrom(string profileName, string profilesLocation)
		{
			return false;
		}

		private static bool ValidCredentialsExistInSharedFile(string profilesLocation, string profileName)
		{
			return false;
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}
	}
}
