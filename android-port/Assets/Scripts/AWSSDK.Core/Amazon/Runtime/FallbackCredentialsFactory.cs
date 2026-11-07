using System.Collections.Generic;
using System.Net;
using Amazon.Runtime.CredentialManagement;

namespace Amazon.Runtime
{
	public static class FallbackCredentialsFactory
	{
		public delegate AWSCredentials CredentialsGenerator();

		internal const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

		internal const string DefaultProfileName = "default";

		private static readonly CredentialProfileStoreChain credentialProfileChain;

		private static AWSCredentials cachedCredentials;

		public static List<CredentialsGenerator> CredentialsGenerators { get; set; }

		static FallbackCredentialsFactory()
		{
		}

		public static void Reset()
		{
		}

		public static void Reset(IWebProxy proxy)
		{
		}

		private static AWSCredentials GetAWSCredentials(ICredentialProfileSource source)
		{
			return null;
		}

		private static AWSCredentials ECSEC2CredentialsWrapper()
		{
			return null;
		}

		private static AWSCredentials ECSEC2CredentialsWrapper(IWebProxy proxy)
		{
			return null;
		}

		public static AWSCredentials GetCredentials()
		{
			return null;
		}

		public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
		{
			return null;
		}
	}
}
