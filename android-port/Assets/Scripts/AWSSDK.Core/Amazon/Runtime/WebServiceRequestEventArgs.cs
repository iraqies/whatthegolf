using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
	public class WebServiceRequestEventArgs : RequestEventArgs
	{
		public IDictionary<string, string> Headers { get; protected set; }

		[Obsolete]
		public IDictionary<string, string> Parameters { get; protected set; }

		public ParameterCollection ParameterCollection { get; protected set; }

		public string ServiceName { get; protected set; }

		public Uri Endpoint { get; protected set; }

		public AmazonWebServiceRequest Request { get; protected set; }

		[Obsolete]
		public AmazonWebServiceRequest OriginalRequest => null;

		protected WebServiceRequestEventArgs()
		{
		}

		internal static WebServiceRequestEventArgs Create(IRequest request)
		{
			return null;
		}
	}
}
