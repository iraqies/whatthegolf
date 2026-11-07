using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSOptInRequiredException : AmazonKinesisException
	{
		public KMSOptInRequiredException(string message)
			: base((string)null)
		{
		}

		public KMSOptInRequiredException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSOptInRequiredException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSOptInRequiredException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSOptInRequiredException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
