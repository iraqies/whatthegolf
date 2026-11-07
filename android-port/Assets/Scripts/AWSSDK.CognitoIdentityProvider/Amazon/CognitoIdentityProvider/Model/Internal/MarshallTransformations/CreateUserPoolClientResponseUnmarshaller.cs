using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class CreateUserPoolClientResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static CreateUserPoolClientResponseUnmarshaller _instance;

		public static CreateUserPoolClientResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static CreateUserPoolClientResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
