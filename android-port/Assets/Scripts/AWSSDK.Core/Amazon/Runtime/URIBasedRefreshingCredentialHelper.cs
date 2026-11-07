using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.Runtime
{
	public class URIBasedRefreshingCredentialHelper : RefreshingAWSCredentials
	{
		protected class SecurityBase
		{
			public string Code { get; set; }

			public string Message { get; set; }

			public DateTime LastUpdated { get; set; }
		}

		protected class SecurityInfo : SecurityBase
		{
			public string InstanceProfileArn { get; set; }

			public string InstanceProfileId { get; set; }
		}

		protected class SecurityCredentials : SecurityBase
		{
			public string Type { get; set; }

			public string AccessKeyId { get; set; }

			public string SecretAccessKey { get; set; }

			public string Token { get; set; }

			public DateTime Expiration { get; set; }

			public string RoleArn { get; set; }
		}

		private static string SuccessCode;

		protected static string GetContents(Uri uri)
		{
			return null;
		}

		protected static string GetContents(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		protected static string GetContents(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return null;
		}

		protected static T GetObjectFromResponse<T>(Uri uri)
		{
			return default;
		}

		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy)
		{
			return default;
		}

		protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
		{
			return default;
		}

		protected static void ValidateResponse(SecurityBase response)
		{
		}
	}
}
