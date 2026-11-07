using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DuplicateProviderException : AmazonCognitoIdentityProviderException
	{
		public DuplicateProviderException(string message)
			: base((string)null)
		{
		}

		public DuplicateProviderException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public DuplicateProviderException(Exception innerException)
			: base((string)null)
		{
		}

		public DuplicateProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public DuplicateProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
