using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSThrottlingException : AmazonKinesisException
	{
		public KMSThrottlingException(string message)
			: base((string)null)
		{
		}

		public KMSThrottlingException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSThrottlingException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSThrottlingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSThrottlingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
