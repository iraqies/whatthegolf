using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CodeDeliveryFailureException : AmazonCognitoIdentityProviderException
	{
		public CodeDeliveryFailureException(string message)
			: base((string)null)
		{
		}

		public CodeDeliveryFailureException(string message, Exception innerException)
			: base((string)null)
		{
		}

		public CodeDeliveryFailureException(Exception innerException)
			: base((string)null)
		{
		}

		public CodeDeliveryFailureException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}

		public CodeDeliveryFailureException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
			: base((string)null)
		{
		}
	}
}
