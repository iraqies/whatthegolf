using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.Util
{
	public static class EC2InstanceMetadata
	{
		private class IMDSDisabledException : InvalidOperationException
		{
		}

		public static readonly string EC2_METADATA_SVC;

		public static readonly string LATEST;

		public static readonly string EC2_METADATA_ROOT;

		public static readonly string EC2_USERDATA_ROOT;

		public static readonly string EC2_DYNAMICDATA_ROOT;

		public static readonly string AWS_EC2_METADATA_DISABLED;

		public static readonly string EC2_APITOKEN_URL;

		private static int DEFAULT_RETRIES;

		private static int MIN_PAUSE_MS;

		private static int MAX_RETRIES;

		private static int DEFAULT_APITOKEN_TTL;

		private static Dictionary<string, string> _cache;

		private static bool useNullToken;

		public static bool IsIMDSEnabled => false;

		public static IWebProxy Proxy { get; set; }

		public static string AmiId => null;

		public static string AmiLaunchIndex => null;

		public static string AmiManifestPath => null;

		public static IEnumerable<string> AncestorAmiIds => null;

		public static string Hostname => null;

		public static string InstanceAction => null;

		public static string InstanceId => null;

		public static string InstanceType => null;

		public static string KernelId => null;

		public static string LocalHostname => null;

		public static string MacAddress => null;

		public static string PrivateIpAddress => null;

		public static string AvailabilityZone => null;

		public static IEnumerable<string> ProductCodes => null;

		public static string PublicKey => null;

		public static string RamdiskId => null;

		public static RegionEndpoint Region => null;

		public static string ReservationId => null;

		public static IEnumerable<string> SecurityGroups => null;

		public static IAMInstanceProfileMetadata IAMInstanceProfileInfo => null;

		public static IDictionary<string, IAMSecurityCredentialMetadata> IAMSecurityCredentials => null;

		public static IDictionary<string, string> BlockDeviceMapping => null;

		public static IEnumerable<NetworkInterfaceMetadata> NetworkInterfaces => null;

		public static string UserData => null;

		public static string InstanceMonitoring => null;

		public static string IdentityDocument => null;

		public static string IdentitySignature => null;

		public static string IdentityPkcs7 => null;

		public static IEnumerable<string> GetItems(string path)
		{
			return null;
		}

		public static string GetData(string path)
		{
			return null;
		}

		public static string GetData(string path, int tries)
		{
			return null;
		}

		public static IEnumerable<string> GetItems(string path, int tries)
		{
			return null;
		}

		private static string FetchData(string path)
		{
			return null;
		}

		private static string FetchData(string path, bool force)
		{
			return null;
		}

		public static string FetchApiToken()
		{
			return null;
		}

		private static string FetchApiToken(int tries)
		{
			return null;
		}

		public static void ClearTokenFlag()
		{
		}

		private static List<string> GetItems(string relativeOrAbsolutePath, int tries, bool slurp)
		{
			return null;
		}

		private static List<string> GetItems(string relativeOrAbsolutePath, int tries, bool slurp, string token)
		{
			return null;
		}

		private static void PauseExponentially(int retry)
		{
		}
	}
}
