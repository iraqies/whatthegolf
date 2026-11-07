using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class ProvisionedThroughputExceededException : AmazonKinesisException
	{
		public ProvisionedThroughputExceededException(string message)
			: base((string)null)
		{
		}

		public ProvisionedThroughputExceededException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ProvisionedThroughputExceededException(Exception innerException)
			: base((string)null)
		{
		}

		public ProvisionedThroughputExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ProvisionedThroughputExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
