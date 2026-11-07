using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class CreateUserPoolDomainResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static CreateUserPoolDomainResponseUnmarshaller _instance;

		public static CreateUserPoolDomainResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static CreateUserPoolDomainResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
