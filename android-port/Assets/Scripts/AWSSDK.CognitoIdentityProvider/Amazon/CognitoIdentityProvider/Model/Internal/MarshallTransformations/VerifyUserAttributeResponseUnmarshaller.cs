using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class VerifyUserAttributeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static VerifyUserAttributeResponseUnmarshaller _instance;

		public static VerifyUserAttributeResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static VerifyUserAttributeResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
