using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public class AmazonKinesisException : AmazonServiceException
	{
		public AmazonKinesisException(string message)
		{
		}

		public AmazonKinesisException(string message, Exception innerException)
		{
		}

		public AmazonKinesisException(Exception innerException)
		{
		}

		public AmazonKinesisException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		public AmazonKinesisException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}
	}
}
