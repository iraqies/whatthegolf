using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime
{
	public class WebServiceResponseEventArgs : ResponseEventArgs
	{
		public IDictionary<string, string> RequestHeaders { get; private set; }

		public IDictionary<string, string> ResponseHeaders { get; private set; }

		public IDictionary<string, string> Parameters { get; private set; }

		public string ServiceName { get; private set; }

		public Uri Endpoint { get; private set; }

		public AmazonWebServiceRequest Request { get; private set; }

		public AmazonWebServiceResponse Response { get; private set; }

		protected WebServiceResponseEventArgs()
		{
		}

		internal static WebServiceResponseEventArgs Create(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
		{
			return null;
		}
	}
}
