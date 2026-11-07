using System;

namespace Amazon.Runtime.Internal.Auth
{
	public class SignatureException : Exception
	{
		public SignatureException(string message)
		{
		}

		public SignatureException(string message, Exception innerException)
		{
		}
	}
}
