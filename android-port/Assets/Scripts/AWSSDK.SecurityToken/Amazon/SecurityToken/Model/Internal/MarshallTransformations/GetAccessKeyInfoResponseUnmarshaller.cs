using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class GetAccessKeyInfoResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static GetAccessKeyInfoResponseUnmarshaller _instance;

		public static GetAccessKeyInfoResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccessKeyInfoResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetAccessKeyInfoResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
