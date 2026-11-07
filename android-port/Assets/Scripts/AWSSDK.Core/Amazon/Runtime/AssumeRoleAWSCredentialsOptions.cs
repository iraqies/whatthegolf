using System;
using System.Net;

namespace Amazon.Runtime
{
	public class AssumeRoleAWSCredentialsOptions
	{
		public string ExternalId { get; set; }

		public string Policy { get; set; }

		public int? DurationSeconds { get; set; }

		public IWebProxy ProxySettings { get; set; }

		public string MfaSerialNumber { get; set; }

		public string MfaTokenCode => null;

		public Func<string> MfaTokenCodeCallback { get; set; }
	}
}
