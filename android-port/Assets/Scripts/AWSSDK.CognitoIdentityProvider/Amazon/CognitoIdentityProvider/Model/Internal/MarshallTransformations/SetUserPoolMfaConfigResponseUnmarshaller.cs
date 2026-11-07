using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class SetUserPoolMfaConfigResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static SetUserPoolMfaConfigResponseUnmarshaller _instance;

		public static SetUserPoolMfaConfigResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static SetUserPoolMfaConfigResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
