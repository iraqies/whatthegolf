using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class LimitExceededException : AmazonKinesisException
	{
		public LimitExceededException(string message)
			: base((string)null)
		{
		}

		public LimitExceededException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public LimitExceededException(Exception innerException)
			: base((string)null)
		{
		}

		public LimitExceededException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public LimitExceededException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
