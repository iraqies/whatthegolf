using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class InvalidArgumentException : AmazonKinesisException
	{
		public InvalidArgumentException(string message)
			: base((string)null)
		{
		}

		public InvalidArgumentException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidArgumentException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidArgumentException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidArgumentException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
