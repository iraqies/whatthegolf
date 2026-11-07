using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class AdminRemoveUserFromGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static AdminRemoveUserFromGroupResponseUnmarshaller _instance;

		public static AdminRemoveUserFromGroupResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AdminRemoveUserFromGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
