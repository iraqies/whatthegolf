using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class AmazonKinesisConfig : ClientConfig
	{
		private static readonly string UserAgentString;

		private string _userAgent;

		public override string RegionEndpointServiceName => null;

		public override string ServiceVersion => null;

		public override string UserAgent => null;
	}
}
