using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class GetFederationTokenResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static GetFederationTokenResponseUnmarshaller _instance;

		public static GetFederationTokenResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, GetFederationTokenResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetFederationTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
