using System;

namespace Amazon.Runtime
{
	public class FederatedAuthenticationFailureException : Exception
	{
		public FederatedAuthenticationFailureException(string msg)
		{
		}

		public FederatedAuthenticationFailureException(string msg, Exception inner)
		{
		}
	}
}
