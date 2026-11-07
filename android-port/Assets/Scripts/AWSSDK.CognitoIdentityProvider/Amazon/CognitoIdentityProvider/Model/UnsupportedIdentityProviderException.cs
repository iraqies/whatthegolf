using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UnsupportedIdentityProviderException : AmazonCognitoIdentityProviderException
	{
		public UnsupportedIdentityProviderException(string message)
			: base((string)null)
		{
		}

		public UnsupportedIdentityProviderException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UnsupportedIdentityProviderException(Exception innerException)
			: base((string)null)
		{
		}

		public UnsupportedIdentityProviderException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UnsupportedIdentityProviderException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
