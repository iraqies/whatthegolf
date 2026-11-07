using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class RegisterDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static RegisterDeviceResponseUnmarshaller _instance;

		public static RegisterDeviceResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static RegisterDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
