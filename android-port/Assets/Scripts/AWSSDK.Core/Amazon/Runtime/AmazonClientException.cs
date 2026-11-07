using System;

namespace Amazon.Runtime
{
	public class AmazonClientException : Exception
	{
		public AmazonClientException(string message)
		{
		}

		public AmazonClientException(string message, Exception innerException)
		{
		}
	}
}
