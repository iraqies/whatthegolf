using System;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal
{
	public class ProcessCredentialVersion1
	{
		[JsonProperty]
		public int Version { get; set; }

		[JsonProperty]
		public string AccessKeyId { get; set; }

		[JsonProperty]
		public string SecretAccessKey { get; set; }

		public string SessionToken { get; set; }

		public DateTime Expiration { get; set; }
	}
}
