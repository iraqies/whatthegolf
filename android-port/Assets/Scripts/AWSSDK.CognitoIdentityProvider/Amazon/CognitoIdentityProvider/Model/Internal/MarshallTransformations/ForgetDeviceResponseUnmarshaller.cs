using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class ForgetDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static ForgetDeviceResponseUnmarshaller _instance;

		public static ForgetDeviceResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static ForgetDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
