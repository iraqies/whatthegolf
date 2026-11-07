using System;
using System.IO;
using System.Net;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class XmlResponseUnmarshaller : ResponseUnmarshaller
	{
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		public abstract AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext input);

		public abstract AmazonServiceException UnmarshallException(XmlUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode);

		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}
	}
}
