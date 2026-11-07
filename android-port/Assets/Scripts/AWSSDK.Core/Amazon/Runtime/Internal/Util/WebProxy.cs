using System;
using System.Net;

namespace Amazon.Runtime.Internal.Util
{
	public class WebProxy : IWebProxy
	{
		public Uri ProxyUri { get; set; }

		public ICredentials Credentials { get; set; }

		public WebProxy(string proxyUri)
		{
		}

		public WebProxy(Uri proxyUri)
		{
		}

		public WebProxy(string proxyHost, int proxyPort)
		{
		}

		public Uri GetProxy(Uri destination)
		{
			return null;
		}

		public bool IsBypassed(Uri host)
		{
			return false;
		}
	}
}
