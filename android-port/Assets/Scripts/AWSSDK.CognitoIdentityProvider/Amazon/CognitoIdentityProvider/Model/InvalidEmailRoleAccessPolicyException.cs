using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidEmailRoleAccessPolicyException : AmazonCognitoIdentityProviderException
	{
		public InvalidEmailRoleAccessPolicyException(string message)
			: base((string)null)
		{
		}

		public InvalidEmailRoleAccessPolicyException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidEmailRoleAccessPolicyException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidEmailRoleAccessPolicyException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidEmailRoleAccessPolicyException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
