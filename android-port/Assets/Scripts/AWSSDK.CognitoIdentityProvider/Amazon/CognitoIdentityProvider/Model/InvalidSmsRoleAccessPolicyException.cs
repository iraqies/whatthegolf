using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InvalidSmsRoleAccessPolicyException : AmazonCognitoIdentityProviderException
	{
		public InvalidSmsRoleAccessPolicyException(string message)
			: base((string)null)
		{
		}

		public InvalidSmsRoleAccessPolicyException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public InvalidSmsRoleAccessPolicyException(Exception innerException)
			: base((string)null)
		{
		}

		public InvalidSmsRoleAccessPolicyException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public InvalidSmsRoleAccessPolicyException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
