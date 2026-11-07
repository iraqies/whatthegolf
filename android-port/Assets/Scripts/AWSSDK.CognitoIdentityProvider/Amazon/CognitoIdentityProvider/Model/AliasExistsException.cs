using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AliasExistsException : AmazonCognitoIdentityProviderException
	{
		public AliasExistsException(string message)
			: base((string)null)
		{
		}

		public AliasExistsException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public AliasExistsException(Exception innerException)
			: base((string)null)
		{
		}

		public AliasExistsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public AliasExistsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
