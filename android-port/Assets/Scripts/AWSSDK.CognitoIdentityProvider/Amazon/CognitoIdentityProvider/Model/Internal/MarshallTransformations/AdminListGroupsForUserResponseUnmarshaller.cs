using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class AdminListGroupsForUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static AdminListGroupsForUserResponseUnmarshaller _instance;

		public static AdminListGroupsForUserResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AdminListGroupsForUserResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
