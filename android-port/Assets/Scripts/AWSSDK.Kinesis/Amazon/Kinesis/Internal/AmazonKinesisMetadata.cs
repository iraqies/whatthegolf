using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Internal
{
	public class AmazonKinesisMetadata : IServiceMetadata
	{
		public string ServiceId => null;

		public IDictionary<string, string> OperationNameMapping => null;
	}
}
