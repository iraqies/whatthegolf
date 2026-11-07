using System;

namespace Amazon.SecurityToken.SAML
{
	public class AdfsAuthenticationControllerException : Exception
	{
		public AdfsAuthenticationControllerException(string message)
		{
		}

		public AdfsAuthenticationControllerException(string message, Exception innerException)
		{
		}

		public AdfsAuthenticationControllerException(Exception innerException)
		{
		}
	}
}
