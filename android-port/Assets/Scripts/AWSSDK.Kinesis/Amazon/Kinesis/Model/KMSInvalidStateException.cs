using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSInvalidStateException : AmazonKinesisException
	{
		public KMSInvalidStateException(string message)
			: base((string)null)
		{
		}

		public KMSInvalidStateException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSInvalidStateException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSInvalidStateException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSInvalidStateException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
