using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class GetCallerIdentityResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static GetCallerIdentityResponseUnmarshaller _instance;

		public static GetCallerIdentityResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, GetCallerIdentityResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetCallerIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
