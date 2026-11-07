namespace Amazon.Runtime.Internal
{
	public class InternalConfiguration
	{
		public bool? EndpointDiscoveryEnabled { get; set; }

		public RequestRetryMode? RetryMode { get; set; }

		public int? MaxAttempts { get; set; }
	}
}
