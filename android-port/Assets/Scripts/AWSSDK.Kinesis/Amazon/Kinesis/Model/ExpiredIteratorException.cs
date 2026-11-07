using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class ExpiredIteratorException : AmazonKinesisException
	{
		public ExpiredIteratorException(string message)
			: base((string)null)
		{
		}

		public ExpiredIteratorException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredIteratorException(Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredIteratorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ExpiredIteratorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
