using System.Collections.Generic;
using System.Net;

namespace Amazon.Runtime
{
	public class AssumeRoleWithWebIdentityCredentialsOptions
	{
		public int? DurationSeconds { get; }

		public string ProviderId { get; }

		public string Policy { get; }

		public List<string> PolicyArns { get; }

		public IWebProxy ProxySettings { get; }
	}
}
