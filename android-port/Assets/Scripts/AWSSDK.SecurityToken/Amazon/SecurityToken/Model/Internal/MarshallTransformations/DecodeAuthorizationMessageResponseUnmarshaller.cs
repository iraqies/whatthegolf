using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class DecodeAuthorizationMessageResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static DecodeAuthorizationMessageResponseUnmarshaller _instance;

		public static DecodeAuthorizationMessageResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, DecodeAuthorizationMessageResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DecodeAuthorizationMessageResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
