using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class UpdateDeviceStatusResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static UpdateDeviceStatusResponseUnmarshaller _instance;

		public static UpdateDeviceStatusResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static UpdateDeviceStatusResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
