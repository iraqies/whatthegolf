using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class KMSAccessDeniedException : AmazonKinesisException
	{
		public KMSAccessDeniedException(string message)
			: base((string)null)
		{
		}

		public KMSAccessDeniedException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public KMSAccessDeniedException(Exception innerException)
			: base((string)null)
		{
		}

		public KMSAccessDeniedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public KMSAccessDeniedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
