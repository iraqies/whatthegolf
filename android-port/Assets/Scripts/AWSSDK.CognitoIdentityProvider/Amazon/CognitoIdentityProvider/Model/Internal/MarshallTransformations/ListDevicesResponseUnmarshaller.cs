using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class ListDevicesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static ListDevicesResponseUnmarshaller _instance;

		public static ListDevicesResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static ListDevicesResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
