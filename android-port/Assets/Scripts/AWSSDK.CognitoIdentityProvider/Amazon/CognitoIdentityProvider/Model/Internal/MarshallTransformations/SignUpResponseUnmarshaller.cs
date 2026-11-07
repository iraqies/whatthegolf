using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class SignUpResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static SignUpResponseUnmarshaller _instance;

		public static SignUpResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static SignUpResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
