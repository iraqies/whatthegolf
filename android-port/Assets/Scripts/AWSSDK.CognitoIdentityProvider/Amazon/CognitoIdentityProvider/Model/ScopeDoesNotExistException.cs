using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ScopeDoesNotExistException : AmazonCognitoIdentityProviderException
	{
		public ScopeDoesNotExistException(string message)
			: base((string)null)
		{
		}

		public ScopeDoesNotExistException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public ScopeDoesNotExistException(Exception innerException)
			: base((string)null)
		{
		}

		public ScopeDoesNotExistException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public ScopeDoesNotExistException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
