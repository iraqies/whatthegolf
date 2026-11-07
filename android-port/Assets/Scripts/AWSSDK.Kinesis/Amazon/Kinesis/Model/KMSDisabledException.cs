using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSDisabledException : AmazonKinesisException
	{
		public KMSDisabledException(string message)
			: base((string)null)
		{
		}

		public KMSDisabledException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSDisabledException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSDisabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSDisabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
