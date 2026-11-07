using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class ExpiredNextTokenException : AmazonKinesisException
	{
		public ExpiredNextTokenException(string message)
			: base((string)null)
		{
		}

		public ExpiredNextTokenException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredNextTokenException(Exception innerException)
			: base((string)null)
		{
		}

		public ExpiredNextTokenException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ExpiredNextTokenException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
