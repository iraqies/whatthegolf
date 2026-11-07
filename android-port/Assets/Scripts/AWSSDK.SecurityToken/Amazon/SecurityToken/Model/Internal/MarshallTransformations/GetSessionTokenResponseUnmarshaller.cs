using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class GetSessionTokenResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static GetSessionTokenResponseUnmarshaller _instance;

		public static GetSessionTokenResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, GetSessionTokenResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetSessionTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
