using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class AdminListDevicesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static AdminListDevicesResponseUnmarshaller _instance;

		public static AdminListDevicesResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AdminListDevicesResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
