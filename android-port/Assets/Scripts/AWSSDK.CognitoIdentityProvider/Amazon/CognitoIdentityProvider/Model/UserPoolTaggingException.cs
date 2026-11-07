using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserPoolTaggingException : AmazonCognitoIdentityProviderException
	{
		public UserPoolTaggingException(string message)
			: base((string)null)
		{
		}

		public UserPoolTaggingException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserPoolTaggingException(Exception innerException)
			: base((string)null)
		{
		}

		public UserPoolTaggingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserPoolTaggingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
