using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserPoolAddOnNotEnabledException : AmazonCognitoIdentityProviderException
	{
		public UserPoolAddOnNotEnabledException(string message)
			: base((string)null)
		{
		}

		public UserPoolAddOnNotEnabledException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public UserPoolAddOnNotEnabledException(Exception innerException)
			: base((string)null)
		{
		}

		public UserPoolAddOnNotEnabledException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public UserPoolAddOnNotEnabledException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
