using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.Runtime
{
	public class InstanceProfileAWSCredentials : URIBasedRefreshingCredentialHelper
	{
		private static TimeSpan _preemptExpiryTime;

		private static TimeSpan _refreshAttemptPeriod;

		private CredentialsRefreshState _currentRefreshState;

		private IWebProxy _proxy;

		private static string[] AliasSeparators;

		private static string Server;

		private static string RolesPath;

		private static string InfoPath;

		public string Role { get; set; }

		private static Uri RolesUri => null;

		private Uri CurrentRoleUri => null;

		private static Uri InfoUri => null;

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		public InstanceProfileAWSCredentials(string role)
		{
		}

		public InstanceProfileAWSCredentials(string role, IWebProxy proxy)
		{
		}

		public InstanceProfileAWSCredentials()
		{
		}

		public InstanceProfileAWSCredentials(IWebProxy proxy)
		{
		}

		public static IEnumerable<string> GetAvailableRoles()
		{
			return null;
		}

		public static IEnumerable<string> GetAvailableRoles(IWebProxy proxy)
		{
			return null;
		}

		private CredentialsRefreshState GetEarlyRefreshState(CredentialsRefreshState state)
		{
			return null;
		}

		private CredentialsRefreshState GetRefreshState(string token)
		{
			return null;
		}

		private static SecurityInfo GetServiceInfo(IWebProxy proxy, string token)
		{
			return null;
		}

		private SecurityCredentials GetRoleCredentials(string token)
		{
			return null;
		}

		private static void CheckIsIMDSEnabled()
		{
		}

		private static string GetFirstRole()
		{
			return null;
		}

		private static string GetFirstRole(IWebProxy proxy)
		{
			return null;
		}

		private static bool IsNullOrWhiteSpace(string s)
		{
			return false;
		}

		private static Dictionary<string, string> CreateMetadataTokenHeaders(string token)
		{
			return null;
		}
	}
}
