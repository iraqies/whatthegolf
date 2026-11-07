using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;

namespace Amazon.Runtime.CredentialManagement
{
	public static class AWSCredentialsFactory
	{
		private static HashSet<CredentialProfileType> CallbackProfileTypes;

		private const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";

		public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource)
		{
			return null;
		}

		public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource)
		{
			return null;
		}

		public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		public static bool TryGetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, out AWSCredentials credentials)
		{
			credentials = null;
			return false;
		}

		public static bool TryGetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, out AWSCredentials credentials)
		{
			credentials = null;
			return false;
		}

		internal static bool IsCallbackRequired(CredentialProfileType? profileType)
		{
			return false;
		}

		private static AWSCredentials GetAWSCredentials(string profileName, ICredentialProfileSource profileSource, CredentialProfileOptions options, RegionEndpoint stsRegion, bool nonCallbackOnly)
		{
			return null;
		}

		private static AWSCredentials GetAWSCredentialsInternal(string profileName, CredentialProfileType? profileType, CredentialProfileOptions options, RegionEndpoint stsRegion, ICredentialProfileSource profileSource, bool throwIfInvalid, HashSet<string> profileLoopAvoidance = null)
		{
			return null;
		}

		private static AWSCredentials GetCredentialSourceAWSCredentials(string credentialSourceType, bool throwIfInvalid)
		{
			return null;
		}

		private static AWSCredentials GetSourceAWSCredentials(string sourceProfileName, ICredentialProfileSource profileSource, bool throwIfInvalid, HashSet<string> profileLoopAvoidance = null)
		{
			return null;
		}

		private static BasicAWSCredentials ThrowInvalidOrReturnNull(string profileName, bool doThrow)
		{
			return null;
		}

		private static BasicAWSCredentials ThrowOrReturnNull(string message, Exception innerException, bool doThrow)
		{
			return null;
		}
	}
}
