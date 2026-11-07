using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class AdminLinkProviderForUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static AdminLinkProviderForUserResponseUnmarshaller _instance;

		public static AdminLinkProviderForUserResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AdminLinkProviderForUserResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
