using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis.Model
{
	public class ResourceNotFoundException : AmazonKinesisException
	{
		public ResourceNotFoundException(string message)
			: base((string)null)
		{
		}

		public ResourceNotFoundException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ResourceNotFoundException(Exception innerException)
			: base((string)null)
		{
		}

		public ResourceNotFoundException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ResourceNotFoundException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
