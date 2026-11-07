using System;

namespace Amazon.Runtime
{
	[Obsolete]
	public abstract class StoredProfileCredentials
	{
		public const string DEFAULT_PROFILE_NAME = "default";

		public const string SHARED_CREDENTIALS_FILE_ENVVAR = "AWS_SHARED_CREDENTIALS_FILE";

		private static string[] PotentialEnvironmentPathsToCredentialsFile;

		public const string DefaultSharedCredentialFilename = "credentials";

		public const string DefaultSharedCredentialLocation = ".aws/credentials";

		public static AWSCredentials GetProfile(string profileName)
		{
			return null;
		}

		public static AWSCredentials GetProfile(string profileName, string profileLocation)
		{
			return null;
		}

		public static string ResolveSharedCredentialFileLocation(string profileLocation)
		{
			return null;
		}

		private static string TestSharedCredentialFileExists(string pathOrFilename)
		{
			return null;
		}
	}
}
