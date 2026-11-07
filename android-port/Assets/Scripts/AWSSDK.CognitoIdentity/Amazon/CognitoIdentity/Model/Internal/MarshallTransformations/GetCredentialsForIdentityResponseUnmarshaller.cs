using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class GetCredentialsForIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static GetCredentialsForIdentityResponseUnmarshaller _instance;

		public static GetCredentialsForIdentityResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetCredentialsForIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
