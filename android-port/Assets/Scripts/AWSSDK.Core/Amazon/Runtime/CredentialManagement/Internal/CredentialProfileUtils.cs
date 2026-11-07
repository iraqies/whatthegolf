using System;
using System.Collections.Generic;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	public static class CredentialProfileUtils
	{
		public static Dictionary<string, string> GetProperties(CredentialProfile profile)
		{
			return null;
		}

		public static void SetProperty(CredentialProfile profile, string key, string value)
		{
		}

		public static string GetProperty(CredentialProfile profile, string key)
		{
			return null;
		}

		public static Guid EnsureUniqueKeyAssigned(CredentialProfile profile, ICredentialProfileStore profileStore)
		{
			return default;
		}

		public static string GetUniqueKey(CredentialProfile profile)
		{
			return null;
		}

		public static void SetUniqueKey(CredentialProfile profile, Guid? uniqueKey)
		{
		}

		public static CredentialProfileType? GetProfileType(CredentialProfile profile)
		{
			return null;
		}

		public static bool IsCallbackRequired(CredentialProfile profile)
		{
			return false;
		}
	}
}
