using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class ListResourceServersResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static ListResourceServersResponseUnmarshaller _instance;

		public static ListResourceServersResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static ListResourceServersResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
