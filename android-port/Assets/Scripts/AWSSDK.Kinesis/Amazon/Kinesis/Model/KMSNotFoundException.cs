using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSNotFoundException : AmazonKinesisException
	{
		public KMSNotFoundException(string message)
			: base((string)null)
		{
		}

		public KMSNotFoundException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSNotFoundException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
