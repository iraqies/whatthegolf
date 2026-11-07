using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class UpdateGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static UpdateGroupResponseUnmarshaller _instance;

		public static UpdateGroupResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static UpdateGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
